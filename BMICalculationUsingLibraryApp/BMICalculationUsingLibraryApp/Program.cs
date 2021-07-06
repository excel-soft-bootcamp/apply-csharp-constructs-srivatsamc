using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationUsingLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float height = PatientDetailsLib.PatientDetailsLib.SetAndGetHeightInMeters();
            float weight = PatientDetailsLib.PatientDetailsLib.SetAndGetWeightInKilos();
            float bmiValue= BMICalculatorLib.BMICalculatorLib.BMI(weight, height);
            string message = BMIValidatorLib.BMIValidatorLib.CheckCondition(bmiValue);
            ConsoleDisplayLib.ConsoleDisplayLib.Display(message);
            
        }
    }
}

