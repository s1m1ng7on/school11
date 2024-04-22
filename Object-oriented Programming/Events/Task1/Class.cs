namespace Task1
{
    public class Class
    {
        private Publisher publisher;

        public List<Student> Students { get; private set; }
        public List<Parent> Parents { get; private set; }

        public Class()
        {
            Students = new List<Student>();
            Parents = new List<Parent>();
            publisher = new Publisher();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            AddObserver(student);
        }

        public void AddParent(Parent parent)
        {
            parent.SetChildren(Students.Where(c => parent.ChildrenNames.Contains(c.Name)).ToList());
            Parents.Add(parent);
            AddObserver(parent);
        }

        public void AddGrade(Student student, string subject, int grade)
        {
            publisher.Notify(student, subject, grade);
        }

        public void AddObserver(IObserver observer)
        {
            publisher.AddObserver(observer);
        }
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
        public List<string> ChildrenNames { get; private set; }
        public List<Student> Children { get; private set; }

        public Parent(string name, string email, params string[] childrenNames)
        {
            Name = name;
            Email = email;
            ChildrenNames = childrenNames.ToList();
        }

        public void SetChildren(List<Student> children)
        {
            Children = children;
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
