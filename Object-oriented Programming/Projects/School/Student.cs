using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public class Student
    {
        public int Number { get; set; }
        public string Class { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<Subject, double> Grades { get; set; }
        public double AverageGrade { get => Grades.Select(g => g.Value).Average(); }

        public Student(string _class, int number, string firstName, string lastName, double[] grades)
        {
            Class = _class;
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            Grades = new Dictionary<Subject, double>()
            {
                { Subject.BulgarianLanguage, grades[0] },
                { Subject.ForeignLanguage, grades[1] },
                { Subject.Maths, grades[2] },
                { Subject.Physics, grades[3] },
                { Subject.Chemistry, grades[4] },
                { Subject.Biology, grades[5] }
            };
        }

        public string ToShortReport()
        {
            return $"{Class} {Number} {FirstName} {LastName} {string.Join(" ", Grades.Values)} {AverageGrade:f2}";
        }

        public string ToLongReport()
        {
            return $"С П Р А В К А\n" +
                $"за успеха на {FirstName} {LastName}\n" +
                $"{Class} клас, номер {Number}\n" +
                $"БЕЛ\t\t- {Grades[Subject.BulgarianLanguage]}\n" +
                $"Чужд език\t- {Grades[Subject.ForeignLanguage]}\n" +
                $"Математика\t- {Grades[Subject.Maths]}\n" +
                $"Физика\t\t- {Grades[Subject.Physics]}\n" +
                $"Химия\t\t- {Grades[Subject.Chemistry]}\n" +
                $"Биология\t- {Grades[Subject.Biology]}\n" +
                $"Среден успех\t- {AverageGrade:f2}\n";
        }
    }

    public enum Subject
    { 
        BulgarianLanguage,
        ForeignLanguage,
        Maths,
        Physics,
        Chemistry,
        Biology
    }
}
