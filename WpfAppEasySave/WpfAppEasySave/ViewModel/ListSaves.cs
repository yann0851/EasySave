using System;
using System.Collections.Generic;
using System.Text;
using SlotsSave;

namespace WpfAppEasySave.ViewModel
{
    class ListSaves
    {
        private List<SaveModel> listSaves;

        public ListSaves()
        {
            listSaves = new List<SaveModel>();
            for(int i = 0; i < 3; i++)
            {
                listSaves.Add(new SaveModel("test", "c:/", "e:/"));
            }
            
        }

        public List<SaveModel> GetListSaves()
        {
            return listSaves;
        }

        public void AddSave(string name, string source, string target)
        {
            listSaves.Add(new SaveModel(name, source, target));
        }
        public void EditSave(int iIndex, string name, string source, string target)
        {
            RemoveSave(iIndex);
            AddSave(name, source, target);
        }
        public void RemoveSave(int iIndex)
        {
            listSaves.RemoveAt(iIndex);
        }
    }
}
