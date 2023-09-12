using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace PersonalRegister
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public Person(string firstName, string lastName, int salary) 
        {
           FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person peterS = new Person("Peter", "Svensson", 25000);
            Person yvonneA = new Person("Yvonne", "Andersson", 30000);
            Person martenB = new Person("Mårten", "Beck", 27000);


        }
    }
}