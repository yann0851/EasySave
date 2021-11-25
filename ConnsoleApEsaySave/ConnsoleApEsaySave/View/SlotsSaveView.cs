using System;
using System.Collections.Generic;
using System.Text;
using Language;

namespace SlotsSave
{
    class SlotsSaveView
    {
        public void SlotsSaveV()
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
                    "1. " + "" + "\n" +
                    "2. " + "" + "\n" +
                    "3. " + "" + "\n" +
                    "4. " + "" + "\n" +
                    "5. " + "" + "\n"
                    );
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                    "6. " + LanguageModel.Traductor("menuback") + "\n"
                    );
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + "████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}