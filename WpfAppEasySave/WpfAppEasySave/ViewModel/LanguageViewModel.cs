using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Error;

namespace Language
{
    class LanguageViewModel
    {
        public void Button_FR()
        {
            try
            {
                string sLang = "FR";
                LanguageModel.sCurrentLanguage = sLang;
            }
            catch
            {
            }
        }

        public void Button_EN()
        {
            try
            {
                string sLang = "EN";
                LanguageModel.sCurrentLanguage = sLang;
            }
            catch
            {

            }
        }
    }
}