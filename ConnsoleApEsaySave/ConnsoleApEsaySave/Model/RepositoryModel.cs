using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    class RepositoryModel
    {
        /* Création des objets du répertoire source et cible */
        public string NameLogRepository { get; set; }
        public string SourceRepository { get; set; }
        public string TargetRepository { get; set; } 
        public long LengthRepository { get; set; }
        public string FileTransfertRepository { get; set; }
    }
}