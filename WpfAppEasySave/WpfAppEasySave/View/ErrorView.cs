using System;
using System.Collections.Generic;
using System.Text;
using Language;

namespace Error
{
    class ErrorView
    {
        public void ErrorV()
        {
            /* Ecriture d'un message d'erreur en cas de saisie invalide */
            Console.WriteLine(LanguageModel.Traductor("error"));
        }
    }
}