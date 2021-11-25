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

namespace StateD
{

    public class StateController
    {
        RepositoryModel repositoryModel = new RepositoryModel();
        MenuView menuView = new MenuView();

        public void StateAffichage()
        {

            string pathlog = @"C:\EasySave\Log\Sample_state.txt";
            if (!File.Exists(pathlog))
            {
                Console.Clear();
                menuView.MenuV();
                Console.Write("Le fichier Status n'extsite pas, veuiller faire une sauvegarde");
            }

            else
            {
                // Read the file as one string.
                string text = System.IO.File.ReadAllText(pathlog);
                Console.WriteLine("\n");
                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt =" + "\n" + "" + "\n" + "{0}", text);
            }

        }


            public void CreateState(JobState js)
            {
                string Json1 = JsonConvert.SerializeObject(js, Formatting.Indented);
                /*
                string dossier = RecupTarget;
                DirectoryInfo fInfo = new DirectoryInfo(dossier);
                int size = (int)fInfo.Length;//taille en octets


                string str = "{\n\n\"" + sContext_name + "\":{ \n\"Name\": \"" + sName + "\",\n\"FileSource\": \"" + sName + "\",\n\"FileTarget\": \"" + sName + "\",\n\"DestPath\": \"mettre DestPath\",\n\"FileSize\": \"" + sName + "\",\n\"FileTransferTime\": \"TIME\",}}\n";
                */
                JObject json = JObject.Parse(Json1);


                //création du fichier log et où il sera créé avec des infos
                using (var Log = new LoggerConfiguration()
                    .WriteTo.File(@"C:\EasySave\Log\Sample_state.txt")//, rollingInterval: RollingInterval.Day//) 
                                                                    //pour ajouter date dans le nom de fichier
                    .CreateLogger())
                {
                    Log.Information(Json1);
                };


            }

    }
} 
