﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Error;

namespace Language
{
    class LanguageController
    {
        public void LanguageC()
        {
            /* Affichage des différentes langues et attente du choix de la part de l'utilisateur */
            int iChoiceL = 0;

            /* Change de langue selon le choix de l'utilisateur */
            while (iChoiceL != 3)
            {
                try
                {
                    LanguageView LanguageView = new LanguageView();
                    LanguageView.LanguageV();

                    iChoiceL = int.Parse(Console.ReadLine());

                    if (iChoiceL == 1)
                    {
                        string sLang = "FR";
                        LanguageModel.sCurrentLanguage = sLang;
                        Console.Clear();

                    }

                    else if (iChoiceL == 2)
                    {
                        string sLang = "EN";
                        LanguageModel.sCurrentLanguage = sLang;
                        Console.Clear();
                    }

                    else if (iChoiceL > 3)
                    {
                        ErrorController errorController = new ErrorController();
                        errorController.ErrorC();
                        Console.Clear();
                    }
                }

                catch
                {
                    ErrorController errorController = new ErrorController();
                    errorController.ErrorC();
                    Console.Clear();
                }
            }
        }
    }
}