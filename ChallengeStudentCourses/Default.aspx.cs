using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            List<Course> courses = new List<Course>()
            {
                new Course() {Name="DAA",CourseId=300,student=new List<Student>()
                {
                new Student() {Name="Ujwal",StudentId=486} ,
                new Student() {Name="Rishabh",StudentId=485}
                }
                },
                new Course() {Name="Discrete Maths",CourseId=301,student=new List<Student>()
                {
                new Student() {Name="Manik",StudentId=484} ,
                new Student() {Name="Anshul",StudentId=483}
                }
                },
                new Course() {Name="Software Enginnering",CourseId=302,student=new List<Student>()
                {
                new Student() {Name="Manish",StudentId=482} ,
                new Student() {Name="Rahul",StudentId=481}
                }
                }
            };
            foreach (Course c in courses)
            {
                result += c.display();
            }
            Label.Text = result;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string result = "";
            Dictionary<int, Student> stud = new Dictionary<int, Student>()
            {
                {486 , new Student {Name="Ujwal" ,Courses=new List <Course>()
                {
                    new Course{CourseId=300,Name="DAA"},
                    new Course{CourseId=301,Name="DM"},
                    new Course{CourseId=302,Name="Analog"}
                }
                }
                },
                {486 , new Student {Name="Ujwal" ,Courses=new List <Course>()
                {
                    new Course{CourseId=300,Name="DAA"},
                    new Course{CourseId=301,Name="DM"},
                    new Course{CourseId=302,Name="Analog"}
                }
                }
                }
            };
            for (int i = 0; i < stud.Count; i++)
            {
                result += stud.ElementAt(i).Key.ToString() + stud.ElementAt(i).Value.display();
            }
            Label.Text=result;

        }
        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}