using System;

namespace RandomShuffling
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] STUDENT_COUNT_PER_CLASS = { 10, 15, 21 };
            int classCount = STUDENT_COUNT_PER_CLASS.Length;
            string[] STUDENT_NAMES = { "john", "Pope", "Bob" };

            string[][] classrooms = new string[classCount][];
            for (int i = 0; i < classCount; ++i)
            {
                classrooms[i] = new string[STUDENT_COUNT_PER_CLASS[i]];
            }

            for (int classIndex = 0; classIndex < classCount; ++classIndex)
            {
                string[] studentNames = classrooms[classIndex];

                for (int studentIndex = 0; studentIndex < studentNames.Length; ++studentIndex)
                {
                    studentNames[studentIndex] = STUDENT_NAMES[studentIndex % 3];
                }
            }

            string[] classroom2 = classrooms[1];
            string[] newClassroom2 = new string[classroom2.Length + 1];

            for (int i = 0; i < classroom2.Length; ++i)
            {
                newClassroom2[i] = classroom2[i];
            }

            newClassroom2[newClassroom2.Length - 1] = "Leanne";
            classrooms[1] = newClassroom2;
            
            /*
            for (int i = 0; i<3;i++)
            {
                string[] classcheck = classrooms[i]; 
                for (int j = 0; j<classcheck.Length; j++)
                {
                    Console.Write($"{classcheck[j]}   ");
                    
                }
                Console.WriteLine("");
            }

            */
        }
    }
}
