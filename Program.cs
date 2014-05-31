using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassHW
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        protected string name, lastName;

        Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        
        public string getPersonInfo() { return name + ", " + lastName; }
    }
    
    class Student : Person, IComparable
    {
        public string email {get; set;}
        private string location;
        
        public bool setName(string input)
        {
            if (.............)
            {
                Console.WriteLine("Name must be at least two characters long");
                return false;
            }
            
            if (................)
            {
                Console.WriteLine("Name can only have letters");
                return false;
            }
            
            if (..................)
            {
                Console.WriteLine("Name must start with an uppercase letter");
                return false;
            }
        }
        
        public string getStudentInfo()
        {
        }
    }
}
