using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using SlotsSave;
using WpfAppEasySave.View;

namespace WpfAppEasySave.ViewModel
{
    class ListSaves
    {
        private List<SaveModel> listSaves;

        public ListSaves()
        {
            listSaves = new List<SaveModel>(); // Création liste au départ nulle
            if(listSaves == null)
            {

            }
            //else //Remplir la sauvegarde avec fichier Json ou autre
            //{

            //}

            //for(int i = 0; i < 3; i++) //Premier test
            //{
            //    listSaves.Add(new SaveModel("test", "c:/", "e:/"));
            //}
            
        }

        public List<SaveModel> GetListSaves() //Retourne toute la liste
        {
            return listSaves;
        }

        public void AddSave(string name, string source, string target) // méthode pour ajouter un élément dans une liste
        {
            listSaves.Add(new SaveModel(name, source, target));
        }
        public void EditSave( string name, string source, string target) // Méthode pour modifier un élément dans une liste
        {
            //RemoveSave(iIndex);
            AddSave(name, source, target);
        }
        public void RemoveSave(int iIndex) // Méthode pour supprimer élément dans une liste
        {
            listSaves.RemoveAt(iIndex);
        }
    }
}
