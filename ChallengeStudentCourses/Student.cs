using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public List<Course> Courses { get; set; }
        public string display()
        {
            string students = "";
            foreach (Course c in Courses)
            {
                students += "Course: " + c.Name + " - " + c.CourseId + "<br />";
            }
            string result = string.Format("Student : {0} <br />{1}", Name, students);
            return result;
        }
    }
}