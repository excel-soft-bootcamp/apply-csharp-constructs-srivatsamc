using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;



namespace BMICalculationUsingLibraryApp
{
    public enum Options
    {
        GIVEINPUT=1,READINPUT
    }
    public class Program
    {
        public static  int _choice;
        public static float heightValue;
        public static float weightValue;
        static void Main(string[] args)
        {

            do
            {
                
                string consoleMessage = $"Enter Your Choice {(int)Options.GIVEINPUT}->PLEASE GIVE INPUT,{(int)Options.READINPUT}->INPUT IS READ FROM FILE";
                Console.WriteLine(consoleMessage);
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    _choice = choice;
                    if (choice > 2 || choice <= 0)
                    {
                        ConsoleDisplayLib.ConsoleDisplayType.Display("Invalid Input");
                    }
                    else
                    {
                        break;
                    }
                  
                }
                
                catch (FormatException ex)
                {
                    ConsoleDisplayLib.ConsoleDisplayType.Display("Choice must be number");
                }

                
            } while (true);


            if (_choice == 1)
            {
                float heightValue = ConsoleInputReaderLib.ConsoleInputReaderType.ConsoleHeightReader();
                float weightValue = ConsoleInputReaderLib.ConsoleInputReaderType.ConsoleWeightReader();
        
            }
            else 
            {
                ConsoleDisplayLib.ConsoleDisplayType.Display("Enter Path");
                string enteredPath = Console.ReadLine();
                FileReaderLib.FileReaderType.ReadFile(enteredPath);

            }

            float bmivalue =BMICalculatorLib.BMICalculatorType.BMIValueCalculator(weightValue,heightValue);
           

            string message = BMIValidatorLib.BMIValidatorType.ValidateBMIValue(bmivalue);

            ConsoleDisplayLib.ConsoleDisplayType.Display(message);

            
        }       
    }
}

