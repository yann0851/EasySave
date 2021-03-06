using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;
using Error;
using ChoiceSave;
using LogD;
using StateD;
using SlotsSave;


namespace Menu
{
    class MenuController
    {
        /* Envoie vers une fonction de l'application selon le choix de l'utilisateur */
        public void MenuC()
        {
            int iChoiceM = 0;

            while (iChoiceM != 5)
            {
                MenuView MenuView = new MenuView();
                MenuView.MenuV();

                try
                {
                    iChoiceM = int.Parse(Console.ReadLine());

                    /* Lance le choix de la langue */
                    if (iChoiceM == 1)
                    {
                        Console.Clear();
                        LanguageController LanguageController = new LanguageController();
                        LanguageController.LanguageC();
                        Console.Clear();
                    }

                    /* Lance le choix de la sauvegarde */
                    else if (iChoiceM == 2)
                    {
                        Console.Clear();
                        SlotsSaveController slotsSaveController = new SlotsSaveController();
                        slotsSaveController.SlotsSaveC();
                        Console.Clear();
                    }

                    /* Lance l'affichage des logs */
                    else if (iChoiceM == 3)
                    {
                        Console.Clear();
                        LogView LogView = new LogView();
                        LogView.LogV();
                        Console.Clear();
                    }

                    /* Lance l'affichage de l'état des sauvegardes */
                    else if (iChoiceM == 4)
                    {
                        Console.Clear();
                        StateView stateView = new StateView();
                        stateView.StateV();
                        Console.Clear();
                    }

                    /* Affichage d'une erreur en cas de saisie invalide de l'utilisateur */
                    else if (iChoiceM>5)
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