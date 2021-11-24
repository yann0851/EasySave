using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;
using Menu;
using Error;
using Serilog;
using Newtonsoft.Json.Linq;
using LogD;

namespace ChoiceSave
{
    class ChoiceSaveViewModel
    {

        RepositoryModel repositoryModel = new RepositoryModel();


        public void ChoiceSaveVM()
        {

            int iChoiceS = 0;
            /* Envoie vers un style de sauvegarde selon le choix de l'utilisateur */
            while (iChoiceS != 3)
            {
                try
                {
                    ChoiceSaveView choiceSaveView = new ChoiceSaveView();
                    choiceSaveView.SaveMenuV();

                    iChoiceS = int.Parse(Console.ReadLine());

                    if (iChoiceS == 1)
                    {
                        RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
                        repositoryViewModel.FullCopyRepository();
                        LogViewModel logViewModel = new LogViewModel();
                        //logViewModel.CreateLog();
                        Console.Clear();
                    }

                    else if (iChoiceS == 2)
                    {
                        RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
                        repositoryViewModel.PartialCopyRepository();
                        LogViewModel logViewModel = new LogViewModel();
                        //logViewModel.CreateLog();
                        Console.Clear();
                    }

                    else if (iChoiceS > 3)
                    {
                        ErrorViewModel errorViewModel = new ErrorViewModel();
                        errorViewModel.ErrorVM();
                        Console.Clear();
                    }
                }
                catch
                {
                    ErrorViewModel errorViewModel = new ErrorViewModel();
                    errorViewModel.ErrorVM();
                    Console.Clear();
                }
            }

           
        }
    }
}
