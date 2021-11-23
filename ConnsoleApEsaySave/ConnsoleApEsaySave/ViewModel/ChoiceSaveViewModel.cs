using System;
using System.Collections.Generic;
using System.Text;
using Language;
using Repository;
using Menu;
using Error;
using Serilog;
using Newtonsoft.Json.Linq;

namespace ChoiceSave
{
    class ChoiceSaveViewModel
    {

        RepositoryModel repositoryModel = new RepositoryModel();


        public void ChoiceSaveVM()
        {
            int iChoiceS = 0;

            /* Envoie vers un style de sauvegarde selon le choix de l'utilisateur */
            while (iChoiceS != 3)
            {
                ChoiceSaveView choiceSaveView = new ChoiceSaveView();
                choiceSaveView.SaveMenuV();

                iChoiceS = int.Parse(Console.ReadLine());

                if (iChoiceS == 1)
                {
                    RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
                    repositoryViewModel.FullCopyRepository();
                    Console.Clear();
                }

                else if (iChoiceS == 2)
                {
                    RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
                    repositoryViewModel.PartialCopyRepository();
                    Console.Clear();
                }

               else if (iChoiceS>3)
                {
                    ErrorViewModel errorViewModel = new ErrorViewModel();
                    errorViewModel.ErrorVM();
                    Console.Clear();
                }
            }


            string sContext_name = "yann";
            string sName = "docx";


            string str = "{\n\n\"" + sContext_name + "\":{ \n\"Name\": \"" + sName + "\",\n\"FileSource\": \"" + repositoryModel.TargetRepository + "\",\n\"FileTarget\": \"" + repositoryModel.SourceRepository + "\",\n\"DestPath\": \"mettre DestPath\",\n\"FileSize\": \"mettre taille\",\n\"FileTransferTime\": \"TIME\",}}\n";
            JObject json = JObject.Parse(str);


            //création du fichier log et où il sera créé avec des infos
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"C:\EasySave\Log\Sample_log.txt")//, rollingInterval: RollingInterval.Day//) 
                                                                //pour ajouter date dans le nom de fichier
                .CreateLogger();
            Log.Information(str);


        }
    }
}
