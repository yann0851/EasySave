﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConnsoleAppEsaySave.Model
{
    public class JobFile
    { 

        public string Name { get; set; }
        public string FileSource { get; set; }
        public string FileTarget { get; set; }
        public long FileSize { get; set; }
        public string FileTransferTime { get; set; }
    }
}
