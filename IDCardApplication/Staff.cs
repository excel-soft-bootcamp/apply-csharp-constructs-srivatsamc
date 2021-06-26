using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public class Staff:AuthorisedPerson
    {
        #region UDT

        private string _role;

        #endregion

        #region Method declaration
        public void TakeSession() { }
        public void MentorStudent() { }

        #endregion

        #region Overloaded Constructor of Child Class Staff

        public Staff(string role, string name, string department, string contact_no, string id_no) :base (name, department, contact_no, id_no)
        {
            this._role = role;
        }
        #endregion
    }
}
