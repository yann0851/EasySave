using System;
using Repository;
using Menu;
using LogD;
using System.Collections.Generic;

namespace ConsoleAppEasySave
{
    class Program
    {
        /* Lancement du menu */
        static void Main()
        { 
            MenuController MenuController = new MenuController();
            MenuController.MenuC();
        }
    }
}
