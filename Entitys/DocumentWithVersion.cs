using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Entitys
{
    public class DocumentWithVersion : BaseDocument
    {
        public string Version { get; private set; }

        public void SetVersion(string version)
        {
            Version = version;
        }        
    }
}
