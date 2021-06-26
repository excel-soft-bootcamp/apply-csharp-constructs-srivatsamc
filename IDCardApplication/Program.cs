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

            Student _student = new Student("4JN16EC096", "Srivatsa M C", "Electronics and Communication", "7892066394", "0254150");
            Staff _staff = new Staff("Librarian","Ramesh","Library","9874563210","4562310");
            Guest _guest = new Guest("11:50", "Rajesh","Administration","8879564123","1254");
            SecurityGuard _securityGuard = new SecurityGuard("9am to 5pm", "John", "Gate 1", "9123654708","54662");

            #endregion
        }
    }
}
