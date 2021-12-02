using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Error;

namespace Language
{
    class LanguageViewModel
    {
        public void LanguageC()
        {
            /* Affichage des différentes langues et attente du choix de la part de l'utilisateur */
            int iChoiceL = 0;

            while (iChoiceL != 3)
            {
                try
                {
                    LangView LanguageView = new LangView();
                    LanguageView.LanguageV();

                    iChoiceL = int.Parse(Console.ReadLine());

                    /* Change la langue en français */
                    if (iChoiceL == 1)
                    {
                        string sLang = "FR";
                        LanguageModel.sCurrentLanguage = sLang;
                        Console.Clear();

                    }

                    /* Change la langue en anglais */
                    else if (iChoiceL == 2)
                    {
                        string sLang = "EN";
                        LanguageModel.sCurrentLanguage = sLang;
                        Console.Clear();
                    }

                    /* Affichage d'une erreur en cas de saisie invalide de l'utilisateur */
                    else if (iChoiceL > 3)
                    {
                        ErrorViewModel errorController = new ErrorViewModel();
                        errorController.ErrorC();
                        Console.Clear();
                    }
                }

                /* Affichage d'une erreur en cas de disfonctionnement */
                catch
                {
                    ErrorViewModel errorController = new ErrorViewModel();
                    errorController.ErrorC();
                    Console.Clear();
                }
            }
        }
    }
}