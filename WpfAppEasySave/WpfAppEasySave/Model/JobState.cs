using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEasySave.Model
{
    public class JobState
    {
        public string Name { get; set; }
        public string SourceFilePath { get; set; }
        public string TargetFilePath { get; set; }
        public string State { get; set; }
        public long TotalFilesToCopy { get; set; }
        public long TotalFilesSize { get; set; }
        public string NbFilesLeftToDo { get; set; }
        public string Progression { get; set; }
    }
}
