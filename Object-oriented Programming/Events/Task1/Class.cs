namespace Task1
{
    public static class Class
    { 
        public static List<Student> Students = new List<Student>();
    }

    public class Student : IObserver
    {
        public string Name { get; private set; }
        public int Grade { get; private set; }
        public int ClassNumber { get; private set; }
        public Dictionary<string, List<int>> Grades { get; private set; }

        public Student(string name, int grade, int classNumber)
        {
            Name = name;
            Grade = grade;
            ClassNumber = classNumber;
            Grades = new Dictionary<string, List<int>>();

            Class.Students.Add(this);
            Publisher.AddObserver(this);
        }

        public void AddGrade(string subject, int grade)
        {
            Publisher.Notify(this, subject, grade);
        }

        public void Update(Student student, string subject, int grade)
        {
            if (student == this)
            {
                if (!Grades.ContainsKey(subject))
                    Grades[subject] = new List<int>();

                Grades[subject].Add(grade);
            }
        }
    }

    public class Parent : IObserver
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public List<Student> Children { get; private set; }

        public Parent(string name, string email, params string[] childrenNames)
        {
            Name = name;
            Email = email;
            Children = Class.Students.Where(s => childrenNames.Contains(s.Name)).ToList();

            Publisher.AddObserver(this);
        }

        public void Update(Student student, string subject, int grade)
        {
            if (Children.Contains(student))
                Console.WriteLine($"{Name} ({Email}): Your child {student.Name} (No.{student.ClassNumber}) from {student.Grade}. class has received {grade} in {subject}.");
        }
    }

    public interface IObserver
    {
        void Update(Student student, string subject, int grade);
    }
}
