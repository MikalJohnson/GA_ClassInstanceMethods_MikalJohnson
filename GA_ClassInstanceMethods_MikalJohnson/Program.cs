namespace GA_ClassInstanceMethods_MikalJohnson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Create a list of 5 grades ranging between 0 and 100
            List<int> mikalGrades = new List<int> { 92, 88, 72 };

            // Create a new instance of the student class with the name
            // "Mikal" and the grade list
            Student mikalStudent = new Student("Not Mikal", mikalGrades);

            mikalStudent.AddGrade(78); // Success
            mikalStudent.AddGrade(200); // Fails
            mikalStudent.AddGrade(-130); // Fails

            mikalStudent.DisplayAllGrades();

            mikalStudent.GetGrade();

            // Below your other code
            mikalStudent.DisplayStudentInfo();

            static List<Student> GenerateRandomStudents()
            {
                List<Student> students = new List<Student>();
                Random random = new Random(); // Random object created here

                for (int i = 1; i <= 5; i++)
                {
                    Student student = new Student($"Student{i}");

                    for (int j = 0; j < 5; j++)
                    {
                        student.ExamScores.Add(random.Next(0, 101));
                    }

                    students.Add(student);
                }

                return students;
            }
            List<Student> randomStudents = GenerateRandomStudents();

            // Add your student to this list
            randomStudents.Add(mikalStudent);

            // Loop and display all the info
            foreach (Student student in randomStudents)
            {
                student.DisplayStudentInfo();
            }

        }
    }
}
