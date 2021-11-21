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
                { "choice 2", new Dictionary<string, string> { { "FR", "Choix de la sauvegarde." }, { "EN", "Save choice." } } },
                { "choice 3", new Dictionary<string, string> { { "FR", "Affichage des logs." }, { "EN", "Display logs." } } },
                { "choice 4", new Dictionary<string, string> { { "FR", "Quitter." }, { "EN", "Quit." } } }
            };
        public static string sCurrentLanguage = "FR";

        public static string Traductor(string sChoice)
        {
            //  LanguageModel languageModel = new LanguageModel();
            return dLanguage[sChoice][sCurrentLanguage];
        }

    }
}
