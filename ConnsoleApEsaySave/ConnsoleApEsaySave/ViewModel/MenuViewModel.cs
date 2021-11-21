using System;
using System.Collections.Generic;
using System.Text;
using Language;

namespace Menu
{
    class MenuViewModel
    {
        public void MenuVM()
        {
            MenuView MenuView = new MenuView();
            MenuView.MenuV();

            int iChoice = int.Parse(Console.ReadLine());

            if (iChoice == 1)
            {
                LanguageViewModel LanguageViewModel = new LanguageViewModel();
                LanguageViewModel.LanguageVM();
            }


        }
    }
}
