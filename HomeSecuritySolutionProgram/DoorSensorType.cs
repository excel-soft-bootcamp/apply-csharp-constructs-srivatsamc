using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolutionProgram
{
    public delegate void DoorStatusProctor(string StatusMessage);
    public class DoorSensorType
    {
        string status = "";
        public event DoorStatusProctor OnChangesInDoorStatus;
        public void Open()
        {
            status = "Door is open";
            OnChangesInDoorStatus.Invoke(status);
            this.Notify();
        }
        public void Close()
        {
            status = "Door is Close";
            OnChangesInDoorStatus.Invoke(status);
            this.Notify();
        }
        void Notify()
        {
            string messageStatus= $"{this.status} and Time : {System.DateTime.Now.ToString()}";
            OnChangesInDoorStatus.Invoke(messageStatus);
        }
    }
}
