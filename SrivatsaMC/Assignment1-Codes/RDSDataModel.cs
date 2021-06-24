using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Codes
{
#region Definition of class RDSDataModel
    class RDSDataModel
    {
#region Definiton of UDT
        private string CounterPartyId;
        private string Name;
        #endregion
#region Initialization of UDT
        public string getCounterPartyId()
        {
            return this.CounterPartyId;
        }

        public void setCounterPartyId( string PartyId)
        {
            this.CounterPartyId = PartyId;
        }

        public string getName()
        {
            return this.Name;
        }

        public void setName(string name)
        {
            this.Name = name;
        }
        #endregion
#endregion


    }
}
