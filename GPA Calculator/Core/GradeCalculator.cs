using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Core
{
    public class GradeCalculator
    {
        public static List<char> GetGrade(List<double> scoreList)
        {
            List<char> grades = new List<char>();
            int count = scoreList.Count;
            for(int i = 0; i < count; i++)
            {
				if (scoreList[i] >= 0 && scoreList[i] <= 39)
				{
					grades.Add('F');

				}
				else if (scoreList[i] >= 40 && scoreList[i] <= 44)
				{
					grades.Add('E');
				}
				else if (scoreList[i] >= 45 && scoreList[i] <= 49)
				{
					grades.Add('D');
				}
				else if (scoreList[i] >= 50 && scoreList[i] <= 59)
				{
					grades.Add('C');
				}
				else if (scoreList[i] >= 60 && scoreList[i] <= 69)
				{
					grades.Add('B');
				}
				else
				{
					grades.Add('A');
				}
			}
			return grades;
        }
		public static List<int> GetGradeUnit(List<double> scoreList)
		{
			List<int> gradeUnit = new List<int>();
			int count = scoreList.Count;
			for (int i = 0; i < count; i++)
			{
				if (scoreList[i] >= 0 && scoreList[i] <= 39)
				{
					gradeUnit.Add(0);

				}
				else if (scoreList[i] >= 40 && scoreList[i] <= 44)
				{
					gradeUnit.Add(1);
				}
				else if (scoreList[i] >= 45 && scoreList[i] <= 49)
				{
					gradeUnit.Add(2);
				}
				else if (scoreList[i] >= 50 && scoreList[i] <= 59)
				{
					gradeUnit.Add(3);
				}
				else if (scoreList[i] >= 60 && scoreList[i] <= 69)
				{
					gradeUnit.Add(4);
				}
				else
				{
					gradeUnit.Add(5);
				}
			}
			return gradeUnit;
		}

		public static List<string> GetRemark(List<double> scoreList)
		{
			List<string> remark = new List<string>();
			int count = scoreList.Count;
			for (int i = 0; i < count; i++)
			{
				if (scoreList[i] >= 0 && scoreList[i] <= 39)
				{
					remark.Add("Fail");

				}
				else if (scoreList[i] >= 40 && scoreList[i] <= 44)
				{
					remark.Add("Pass");
				}
				else if (scoreList[i] >= 45 && scoreList[i] <= 49)
				{
					remark.Add("Fair");
				}
				else if (scoreList[i] >= 50 && scoreList[i] <= 59)
				{
					remark.Add("Good");
				}
				else if (scoreList[i] >= 60 && scoreList[i] <= 69)
				{
					remark.Add("Very Good");
				}
				else
				{
					remark.Add("Excellent");
				}
			}
			return remark;
		}


	}
}
