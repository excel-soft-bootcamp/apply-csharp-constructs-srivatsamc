using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Codes
{
#region Definition of Class program
    class Program
    {
        static void Main(string[] args)
        {
#region Creation of Instance
            TDSDataModel instance1 = new TDSDataModel();
            RDSDataModel instance2 = new RDSDataModel();
            RiskCalculator instance3 = new RiskCalculator();
            RiskInputDataMerger instance4 = new RiskInputDataMerger();
            #endregion
#region Setting value for TDSDataModel Datamembers
            instance1.SetTradeID("T101");
            instance1.SetDate("22/06/21");
            instance1.SetCurrentTradeValue(1200);
            instance1.SetCounterpartyID("123");
            #endregion

            #region Setting value for RDSDataModel Datamembers

            instance2.setCounterPartyId("789");
            instance2.setName("Robin");
            #endregion
#region Getting values od TDSDataModel
            string tradeid = instance1.getTradeID();
            string date = instance1.getDate();
            int tradevalue = instance1.getCurrentTradeValue();
            string partyid = instance1.getCounterpartyID();
            #endregion

            #region Getting values od RDSDataModel

            string PartyId = instance2.getCounterPartyId();
            string name = instance2.getName();
            #endregion

#region Printing values of class TDSDataModel

            System.Console.WriteLine("Trade id is :" +tradeid);
            System.Console.WriteLine("Date :"+date);
            System.Console.WriteLine("Current Trade value is :"+tradevalue);
            System.Console.WriteLine("PartyID(TDS) is :"+partyid);
            #endregion

            #region Printing values of class RDSDataModel

            System.Console.WriteLine("Party id(RDS)"+PartyId);
            System.Console.WriteLine("Name :"+name);
            #endregion

            System.Console.WriteLine(instance3.Calculator());
            System.Console.WriteLine(instance4.merge());
        }
    }
#endregion
}
