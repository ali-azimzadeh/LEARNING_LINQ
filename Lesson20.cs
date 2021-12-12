using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_LINQ
{
    class Lesson20
    {
       
        static void Main(string[] args)
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

            //******************************
            //Samlple1
            //******************************

            Student[] students =
                //Anonymous Function/Method
                StudentExtension.where(studentArray, delegate (Student student) 
                {
                    return student.Age > 12 && student.Age < 20;
                });

            //******************************
            //Samlple2
            //******************************

            //Student[] students =
            //    StudentExtension.where(studentArray, delegate (Student std)
            //    {
            //        return std.StudentID == 5;
            //    });

            //******************************
            //Samlple3
            //******************************

            //Also, use another criteria using same delegate
            //Student[] students =
            //    StudentExtension.where(studentArray, delegate (Student std)
            //    {
            //        return std.StudentName == "Sara";
            //    });
        }
    }
}

