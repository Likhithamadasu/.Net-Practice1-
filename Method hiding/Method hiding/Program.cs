using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_hiding
{
    internal class Program
    {
        public class Employee
        {
            public string Name { get; set; }
            public string Title { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public double BaseSalary { get; set; }

            public Employee()
            {
            }

            public Employee(string name, string title, string gender, int age, double baseSalary)
            {
                Name = name;
                Title = title;
                Gender = gender;
                Age = age;
                BaseSalary = baseSalary;
            }

            public virtual double CalculateBonus()
            {
                return 0;
            }

            public virtual void DisplayFullDetails()
            {
                Console.WriteLine($"Name: {Name}, Title: {Title}, Gender: {Gender}, Age: {Age}, Base Salary: {BaseSalary}");
            }
        }

        public class Manager : Employee
        {
            public Manager()
            {
            }

            public Manager(string name, string title, string gender, int age, double baseSalary) : base(name, title, gender, age, baseSalary)
            {
            }

            public override double CalculateBonus()
            {
                return 0.1 * BaseSalary;
            }

            public override void DisplayFullDetails()
            {
                double bonus = CalculateBonus();
                Console.WriteLine($"Name: {Name}, Title: {Title}, Gender: {Gender}, Age: {Age}, Base Salary: {BaseSalary}, Bonus: {bonus}, Total Salary: {BaseSalary + bonus}");
            }

            public new void DisplayFullDetails(string message)
            {
                Console.WriteLine($"{message} - Manager: {Name}, Title: {Title}, Gender: {Gender}, Age: {Age}, Base Salary: {BaseSalary}");
            }
        }

        public class DeliveryPartner : Employee
        {
            public DeliveryPartner()
            {
            }

            public DeliveryPartner(string name, string title, string gender, int age, double baseSalary) : base(name, title, gender, age, baseSalary)
            {
            }

            public override double CalculateBonus()
            {
                return 0.2 * BaseSalary;
            }

            public override void DisplayFullDetails()
            {
                double bonus = CalculateBonus();
                Console.WriteLine($"Name: {Name}, Title: {Title}, Gender: {Gender}, Age: {Age}, Base Salary: {BaseSalary}, Bonus: {bonus}, Total Salary: {BaseSalary + bonus}");
            }
        }

        public class Developer : Employee
        {
            public Developer()
            {
            }

            public Developer(string name, string title, string gender, int age, double baseSalary) : base(name, title, gender, age, baseSalary)
            {
            }

            public override double CalculateBonus()
            {
                return 0.15 * BaseSalary;
            }

            public override void DisplayFullDetails()
            {
                double bonus = CalculateBonus();
                Console.WriteLine($"Name: {Name}, Title: {Title}, Gender: {Gender}, Age: {Age}, Base Salary: {BaseSalary}, Bonus: {bonus}, Total Salary: {BaseSalary + bonus}");
            }
        }

        class Programs
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Developer Details:");
                Console.Write("Name: ");
                string developerName = Console.ReadLine();
                Console.Write("Title: ");
                string developerTitle = Console.ReadLine();
                Console.Write("Gender: ");
                string developerGender = Console.ReadLine();
                Console.Write("Age: ");
                int developerAge = int.Parse(Console.ReadLine());
                Console.Write("Base Salary: ");
                double developerBaseSalary = double.Parse(Console.ReadLine());

                Developer developer = new Developer(developerName, developerTitle, developerGender, developerAge, developerBaseSalary);

                Console.WriteLine("\nEnter Manager Details:");
                Console.Write("Name: ");
                string managerName = Console.ReadLine();
                Console.Write("Title: ");
                string managerTitle = Console.ReadLine();
                Console.Write("Gender: ");
                string managerGender = Console.ReadLine();
                Console.Write("Age: ");
                int managerAge = int.Parse(Console.ReadLine());
                Console.Write("Base Salary: ");
                double managerBaseSalary = double.Parse(Console.ReadLine());

                Manager manager = new Manager(managerName, managerTitle, managerGender, managerAge, managerBaseSalary);

                Console.WriteLine("\nEnter Delivery Partner Details:");
                Console.Write("Name: ");
                string partnerName = Console.ReadLine();
                Console.Write("Title: ");
                string partnerTitle = Console.ReadLine();
                Console.Write("Gender: ");
                string partnerGender = Console.ReadLine();
                Console.Write("Age: ");
                int partnerAge = int.Parse(Console.ReadLine());
                Console.Write("Base Salary: ");
                double partnerBaseSalary = double.Parse(Console.ReadLine());

                DeliveryPartner deliveryPartner = new DeliveryPartner(partnerName, partnerTitle, partnerGender, partnerAge, partnerBaseSalary);

                Console.WriteLine("\nDeveloper Details:");
                developer.DisplayFullDetails();

                Console.WriteLine("\nManager Details:");
                manager.DisplayFullDetails();

                Console.WriteLine("\nDelivery Partner Details:");
                deliveryPartner.DisplayFullDetails();


                Console.WriteLine("\nMethod Hiding Demonstration:");
                manager.DisplayFullDetails("Welcome");
            }
        }

    }
}


   
