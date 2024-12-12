using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForScanningCodes
{
    class DataBase
    {
        private string path;
        public void AskPath(string pathFile)
        {
            path = pathFile;
        }
        public string ReturnPath()
        {
            return path;
        }
    }
   
}
