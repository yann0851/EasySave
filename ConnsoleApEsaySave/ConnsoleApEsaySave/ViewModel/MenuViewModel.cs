using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;

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

                }

                else if (iChoice == 2)
                {
                    RepositoryView RepositoryView = new RepositoryView();
                    RepositoryView.RepositoryV();
                }

                else if (iChoice == 3)
                {

                }

                else
                {

                }

            }
        }
    }
}
