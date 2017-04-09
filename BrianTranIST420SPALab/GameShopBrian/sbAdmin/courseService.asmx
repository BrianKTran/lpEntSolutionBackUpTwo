<%@ WebService Language="C#" Class="courseService" %>

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
//using System.Diagnostics;
using System.Web;
using System.Web.Services;

using lpconcept;

[WebService(Namespace = "http://puns.org/", Name="Course Service v1.0", Description = "This web service provides CRUD functions over a collections of courses")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(true)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class courseService : System.Web.Services.WebService
{

    private CourseDataService _service;

    public courseService()
    {
        _service = new CourseDataService();
    }



    [WebMethod]
    public Course[] GetCourses()
    {

        return _service.GetCourses();

    }

    [WebMethod]
    public Course GetCourseByID(int CourseID)
    {

        return _service.GetCourseById(CourseID);

    }

    [WebMethod]
    public void AddCourse (Course course)
    {

        _service.CreateCourse(course);

    }

    [WebMethod]
    public void EditCourse (Course course)
    {

        _service.UpdateCourse(course);

    }

    [WebMethod]
    public void DeleteCourse (int CourseID)
    {

        _service.DeleteCourse(CourseID);

    }


    [WebMethod]
    public string courseCatalog()
    {
        return "Hello World";
    }


    [WebMethod]
    public int Multiply(int x, int y)
    {
        return x * y;
    }

}
