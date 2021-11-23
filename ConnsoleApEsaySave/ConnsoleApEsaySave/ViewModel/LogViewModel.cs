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

namespace LogD
{
    
    public class LogViewModel
    {
        RepositoryModel repositoryModel = new RepositoryModel();
        MenuView menuView = new MenuView();        


        public void LogAffichage()
        {

            string pathlog = @"C:\EasySave\Log\Sample_log.txt";
            if (!File.Exists(pathlog))
            {
                Console.Clear();
                menuView.MenuV();
                Console.Write("Le fichier Log n'extsite pas, veuiller faire une sauvegarde");
            }

            else { 
                // Read the file as one string.
                string text = System.IO.File.ReadAllText(pathlog);
                Console.WriteLine("\n");
                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt =" + "\n" + "" + "\n" + "{0}", text);
            }
        }

        public void CreateLog()
        {
            string sContext_name = "yann";
            string sName = "docx";


            string str = "{\n\n\"" + sContext_name + "\":{ \n\"Name\": \"" + sName + "\",\n\"FileSource\": \"" + repositoryModel.TargetRepository + "\",\n\"FileTarget\": \"" + repositoryModel.SourceRepository + "\",\n\"DestPath\": \"mettre DestPath\",\n\"FileSize\": \"mettre taille\",\n\"FileTransferTime\": \"TIME\",}}\n";
            JObject json = JObject.Parse(str);


            //création du fichier log et où il sera créé avec des infos
            using (var Log = new LoggerConfiguration()
                .WriteTo.File(@"C:\EasySave\Log\Sample_log.txt")//, rollingInterval: RollingInterval.Day//) 
                                                                //pour ajouter date dans le nom de fichier
                .CreateLogger()) 
            {
                Log.Information(str);
            };
                

        }



























        public void HeadShrek()
        {
            Console.WriteLine(@"
⡴⠑⡄⠀⠀⠀⠀⠀⠀⠀ ⣀⣀⣤⣤⣤⣀⡀
⠸⡇⠀⠿⡀⠀⠀⠀⣀⡴⢿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀
⠀⠀⠀⠀⠑⢄⣠⠾⠁⣀⣄⡈⠙⣿⣿⣿⣿⣿⣿⣿⣿⣆
⠀⠀⠀⠀⢀⡀⠁⠀⠀⠈⠙⠛⠂⠈⣿⣿⣿⣿⣿⠿⡿⢿⣆
⠀⠀⠀⢀⡾⣁⣀⠀⠴⠂⠙⣗⡀⠀⢻⣿⣿⠭⢤⣴⣦⣤⣹⠀⠀⠀⢀⢴⣶⣆
⠀⠀⢀⣾⣿⣿⣿⣷⣮⣽⣾⣿⣥⣴⣿⣿⡿⢂⠔⢚⡿⢿⣿⣦⣴⣾⠸⣼⡿
⠀⢀⡞⠁⠙⠻⠿⠟⠉⠀⠛⢹⣿⣿⣿⣿⣿⣌⢤⣼⣿⣾⣿⡟⠉
⠀⣾⣷⣶⠇⠀⠀⣤⣄⣀⡀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇
⠀⠉⠈⠉⠀⠀⢦⡈⢻⣿⣿⣿⣶⣶⣶⣶⣤⣽⡹⣿⣿⣿⣿⡇
⠀⠀⠀⠀⠀⠀⠀⠉⠲⣽⡻⢿⣿⣿⣿⣿⣿⣿⣷⣜⣿⣿⣿⡇
⠀⠀ ⠀⠀⠀⠀⠀⢸⣿⣿⣷⣶⣮⣭⣽⣿⣿⣿⣿⣿⣿⣿⠇
⠀⠀⠀⠀⠀⠀⣀⣀⣈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇
⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃");

        }






    }
}
