using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Person(string fName, string lName, int personAge)
            {
                FirstName = fName;
                LastName = lName;
                Age = personAge;
            }

            public override string ToString()
            {
                string myState;
                myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirstName, LastName, Age);
                return myState;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with System.Object *****\n");
            Person p1 = new Person();

            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            Person p2 = p1;
            object o = p2;

            if (o.Equals(p1) && p1.Equals(o))
            {
                Console.WriteLine("Same Instance!");

            }
            Console.ReadLine();

        }
    }
}
