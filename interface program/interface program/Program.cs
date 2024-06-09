using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_program
{
  
           
        internal class Program
        {


            interface IDrivable
            {
                void Start();
                void Stop();
                void Drive();
            }

            class Car : IDrivable
            {
                public void Start()
                {
                    Console.WriteLine("Car starting...");
                }

                public void Stop()
                {
                    Console.WriteLine("Car stopping...");
                }

                public void Drive()
                {
                    Console.WriteLine("Car driving...");
                }
            }

            class Bicycle : IDrivable
            {
                public void Start()
                {
                    Console.WriteLine("Bicycle starting...");
                }

                public void Stop()
                {
                    Console.WriteLine("Bicycle stopping...");
                }

                public void Drive()
                {
                    Console.WriteLine("Bicycle riding...");
                }
            }

            class objects
            {
                static void Main(string[] args)
                {
                    IDrivable[] vehicles = new IDrivable[4];
                    vehicles[0] = new Car();
                    vehicles[1] = new Car();
                    vehicles[2] = new Bicycle();
                    vehicles[3] = new Bicycle();

                    foreach (var vehicle in vehicles)
                    {
                        Console.WriteLine("Enter '1' to Stop, '2' to Start, '3' to Drive:");
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                vehicle.Stop();
                                break;
                            case 2:
                                vehicle.Start();
                                break;
                            case 3:
                                vehicle.Drive();
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }

                        Console.WriteLine();
                    }
                }
            }

        }
}

    
       
