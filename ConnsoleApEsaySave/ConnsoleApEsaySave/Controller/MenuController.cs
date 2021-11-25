using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;
using Error;
using ChoiceSave;
using LogD;
using StateD;

namespace Menu
{
    class MenuController
    {
        public void MenuC()
        {
            int iChoiceM = 0;

            /* Envoie vers une fonction de l'application selon le choix de l'utilisateur */
            while (iChoiceM != 5)
            {
                MenuView MenuView = new MenuView();
                MenuView.MenuV();

                try
                {
                    iChoiceM = int.Parse(Console.ReadLine());
                
                    if (iChoiceM == 1)
                    {
                        Console.Clear();
                        LanguageController LanguageController = new LanguageController();
                        LanguageController.LanguageC();
                        Console.Clear();
                    }

                    else if (iChoiceM == 2)
                    {
                        Console.Clear();
                        ChoiceSaveController choiceSaveController = new ChoiceSaveController();
                        choiceSaveController.ChoiceSaveC();
                        Console.Clear();
                    }

                    else if (iChoiceM == 3)
                    {
                        Console.Clear();
                        LogView LogView = new LogView();
                        LogView.LogV();
                        Console.Clear();
                    }

                    else if (iChoiceM == 4)
                    {
                        Console.Clear();
                        StateView stateView = new StateView();
                        stateView.StateV();
                        Console.Clear();
                    }

                    else if(iChoiceM>5)
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