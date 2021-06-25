using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    public class BMIValidator
    {
        
#region Checking BMIvalue 
        public string  CheckCondition(float BMIValue)
        {
            if (BMIValue < 18.5)
            {
                return "UnderWeight";
            }
            else if (BMIValue >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal"
            }
        }
#endregion
    }
}
