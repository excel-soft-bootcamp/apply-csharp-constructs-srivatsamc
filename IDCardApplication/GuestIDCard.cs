using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCardApplication
{
    public class GuestIDCard:IDCard
    {
        public string _timeOfVisit;

        #region Overloaded constructors

        public GuestIDCard(string timeOfVisit, string name, string id_no) : base(name, id_no)
        {
            this._timeOfVisit = timeOfVisit;
        }
        public GuestIDCard(string timeOfVisit, string name,  string id_no,string contact_no) :base (name, id_no, contact_no)
        {
            this._timeOfVisit = timeOfVisit;
        }
        #endregion
    }
}
