using System;
using System.Collections.Generic;
using System.Text;

namespace Language
{
    class LanguageModel
    {
        /* Création du dictionnaire permettant de traduire l'application */

        static Dictionary<string, Dictionary<string, string>> dLanguage = new Dictionary<string, Dictionary<string, string>>
            {
                { "choice", new Dictionary<string, string> { { "FR", "Faites votre choix :" },{ "EN", "Make your choice:" } } },
                { "menuchoice 1", new Dictionary<string, string> { { "FR", "Changer de langage." }, { "EN", "Change language." } } },
                { "menuchoice 2", new Dictionary<string, string> { { "FR", "Choix de la sauvegarde." }, { "EN", "Choice of backup." } } },
                { "menuchoice 3", new Dictionary<string, string> { { "FR", "Affichage des logs." }, { "EN", "Display logs." } } },
                { "menuchoice 4", new Dictionary<string, string> { { "FR", "Quitter." }, { "EN", "Quit." } } },
                { "nom_sauvegarde", new Dictionary<string, string> { { "FR", "Veuillez choisir un nom pour votre sauvegarde :" }, { "EN", "Please choose a name for your backup :" } } },
                { "source", new Dictionary<string, string> { { "FR", "Veuillez choisir votre répertoire source :" }, { "EN", "Please choose your source directory:" } } },
                { "target", new Dictionary<string, string> { { "FR", "Où voulez-vous copier ce dossier :" }, { "EN", "Where do you want to copy this file :" } } },
                { "error", new Dictionary<string, string> { { "FR", "Une erreur s'est produite. Veuillez entrer un choix valide." }, { "EN", "An error has occurred. Please enter a valid choice." } } },
                { "savechoice 1", new Dictionary<string, string> { { "FR", "Copie complète." }, { "EN", "Full Copy." } } },
                { "savechoice 2", new Dictionary<string, string> { { "FR", "Copie partielle." }, { "EN", "Partial copy." } } },
                { "savechoice 3", new Dictionary<string, string> { { "FR", "Retour au menu." }, { "EN", "Back to menu." } } }
            };
        
        /* Initialisation du langage par défaut en français */
        public static string sCurrentLanguage = "FR";

        public static string Traductor(string sChoice)
        {
            return dLanguage[sChoice][sCurrentLanguage];
        }

    }
}
