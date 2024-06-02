using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Student(string _class, int number, string firstName, string lastName)
        {
            Class = _class;
            Number = number;
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddGrade(Subject subject, double grade)
        {
            if (!Grades.ContainsKey(subject))
                Grades.Add(subject, grade);
            else
                throw new ArgumentException("Grade already exists.");
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
