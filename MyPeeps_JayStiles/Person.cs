using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps

{
    class Person
    {
        string FirstName;
        string LastName;
        string EmailAddress;
        int Age;
        
        
        public Person(string firstName, string lastName, string emailAddress, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Age = age;
            
        }

        public virtual void Play()
        {
            Console.WriteLine("\nFirst name: {0} \nLast name {1} \nEmail Address: {2} \nAge: {3}", FirstName, LastName, EmailAddress, Age);
        }

    }
}
