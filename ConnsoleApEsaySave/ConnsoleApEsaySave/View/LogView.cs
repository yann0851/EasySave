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

            LogViewModel LogViewModel = new LogViewModel();

            //Création du log
            LogViewModel.CreateLog();
            Console.WriteLine("Création du log dans le fichier C:Easy/Save/Log sous le nom de 'Sample_log.txt'");

            LogViewModel.HeadShrek();
            Console.ReadKey();
        }
    }
}