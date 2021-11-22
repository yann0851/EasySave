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
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine(
                LanguageModel.Traductor("choice") + "\n" +
                "1. " + LanguageModel.Traductor("menuchoice 1") + "\n" +
                "2. " + LanguageModel.Traductor("menuchoice 2") + "\n" +
                "3. " + LanguageModel.Traductor("menuchoice 3") + "\n" +
                "4. " + LanguageModel.Traductor("menuchoice 4") + "\n"
                );
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            
        }
    }
}
