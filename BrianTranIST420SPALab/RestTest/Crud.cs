using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameShopBrian;
using lpconcept;
//using NUnit.Framework;

namespace RestTest
{
    [TestClass]
    public class Crud
    {
        private CourseDataService _service;
        //private RESTService customer;

        [TestMethod]
        public void Get_Course_Test()
        {
            //Arrange
            _service = new CourseDataService();

            //Act
            _service.GetCourses();

            //Assert

            Equals(_service.GetCourses());

        }

        //       [TestMethod]
        //       public void ShouldReadAll()
        //       {
        //           ist420grp5Entities1 entities = new ist420grp5Entities1();
        //               //Arrange
        //               customer = new RESTService();
        //           //Act
        //           customer.ReadCustomerList();

        //           //Assert

        //           Equals(customer.ReadCustomerList());

        //}
    }

     //   [TestMethod]
     //   public void ShouldAddCourse()
     //   {
     //       //var mockSet = new Mock<DbSet<User>>();
     //       var mockContext = new Mock<string>(custName, custSSN, custPhone, custEmail);

     //       mockContext.Setup(m => m.Users).Returns(mockSet.Object);

     ////       var usrCRUD = new CreateCustomer(string custName, string custSSN, string
     ////custEmail, string custPhone);
            
     //           //var usr = new User();
     //           //usr.Login = "Login_Name";
     //           //usr.Email = "loginName@test.com";
     //           //usr.Password = "***";
     //           //usr.InvalidLogins = 0;
     //           //usr.RememberID = 0;

     //           //usrCRUD.AddUser(usr);

     //           tblCustomerBrianTran cust = new tblCustomerBrianTran();
     //       cust.CustomerName = custName;
     //       cust.CustomerSSN = custSSN;
     //       cust.CustomerEmail = custEmail;
     //       cust.CustomerPhone = custPhone;
     //       //Call the method to add the object to the table
     //       entities.tblCustomerBrianTrans.Add(cust);

     //       mockSet.Verify(m => m.Add(It.Is<User>(arg => arg.Login == "Login_Name")));
     //       mockContext.Verify(m => m.SaveChanges(), Times.Once());



















            //private IRESTService cust;
            ////private RESTService custID;
            //int custID;
            //tblCustomerBrianTran cust = new tblCustomerBrianTran();
            //[TestMethod]
            //public void GetAllCourses_ShouldReturnAllCourses()
            //{

            //    //Arrange
            //    string readUrl = "http://localhost:50491/RESTService.svc/Read?";
            //    //localHost = new RESTService();
            //    //var getCourses = ReadCustomerList();
            //    //var entities = new ist420grp5Entities1();
            //    //var result = entities.ReadCustomerList() as List<>
            //    //var getCourses = 1;
            //    //Act
            //    //cust.ReadCustomer(int custID);
            //    readUrl.ReadCustomerList();
            //    //Assert
            //    Equals

            //            //Equals(cust.ReadCustomer(int custID));



            //}
        }

