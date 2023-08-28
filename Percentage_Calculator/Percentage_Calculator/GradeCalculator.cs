using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class GradeCalculator
    {
        public string GetGradeByPercentage(int Percentage)
        {
            if (Percentage >= 91 && Percentage <= 100)
            {
                return "A";
            }
            else if (Percentage >= 81 && Percentage <= 90)
            {
                return "B";
            }
            else if (Percentage >= 71 && Percentage <= 80)
            {
                return "C";
            }
            else if (Percentage >= 61 && Percentage <= 70)
            {
                return "D";
            }
            return "Fail";
        }
    }
}
