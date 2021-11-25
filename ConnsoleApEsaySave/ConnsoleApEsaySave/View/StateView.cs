using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using LogD;

namespace StateD
{
    class StateView
    {
        public void StateV()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string sLogs = @"
                                        ██       ██████   ██████  ███████ 
                                        ██      ██    ██ ██       ██      
                                        ██      ██    ██ ██   ███ ███████ 
                                        ██      ██    ██ ██    ██      ██ 
                                        ███████  ██████   ██████  ███████
            ";
            Console.WriteLine(sLogs);
            Console.WriteLine("\n" + "████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            StateController stateController = new StateController();

            //Création du log
            stateController.StateAffichage();
            Console.ReadKey();
        }
    }
}
