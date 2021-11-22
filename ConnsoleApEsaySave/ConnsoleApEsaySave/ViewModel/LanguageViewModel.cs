using System;
using System.Collections.Generic;
using System.Text;

namespace Language
{
    class LanguageViewModel
    {
        public void LanguageVM()
        {
            /* Affichage des différentes langues et attente du choix de la part de l'utilisateur */
            LanguageView languageView = new LanguageView();
            languageView.LanguageV();

            string sLang = Console.ReadLine();
            LanguageModel.sCurrentLanguage = sLang;
        }

        
    }
}
