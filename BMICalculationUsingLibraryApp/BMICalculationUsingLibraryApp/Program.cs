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
            float height = ConsoleInputReaderLib.ConsoleInputReaderType.ConsoleHeightReader();
            float weight = ConsoleInputReaderLib.ConsoleInputReaderType.ConsoleWeightReader();

            float heightInMeters=PatientDetailsLib.PatientDetailsType.SetHeight(height);
            float weightInKilos = PatientDetailsLib.PatientDetailsType.SetWeight(weight);

            float bmiValue= BMICalculatorLib.BMICalculatorType.BMIValueCalculator(weightInKilos,heightInMeters);

            string message = BMIValidatorLib.BMIValidatorType.ValidateBMIValue(bmiValue);

            ConsoleDisplayLib.ConsoleDisplayType.Display(message);
            
        }
    }
}

