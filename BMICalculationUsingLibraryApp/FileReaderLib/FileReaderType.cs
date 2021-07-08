using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace FileReaderLib
{
    public class FileReaderType
    {
        public static void ReadFile(string path)
        {
            var lines = File.ReadAllLines(path);
            var detailsList =new List<FileReaderType>();

            foreach (var line in detailsList)
            {
                detailsList.Add(new FileReaderType() { });
                
            }
        }
        public int val1 { get; set; }
        public int val2 { get; set; }
    }
}
