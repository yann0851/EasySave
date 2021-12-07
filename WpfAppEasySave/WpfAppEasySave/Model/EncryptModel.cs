using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace WpfAppEasySave.Model
{
    class EncryptModel
    {
        public string FolderSource { get; set; }
        public string FolderTarget { get; set; }
        public string Key { get; set; }

        public string RSA { get; set; }
        //public string FolderSource { get; set; }

    }
}
