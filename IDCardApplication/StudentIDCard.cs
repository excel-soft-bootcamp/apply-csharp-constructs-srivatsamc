using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public class StudentIDCard:IDCard
    {
        private string _usn;

        #region Overloaded Constructor of Child Class Student

        public StudentIDCard(string usn, string name, string id_no) : base(name, id_no)
        {
            this._usn = usn;
        }

        public StudentIDCard(string usn, string name, string id_no,string contact_no) : base(name, id_no,contact_no)
        {
            this._usn = usn;
        }

        public StudentIDCard(string usn, string name, string id_no, string contact_no, string bloodgroup) : base(name, id_no, contact_no, bloodgroup)
        {
            this._usn = usn;
        }
        #endregion

    }
}
