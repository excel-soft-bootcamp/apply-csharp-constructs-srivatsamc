using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolutionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystemType DoorObserver = new SecuritySystemType();
            DoorStatusProctor doorStatus = new DoorStatusProctor(DoorObserver.SendSMS);

            DoorSensorType sensorStatus = new DoorSensorType();
            sensorStatus.OnChangesInDoorStatus += doorStatus;
            sensorStatus.Open();
            sensorStatus.Close();
           
    
        }
    }
}
