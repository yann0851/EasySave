using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;
using Error;
using ChoiceSave;
using LogD;

namespace Menu
{
    class MenuViewModel
    {
        public void MenuVM()
        {
            int iChoiceM = 0;

            /* Envoie vers une fonction de l'application selon le choix de l'utilisateur */
            while (iChoiceM != 4)
            {
                MenuView MenuView = new MenuView();
                MenuView.MenuV();

                iChoiceM = int.Parse(Console.ReadLine());

                if (iChoiceM == 1)
                {
                    Console.Clear();
                    LanguageViewModel LanguageViewModel = new LanguageViewModel();
                    LanguageViewModel.LanguageVM();
                    Console.Clear();

                }

                else if (iChoiceM == 2)
                {
                    Console.Clear();
                    ChoiceSaveViewModel choiceSaveViewModel = new ChoiceSaveViewModel();
                    choiceSaveViewModel.ChoiceSaveVM();
                    Console.Clear();
                }

                else if (iChoiceM == 3)
                {
                    Console.WriteLine("\n");
                    LogView LogView = new LogView();
                    LogView.LogV();
                    Console.Clear();
                }

                else if (iChoiceM>4)
                {
                    ErrorViewModel errorViewModel = new ErrorViewModel();
                    errorViewModel.ErrorVM();
                    Console.Clear();
                }

            }
        }
    }
}
