using System;
using System.Collections.Generic;
using System.Text;

namespace Language
{
    class LanguageModel
    {
        static Dictionary<string, Dictionary<string, string>> dLanguage = new Dictionary<string, Dictionary<string, string>>
            {
                { "choice", new Dictionary<string, string> { { "FR", "Faites votre choix :" },{ "EN", "Make your choice:" } } },
                { "choice 1", new Dictionary<string, string> { { "FR", "Changer de langage." }, { "EN", "Change language." } } },
                { "choice 2", new Dictionary<string, string> { { "FR", "Choix de la sauvegarde." }, { "EN", "Choice of backup." } } },
                { "choice 3", new Dictionary<string, string> { { "FR", "Affichage des logs." }, { "EN", "Display logs." } } },
                { "choice 4", new Dictionary<string, string> { { "FR", "Quitter." }, { "EN", "Quit." } } },
                { "source", new Dictionary<string, string> { { "FR", "Veuillez choisir votre répertoire source :" }, { "EN", "Please choose your source directory:" } } },
                { "target", new Dictionary<string, string> { { "FR", "Où voulez-vous copier ce dossier :" }, { "EN", "Where do you want to copy this file :" } } },
                { "error", new Dictionary<string, string> { { "FR", "Une erreur s'est produite. Veuillez entrer un choix valide." }, { "EN", "An error has occurred. Please enter a valid choice." } } },
                { "savechoice 1", new Dictionary<string, string> { { "FR", "Copie complète." }, { "EN", "Full Copy." } } },
                { "savechoice 2", new Dictionary<string, string> { { "FR", "Copie partielle." }, { "EN", "Partial copy." } } },
                { "savechoice 3", new Dictionary<string, string> { { "FR", "Retour au menu." }, { "EN", "Back to menu." } } }
            };
        public static string sCurrentLanguage = "FR";

        public static string Traductor(string sChoice)
        {
            return dLanguage[sChoice][sCurrentLanguage];
        }

    }
}
