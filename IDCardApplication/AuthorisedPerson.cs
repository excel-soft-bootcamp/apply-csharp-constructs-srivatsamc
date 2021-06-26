using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public abstract class AuthorisedPerson
    {
        #region UDT

        private string _name,_department,_contact_no,_id_no;

        #endregion

        #region Overloaded Constructors of Abstract Class AuthorisedPerson

        public AuthorisedPerson(string name)
        {
            this._name = name;
        }

        public AuthorisedPerson(string name,string department)
        {
            this._name = name;
            this._department = department;
        }

        public AuthorisedPerson(string name, string department,string contact_no)
        {
            this._name = name;
            this._department = department;
            this._contact_no = contact_no;
        }

        public AuthorisedPerson(string name, string department, string contact_no,string id_no)
        {
            this._name = name;
            this._department = department;
            this._contact_no = contact_no;
            this._id_no = id_no;
        }

        #endregion
    }
}
