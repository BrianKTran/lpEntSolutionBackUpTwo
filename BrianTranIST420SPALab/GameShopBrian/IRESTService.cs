using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace GameShopBrian
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRESTService" in both code and config file together.




    [ServiceContract]
    public interface IRESTService
    {
       
        [WebGet(UriTemplate = "/",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
         string DoWork();

        [WebGet(UriTemplate = "/GetInventory",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        tblInventoryBrianTran[] GetInventory();

        [WebGet(UriTemplate = "/GetInvoiceTotal?Shipping={shipping}&State={state}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        decimal GetInvoiceTotal(string shipping, string state);


        [WebGet(UriTemplate = "/Create?CustomerName={custName}&CustomerSSN={custSSN}&CustomerEmail={custEmail}&CustomerPhone={custPhone}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string CreateCustomer(string custName, string custSSN, string custEmail, string custPhone);

        [WebGet(UriTemplate = "/Update?CustomerID={custID}&CustomerName={custName}&CustomerSSN={custSSN}&CustomerEmail={custEmail}&CustomerPhone={custPhone}",
             ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        bool UpdateCustomer(int custID, string custName, string custSSN, string custEmail, string custPhone);

        [WebGet(UriTemplate = "/Read?CustomerID={custID}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        tblCustomerBrianTran ReadCustomer(int custID);

        [WebGet(UriTemplate = "/Delete?CustomerID={custID}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        bool DeleteCustomer(int custID);

        [WebGet(UriTemplate = "/ReadAll",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        tblCustomerBrianTran[] ReadCustomerList();


    }
}
