using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    
    class Calculation
    {
        //private float bmi;
#region Calculation of BodyMassIndex

        public float Calculator (float heightvalue, float weightvalue)
        {
            
            return (weightvalue / heightvalue);
       
        }
#endregion

    }
}
