using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    public class BMIValidator
    {
        Display consoledisplay = new Display();
#region Checking BMIvalue 
        public void CheckCondition(float BMIValue)
        {
            if (BMIValue < 18.5)
            {
                consoledisplay.Message1();
            }
            else if (BMIValue >= 25)
            {
                consoledisplay.Message2();
            }
            else
            {
                consoledisplay.Message3();
            }
        }
#endregion
    }
}
