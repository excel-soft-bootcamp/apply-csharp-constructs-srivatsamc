using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public class Student:AuthorisedPerson
    {
        #region UDT

        private string _usn;

        #endregion

        #region Method declaration
        public void AttendClass() { }

        #endregion

        #region Overloaded Constructor of Child Class Student

        public Student(string usn, string name, string department, string contact_no, string id_no) : base(name, department, contact_no, id_no)
        {
            this._usn = usn;
        }

        #endregion

    }
}
