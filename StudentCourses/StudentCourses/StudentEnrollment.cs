using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCourses
{
    public class StudentEnrollment
    {
        public Course course { get; set; }
        public Student student { get; set; }
        public int grade { get; set; }
    }

}