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
        public static void Input(string path)
        {
            List<PatientDetailsType> patients = PatientDataReaderType.GetAllPatientsDetails(path);
            for (int i = 0; i < patients.Count; i++)
            {
                FileReaderLib.PatientDetailsType dataInfo = patients[i];

                float bmiValue = BMICalculatorLib.BMICalculatorType.BMIValueCalculator(dataInfo.WeightInKilos, dataInfo.HeightInMeters);
                string result = BMIValidatorLib.BMIValidatorType.ValidateBMIValue(bmiValue);
                ConsoleDisplayLib.ConsoleDisplayType.Display(dataInfo.Name + "\t\t" + dataInfo.HeightInMeters + "\t" + dataInfo.WeightInKilos + "\t" + bmiValue + "\t\t" + result);
            }
        }
        
}
}
