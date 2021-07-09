using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolutionProgram
{
    public delegate void DoorStatusProctor();
    public class DoorSensorType
    { 
        public event DoorStatusProctor OnChangesInDoorStatus;
        public void Open()
        {
            OnChangesInDoorStatus.Invoke();
        }
        public void Close()
        {    
            OnChangesInDoorStatus.Invoke();
        }
    }
}
