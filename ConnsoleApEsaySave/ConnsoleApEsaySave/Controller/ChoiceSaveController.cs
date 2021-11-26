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
        /* Choix du style de sauvegarde selon le choix de l'utilisateur */
        public void ChoiceSaveC()
        {
            int iChoiceS = 0;

            while (iChoiceS != 4 && iChoiceS != 3)
            {
                try
                {
                    ChoiceSaveView choiceSaveView = new ChoiceSaveView();
                    choiceSaveView.SaveMenuV();

                    iChoiceS = int.Parse(Console.ReadLine());

                    /* Sauvegarde Complète */
                    if (iChoiceS == 1)
                    {
                        RepositoryController repositoryController = new RepositoryController();
                        repositoryController.FullCopyRepository();
                        LogController logController = new LogController();
                        StateController stateController = new StateController();
                        Console.Clear();
                    }

                    /* Sauvegarde Partielle */
                    else if (iChoiceS == 2)
                    {
                        RepositoryController repositoryController = new RepositoryController();
                        repositoryController.PartialCopyRepository();
                        LogController logController = new LogController();
                        StateController stateController = new StateController();
                        Console.Clear();
                    }

                    /* Suppresion de la sauvegarde */
                    else if (iChoiceS == 3)
                    {
                        Console.Clear();
                        SlotsSaveModel.Slots(SlotsSaveModel.iCurrentSlot) = null;
                        SlotsSaveModel.SaveSlots();
                        Console.Clear();
                    }

                    /* Affichage d'une erreur en cas de saisie invalide de l'utilisateur */
                    else if (iChoiceS > 4)
                    {
                        ErrorController errorController = new ErrorController();
                        errorController.ErrorC();
                        Console.Clear();
                    }
                }

                /* Affichage d'une erreur en cas de disfonctionnement */
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