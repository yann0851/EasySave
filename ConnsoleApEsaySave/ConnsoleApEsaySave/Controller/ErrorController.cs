using System;
using System.Collections.Generic;
using System.Text;

namespace Error
{
    class ErrorController
    {
        public void ErrorC()
        {
            /* Affichage du message d'erreur et attente d'une action de l'utilisateur */
            ErrorView errorView = new ErrorView();
            errorView.ErrorV();
            Console.ReadKey();
        }
    }
}
