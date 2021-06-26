using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public class SecurityGuard:AuthorisedPerson
    {
        #region UDT

        private string _timings;

        #endregion

        #region Method declaration
        public void Duty() { }

        #endregion

        #region Overloaded Constructor of Child Class SecurityGuard

        public SecurityGuard(string timings, string name, string department, string contact_no, string id_no) :base (name, department, contact_no, id_no)
        {
            this._timings = timings;
        }
        #endregion
    }
}
