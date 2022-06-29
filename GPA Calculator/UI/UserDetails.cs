using GPA_Calculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.UI
{
    public class UserDetails
    {
        
        public static string GetUserName()
        {
            var name = "";
            do
            {
                Console.Write("Enter your name: ");
                 name = Console.ReadLine();

            }
            while (string.IsNullOrEmpty(name));
                    //{
                    //    Console.Write("Name can't be empty, enter name again: ");
                    //    name = Console.ReadLine();
                    //}
              return name;
 
        }
        public static int GetUSerNumberOfCourses()
        {
            Console.Write("Enter number of courses registered: ");
            var numberOfCourseString = Console.ReadLine();

            int numberOfCourse;
            while (!int.TryParse(numberOfCourseString, out numberOfCourse))
            {
                Console.Write ("This is not a number!. Enter a number: ");
                numberOfCourseString = Console.ReadLine();
            }
            return numberOfCourse;
        }
        public static string GetUserCourseCode()
        {
            Console.Write("Enter your Coursecode: ");
            var courseCode = Console.ReadLine();
            while (string.IsNullOrEmpty(courseCode))
            {
                Console.Write("Coursecode can't be empty. Enter Coursecode again: ");
                courseCode = Console.ReadLine();
            }
            return courseCode;
        }
        public static int GetUSerCourseUnit()
        {
            Console.Write("Enter Course Unit: ");
            var courseUnitString = Console.ReadLine();

            int unit;
            while(!int.TryParse(courseUnitString, out unit))
            {
                Console.Write("This is not a number!. Enter a number: ");
                courseUnitString = Console.ReadLine();
            }
            return unit;
        }
        public static double GetUSerCourseScore()
        {
            Console.Write("Enter Course Score: ");
            var courseScoreString = Console.ReadLine();

            double score;
            while (!double.TryParse(courseScoreString, out score) || (score < 0 || score > 100))
            {
                Console.Write("Input is not a number or its not between 0 and 100. Enter a number: ");
                courseScoreString = Console.ReadLine();
            }
            return score;
        }
        public static User GetUser()
        {
            string name = GetUserName();
            int numberCourses = GetUSerNumberOfCourses();
            List<string> courseCode = new List<string>();
            List<int> courseUnit = new List<int>();
            List<double> courseScore = new List<double>();
            for(int i = 0; i < numberCourses; i++)
            {
                courseCode.Add(GetUserCourseCode());
                courseUnit.Add(GetUSerCourseUnit());
                courseScore.Add(GetUSerCourseScore());
            }
            return new User(numberCourses, name, courseCode, courseUnit, courseScore);
        }
    }
}
