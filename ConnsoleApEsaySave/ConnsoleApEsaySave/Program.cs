using System;
using Repository;
using Menu;
using System.Collections.Generic;

namespace ConnsoleAppEsaySave
{
    class Program
    {
        /* Lancement du menu */
        static void Main()
        { 
            MenuViewModel MenuViewModel = new MenuViewModel();
            MenuViewModel.MenuVM(); 
        }
    }
}
