using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_LINQ
{
    class Lesson30
    {
        static void Main()
        {
            // Create the first data source.
            List<Student2> students = new List<Student2>()
        {
            new Student2
            {
                First="Ali",
                Last="Azimzadeh",
                ID=111,
                Street="123 Main Street",
                City="Tehran",
                Scores= new List<int> { 97, 92, 81, 60 }
            },

            new Student2 
            {
                First="Reza",
                Last="Ahmadi",
                ID=112,
                Street="124 Main Street",
                City="Tabriz",
                Scores= new List<int> { 75, 84, 91, 39 } 
            },

            new Student2
            {
                First="Sara",
                Last="Mohseni",
                ID=113,
                Street="125 Main Street",
                City="Shiraz",
                Scores= new List<int> { 88, 94, 65, 91 } 
            },
        };

            // Create the second data source.
            List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher { First="Abbas", Last="Moradi", ID=945, City="Tehran" },
            new Teacher { First="Amir", Last="Ghasemi", ID=956, City="Shiraz" },
            new Teacher { First="Maryam", Last="Karimi", ID=972, City="Karaj" }
        };

            // Create the query.
            var peopleInSeattle = (from student in students
                                   where student.City == "Tehran"
                                   select student.Last)
                        .Concat(from teacher in teachers
                                where teacher.City == "Tehran"
                                select teacher.Last);

            Console.WriteLine("The following students and teachers live in Seattle:");

            // Execute the query.
            foreach (var person in peopleInSeattle)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    internal class Student2
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public List<int> Scores;
    }

    internal class Teacher
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string City { get; set; }
    }
}
