using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Repository;
using WpfAppEasySave.View;
using System.Linq;

namespace SlotsSave
{
    class SaveModel
    {
        public string Name { get; set; }
        public string FolderSource { get; set; }
        public string FolderTarget { get; set; }

        public SaveModel(string newName, string newSource, string newTarget)
        {
            this.Name = newName;
            this.FolderSource = newSource;
            this.FolderTarget = newTarget;
        }

        public SaveModel()
        {
            this.Name = null;
            this.FolderSource = null;
            this.FolderTarget = null;
        }


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
                RepositoryViewModel.CreateDirectory(@"C:\EasySave\Slots");
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