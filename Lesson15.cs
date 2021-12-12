using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_LINQ
{
    class Lesson15
    {
        public Lesson15()
        {

        }
        /// <summary>
        ///foreach روش پیمایش آرایه با استفاده از حلقه ی 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) => Sample2();
        

        static void Sample2()
        {
            Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "Ali", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Reza",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Ahmad",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Sara" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Atusa" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Amir",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Kamran",Age = 19  },
        };

            Student[] students = new Student[10];

            int i = 0;

            foreach (Student std in studentArray)
            {
                if (std.Age > 12 && std.Age < 20)
                {
                    students[i] = std;
                    i++;
                    Console.Write(std.StudentName + " ");
                }
            }
        }
    }
}
