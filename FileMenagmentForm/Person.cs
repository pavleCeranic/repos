using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMenagmentForm
{
    class Person
    {
        public Person(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public string  firstName { get; set; }
        public string lastName { get; set; }
        public string  email { get; set; }

        public override string ToString()
        {
            return "First Name: " + firstName + "Last Name: " + lastName + "Email: " + email;
        }

    }
}
