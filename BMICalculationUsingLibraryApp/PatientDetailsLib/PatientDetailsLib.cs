using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDetailsLib
{
    public static class PatientDetailsLib
    {
        private static float heightInMeters;
        private static float weightInKilos;

        public static float SetAndGetHeightInMeters()
        {
           Console.WriteLine("Enter Height In Meters");
           heightInMeters = float.Parse(Console.ReadLine());
           return heightInMeters;
            
        }

        public static float SetAndGetWeightInKilos()
        {
            Console.WriteLine("Enter Weight In Kilos");
            weightInKilos = float.Parse(Console.ReadLine());
            return weightInKilos;

            
        }

    }
}


