using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        public List<Student> Students { get; set; }

        public School()
        {
            Students = GetAllStudents();
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader("students.txt", Encoding.UTF8))
            {
                string line;
                while ((line = Console.ReadLine()) != null)
                {
                    string[] lineArgs = line.Split(' ');

                    Student currentStudent = new Student(lineArgs[0], int.Parse(lineArgs[1]), lineArgs[2], lineArgs[3]);

                    currentStudent.AddGrade(Subject.BulgarianLanguage, double.Parse(lineArgs[4]));
                    currentStudent.AddGrade(Subject.ForeignLanguage, double.Parse(lineArgs[5]));
                    currentStudent.AddGrade(Subject.Maths, double.Parse(lineArgs[6]));
                    currentStudent.AddGrade(Subject.Physics, double.Parse(lineArgs[7]));
                    currentStudent.AddGrade(Subject.Chemistry, double.Parse(lineArgs[8]));
                    currentStudent.AddGrade(Subject.Biology, double.Parse(lineArgs[9]));

                    students.Add(currentStudent);
                }
            }

            return students;
        }

        public Student GetStudent(string _class, int number)
        {
            return Students.Where(s => s.Class == _class && s.Number == number).FirstOrDefault();
        }

        public void AddStudent()
        {

        }
    }
}
