using System;
using System.Collections.Generic;
using System.Text;
using Language;

namespace Menu
{
    class MenuView
    {
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
                "1. " + LanguageModel.Traductor("choice 1") + "\n" +
                "2. " + LanguageModel.Traductor("choice 2") + "\n" +
                "3. " + LanguageModel.Traductor("choice 3") + "\n" +
                "4. " + LanguageModel.Traductor("choice 4") + "\n"
                );
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            
        }
    }
}
