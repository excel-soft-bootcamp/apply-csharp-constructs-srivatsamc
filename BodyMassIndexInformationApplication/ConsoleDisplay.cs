using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
   public class ConsoleDisplay
    {
#region Message display
        public void Message1()/*(float bmivalue)*/
        {
            /*if ( bmivalue < 18.5)
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
            }*/
            Console.WriteLine("You are UNDERWEIGHT");
        }
        public void Message2()
        {
            Console.WriteLine("You are OVERWEIGHT");
        }
        public void Message3()
        {
            Console.WriteLine("You are HEALTHY");
        }
    }
#endregion
}
