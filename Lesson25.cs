using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_LINQ
{
    class Lesson25
    {
        /// <summary>
        /// Using LINQ for this collection
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student[] studentArray = {
                    new Student() { StudentID = 1, StudentName = "Ali", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Ahmad",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Maryam",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Reza" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Amir" , Age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Saman",  Age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rasta",Age = 19  } ,
                };

            // Use LINQ to find teenager students
            Student[] teenAgerStudents =
                studentArray
                .Where(s => s.Age > 12 && s.Age < 20)
                .ToArray()
                ;

            // Use LINQ to find first student whose name is Maryam 
            Student maryam =
                studentArray
                .Where(s => s.StudentName == "Maryam")
                .FirstOrDefault()
                ;

            // Use LINQ to find student whose StudentID is 5
            Student student5 =
                studentArray
                .Where(s => s.StudentID == 5)
                .FirstOrDefault()
                ;
        }
    }
}
