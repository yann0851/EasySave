using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using LogD;
using StateD;
using ConsoleAppEasySave.Model;
using System.Security.Cryptography;

namespace Repository
{
    class RepositoryController
    {
        
        RepositoryModel repositoryModel = new RepositoryModel();
        LogController logController = new LogController();
        StateController stateController = new StateController();
        JobFile jobFile = new JobFile();
        JobState jobState = new JobState();

        System.Diagnostics.Stopwatch cWatch = new System.Diagnostics.Stopwatch();

        /* Demande d'entrée du chemin source et du chemin cible du fichier à sauvegarder */
        public void RepositoryC()
        {
            RepositoryView RepositoryView = new RepositoryView();

            RepositoryView.RepositoryNameV();

            string sName = Console.ReadLine();
            repositoryModel.NameLogRepository = sName;

            RepositoryView.RepositorySourceV();

            string sSource = Console.ReadLine();
            repositoryModel.SourceRepository = @sSource;
            CreateDirectory(repositoryModel.SourceRepository);

            RepositoryView.RepositoryTargetV();

            string sTarget = Console.ReadLine();
            repositoryModel.TargetRepository = @sTarget;
            CreateDirectory(repositoryModel.TargetRepository);
        }


        /* Sauvegarde Complète */
        public void PartialCopyRepository()
        {
            RepositoryC();

            cWatch.Start();
            //List<JobFile> files = new List<JobFile>();

            string[] files = Directory.GetFiles(repositoryModel.SourceRepository); // tableau ou on récupère les fichiers
            foreach (string sFile in files) // Pour chaque fichier
            {
                string sNameFiles = Path.GetFileName(sFile); // Récupère le nom du fichier dans le dossier
                string sDestFile = Path.Combine(repositoryModel.TargetRepository, sNameFiles); // Grâce au nom du fichier récupérer du dessus on le combine avec le chemin du dossier.
                try
                {
                    File.Copy(sFile, sDestFile); // Copie le fichier dans le répertoire cible

                }
                catch
                {
                    if (File.Exists(sDestFile))
                    {
                        try
                        {
                            if(CalculateMD5(sFile) == CalculateMD5(sDestFile))
                            {
                               
                            }
                            else
                            {
                                File.Delete(sDestFile);
                                File.Copy(sFile, sDestFile);
                            }
                        }
                        catch
                        {

                        }
                    }
                    DeleteFile(repositoryModel.SourceRepository, repositoryModel.TargetRepository);
                    DeleteFolder(repositoryModel.SourceRepository, repositoryModel.TargetRepository);
                    LengthDirectory(repositoryModel.SourceRepository);
                }
            }
            string[] folders = Directory.GetDirectories(repositoryModel.SourceRepository);
            foreach (string sFolder in folders) // Récupérer des dossiers dans le dossier principal
            {
                string sNameRepository = Path.GetFileName(sFolder); // On récupère le nom du répertoire dans le Répertoire Source
                string sDestRepository = Path.Combine(repositoryModel.TargetRepository, sNameRepository); // On va ajouter le nom du répertoire dans le chemin d'accès au répertoire cible
                try
                {
                    Directory.CreateDirectory(sFolder.Replace(sFolder, sDestRepository)); // copie le dossier
                }
                catch
                {
                    DeleteFolder(sFolder, sDestRepository);
                }

                foreach (string sFileFolder in Directory.GetFiles(sFolder)) // Récupérer le fichier des dossiers dans le dossier principal
                {
                    string sNamePathSourceFile = Path.GetFileName(sFolder) + "\\" + Path.GetFileName(sFileFolder); // On prend le nom du dossier et le nom du fichier à l'intérieur
                    string sDestPathTargetRepository = Path.Combine(repositoryModel.TargetRepository, sNamePathSourceFile); // Grâce à ce qu'on a fait au-dessus on combine le nom du dossier cible avec le nom du dossier et fichier
                    try
                    {
                        File.Copy(sFileFolder, sFileFolder.Replace(sFileFolder, sDestPathTargetRepository)); // copie les fichiers du sous-dossier
                    }
                    catch
                    {
                        if (File.Exists(sDestPathTargetRepository)) // Si mon fichier existe
                        {
                            try
                            {
                                if (CalculateMD5(sFileFolder) == CalculateMD5(sDestPathTargetRepository))
                                {

                                }
                                else
                                {
                                    File.Delete(sDestPathTargetRepository);
                                    File.Copy(sFileFolder, sDestPathTargetRepository);
                                }
                            }
                            catch
                            {

                            }
                        }
                        DeleteFile(sFolder, sDestRepository);
                    }

                }

                LengthDirectory(sFolder);
            }

            cWatch.Stop();
            TimeSpan Time = cWatch.Elapsed;
            repositoryModel.FileTransfertRepository = Time.ToString(@"m\:ss\.fff");

            ObjectJsonLog();
            ObjectJsonState();

        }

