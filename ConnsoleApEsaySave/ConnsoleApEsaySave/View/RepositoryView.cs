using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Repository
{
    class RepositoryView
    {
        public void RepositoryV()
        {
            // Choisir le répertoire source
            Console.WriteLine("Veuillez choisir votre répertoire source : ");
            RepositoryViewModel RepositoryViewModel = new RepositoryViewModel();




            // Fonction qui ouvre fichier à faire dans VieWModel.
            //string sSourceRepository = truc sélectionner;


            // Création du répertoire cible

            //RepositoryViewModel.TargetRepositoryVM(); // Créer le répertoire
            //Console.WriteLine("Le répertoire cible " + RepositoryViewModel.sTargetRepository + " a bien été créé"); // Vérification et voir où le répertoire s'est créé

            // Variable qui va prendre le chemin
            RepositoryViewModel.SourceRepository = @"C:\EasySave\RepertoireSource"; // sSourceRepository

            Console.WriteLine("Où voulez-vous copier ce dossier :");
            // Fonction qui ouvre fichier à faire dans VieWModel.
            //string sTargetRepository = truc sélectionner;

            RepositoryViewModel.TargetRepository = @"C:\EasySave\RepertoireCible"; // sTargetRepository

            //Copie des dossiers :
            RepositoryViewModel.CopyRepository();
            // Console.WriteLine("Fichiers sauvegardés !");

            Console.ReadKey();
        }


    }
}
