using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
     class PatientDetails
    {
       
#region UDT

        private float heightInMeters;
        private float weightInKilos;
        

        #endregion

        public float HeightInMeters
        {
            get
            {
               return this.heightInMeters;
            }
            set
            {
                Console.WriteLine("Enter Height In Meters");
                this.heightInMeters = float.Parse(Console.ReadLine());
            }
        } 

        public float WeightInKilos
        {
            get
            {
                return this.weightInKilos;
            }
            set
            {
                Console.WriteLine("Enter Weight In Kilos");
                this.weightInKilos =float.Parse( Console.ReadLine());
            }
        }
     
     }
        
}
