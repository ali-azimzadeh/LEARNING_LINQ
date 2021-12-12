using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_LINQ
{
    class Lesson10
    {
        public Lesson10()
        {
        }
        static void Main(string[] args) => Sample1();
        public static void Sample1()
        {
            // Data source
            string[] names = { "Ali", "Reza", "Sara", "Ahmad" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // Query execution
            foreach (var name in myLinqQuery)
            {
                Console.Write(name + " ");
            }
        }
    }
}
