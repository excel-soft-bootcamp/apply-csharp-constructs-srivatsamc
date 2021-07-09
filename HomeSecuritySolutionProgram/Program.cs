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
            DoorStatusProctor statusOfOpenDoor = new DoorStatusProctor(DoorObserver.SendSMS);
            DoorStatusProctor statusOfCloseDoor = new DoorStatusProctor(DoorObserver.SendSMS);

            DoorSensorType openDoor = new DoorSensorType();
            openDoor.OnChangesInDoorStatus += statusOfOpenDoor;
            openDoor.Open();
            openDoor.Close();
           
    
        }
    }
}
