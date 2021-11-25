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
        /* Affichage du message demandant le fichier source */
        public void RepositoryNameV()
        {
            Console.WriteLine(LanguageModel.Traductor("nom_sauvegarde"));
        }
        public void RepositorySourceV()
        {
            Console.WriteLine(LanguageModel.Traductor("source"));          
        }

        /* Affichage du message demandant le fichier cible */
        public void RepositoryTargetV()
        {
            Console.WriteLine(LanguageModel.Traductor("target"));
        }

    }
}