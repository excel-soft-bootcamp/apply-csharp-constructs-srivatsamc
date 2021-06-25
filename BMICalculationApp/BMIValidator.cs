using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    public class BMIValidator
    {
        Display consoleDisplay = new Display();
#region Checking BMIvalue 
        public void CheckCondition(float BMIValue)
        {
            if (BMIValue < 18.5)
            {
                consoleDisplay.Message1();
            }
            else if (BMIValue >= 25)
            {
                consoleDisplay.Message2();
            }
            else
            {
                consoleDisplay.Message3();
            }
        }
#endregion
    }
}
