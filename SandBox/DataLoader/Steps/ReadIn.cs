using System.Collections.Generic;
using System.Linq;
using System.IO;
using DataLoader.Steps.Helpers;

namespace DataLoader.Steps
{
    internal class ReadIn
    {
        public List<string> ReadInStrings;
        private List<string> _ReadInStrings;
        
        public ReadIn() { 
            _ReadInStrings = new List<string>();
        }

        public bool StartRead()
        {
            
            string line = string.Empty;
            FileInfo[] fia = new DirectoryInfo(StringHelper.Path2File).GetFiles(StringHelper.FileSearchPattern);

            foreach (FileInfo fi in fia)
            {
                StreamReader sr = new StreamReader(fi.FullName);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    else
                    {
                        _ReadInStrings.Add(line);
                    }
                }
                
            }
            ReadInStrings = _ReadInStrings.ToList();
            return ReadInStrings.Count < 1 ? false : true;
        }
    }
}

