using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Course
    {
        public  string  Name { get; set; }
        public int CourseId { get; set; }
        public List<Student> student { get; set; }
        public string display()
        {
            string students="";
            foreach (Student s in student)
            {
                students += "Student: " + s.Name + " - " + s.StudentId + "<br />";
            }
            string result = string.Format("Course : {0} - {1}<br />{2}", Name, CourseId, students);
            return result;
        }
    }
}