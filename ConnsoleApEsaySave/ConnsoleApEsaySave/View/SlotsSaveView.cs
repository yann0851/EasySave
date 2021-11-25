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


            string sName1 = "-----";
            if (SlotsSaveModel.Slots(0) != null)
            {
                sName1 = SlotsSaveModel.Slots(0).Name;
            }
            string sName2 = "-----";
            if (SlotsSaveModel.Slots(1) != null)
            {
                sName2 = SlotsSaveModel.Slots(1).Name;
            }
            string sName3 = "-----";
            if (SlotsSaveModel.Slots(2) != null)
            {
                sName3 = SlotsSaveModel.Slots(2).Name;
            }
            string sName4 = "-----";
            if (SlotsSaveModel.Slots(3) != null)
            {
                sName4 = SlotsSaveModel.Slots(3).Name;
            }
            string sName5 = "-----";
            if (SlotsSaveModel.Slots(4) != null)
            {
                sName5 = SlotsSaveModel.Slots(4).Name;
            }

            Console.WriteLine(
                   LanguageModel.Traductor("choice") + "\n" + "\n" +
                    "1. " + sName1 + "\n" +
                    "2. " + sName2 + "\n" +
                    "3. " + sName3 + "\n" +
                    "4. " + sName4 + "\n" +
                    "5. " + sName5 + "\n"
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
            SlotsSaveModel.Slots(0) = new SaveModel();

            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(0).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(0).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(0).FolderTarget = Console.ReadLine();
        }

        public void Save2V()
        {
            SlotsSaveModel.Slots(1) = new SaveModel();

            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(1).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(1).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(1).FolderTarget = Console.ReadLine();
        }

        public void Save3V()
        {
            SlotsSaveModel.Slots(2) = new SaveModel();

            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(2).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(2).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(2).FolderTarget = Console.ReadLine();
        }

        public void Save4V()
        {
            SlotsSaveModel.Slots(3) = new SaveModel();

            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(3).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(3).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(3).FolderTarget = Console.ReadLine();
        }

        public void Save5V()
        {
            SlotsSaveModel.Slots(4) = new SaveModel();

            Console.WriteLine(LanguageModel.Traductor("slotName") + "\n");
            SlotsSaveModel.Slots(4).Name = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotSource") + "\n");
            SlotsSaveModel.Slots(4).FolderSource = Console.ReadLine();

            Console.WriteLine(LanguageModel.Traductor("slotTarget") + "\n");
            SlotsSaveModel.Slots(4).FolderTarget = Console.ReadLine();
        }
    }
}