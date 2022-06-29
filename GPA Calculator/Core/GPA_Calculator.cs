using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Core
{
    public class GPA_Calculator
    {
        public static int GetTotalPassedCourseUnit(User user)
        {
            int count = user.numberOfCourses;
            int totalCourseUnitPassed = 0;
            for(int i = 0; i < count; i++)
            {
                if (user.courseScore[i] > 39)
                {
                    totalCourseUnitPassed += user.courseUnit[i];
                }
            }
            return totalCourseUnitPassed;
        }
        public static List<int> GetGradeWeight(List<int> gradeUnits, List<int> courseUnit)
        {
            int count = gradeUnits.Count;
            List<int> gradeWeight = new List<int>();
            for(int i = 0; i < count; i++)
            {
                gradeWeight.Add(gradeUnits[i] * courseUnit[i]);
            }
            return gradeWeight;
        }
        public static int GetTotalWeightPoint(List<int> gradeWeight) => gradeWeight.Sum();

        public static string GetGPA(int totalWeightPoint, int totalCourseUnit)
        {
            return (((double )totalWeightPoint)/ totalCourseUnit) .ToString("0.00");
        }
    }
}
