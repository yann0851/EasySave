using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;
using Error;
using ChoiceSave;

namespace Menu
{
    class MenuViewModel
    {
        public void MenuVM()
        {
            int iChoice = 0;

            while (iChoice != 4)
            {
                MenuView MenuView = new MenuView();
                MenuView.MenuV();

                iChoice = int.Parse(Console.ReadLine());

                if (iChoice == 1)
                {
                    LanguageViewModel LanguageViewModel = new LanguageViewModel();
                    LanguageViewModel.LanguageVM();
                    Console.Clear();

                }

                else if (iChoice == 2)
                {
                    ChoiceSaveViewModel choiceSaveViewModel = new ChoiceSaveViewModel();
                    choiceSaveViewModel.ChoiceSaveVM();
                    Console.Clear();
                }

                else if (iChoice == 3)
                {
                    Console.Clear();
                }

                else if (iChoice>4)
                {
                    ErrorViewModel errorViewModel = new ErrorViewModel();
                    errorViewModel.ErrorVM();
                    Console.Clear();
                }

            }
        }
    }
}
