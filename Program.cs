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

        protected Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        protected string getPersonInfo()
        {
            return name + ", " + lastName;
        }
    }
    
    class Student : Person, IComparable
    {
        public string email {get; set;}
        private string location
        {
            get
            {
                if (location == "SA")
                {
                    return "Sarajevo";
                }
                else if (location == "TZ")
                {
                    return "Tuzla";
                }
                else
                {
                    return "Other";
                }
            }
            set
            {
                if (value == "SA" || value == "SARAJEVO" || value == "Sarajevo")
                {
                    location = "Sarajevo";
                }
                else if (value == "TZ" || value == "TUZLA" || value == "Tuzla")
                {
                    location = "Tuzla";
                }
                else
                {
                    location = "NA";
                }
            }
        }

        public Student() : base("Dino", "Prašo")
        {
            this.email = "email@aubih.edu.ba";
            this.location = "Sarajevo";
        }

        ~Student() {

        }

        public Student(string name, string lastname, string email)
            : base(name, lastname)
        {
            this.email = email;
            this.location = "Sarajevo";
        }

        public bool setName(string input)
        {
            if (input.Length <= 2)
            {
                Console.WriteLine("Name must be at least two characters long");
                return false;
            }

            char[] cArray = input.ToCharArray();
            foreach(char c in cArray) {
                if(!char.IsLetter(c)) {
                    Console.WriteLine("Name can only have letters");
                return false;
                }
            }

            if (char.IsUpper(cArray[0]))
            {
                Console.WriteLine("Name must start with an uppercase letter");
                return false;
            }

            return true;
        }
        
        public string getStudentInfo()
        {
            return base.getPersonInfo() + ", " + this.email + ", " + this.location;
        }

        public override string ToString()
        {
            return getStudentInfo();
        }

        public int CompareTo(Student student)
        {
            return location.CompareTo(student.location);
        }
    }
}
