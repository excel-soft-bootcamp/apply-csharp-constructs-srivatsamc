using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
#region Setting and Getting Values for Height and Weight given by Patient

            PatientDetails information = new PatientDetails();
            float heightValue= information.HeightInMeters;
            float weightValue = information.WeightInKilos;

            #endregion

#region Calculating BodyMassIndex

            BMICalculator calculate = new BMICalculator();
            float bmiValue = calculate.BMI(heightValue, weightValue);

            #endregion

#region Validating BMIValue

            BMIValidator validate = new BMIValidator();
            string message = validate.CheckCondition(bmiValue);

            #endregion

#region Dispalying appropriate message on console

            ConsoleDisplay console = new ConsoleDisplay();
            console.Display(message);

#endregion

        }
    }
}
