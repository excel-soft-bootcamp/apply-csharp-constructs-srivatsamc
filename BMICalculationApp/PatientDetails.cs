using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
     class PatientDetails
    {
        BMICalculator calculation = new BMICalculator();
        BMIValidator validate = new BMIValidator();
#region UDT

        private float heightInMeters;
        private float weightInKilos;
        

        #endregion

        public void ReadDetails()
        {
#region Reading Details of Patient
            Console.WriteLine("Enter your Height in Meters");
            this.heightInMeters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Weight in Kilos");
            this.weightInKilos = Convert.ToInt32(Console.ReadLine());
            #endregion
#region BMI Calculation
            float bmiValue= calculation.CalculateBMI( this.weightInKilos,this.heightInMeters);
            #endregion
#region BMI value Validation
            validate.CheckCondition(bmiValue);
#endregion
        }
     
      


       
        
        
      
        
    
    }
}
