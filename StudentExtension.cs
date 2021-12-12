using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_LINQ
{
    delegate bool FindStudent(Student std);

    class StudentExtension
    {
        public static Student[] where(Student[] stdArray, FindStudent findDelegate)
        {
            int i = 0;

            Student[] result = new Student[10];

            foreach (Student student in stdArray)
            {
                if (findDelegate(student) == true)
                {
                    result[i] = student;
                    i++;
                }
            }

            return result;
        }
    }
}
