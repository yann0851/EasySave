using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using WpfAppEasySave.Model;

namespace WpfAppEasySave.ViewModel
{
    class EncryptViewModel
    {
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;

        EncryptModel encryptModel = new EncryptModel();

        public void EncryptVM(string sFolderTarget, string sFile) // Fonction qu'on appelle dans la page Sauvegarde pour chiffrer les fichiers
        {
            CreateKey("Key01");
            //encryptModel.FolderSource = sFolderSource;
            encryptModel.FolderTarget = sFolderTarget;

            if (_rsa is null) // Si pas de clé
            {
                MessageBox.Show("La clé n'a pas été créée ou récupérée !");
            }
            else // Sinon si clé créé
            {
                EncryptFile(new FileInfo(sFile)); // Lancer la fonction
            }
        }

        public void EncryptFile(FileInfo file) // Chiffrer le fichier
        {
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false); // On chiffre le fichier avec la clé créée précédemment ou garder dans un fichier

            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            string outFile = Path.Combine(this.encryptModel.FolderTarget, Path.ChangeExtension(file.Name, ".enc")); // Créer le fichier .en

            using (var outFs = new FileStream(outFile, FileMode.Create)) //Dans fichier chiffré
            {
                outFs.Write(LenK, 0, 4); // Longueur de la clé
                outFs.Write(LenIV, 0, 4); // Longueur de IV (vecteur d'initialisation : bloc de bits combiné avec le premier bloc de données lors d'une opération de chiffrement)
                outFs.Write(keyEncrypted, 0, lKey); // Clé de chiffrement
                outFs.Write(aes.IV, 0, lIV); // IV

                using (var outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write)) // Ecrire texte chiffré
                {
                    // On chiffre un morceau pour économiser de la mémoire
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8; // On peut choisir n'importe quelle taille pour la taille du bloc
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (var inFs = new FileStream(file.FullName, FileMode.Open)) // On écrit le contenu du fichier en le chiffrant
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes); // On lit les données dans le bloc
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count); // On écrit les données chiffrées dans le fichier
                            bytesRead += blockSizeBytes;
                        } while (count > 0);
                    }
                    outStreamEncrypted.FlushFinalBlock(); // Met à jour le fichier avec les données chiffrées
                }
            }
        }

        public void CreateKey(string sNameKey) // Créer la clé
        {
            _cspp.KeyContainerName = sNameKey;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };

            encryptModel.RSA = _rsa.PublicOnly
                ? $"Key: {_cspp.KeyContainerName} - Public Only"
                : $"Key: {_cspp.KeyContainerName} - Full Key Pair";

            CreateKeyFile(_rsa);
        }

        public void ExportPublicKey(string sKeyFile, RSACryptoServiceProvider _rsa) // Exporter la clé publique pour la garder dans un fichier
        {
            using (var sw = new StreamWriter(sKeyFile, false))
            {
                sw.Write(_rsa.ToXmlString(false)); // Ecrit la clé publique dans le fichier
            }
        }

        public void ImportKey(string KeyFile, string sNameKey, RSACryptoServiceProvider _rsa) // Import la clé dans une variable
        {
            if(!File.Exists(KeyFile))
            {
                MessageBox.Show("La clé n'existe pas !");
            }
            else
            {
                using (var sr = new StreamReader(KeyFile)) // Lire le fichier
                {
                    _cspp.KeyContainerName = sNameKey;
                    _rsa = new RSACryptoServiceProvider(_cspp);

                    string keytxt = sr.ReadToEnd();
                    _rsa.FromXmlString(keytxt);
                    _rsa.PersistKeyInCsp = true;

                    encryptModel.RSA = _rsa.PublicOnly
                        ? $"Key: {_cspp.KeyContainerName} - Public Only"
                        : $"Key: {_cspp.KeyContainerName} - Full Key Pair";
                }
            }
        }

        public void CreateKeyFile(RSACryptoServiceProvider _rsa) // Créer si n'existe pas le fichier
        {
            string sRepositoryFile = @"C:\EasySave\Key";

            RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
            repositoryViewModel.CreateDirectory(sRepositoryFile); // Créer le répertoire

            string sFile = @"C:\EasySave\Key\Key.txt";
            if (!File.Exists(sFile)) // test si le fichier existe ou pas
            {
                File.Create(sFile);
            }
            else
            {
                ExportPublicKey(sFile, _rsa); // Appel fonction export le fichier
            }
        }
    }
}