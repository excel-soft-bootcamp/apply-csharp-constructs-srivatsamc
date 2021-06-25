using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    public class BMIValidator
    {
        ConsoleDisplay display = new CpnsoleDisplay();
#region Checking BMIvalue 
        public void CheckCondition(float BMIValue)
        {
            if (BMIValue < 18.5)
            {
                display.Display("hhhhh");
            }
            else if (BMIValue >= 25)
            {
                display.Display("hhhhh");
            }
            else
            {
                display.Display("hhhhh");
            }
        }
#endregion
    }
}
