using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lpconcept
{
    [Serializable]
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string CourseName { get; set; }
    }
}