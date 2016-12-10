using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{   
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int name = 0; name < n; name++)
            {
                Student currentStudent = new Student();
                List<string> studentData = Console.ReadLine().Split().ToList();

                GetStudentData(currentStudent, studentData);

                students.Add(currentStudent);
            }

            List<Student> notableStudents = students.OrderBy(student => student.name).ThenByDescending(student => student.averageGrade).ToList();
            PrintNotableStudents(notableStudents);
        }

        private static void GetStudentData(Student currentStudent, List<string> studentData)
        {
            currentStudent.name = studentData[0];
            List<double> currentStudentGrades = new List<double>();

            GetGrades(studentData, currentStudentGrades);

            currentStudent.grades = currentStudentGrades;
        }

        private static void GetGrades(List<string> studentData, List<double> currentStudentGrades)
        {
            for (int grade = 1; grade < studentData.Count; grade++)
            {
                double studentGrade = double.Parse(studentData[grade]);
                currentStudentGrades.Add(studentGrade);
            }
        }

        private static void PrintNotableStudents(List<Student> notableStudents)
        {
            foreach (var student in notableStudents)
            {
                if (student.averageGrade >= 5)
                {
                    Console.WriteLine("{0:f2} -> {1:f2}", student.name, student.averageGrade);
                }
            }
        }
    }

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
}
