using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object creation of child classes and passing parameters for the constructors

            StudentIDCard _student = new StudentIDCard("4JN16EC096","Srivatsa","123456","7892066394","O+");
            StaffIDCard _staff = new StaffIDCard("Assistant Proffessor", "Sharath", "4561235", "7851885583");
            GuestIDCard _guest = new GuestIDCard("11:50", "Rajesh", "789552", "8879564123");
            SecurityGuardIDCard _securityGuard = new SecurityGuardIDCard("9am to 5pm", "John", "123564","9123654708","AB+");

            Console.WriteLine();
            #endregion
        }
    }
}
