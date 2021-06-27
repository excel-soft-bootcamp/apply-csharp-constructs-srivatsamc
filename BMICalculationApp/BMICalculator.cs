using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    public class BMICalculator
    {
        
        #region Calculation of BodyMassIndex

        public float BMI(float weight,float height)
        {
           return (weight / height);  
        }

        #endregion
    }
}
