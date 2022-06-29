using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Core
{
    public class User
    {
        public int numberOfCourses { get; set; }
        public string studentName { get; set; }
        public List<string> courseCode { get; set; }
        public List<int> courseUnit { get; set; }
        public List<double> courseScore { get; set; }
        public int TotalRegisteredUnits => courseUnit.Sum();


        public User(int numberOfCourses, string studentName, List<string> courseCode, List<int> courseUnit, List<double> courseScore)
        {
            this.numberOfCourses = numberOfCourses;
            this.studentName = studentName;
            this.courseCode = courseCode;
            this.courseUnit = courseUnit;
            this.courseScore = courseScore;
        }
    }
}
