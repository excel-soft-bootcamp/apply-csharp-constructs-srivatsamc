using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
#region Taking inputs from User
            System.Console.WriteLine("Enter your Height in meters :");

            int H = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter your Weight in Kilograms :");

            float W = Convert.ToInt32(Console.ReadLine());
            
            
            #endregion
#region Loading value of height and weight
            calculator.setHeight(H);
            calculator.setweight1(W);

            #endregion

            int BodyMass=calculator.bodyMass();

            if (BodyMass < 18.5)
            {
                Console.WriteLine("You are UNDERWEIGHT");
            }
            else if (BodyMass >= 25)
            {
                Console.WriteLine("You are Healthy");
            }
            else
            {
                Console.WriteLine("You are between average");
            }
        }
    }
}
