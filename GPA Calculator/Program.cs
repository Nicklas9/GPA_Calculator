using GPA_Calculator.Core;
using GPA_Calculator.UI;
using System;
using System.Collections.Generic;

namespace GPA_Calculator.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = UserDetails.GetUser();
            List<char> grades = GradeCalculator.GetGrade(user.courseScore);
            List<int> gradeUnits = GradeCalculator.GetGradeUnit(user.courseScore);
            List<int> weightPoints = GPA_Calculator.GetGradeWeight(gradeUnits, user.courseUnit);
            List<string> remarks = GradeCalculator.GetRemark(user.courseScore);
            Table.PrintTable(user,grades,gradeUnits,weightPoints,remarks);
            Console.WriteLine($"Total Course Unit Registered is {user.TotalRegisteredUnits}\nTotal Course Unit Passed is {GPA_Calculator.GetTotalPassedCourseUnit(user)}\nTotal Weight Point is {GPA_Calculator.GetTotalWeightPoint(weightPoints)}");

            int totalWeightPoint = GPA_Calculator.GetTotalWeightPoint(weightPoints);
            Console.WriteLine($"Your GPA is = {GPA_Calculator.GetGPA(totalWeightPoint, user.TotalRegisteredUnits)} to 2 decimal places."); 
        }
    }
}
