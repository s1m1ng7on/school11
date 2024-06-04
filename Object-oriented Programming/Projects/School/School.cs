using System.Text;

namespace School
{
    public class School
    {
        private const string studentsDataFilePath = "students.txt";

        public Student SelectedStudent { get; set; } 
        public List<Student> Students { get; set; }

        public School()
        {
            Students = new List<Student>();
            LoadStudents();
        }

        public Student GetStudent(string _class, int number)
        {
            return Students.Where(s => s.Class == _class && s.Number == number).FirstOrDefault();
        }

        public void AddStudent(string _class, int number, string firstName, string lastName, double[] grades)
        {
            if (Students.Where(s => s.Class == _class && s.Number == number).FirstOrDefault() == null)
            {
                Student newStudent = new Student(_class, number, firstName, lastName, grades);
                Students.Add(newStudent);
                SaveStudents();
            }
        }

        private void LoadStudents()
        {
            if (Students.Count > 0)
                Students.Clear();

            if (File.Exists(studentsDataFilePath))
            {
                using (StreamReader reader = new StreamReader(studentsDataFilePath, Encoding.UTF8))
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

        private void SaveStudents()
        {
            using (StreamWriter writer = new StreamWriter(studentsDataFilePath, false, Encoding.UTF8))
            {
                foreach (Student student in Students)
                    writer.WriteLine(student.ToShortReport());
            }

            LoadStudents();
        }
    }
}
