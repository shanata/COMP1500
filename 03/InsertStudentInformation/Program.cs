using System;

namespace InsertStudentInformation{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Student Number: ");
            string studentNumberString = Console.ReadLine();
            int studentNumber = int.Parse(studentNumberString);

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{name}\n{studentNumber}\n{grade}%");
        }
    }

}
/*
using System;

namespace InsertStudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information:");

            Console.Write("Name: ");
            string name = Console.ReadLine() ?? ""; // ← null이면 빈 문자열로 처리

            Console.Write("Student Number: ");
            string studentNumberString = Console.ReadLine() ?? "0"; // ← null이면 "0"으로 처리
            int studentNumber = int.Parse(studentNumberString);     // ⚠️ 숫자 아닌 입력은 예외 발생

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine() ?? "0"; // ← null이면 "0"으로 처리
            int grade = int.Parse(gradeString);             

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{name}\n{studentNumber}\n{grade}%");
        }
    }
}
*/