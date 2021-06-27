using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public class StaffIDCard:IDCard
    {
       private string _designation;

        #region Overloaded Constructor of Child Class Staff

        public StaffIDCard(string designation, string name, string id_no ) :base (name, id_no)
        {
            this._designation = designation;
        }

        public StaffIDCard(string designation, string name, string id_no,string contact_no) : base(name, id_no,contact_no)
        {
            this._designation = designation;
        }

        public StaffIDCard(string designation, string name, string id_no, string contact_no,string bloodgroup) : base(name, id_no, contact_no,designation)
        {
            this._designation = designation;
        }
        #endregion
    }
}
