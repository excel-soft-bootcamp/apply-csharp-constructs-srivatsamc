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
        
        static void Main(string[] args)
        {
            int repeatableCount = 3;
            do
            {
                string consoleMessage = $"Enter Your Choice {(int)Options.GIVEINPUT}->PLEASE GIVE INPUT,{(int)Options.READINPUT}->INPUT IS READ FROM FILE";
                Console.WriteLine(consoleMessage);
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        float heightInMeters = ConsoleInputReaderLib.ConsoleInputReaderType.ConsoleHeightReader();
                        float weightInKilos = ConsoleInputReaderLib.ConsoleInputReaderType.ConsoleWeightReader();
                        float bmivalue = BMICalculatorLib.BMICalculatorType.BMIValueCalculator(weightInKilos, heightInMeters);
                        string message = BMIValidatorLib.BMIValidatorType.ValidateBMIValue(bmivalue);
                        ConsoleDisplayLib.ConsoleDisplayType.Display("Result is : "+heightInMeters+ "\t" +weightInKilos+ "\t" +bmivalue+ "\t\t" +message);
                        repeatableCount = 0;
                    }
                    else if (choice == 2)
                    {
                        ConsoleDisplayLib.ConsoleDisplayType.Display("enter path");
                        string enteredPath = Console.ReadLine();
                        ConsoleDisplayLib.ConsoleDisplayType.Display(@"Entered path is " + (string)enteredPath);
                        FileReaderLib.FileReaderType.Input(enteredPath);
                        repeatableCount = 0;
                    }
                    else
                    {
                        ConsoleDisplayLib.ConsoleDisplayType.Display("Invalid Input");
                    }
                }
                
                catch (FormatException )
                {
                    ConsoleDisplayLib.ConsoleDisplayType.Display("Choice must be number");
                }
                --repeatableCount;
            } while (repeatableCount > 0);
        }   
    }
}

