using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public class Guest:AuthorisedPerson
    {
        #region UDT

        private string _timeOfVisit;

        #endregion

        #region Method declaration
        public void AttendMeeting() { }

        #endregion

        #region Overloaded Constructor of Child Class Guest

        public Guest(string timeOfVisit, string name, string department, string contact_no, string id_no) :base (name, department, contact_no, id_no)
        {
            this._timeOfVisit = timeOfVisit;
        }
        #endregion
    }
}
