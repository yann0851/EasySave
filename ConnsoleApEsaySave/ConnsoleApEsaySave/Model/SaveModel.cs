using System;
using System.Collections.Generic;
using System.Text;

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

        public static ref SaveModel Slots(int iSlots)
        {
            return ref slotsSave[iSlots];
        }
    }

}