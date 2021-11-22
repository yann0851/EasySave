using System;
using System.Collections.Generic;
using System.Text;
using Language;

namespace ChoiceSave
{
    class ChoiceSaveView
    {
        public void SaveMenuV()
        {
            /* Ecriture du menu du choix de sauvegarde */
            Console.WriteLine(
                   LanguageModel.Traductor("choice") + "\n" +
                    "1. " + LanguageModel.Traductor("savechoice 1") + "\n" +
                    "2. " + LanguageModel.Traductor("savechoice 2") + "\n" +
                    "3. " + LanguageModel.Traductor("savechoice 3") + "\n"
                    );
        }
    }
}
