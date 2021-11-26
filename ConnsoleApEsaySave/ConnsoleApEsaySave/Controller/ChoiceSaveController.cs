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
using StateD;
using SlotsSave;

namespace ChoiceSave
{
    class ChoiceSaveController
    {
        RepositoryModel repositoryModel = new RepositoryModel();
        public void ChoiceSaveC()
        {
            int iChoiceS = 0;

            /* Envoie vers un style de sauvegarde selon le choix de l'utilisateur */
            while (iChoiceS != 4 && iChoiceS != 3)
            {
                try
                {
                    ChoiceSaveView choiceSaveView = new ChoiceSaveView();
                    choiceSaveView.SaveMenuV();

                    iChoiceS = int.Parse(Console.ReadLine());

                    if (iChoiceS == 1)
                    {
                        RepositoryController repositoryController = new RepositoryController();
                        repositoryController.FullCopyRepository();
                        LogController logController = new LogController();
                        StateController stateController = new StateController();
                        //logController.CreateLog();
                        Console.Clear();
                    }

                    else if (iChoiceS == 2)
                    {
                        RepositoryController repositoryController = new RepositoryController();
                        repositoryController.PartialCopyRepository();
                        LogController logController = new LogController();
                        StateController stateController = new StateController();
                        //logController.CreateLog();
                        Console.Clear();
                    }

                    else if (iChoiceS == 3)
                    {
                        //supprimer sauvegarde
                        Console.Clear();
                        SlotsSaveModel.Slots(SlotsSaveModel.iCurrentSlot) = null;
                        Console.Clear();
                    }

                    else if (iChoiceS > 4)
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