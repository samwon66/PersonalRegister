using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace PersonalRegister
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int salary) 
        {
           FirstName = firstName;
           LastName = lastName;
           Salary = salary;
        }

        public string PrintOut()
        {
            return $"Förnamn : {FirstName}\n" +
                   $"Efternamn: {LastName}\n" +
                   $"Lön: {Salary}\n";
                   
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] register = new Person[] { };
            Menu();
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                Console.WriteLine("Mata in förnamnet: ");
                string newFirstName = Console.ReadLine();
                Console.WriteLine("Mata in efternamnet: ");
                string newLastName = Console.ReadLine();
                Console.WriteLine("Mata in lönen: ");
                int newSalary = Convert.ToInt32(Console.ReadLine());
                Person person = new Person(newFirstName, newLastName, newSalary);
                break;

                case 2:
                Console.WriteLine("Du har valt att skriva ut registern.");
                foreach (Person item in register) 
                {
                        item.PrintOut();
                }
                Console.ReadLine();
                break;

                default:
                    Console.WriteLine("Du har angett ett ogiltigt val, var god och försök igen!");
                    break;
            }
            
        }
            static void Menu()
            {
                Console.WriteLine("Välkommen till personalregister");
                Console.WriteLine("Välj ett alternativ.");
                Console.WriteLine("1. Registera en ny personal.");
                Console.WriteLine("2. Skriva ut registern.");
            }

            
    }

}