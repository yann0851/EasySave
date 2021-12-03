using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppEasySave.ViewModel
{
    internal sealed class Context // Singleton créer un seul objet
    {
        private static Context _instance;

        private ListSaves ListSaves;

        private Context()
        {
            ListSaves = new ListSaves();
        }

        public static Context GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Context();
            }
            return _instance;
        }

        public ListSaves GetListSaves()
        {
            return ListSaves;
        }

    }
}
