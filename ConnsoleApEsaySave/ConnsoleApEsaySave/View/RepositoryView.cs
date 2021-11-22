using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Language;

namespace Repository
{
    class RepositoryView
    {
        public void RepositorySourceV()
        {
            // Choisir le répertoire source
            Console.WriteLine(LanguageModel.Traductor("source"));
            

            // Fonction qui ouvre fichier à faire dans VieWModel.
            //string sSourceRepository = truc sélectionner;


            // Création du répertoire cible

            //RepositoryViewModel.TargetRepositoryVM(); // Créer le répertoire
            //Console.WriteLine("Le répertoire cible " + RepositoryViewModel.sTargetRepository + " a bien été créé"); // Vérification et voir où le répertoire s'est créé

            // Variable qui va prendre le chemin
            // string sSource = Console.ReadLine();
            // RepositoryViewModel.SourceRepository = @sSource; // sSourceRepository

            // Console.WriteLine(LanguageModel.Traductor("target"));
            // Fonction qui ouvre fichier à faire dans VieWModel.
            //string sTargetRepository = truc sélectionner;

            // string sTarget = Console.ReadLine();
            // RepositoryViewModel.TargetRepository = @sTarget; // sTargetRepository

            //Copie des dossiers :
            //RepositoryViewModel.CopyRepository();
            // Console.WriteLine("Fichiers sauvegardés !");

            
        }

        public void RepositoryTargetV()
        {
            Console.WriteLine(LanguageModel.Traductor("target"));
        }

    }
}
