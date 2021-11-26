using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Repository;

namespace SlotsSave
{
    class SaveModel
    {
        public string Name { get; set; }
        public string FolderSource { get; set; }
        public string FolderTarget { get; set; }
    }

    class SlotsSaveModel
    {
        public static SaveModel[] slotsSave = new SaveModel[5];

        public static int iCurrentSlot;

        public static string sPathSlots = @"C:\EasySave\Slots\Slots.txt";

        public static ref SaveModel Slots(int iSlots)
        {
            return ref slotsSave[iSlots];
        }



        public static void SaveSlots()
        {

                RepositoryController.CreateDirectory(@"C:\EasySave\Slots");
                string Json = JsonConvert.SerializeObject(slotsSave, Formatting.Indented);
                File.WriteAllText(sPathSlots, Json);
        }

        public static void LoadSlots()
        {
            string sReadSlots = File.ReadAllText(sPathSlots);

            slotsSave = JsonConvert.DeserializeObject<SaveModel[]>(sReadSlots);
        }
    }

}