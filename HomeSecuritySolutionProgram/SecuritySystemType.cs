using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolutionProgram
{
   
    public class SecuritySystemType
    {
        HomeOwnerType owner = new HomeOwnerType();
        public void SendSMS()
        {
            Console.WriteLine("Door status changed");
            owner.GetSMSNotification();
        }
    }
}
