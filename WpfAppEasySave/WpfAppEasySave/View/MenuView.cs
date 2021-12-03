using System;
using System.Collections.Generic;
using System.Text;
using Language;

namespace Menu
{
    class MenuView
    {
        /* Affichage d'un titre et du menu général */
        public void MenuV()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string title = @"
            ▄██████▀    ▄██████▄    ▄████████▄ ▄██   ██▄    ▄███████▄    ▄██████▄  ███    ███    ▄██████▀ 
            ███        ███    ███   ███    ███ ███   ███   ███    ███   ███    ███ ███    ███   ███    
            ███        ███    ███   ███    █▀  ███▄▄▄███   ███    █▀    ███    ███ ███    ███   ███    
            ███▄▄▄     ███    ███   ███        ▀▀▀▀▀▀███   ███          ███    ███ ███    ███   ███▄▄▄
            ███▀▀▀     ██████████   ██████████ ▄██   ███   ██████████   ██████████ ███    ███   ███▀▀▀
            ███        ███    ███          ███ ███   ███          ███   ███    ███ ███    ███   ███    
            ███        ███    ███          ███ ███   ███          ███   ███    ███ ███    ███   ███   
            ▀██████▄   ███    ███  ▄████████▀   ▀█████▀   ▄████████▀    ███    ███  ▀██████▀     ▀██████▄";
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n"+"████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine(
            //    LanguageModel.Traductor("choice") + "\n" + "\n" +
            //    "1. " + LanguageModel.Traductor("menuchoice 1") + "\n" +
            //    "2. " + LanguageModel.Traductor("menuchoice 2") + "\n" +
            //    "3. " + LanguageModel.Traductor("menuchoice 3") + "\n" +
            //    "4. " + LanguageModel.Traductor("menuchoice 4") + "\n");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("5. " + LanguageModel.Traductor("menuchoice 5") + "\n"
            //    );
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + "████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
