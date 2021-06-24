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
            Information info = new Information();
            Calculation calculation = new Calculation();
            MessageDisplay messageDisplay = new MessageDisplay();

            #endregion
#region Fethching Height and Weight Information
            Console.WriteLine("Enter Height in Meters");
            float heightValue = Convert.ToInt32(Console.ReadLine());;

            Console.WriteLine("Enter Weight in Kilograms");
            float weightValue = Convert.ToInt32(Console.ReadLine()); ;

            #endregion

#region Storing values
            info.SetheightInMeters(heightValue);
            
            info.SetweightInKilos(weightValue);
            #endregion

#region Getting values
            float heightvalue= info.GetheightInMeters();
            float weightvalue= info.GetweightInKilos();
            #endregion

#region BodyMassIndex Calculation
            float bodyMassIndex=calculation.Calculator( heightvalue , weightvalue);
            #endregion

#region Display information
            messageDisplay.display(bodyMassIndex);

#endregion
        }
    }
}
