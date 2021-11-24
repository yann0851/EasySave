using System;
using System.Collections.Generic;
using System.Text;

namespace Language
{
    class LanguageView
    {
        public void LanguageV()
        {
            /* Ecriture du menu du choix de sauvegarde */
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string sLanguage = @"
                            ██       █████  ███    ██  ██████  ██    ██  █████   ██████  ███████ 
                            ██      ██   ██ ████   ██ ██       ██    ██ ██   ██ ██       ██      
                            ██      ███████ ██ ██  ██ ██   ███ ██    ██ ███████ ██   ███ █████   
                            ██      ██   ██ ██  ██ ██ ██    ██ ██    ██ ██   ██ ██    ██ ██      
                            ███████ ██   ██ ██   ████  ██████   ██████  ██   ██  ██████  ███████ 
            ";
            Console.WriteLine(sLanguage);
            Console.WriteLine("\n" + "████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(
                   LanguageModel.Traductor("choice") + "\n" + "\n" +
                    "1. " + LanguageModel.Traductor("langchoice 1") + "\n" +
                    "2. " + LanguageModel.Traductor("langchoice 2") + "\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                    "3. " + LanguageModel.Traductor("langchoice 3") + "\n"
                    );
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + "████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
