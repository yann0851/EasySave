using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;
using Menu;
using Error;

namespace ChoiceSave
{
    class ChoiceSaveViewModel
    {
        public void ChoiceSaveVM()
        {
            int iChoiceS = 0;

            /* Envoie vers un style de sauvegarde selon le choix de l'utilisateur */
            while (iChoiceS != 3)
            {
                ChoiceSaveView choiceSaveView = new ChoiceSaveView();
                choiceSaveView.SaveMenuV();

                iChoiceS = int.Parse(Console.ReadLine());

                if (iChoiceS == 1)
                {
                    RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
                    repositoryViewModel.FullCopyRepository();
                    Console.Clear();
                }

                else if (iChoiceS == 2)
                {
                    RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
                    repositoryViewModel.PartialCopyRepository();
                    Console.Clear();
                }

               else if (iChoiceS>3)
                {
                    ErrorViewModel errorViewModel = new ErrorViewModel();
                    errorViewModel.ErrorVM();
                    Console.Clear();
                }
            }
        }
    }
}
