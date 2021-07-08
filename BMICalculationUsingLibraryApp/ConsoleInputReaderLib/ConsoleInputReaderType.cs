using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputReaderLib
{
    public class ConsoleInputReaderType
    {
        public static float ConsoleHeightReader()
        {

            ConsoleDisplayLib.ConsoleDisplayType.Display("Enter the height in meter");
            float height = float.Parse(Console.ReadLine());
            return height;
        }
        public static float ConsoleWeightReader()
        {
            ConsoleDisplayLib.ConsoleDisplayType.Display("Enter the weight in kg");
            float weight = float.Parse(Console.ReadLine());
            return weight;
        }
    }
}
