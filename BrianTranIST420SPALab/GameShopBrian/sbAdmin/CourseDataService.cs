using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace lpconcept
{
    public class CourseDataService
    {
        private List<Course> Courses { get; set; }

        public CourseDataService()
        {
            if (File.Exists("./Courses.dat"))
            {
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream("./Courses.dat", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    this.Courses = (List<Course>)formatter.Deserialize(stream);
                }
            }
            else
            {
                this.Courses = new List<Course>();
                SeedCourses();
            }
        }

        

        private void Save()
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("C:/Users/Brian/Desktop/writehere/Courses.dat", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, this.Courses);
            }
        }

        private void SeedCourses()
        {
            var Course = new Course
            {
                CourseID = 1,
                Title = "IST 440W",
                CourseName = "Integration & Problem Solving"
            };

            this.Courses.Add(Course);
            Save();
        }

        public Course[] GetCourses()
        {
            return this.Courses.ToArray();
        }

        public Course GetCourseById(int id)
        {
            return this.Courses.SingleOrDefault(p => p.CourseID == id);
        }

        public void UpdateCourse(Course Course)
        {
            var found = this.Courses.SingleOrDefault(p => p.CourseID == Course.CourseID);
            if (found != null)
            {
                this.Courses.Remove(found);
                this.Courses.Add(Course);
                Save();
            }
        }

        public void CreateCourse(Course Course)
        {
            var lastID = this.Courses.Max(p => p.CourseID);
            Course.CourseID = lastID + 1;
            this.Courses.Add(Course);
            Save();
        }

        public void DeleteCourse(int id)
        {
            var Course = this.Courses.SingleOrDefault(p => p.CourseID == id);
            this.Courses.Remove(Course);
            Save();
        }
    }

    
}

