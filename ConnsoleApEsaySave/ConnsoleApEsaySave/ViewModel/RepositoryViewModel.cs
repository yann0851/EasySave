﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace Repository
{
    class RepositoryViewModel
    {
        public string TargetRepository { get; set; } // Objet pour le répertoire cible
        public string SourceRepository { get; set; } // Objet pour le répertoire source

        // Création du répertoire
        //public void TargetRepositoryVM()
        //{
        //    TargetRepository = @"C:\EasySave\RepertoireCible";
        //    if (!Directory.Exists(TargetRepository))
        //    {
        //        Directory.CreateDirectory(TargetRepository);
        //    }
        //}

        // Sauvegarde Complet
        public void CopyRepository()
        {
            RepositoryViewModel RepositoryViewModel = new RepositoryViewModel(); // Appel de la méthode

            if (!Directory.Exists(SourceRepository)) // test si le répertoire existe ou pas
            {
                Directory.CreateDirectory(SourceRepository);
            }

            string[] files = Directory.GetFiles(SourceRepository); // tableau ou on récupère les fichiers
            foreach (string sFile in files) // Pour chaque fichier
            {
                string sNameFiles = Path.GetFileName(sFile); // Récupère le nom du fichier dans le dossier
                string sDestFile = Path.Combine(TargetRepository, sNameFiles); // Grâce au nom du fichier récupérer du dessus on le combine avec le chemin du dossier.
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
                            string sNameDestFiles = Path.GetFileName(sDestFile);
                            string sContentFileSource = File.ReadAllText(sFile);
                            File.WriteAllText(sDestFile, sContentFileSource);
                        }
                        catch
                        {

                        }
                    }

                    RepositoryViewModel.DeleteFile(SourceRepository, TargetRepository);
                    RepositoryViewModel.DeleteFolder(SourceRepository, TargetRepository);

                }
            }
            string[] folders = Directory.GetDirectories(SourceRepository);
            foreach (string sFolder in folders) // Récupérer des dossiers dans le dossier principal
            {
                string sNameRepository = Path.GetFileName(sFolder); // On récupère le nom du répertoire dans le Répertoire Source
                string sDestRepository = Path.Combine(TargetRepository, sNameRepository); // On va ajouter le nom du répertoire dans le chemin d'accès au répertoire cible
                try
                {
                    Directory.CreateDirectory(sFolder.Replace(sFolder, sDestRepository)); // copie le dossier
                }
                catch
                {
                    RepositoryViewModel.DeleteFolder(sFolder, sDestRepository);
                }

                foreach (string sFileFolder in Directory.GetFiles(sFolder)) // Récupérer le fichier des dossiers dans le dossier principal
                {
                    string sNamePathSourceFile = Path.GetFileName(sFolder) + "\\" + Path.GetFileName(sFileFolder); // On prend le nom du dossier et le nom du fichier à l'intérieur
                    string sDestPathTargetRepository = Path.Combine(TargetRepository, sNamePathSourceFile); // Grâce à ce qu'on a fait au-dessus on combine le nom du dossier cible avec le nom du dossier et fichier
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
                                //string sNameDestFiles = Path.GetFileName(sDestPathTargetRepository); // Nom 
                                string sContentFileSource = File.ReadAllText(sFileFolder); // Je vais chercher le contenu du fichier source
                                File.WriteAllText(sDestPathTargetRepository, sContentFileSource); // Je remplace le contenu du fichier cible avec le contenu du fichier source
                            }
                            catch
                            {

                            }
                        }
                        RepositoryViewModel.DeleteFile(sFolder, sDestRepository);
                    }

                }
            }
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
    }
}