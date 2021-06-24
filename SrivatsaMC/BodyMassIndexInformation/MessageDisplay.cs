using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class MessageDisplay
    {
#region Message display
        public void display(float bmivalue)
        {
            if ( bmivalue < 18.5)
            {
                Console.WriteLine("You are UNDERWEIGHT");
            }
            else if (bmivalue >= 25)
            {
                Console.WriteLine("You are OVERWEIGHT");
            }
            else
            {
                Console.WriteLine("You are HEALTHY");
            }
        }
    }
#endregion
}
