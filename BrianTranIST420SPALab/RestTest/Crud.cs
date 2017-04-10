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
        [TestMethod]
        public void Create_Course_Test()
        {
            using (ist420grp5Entities1 entities = new ist420grp5Entities1())
            {
                //Insert a Record
                //Create the custent cust obect
                tblCustomerBrianTran cust = new tblCustomerBrianTran();
                cust.CustomerName = "IST";
                cust.CustomerSSN = "911";
                cust.CustomerEmail = "ggez@gmail.com";
                cust.CustomerPhone = "911";
                cust.CustomerID = 911;
                //Call the method to add the object to the table
                entities.tblCustomerBrianTrans.Add(cust);
                //Save the changes to the DB
                //entities.SaveChanges();
                //cust.CustomerID will contain the record number
            }
            //ist420grp5Entities1 et = new ist420grp5Entities1();
            //tblCustomerBrianTran newTable = et.tblCustomerBrianTrans.Find(911);
            //if (newTable==null) 
            //{
            //    Assert.Fail();
            //}
        }


        [TestMethod]
        public void Update_Course_Test()

        {
          

            //using (ist420grp5Entities1 entities = new ist420grp5Entities1())
            //{
            //    //Update a Record
            //    //Create the custent cust object
            //    tblCustomerBrianTran cust = new tblCustomerBrianTran();
            //    cust = entities.tblCustomerBrianTrans.Find(custID);
            //    cust.CustomerName = (custName == null) ? cust.CustomerName : custName;
            //    cust.CustomerSSN = (custSSN == null) ? cust.CustomerSSN : custSSN;
            //    cust.CustomerEmail = (custEmail == null) ? cust.CustomerEmail : custEmail;
            //    cust.CustomerPhone = (custPhone == null) ? cust.CustomerPhone : custPhone;
            //    //Save the changes to the DB
            //    entities.SaveChanges();
            //    //cust.fldStudentID will contain the record number
            //    if (cust.CustomerID > 0)
            //        return true;
            //    else
            //        return false;
            //}

        }

        //[TestMethod]
        //public void Get_Course_Info_Test()
        //{

        //    //Arrange
        //    _service = new CourseDataService();

        //    //Act
        //    _service.GetCoursesById(CourseID);

        //    //Assert

        //    Equals(_service.GetCourses(CourseID));

        //}

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

