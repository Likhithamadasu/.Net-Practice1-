using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_details
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
                Console.WriteLine($"Name: {Name}, Title: {Title}, Gender: {Gender}, Age: {Age}, Base Salary: {BaseSalary}, Bonus: {CalculateBonus()}");
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
                return 0.2 * BaseSalary; // Delivery Partner gets 20% bonus
            }

            public override void DisplayFullDetails()
            {
                Console.WriteLine($"Name: {Name}, Title: {Title}, Gender: {Gender}, Age: {Age}, Base Salary: {BaseSalary}, Bonus: {CalculateBonus()}");
            }
        }

        class details
        {
            static void Main(string[] args)
            {
                Manager manager = new Manager("John Doe", "Manager", "Male", 35, 50000);
                manager.DisplayFullDetails();

                DeliveryPartner deliveryPartner = new DeliveryPartner("Jane Smith", "Delivery Partner", "Female", 28, 30000);
                deliveryPartner.DisplayFullDetails();
            }
        }

    }
}



