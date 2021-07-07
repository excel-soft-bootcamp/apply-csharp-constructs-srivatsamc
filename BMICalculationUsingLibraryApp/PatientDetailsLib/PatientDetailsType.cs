using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDetailsLib
{
    public static class PatientDetailsType
    {
        public static float SetHeight(float height)
        {

          float heightInMeters = height;
          return heightInMeters;
        }

        public static float SetWeight(float weight)
        {
            float weightInKilos = weight;
            return weightInKilos;   
        }

    }
}


