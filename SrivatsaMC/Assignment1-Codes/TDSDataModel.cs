using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Codes
{
    #region Definition of Class TDSDataModel
    class TDSDataModel
    {
        #region UDT of Class
        private string TradeID;
        private string Date;
        private int CurrentTradeValue;
        private string CounterpartyID;
        #endregion
        #region Initialization of UDT

        public string getTradeID()
        {
            return this.TradeID;
        }

        public void SetTradeID(string tradeid)
        {
            this.TradeID = tradeid;

        }

        public string getDate()
        {
            return this.Date;
        }

        public void SetDate(string date)
        {
            this.Date = date;

        }

        public int getCurrentTradeValue()
        {
            return this.CurrentTradeValue;
        }

        public void SetCurrentTradeValue(int tradevalue)
        {
            this.CurrentTradeValue = tradevalue;

        }
        public string getCounterpartyID()
        {
            return this.CounterpartyID;
        }

        public void SetCounterpartyID(string partyid)
        {
            this.CounterpartyID = partyid;

        }
        #endregion
        #endregion
    }
}