        public void FullCopyRepository()
        {
            RepositoryC();

            cWatch.Start();
            string[] files = Directory.GetFiles(repositoryModel.SourceRepository); // tableau ou on récupère les fichiers
            foreach (string sFile in files) // Pour chaque fichier
            {
                string sNameFiles = Path.GetFileName(sFile); // Récupère le nom du fichier dans le dossier
                string sDestFile = Path.Combine(repositoryModel.TargetRepository, sNameFiles); // Grâce au nom du fichier récupérer du dessus on le combine avec le chemin du dossier.
                try
                {
                    File.Copy(sFile, sDestFile); // Copie le fichier dans le répertoire cible
                }

                catch
                {

                }
            }
            LengthDirectory(repositoryModel.SourceRepository);

            string[] folders = Directory.GetDirectories(repositoryModel.SourceRepository);
            foreach (string sFolder in folders) // Récupérer des dossiers dans le dossier principal
            {
                string sNameRepository = Path.GetFileName(sFolder); // On récupère le nom du répertoire dans le Répertoire Source
                string sDestRepository = Path.Combine(repositoryModel.TargetRepository, sNameRepository); // On va ajouter le nom du répertoire dans le chemin d'accès au répertoire cible
                try
                {
                    Directory.CreateDirectory(sFolder.Replace(sFolder, sDestRepository)); // copie le dossier
                }

                catch
                {
                    
                }

                foreach (string sFileFolder in Directory.GetFiles(sFolder)) // Récupérer le fichier des dossiers dans le dossier principal
                {
                    string sNamePathSourceFile = Path.GetFileName(sFolder) + "\\" + Path.GetFileName(sFileFolder); // On prend le nom du dossier et le nom du fichier à l'intérieur
                    string sDestPathTargetRepository = Path.Combine(repositoryModel.TargetRepository, sNamePathSourceFile); // Grâce à ce qu'on a fait au-dessus on combine le nom du dossier cible avec le nom du dossier et fichier
                    try
                    {
                        File.Copy(sFileFolder, sFileFolder.Replace(sFileFolder, sDestPathTargetRepository)); // copie les fichiers du sous-dossier
                    }

                    catch
                    {
                       
                    }

                }

                LengthDirectory(sFolder);
            }

            cWatch.Stop();
            TimeSpan Time = cWatch.Elapsed;
            repositoryModel.FileTransfertRepository = Time.ToString(@"m\:ss\.fff");

            ObjectJsonLog();
            ObjectJsonState();

        }
        public void DeleteFile(string sSourceRepository, string sTargetRepository) // à OPTI
        {
            string[] files = Directory.GetFiles(sTargetRepository); // tableau ou on récupère les fichiers
            foreach (string sFile in files) // Pour chaque fichier
            {
                string sTargetFiles = Path.GetFileName(sFile); // Récupère le nom du fichier dans le dossier
                string sSourceFile = Path.Combine(sSourceRepository, sTargetFiles); // Grâce au nom du fichier récupérer du dessus on le combine avec le chemin du dossier.

                if (!File.Exists(sSourceFile))
                {
                    try
                    {
                        File.Delete(sFile);
                    }
                    catch
                    {

                    }
                }

            }
        }
        public void DeleteFolder(string sSourceFolder, string sTargetFolder)
        {
            string[] folders = Directory.GetDirectories(sTargetFolder);
            foreach (string sFolder in folders) // Récupérer des dossiers dans le dossier principal
            {
                string sNameRepository = Path.GetFileName(sFolder);
                string sSourceRepository = Path.Combine(sSourceFolder, sNameRepository);

                if (!Directory.Exists(sSourceRepository))
                {
                    try
                    {
                        DeleteFile(sSourceRepository, sFolder);
                        Directory.Delete(sFolder);
                    }
                    catch
                    {

                    }
                }

            }
        }
        public void CreateDirectory(string sCreateDirectory)
        {
            if (!Directory.Exists(sCreateDirectory)) // test si le répertoire existe ou pas
            {
                Directory.CreateDirectory(sCreateDirectory);
            }
        }

        static string CalculateMD5(string sFile)
        {
            using (var md5 = MD5.Create()) // Créé un MD5 pour le fichier
            {
                using (var stream = File.OpenRead(sFile)) // On accède en lecture au fichier
                {
                    var checksum = md5.ComputeHash(stream); // On calcule la valeur du hachage du fichier (sous forme d'un tableau de 16 octets)
                    return BitConverter.ToString(checksum).Replace("-", "").ToLowerInvariant(); // Convertit le tableau d'octet sous forme de chaîne (hexadécimale) 
                                                                                                // Remplace les caractères - en rien
                                                                                                // Convertit en minuscule pour éviter la casse.
                }
            }
        }

        public void ObjectJsonLog()
        {
            jobFile.FileSource = repositoryModel.SourceRepository;
            jobFile.FileTarget = repositoryModel.TargetRepository;
            jobFile.Name = repositoryModel.NameLogRepository;

            jobFile.FileSize = repositoryModel.LengthRepository;
            jobFile.FileTransferTime = repositoryModel.FileTransfertRepository;

            //TODO les autres attributs
            //repositoryModel.SourceRepository,repositoryModel.TargetRepository, repositoryModel.NameLogRepository
            logController.CreateLog(jobFile);
        }

        public void ObjectJsonState()
        {
            jobState.Name = repositoryModel.NameLogRepository;
            jobState.SourceFilePath = repositoryModel.SourceRepository;
            jobState.TargetFilePath = repositoryModel.TargetRepository;
            jobState.State = repositoryModel.SourceRepository;
            jobState.TotalFilesToCopy = repositoryModel.SourceRepository;
            jobState.TotalFilesSize = repositoryModel.SourceRepository;
            jobState.NbFilesLeftToDo = repositoryModel.TargetRepository;
            jobState.Progression = repositoryModel.TargetRepository;
            stateController.CreateState(jobState);

        }

        public void LengthDirectory(string sFolder)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sFolder); // On dit dans quel répertoire on est 

            FileInfo[] fileInfo = directoryInfo.GetFiles(); // on récupère tous les fichiers

            foreach (FileInfo file in fileInfo) // On prend chaque fichier du répertoire
            {
                repositoryModel.LengthRepository += file.Length; // taille en octet
            }
        }
    }

}