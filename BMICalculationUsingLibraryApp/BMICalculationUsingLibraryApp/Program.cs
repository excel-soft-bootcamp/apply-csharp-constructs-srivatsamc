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
                
                catch (FormatException )
                {
                    ConsoleDisplayLib.ConsoleDisplayType.Display("Choice must be number");
                }

                
            } while (true);


            if (_choice == 1)
            {
                float heightInMeters = ConsoleInputReaderLib.ConsoleInputReaderType.ConsoleHeightReader();
                float weightInKilos = ConsoleInputReaderLib.ConsoleInputReaderType.ConsoleWeightReader();
                float bmivalue = BMICalculatorLib.BMICalculatorType.BMIValueCalculator(weightInKilos,heightInMeters);
                string message = BMIValidatorLib.BMIValidatorType.ValidateBMIValue(bmivalue);
                ConsoleDisplayLib.ConsoleDisplayType.Display(message);

            }
            else 
            {
                ConsoleDisplayLib.ConsoleDisplayType.Display("Enter Path");
                string enteredPath = Console.ReadLine();

                List<string> patientDetailsList= FileReaderLib.Functionality.GetAllPatientsDetails(enteredPath);
                string detailsList =  Convert.ToString(patientDetailsList);

                object details = FileReaderLib.Functionality.MappingObject(detailsList);

                FileReaderLib.Functionality.SeparationOfLines(details);

       
            }
               
        }       
    }
}

