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


            string name1 = "-----";
            if (SlotsSaveModel.Slots(0) != null)
            {
                name1 = SlotsSaveModel.Slots(0).Name;
            }
            string name2 = "-----";
            if (SlotsSaveModel.Slots(1) != null)
            {
                name2 = SlotsSaveModel.Slots(1).Name;
            }
            string name3 = "-----";
            if (SlotsSaveModel.Slots(2) != null)
            {
                name3 = SlotsSaveModel.Slots(2).Name;
            }
            string name4 = "-----";
            if (SlotsSaveModel.Slots(3) != null)
            {
                name4 = SlotsSaveModel.Slots(3).Name;
            }
            string name5 = "-----";
            if (SlotsSaveModel.Slots(4) != null)
            {
                name5 = SlotsSaveModel.Slots(4).Name;
            }

            Console.WriteLine(
                   LanguageModel.Traductor("choice") + "\n" + "\n" +
                    "1. " + name1 + "\n" +
                    "2. " + name2 + "\n" +
                    "3. " + name3 + "\n" +
                    "4. " + name4 + "\n" +
                    "5. " + name5 + "\n"
                    );
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                    "6. " + LanguageModel.Traductor("menuback") + "\n"
                    );
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + "████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Save1V()
        {
            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(1).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(1).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(1).FolderTarget = Console.ReadLine();
        }

        public void Save2V()
        {
            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(1).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(1).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(1).FolderTarget = Console.ReadLine();
        }

        public void Save3V()
        {
            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(1).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(1).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(1).FolderTarget = Console.ReadLine();
        }

        public void Save4V()
        {
            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(1).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(1).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(1).FolderTarget = Console.ReadLine();
        }

        public void Save5V()
        {
            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(1).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(1).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(1).FolderTarget = Console.ReadLine();
        }
    }
}