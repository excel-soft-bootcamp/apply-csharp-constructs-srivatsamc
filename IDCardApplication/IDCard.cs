using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public abstract class IDCard
    {
        private string _name,_bloodgroup,_contact_no,_id_no;

        #region Overloaded Constructors

        public IDCard(string name,string id_no)
        {
            this._name = name;
            this._id_no = id_no;
        }

        public IDCard(string contact_no,string name, string id_no):this (name,id_no)
        {
            this._contact_no = contact_no;
        }

        public IDCard(string bloodgroup,string name, string id_no, string contact_no):this(name,id_no,contact_no)
        {
            this._bloodgroup = bloodgroup;
        }


        #endregion
    }
}
