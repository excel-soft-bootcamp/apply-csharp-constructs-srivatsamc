using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public class SecurityGuardIDCard:IDCard
    {

        private string _timings;

        #region Overloaded Constructor of Child Class SecurityGuard

        public SecurityGuardIDCard(string timings, string name, string id_no) :base (name, id_no)
        {
            this._timings = timings;
        }

        public SecurityGuardIDCard(string timings, string name, string id_no,string contact_no) : base(name, id_no,contact_no)
        {
            this._timings = timings;
        }

        public SecurityGuardIDCard(string timings, string name, string id_no, string contact_no,string bloodgroup) : base(name, id_no, contact_no,bloodgroup)
        {
            this._timings = timings;
        }
        #endregion
    }
}
