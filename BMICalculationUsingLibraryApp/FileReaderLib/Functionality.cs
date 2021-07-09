using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderLib
{
    public class Functionality
    {
        Functionality functionality = new Functionality();
        public static List<string> GetAllPatientsDetails(string path)
        {
            System.IO.StreamReader lineReader = new System.IO.StreamReader(path);
            List<string> stringList = new List<string>();
            while (!lineReader.EndOfStream)
            {
                string patientsList = lineReader.ReadLine();
                stringList.Add(patientsList);
            }
            return stringList;
        }

        public static object MappingObject(string listOfPatients)
        {
            string[] lineItems = listOfPatients.Split(',');
            PatientDetailsType patientData = new PatientDetailsType();
            patientData.Name = lineItems[0];
            patientData.HeightInMeters = int.Parse(lineItems[1]);
            patientData.WeightInKilos = int.Parse(lineItems[2]);
            return patientData;
        }



        
 
    }
}
