using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStudy
{
    public class Student
    {
        public Student()
        {
            EnrolledCourses = new List<Course>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public List<Course> EnrolledCourses { get; set; }

    }
}
