using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string name { get; set; }
        public List<double> grades { get; set; }
        public double averageGrade
        {
            get
            {
                return grades.Average();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
