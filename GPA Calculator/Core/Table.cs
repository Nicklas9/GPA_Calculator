using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Core
{
    internal class Table
    {
        public static void PrintTable(User user,List<char> grades, List<int> gradeUnit, List<int> gradeWeight, List<string> remarks)
        {
            CreateTableHeader();
            int count = user.numberOfCourses;
            for (int i = 0; i < count; i++)
            {
                AddTableElement(user.courseCode[i], user.courseUnit[i], grades[i], gradeUnit[i], gradeWeight[i], remarks[i]);
            }
            Console.WriteLine(".................................................................................................");
        }
        private static void CreateTableHeader()
        {
            Console.WriteLine("...............................................................................................");
            Console.WriteLine($"|{"COURSE & CODE",15}|{"COURSE UNIT",15}|{"GRADE",15}|{"GRADE UNIT",15}|{"WEIGHT Pt.",15}|{"REMARK",15}|");
            Console.WriteLine(".................................................................................................\n");
        }
        private static void AddTableElement(string courseCode, int courseUnit, char acquiredGrade, int acquiredGradeUnit, int gradeWeight, string remark)
        {
            Console.WriteLine($"|{courseCode,-15}|{courseUnit,-15}|{acquiredGrade,-15}|{acquiredGradeUnit,-15}|{gradeWeight,-15}|{remark,-15}|");
        }
    }
}
