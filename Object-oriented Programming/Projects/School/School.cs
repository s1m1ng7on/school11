using System.Text;

namespace School
{
    public class School
    {
        public List<Student> Students { get; set; }

        public School()
        {
            Students = new List<Student>();
            LoadStudents();
        }

        public void LoadStudents()
        {
            if (Students.Count > 0)
                Students.Clear();  

            if (File.Exists("students.txt"))
            {
                using (StreamReader reader = new StreamReader("students.txt", Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] lineArgs = line.Split(' ');

                        Student student = new Student(lineArgs[0], int.Parse(lineArgs[1]), lineArgs[2], lineArgs[3], lineArgs.Skip(4).Take(6).Select(double.Parse).ToArray());
                        Students.Add(student);
                    }
                }
            }
        }

        public Student GetStudent(string _class, int number)
        {
            Student student = Students.Where(s => s.Class == _class && s.Number == number).FirstOrDefault();

            if (student == null)
                throw new ArgumentException("A student in this class or with this number could not be found.");

            return student;
        }

        public void AddStudent(string _class, int number, string firstName, string lastName, double[] grades)
        {
            Student newStudent = new Student(_class, number, firstName, lastName, grades);
            Students.Add(newStudent);
            SaveStudents();
        }

        private void SaveStudents()
        {
            using (StreamWriter writer = new StreamWriter("students.txt", true, Encoding.UTF8))
            {
                foreach (Student student in Students)
                {
                    writer.WriteLine(student.ToShortReport());
                }
            }

            LoadStudents();
        }
    }
}
