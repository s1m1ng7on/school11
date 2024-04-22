namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintInstructions();
            GetInput();
        }

        static void PrintInstructions()
        {
            Console.WriteLine(
                "ADD STUDENT\n" +
                "Student <name> <class> <class number>\n" +
                "---------------------------------------------\n" +
                "ADD PARENT\n" +
                "Parent <name> <email> <children names>\n" +
                "---------------------------------------------\n" +
                "ADD GRADE\n" +
                "Grade <student name> <subject> <grade>\n");
        }

        static void GetInput()
        {
            Class myClass = new Class();

            string[] inputArgs;
            while ((inputArgs = Console.ReadLine().Split(' '))[0].ToLower() != "end")
            {
                switch (inputArgs[0].ToLower())
                {
                    case "student":
                        Student newStudent = new Student(inputArgs[1], int.Parse(inputArgs[2]), int.Parse(inputArgs[3]));
                        myClass.AddStudent(newStudent);
                        break;
                    case "parent":
                        Parent newParent = new Parent(inputArgs[1], inputArgs[2], inputArgs.Skip(3).ToArray());
                        myClass.AddParent(newParent);
                        break;
                    case "grade":
                        Student selectedStudent = myClass.Students.Where(s => s.Name == inputArgs[1]).FirstOrDefault();
                        if (selectedStudent != null)
                            myClass.AddGrade(selectedStudent, inputArgs[2], int.Parse(inputArgs[3]));
                        break;
                }
            }
        }
    }
}