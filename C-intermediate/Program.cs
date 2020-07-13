using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_intermediate
{
    class Program
    {

        public class Person
        {
            public string Name;
            public static Person createPerson(string str)
            {
                var person = new Person();
                person.Name = str;

                return person;
            }
            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, Name);
            }
        }

        static void Main(string[] args)
        {

            //Classes
            var person = Person.createPerson("Ken");
            person.Introduce("Len");

        }
    }
}
