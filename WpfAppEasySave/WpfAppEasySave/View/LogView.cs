using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace LogD
{
    class LogView
    {
        public void LogV()
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
            LogViewModel logController = new LogViewModel();

            //Création du log
            logController.LogAffichage();
            Console.ReadKey();
        }
    }
}