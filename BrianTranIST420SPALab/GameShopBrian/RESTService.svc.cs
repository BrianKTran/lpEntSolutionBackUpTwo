using GameShopBrian;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GameShopBrian
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RESTService.svc or RESTService.svc.cs at the Solution Explorer and start debugging.

    public partial class ist420grp5Entities1
    {
      

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }


    public class RESTService : IRESTService
    {
        public string DoWork()
        {
            return "Hello Brian";
        }

        public tblInventoryBrianTran[] GetInventory()
        {
            using (ist420grp5Entities entities = new ist420grp5Entities())
            {
                var Inventory = from Inv in entities.tblInventoryBrianTrans select Inv;

                return Inventory.ToArray();
            }
        }

        public decimal GetInvoiceTotal(string shipping, string state)
        {
            decimal shippingCost = 0m;
            decimal Shipping = 0m;
            decimal stateTax = 0m;
            decimal amountBeforeTax = 0;
            decimal amountWithTax = 0;
            decimal metric = 1.0m;
            decimal levy = 70.00m;
            decimal total = 0;


            if (shipping == "UPS")
            {
                shippingCost = 2.50m;
                Shipping = shippingCost * metric;
            }
            else if (shipping == "FedEx")
            {
                shippingCost = 1.50m;
                Shipping = shippingCost * metric;
            }

            if (state == "PA")
            {
                stateTax = 0.07m;
            }

            else if (state == "NY")
            {
                stateTax = 0.10m;
            }
            else if (state == "NJ")
            {
                amountBeforeTax = 0.04m;
            }

            amountBeforeTax = levy + Shipping;
            amountWithTax = amountBeforeTax * stateTax;
            total = amountBeforeTax + amountWithTax;

            return total;

        }

        public string CreateCustomer(string custName, string custSSN, string
      custEmail, string custPhone)
        {
            using (ist420grp5Entities1 entities = new ist420grp5Entities1())
            {
                //Insert a Record
                //Create the custent cust obect
                tblCustomerBrianTran cust = new tblCustomerBrianTran();
                cust.CustomerName = custName;
                cust.CustomerSSN = custSSN;
                cust.CustomerEmail = custEmail;
                cust.CustomerPhone = custPhone;
                //Call the method to add the object to the table
                entities.tblCustomerBrianTrans.Add(cust);
                //Save the changes to the DB
                entities.SaveChanges();
                //cust.CustomerID will contain the record number
                if (cust.CustomerID > 0)
                    return cust.CustomerID.ToString();
                else
                    return "false";
            }

        }


        public bool UpdateCustomer(int custID, string custName, string custSSN,
string custEmail, string custPhone)
        {

            using (ist420grp5Entities1 entities = new ist420grp5Entities1())
            {
                //Update a Record
                //Create the custent cust object
                tblCustomerBrianTran cust = new tblCustomerBrianTran();
                cust = entities.tblCustomerBrianTrans.Find(custID);
                cust.CustomerName = (custName == null) ? cust.CustomerName :
custName;
                cust.CustomerSSN = (custSSN == null) ? cust.CustomerSSN :
custSSN;
                cust.CustomerEmail = (custEmail == null) ? cust.CustomerEmail :
custEmail;
                cust.CustomerPhone = (custPhone == null) ? cust.CustomerPhone :
custPhone;
                //Save the changes to the DB
                entities.SaveChanges();
                //cust.fldStudentID will contain the record number
                if (cust.CustomerID > 0)
                    return true;
                else
                    return false;
            }
        }

        public tblCustomerBrianTran ReadCustomer(int custID)
        {
            using (ist420grp5Entities1 entities = new ist420grp5Entities1())
            {
                tblCustomerBrianTran cust = new tblCustomerBrianTran();
                cust = entities.tblCustomerBrianTrans.Find(custID);
                return cust;
            }
        }

        public tblCustomerBrianTran[] ReadCustomerList()
        {
            using (ist420grp5Entities1 entities = new ist420grp5Entities1())
            {
                var customer = from s in entities.tblCustomerBrianTrans
                               select
                                   s;
                return customer.ToArray();
            }
        }




        public bool DeleteCustomer(int custID)
        {
            using (ist420grp5Entities1 entities = new ist420grp5Entities1())
            {
                //Create the custent cust object
                tblCustomerBrianTran cust = new tblCustomerBrianTran();
                try
                {
                    cust = entities.tblCustomerBrianTrans.Find(custID);
                    //Delete a record
                    entities.tblCustomerBrianTrans.Remove(cust);
                    entities.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        } //End DeleteStudent




    }

}