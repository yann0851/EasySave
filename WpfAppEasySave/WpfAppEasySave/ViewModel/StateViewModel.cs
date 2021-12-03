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
using ConsoleAppEasySave.Model;
using Newtonsoft.Json;
using Language;

namespace StateD
{

    public class StateViewModel
    {
        RepositoryModel repositoryModel = new RepositoryModel();

        public void StateAffichage()
        {

            string pathlog = @"C:\EasySave\Log\Sample_state.txt";
            if (!File.Exists(pathlog))
            {
                Console.WriteLine(LanguageModel.Traductor("logs"));
            }

            /* Affichage du contenu du fichier d'état */
            else
            {
                string text = System.IO.File.ReadAllText(pathlog);
                Console.WriteLine("\n");
                System.Console.WriteLine("Contents of WriteText.txt =" + "\n" + "" + "\n" + "{0}", text);
            }

        }


            public void CreateState(JobState js)
            {
                string Json1 = JsonConvert.SerializeObject(js, Formatting.Indented);
                JObject json = JObject.Parse(Json1);


                /* Création du fichier */
                using (var Log = new LoggerConfiguration()
                    .WriteTo.File(@"C:\EasySave\Log\Sample_state.txt")
                    .CreateLogger())
                {
                    Log.Information(Json1);
                };
            }

        internal void CreateState()
        {
            throw new NotImplementedException();
        }
    }
} 
