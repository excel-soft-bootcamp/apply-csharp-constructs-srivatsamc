using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class Program
    {
        static void Main(string[] args)
        {
#region Object Declaration
            PatientInformation information = new PatientInformation();
            BMICalculation calculate = new BMICalculation();
            ConsoleDisplay display = new ConsoleDisplay();

            #endregion
#region Fethching Height and Weight Information
            Console.WriteLine("Enter Height in Meters and Weight in Kilograms");
            float heightValue= Convert.ToInt32(Console.ReadLine());
            float weightValue= Convert.ToInt32(Console.ReadLine());

            /*Console.WriteLine("Enter Weight in Kilograms");
            float weightValue = Convert.ToInt32(Console.ReadLine()); ;*/

            #endregion

            #region Storing values
            /* info.SetheightInMeters(heightValue);

             info.SetweightInKilos(weightValue);*/

            information.PatientDetails = heightValue;
            information.PatientDetails = weightValue;



            #endregion

            #region Getting values

            /* float heightvalue= info.GetheightInMeters();
             float weightvalue= info.GetweightInKilos();*/

             Console.WriteLine(information.PatientDetails);
            

            #endregion

            #region BodyMassIndex Calculation

            float bmiValue =calculate.BMICalculator( heightValue , weightValue);

            #endregion

            #region Display information
            if (bmiValue< 18.5)
            {
                display.Message1();
            }
            else if (bmiValue >= 25)
            {
                display.Message2();
            }
            else
            {
                display.Message3();
            }

            

#endregion
        }
    }
}
