using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentCourses
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Assignment1btn_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>()
            {
                new Course() { CourseID = 1, CourseName = "Math 101", Students = new List<Student>(){
                    new Student() {StudentID = 1, Name = "Henry Jenkins"},
                    new Student() {StudentID = 2, Name = "Sally Bless" }}},
                new Course() { CourseID = 2, CourseName = "Chicago Blues History", Students = new List<Student>(){
                    new Student() {StudentID = 3, Name = "Carl Junior" },
                    new Student() {StudentID = 4, Name = "Donny Duck" }}},
                new Course() { CourseID = 3, CourseName = "Creative Writing", Students = new List<Student>(){
                    new Student() {StudentID = 5, Name = "Charlotte Jackson" },
                    new Student() {StudentID = 6, Name = "Bert Reynolds" }}},
            };

            foreach (var course in courses)
            {
                resultlbl.Text += string.Format("<br/>Course #: {0}  -  Course Name: {1}", course.CourseID, course.CourseName);
                foreach (var student in course.Students)
                {
                    resultlbl.Text += string.Format("<br/>%nbsp;&nbsp;Student ID #: {0}  -  Student Name: {1}", student.StudentID, student.Name);
                }
                    
            }
        }
                


        protected void Assignment2btn_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() { CourseID = 1, CourseName = "Pop Culture History" };
            Course course2 = new Course() { CourseID = 2, CourseName = "Cinematography 1" };
            Course course3 = new Course() { CourseID = 3, CourseName = "Human Sexuality 3" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student{ StudentID = 1, Name = "Reis Mahnic", Courses = new List<Course> { course1,course2}}},
                { 2, new Student{ StudentID = 2, Name = "Nicole Namie", Courses = new List<Course> { course2,course3}}},
                { 3, new Student{ StudentID = 3, Name = "Brent Moore", Courses = new List<Course> { course1,course3}}},
            };

            foreach (var student in students)
            {
                resultlbl.Text += String.Format("<br/>Student ID #: {0}  -  Student Name: {1}", student.Key, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultlbl.Text += String.Format("<br/>&nbsp;&nbsp;Course ID #: {0}  -  Course Name: {1}", course.CourseID, course.CourseName);
                }
            }

        }

        protected void Assignment3btn_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentID = 20;
            student.Name = "Barry Burton";
            student.Enrollments = new List<StudentEnrollment>()
            {
                new StudentEnrollment {grade = 56,  course = new Course { CourseID = 1, CourseName = "Taxidermy 101"}},
                new StudentEnrollment {grade = 87, course = new Course { CourseID = 2, CourseName = "Anatomy & Phisiology 2"}},
                new StudentEnrollment {grade = 34, course = new Course { CourseID = 3, CourseName = "Cat Feeding 302"}},
            };
           
            resultlbl.Text += String.Format("<br/>Student #: {0}  -  Student Name: {1}", student.StudentID, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                resultlbl.Text += String.Format("<br/>&nbsp;&nbsp;Course Name: {0}  -  Student's Grade: {1}", enrollment.course.CourseName, enrollment.grade);
            }
            
        }
    }
}