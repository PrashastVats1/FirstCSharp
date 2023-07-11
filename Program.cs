using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");
            //Console.ReadKey();
            /*string firstName;
            string lastName;
            Console.WriteLine("Enter first name");
            firstName=Console.ReadLine();
            Console.WriteLine("Enter last name");
            lastName=Console.ReadLine();
            Console.WriteLine("Welcome Mr.//Ms. " + firstName +" "+ lastName);
            Console.ReadKey();
            */
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter grade");
            grade=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary");
            salary=double.Parse(Console.ReadLine());
            Console.WriteLine("Name: \t" + name + "\n Age: \t" + age +
                "\n Grade: \t" + grade + "\n Salary: \t" + salary + "\n Date of Joining: \t" + doj);
            Console.ReadKey();
        }
    }
}
