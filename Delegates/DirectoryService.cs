using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public  class DirectoryService
    {
      
        public static event Action <FileArgs>? FileFound;

        public static void AllFileSearch(string directoryPath)
        {
            var directory = new DirectoryInfo(directoryPath);

            var files = directory.GetFiles();

            foreach (var file in files)
            {
                FileFound?.Invoke( new FileArgs(file.Name));
            }
        }

    }
}
