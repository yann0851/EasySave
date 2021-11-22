using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;
using Menu;

namespace ChoiceSave
{
    class ChoiceSaveViewModel
    {
        public void ChoiceSaveVM()
        {
            int iChoice = 0;

            while (iChoice != 3)
            {
                ChoiceSaveView choiceSaveView = new ChoiceSaveView();
                choiceSaveView.SaveMenuV();

                iChoice = int.Parse(Console.ReadLine());

                if (iChoice == 1)
                {
                    RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
                    repositoryViewModel.FullCopyRepository();
                    Console.Clear();
                }

                else if (iChoice == 2)
                {
                    RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
                    repositoryViewModel.PartialCopyRepository();
                    Console.Clear();
                }

                else if (iChoice == 3)
                {
                    MenuViewModel MenuViewModel = new MenuViewModel();
                    MenuViewModel.MenuVM();
                    Console.Clear();
                }
            }
        }
    }
}
