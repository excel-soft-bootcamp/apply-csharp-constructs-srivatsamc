using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
   public class Display
    {
 #region Message display
        public void Message1()
        {
            
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
    
    #endregion

}
}
