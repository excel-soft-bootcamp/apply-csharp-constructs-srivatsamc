using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderLib
{
    public class PatientDataReaderType
    {
        public static List<FileReaderLib.PatientDetailsType> GetAllPatientsDetails(string path)
        {
            List<string> lines = GetAllLines(path);
            List<FileReaderLib.PatientDetailsType> patientList = new List<FileReaderLib.PatientDetailsType>();
            for (int i = 0; i < lines.Count; i++)
            {
                FileReaderLib.PatientDetailsType patientDataInfo = MapLineItemPatientObject(lines[i]);
                patientList.Add(patientDataInfo);

            }
            return patientList;
        }
        private static List<string> GetAllLines(string path)
        {
            List<string> lines = new List<string>();
                try
                {
                    System.IO.StreamReader reader = new System.IO.StreamReader(path);
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        lines.Add(line);
                    }
                    reader.Close();

                }
                catch (SystemException)
                {
                    ConsoleDisplayLib.ConsoleDisplayType.Display("Entered path is not correct Please enter Valid path");
                }
                return lines;
        }
        private static FileReaderLib.PatientDetailsType MapLineItemPatientObject(string lineItem)
        {
            string[] lineItems = lineItem.Split(',');
            FileReaderLib.PatientDetailsType patientData = new FileReaderLib.PatientDetailsType();
            patientData.Name = lineItems[0];
            patientData.HeightInMeters = Int32.Parse(lineItems[1]);
            patientData.WeightInKilos = Int32.Parse(lineItems[2]);
            return patientData;
        }
    }
}
