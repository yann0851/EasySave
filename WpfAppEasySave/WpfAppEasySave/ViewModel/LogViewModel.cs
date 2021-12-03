using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using Serilog;
using Newtonsoft.Json.Linq;
using Repository;
using Menu;
using ConsoleAppEasySave.Model;
using Newtonsoft.Json;
using Language;

namespace LogD
{
    public class LogViewModel
    {
        RepositoryModel repositoryModel = new RepositoryModel();
        MenuView menuView = new MenuView();        

        /* Affichage des logs journaliers */
        public void LogAffichage()
        {
            string pathlog = @"C:\EasySave\Log\Sample_log.txt";

            /* Affichage d'une erreur, le fichier n'existe pas */
            if (!File.Exists(pathlog))
            {
                Console.Clear();
                menuView.MenuV();
                //Console.WriteLine(LanguageModel.Traductor("logs"));
            }

            /* Affichage du contenu du fichier */
            else { 
                string text = System.IO.File.ReadAllText(pathlog);
                Console.WriteLine("\n");
                System.Console.WriteLine("Contents of WriteText.txt =" + "\n" + "" + "\n" + "{0}", text);
            }
        }

        internal void CreateLog()
        {
            throw new NotImplementedException();
        }

        public void CreateLog(JobFile j)
        {
            string Json = JsonConvert.SerializeObject(j, Formatting.Indented);
            JObject json = JObject.Parse(Json);
            
            /* Création du fichier log et où il sera créé avec des infos */
            using (var Log = new LoggerConfiguration()
                .WriteTo.File(@"C:\EasySave\Log\Sample_log.txt")
                .CreateLogger()) 
            {
                Log.Information(Json);
            };
        }
    }
}
