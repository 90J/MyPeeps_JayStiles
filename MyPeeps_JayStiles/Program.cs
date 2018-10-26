using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeeps

{
    class Program
    {
        static void Main(string[] args)
        {
            int num =  2;

        Start:

            Person[] person = new Person[num];
            person[0] = new Person("Jay", "Stiles", "JayStiles@quickenloans.com", 43);
            person[1] = new Person("Tim", "Bro", "TimBroughton@quickenloans.com", 26);

            foreach (Person character in person)
            {
                character.Play();
            }

            //Get userInput

            Console.WriteLine( "");
            Console.WriteLine("Enter the following requested information");
            Console.Write("First name: ");
            string userInputFN = Console.ReadLine();
            
            

            Console.Write("Last name: ");
            string userInputLN = Console.ReadLine();

            Console.Write("Email address: ");
            string userInputEA = Console.ReadLine();

            Console.Write("Age: ");
            int userInputAge = Convert.ToInt32(Console.ReadLine());

            
            if (userInputAge < 18)
            {
                Console.WriteLine("Cannot add minors, add someone that is over 18.");
                goto Start;
            }
            else
            {
                num = num + 1;
                Person[] x = new Person[num+1];
                x[num+1] = new Person(userInputFN, userInputLN, userInputEA, userInputAge);
                
                goto Start;
            }
        }
    }
}
