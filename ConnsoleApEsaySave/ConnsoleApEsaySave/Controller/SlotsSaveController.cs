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
            SlotsSaveModel.SaveSlots();
            SlotsSaveModel.LoadSlots();
            

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
                            /* Si la sauvegarde existe déjà envoie vers le choix du type de sauvegarde voulu */
                            if (SlotsSaveModel.Slots(0) != null)
                            {
                                SlotsSaveModel.iCurrentSlot = 0;
                                ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                                choiceSaveController.ChoiceSaveC();
                                Console.Clear();
                            }
                            /* Si la sauvegarde n'existe pas, création de la sauvegarde */
                            else
                            {
                                slotsSaveView.Save1V();
                                SlotsSaveModel.SaveSlots();
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

                    else if (iChoiceSS == 2)
                    {
                        //sauvegarde 2
                        Console.Clear();
                        try
                        {
                            if (SlotsSaveModel.Slots(1) != null)
                            {
                                SlotsSaveModel.iCurrentSlot = 1;
                                ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                                choiceSaveController.ChoiceSaveC();
                                Console.Clear();
                            }
                            else
                            {
                                slotsSaveView.Save2V();
                                SlotsSaveModel.SaveSlots();
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

                    else if (iChoiceSS == 3)
                    {
                        //sauvegarde 3
                        Console.Clear();
                        try
                        {
                            if (SlotsSaveModel.Slots(2) != null)
                            {
                                SlotsSaveModel.iCurrentSlot = 2;
                                ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                                choiceSaveController.ChoiceSaveC();
                                Console.Clear();
                            }
                            else
                            {
                                slotsSaveView.Save3V();
                                SlotsSaveModel.SaveSlots();
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

                    else if (iChoiceSS == 4)
                    {
                        //sauvegarde 4
                        Console.Clear();
                        try
                        {
                            if (SlotsSaveModel.Slots(3) != null)
                            {
                                SlotsSaveModel.iCurrentSlot = 3;
                                ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                                choiceSaveController.ChoiceSaveC();
                                Console.Clear();
                            }
                            else
                            {
                                slotsSaveView.Save4V();
                                SlotsSaveModel.SaveSlots();
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

                    else if (iChoiceSS == 5)
                    {
                        //sauvegarde 5
                        Console.Clear();
                        try
                        {
                            if (SlotsSaveModel.Slots(4) != null)
                            {
                                SlotsSaveModel.iCurrentSlot = 4;
                                ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                                choiceSaveController.ChoiceSaveC();
                                Console.Clear();
                            }
                            else
                            {
                                slotsSaveView.Save5V();
                                SlotsSaveModel.SaveSlots();
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