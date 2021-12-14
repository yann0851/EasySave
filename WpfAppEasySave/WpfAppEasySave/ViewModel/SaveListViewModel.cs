using SlotsSave;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppEasySave.ViewModel
{
    
    class SaveListViewModel
    {
        public List<SaveModel> SaveList { get; set; }

        public SaveListViewModel()
        {
            SaveList = Context.GetInstance().GetListSaves().GetListSaves();
        }

    }
}
