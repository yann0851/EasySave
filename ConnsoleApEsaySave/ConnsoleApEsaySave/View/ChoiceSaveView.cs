using System;
using System.Collections.Generic;
using System.Text;
using Language;

namespace ChoiceSave
{
    class ChoiceSaveView
    {
        public void SaveMenuV()
        {
            /* Ecriture du menu du choix de sauvegarde */
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string sSave = @"
                                        ███████  █████  ██    ██ ███████ 
                                        ██      ██   ██ ██    ██ ██      
                                        ███████ ███████ ██    ██ █████   
                                             ██ ██   ██  ██  ██  ██      
                                        ███████ ██   ██   ████   ███████
            ";
            Console.WriteLine(sSave);
            Console.WriteLine("\n" + "████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(
                   LanguageModel.Traductor("choice") + "\n" + "\n" +
                    "1. " + LanguageModel.Traductor("savechoice 1") + "\n" +
                    "2. " + LanguageModel.Traductor("savechoice 2") + "\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                    "3. " + LanguageModel.Traductor("savechoice 3") + "\n"
                    );
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + "████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}