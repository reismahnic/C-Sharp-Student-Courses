using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCourses
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
    }
}