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
using ChoiceSave;

namespace SlotsSave
{
    class SlotsSaveController
    {
        public void SlotsSaveC()
        {
            int iChoiceSS = 0;

            /* Envoie vers un style de sauvegarde selon le choix de l'utilisateur */
            while (iChoiceSS != 6)
            {
               try
                {
                    SlotsSaveView slotsSaveView = new SlotsSaveView();
                    slotsSaveView.SlotsSaveV();

                    iChoiceSS = int.Parse(Console.ReadLine());

                   if (iChoiceSS == 1)
                    {
                        //sauvegarde 1
                        Console.Clear();
                        try
                        {
                            
                        }
                        catch
                        {
                            ErrorController errorController = new ErrorController();
                            errorController.ErrorC();
                            Console.Clear();
                        }
                        ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                        choiceSaveController.ChoiceSaveC();
                        Console.Clear();
                    }

                    else if (iChoiceSS == 2)
                    {
                        //sauvegarde 2
                        Console.Clear();
                        ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                        choiceSaveController.ChoiceSaveC();
                        Console.Clear();
                    }

                    else if (iChoiceSS == 3)
                    {
                        //sauvegarde 3
                        Console.Clear();
                        ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                        choiceSaveController.ChoiceSaveC();
                        Console.Clear();
                    }

                    else if (iChoiceSS == 4)
                    {
                        //sauvegarde 4
                        Console.Clear();
                        ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                        choiceSaveController.ChoiceSaveC();
                        Console.Clear();
                    }

                    else if (iChoiceSS == 5)
                    {
                        //sauvegarde 5
                        Console.Clear();
                        ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                        choiceSaveController.ChoiceSaveC();
                        Console.Clear();
                    }

                    else if (iChoiceSS > 6)
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