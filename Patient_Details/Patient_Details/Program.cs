using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Details
{
  

namespace HospitalManagement
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<Patient> patients = new List<Patient>();

                Console.WriteLine("Welcome to ABC Hospital");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Enter details for Patient {i + 1}:");

                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Gender: ");
                    string gender = Console.ReadLine();

                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Phone Number: ");
                    string phoneNumber = Console.ReadLine();

                    Console.Write("State: ");
                    string state = Console.ReadLine();

                    Console.Write("Pincode: ");
                    string pincode = Console.ReadLine();

                    Console.WriteLine("Select the department for the treatment:");
                    Console.WriteLine("1. General              : 400");
                    Console.WriteLine("2. ENT                  : 800");
                    Console.WriteLine("3. Cardiology           : 1200");
                    Console.WriteLine("4. Operation Theater    : 5000");
                    Console.WriteLine("5. Intensive care Unit  : 6000");
                    Console.Write("Department choice: ");
                    int departmentChoice = int.Parse(Console.ReadLine());

                    int treatmentCost = 0;

                    switch (departmentChoice)
                    {
                        case 1:
                            treatmentCost = 400;
                            break;
                        case 2:
                            treatmentCost = 800;
                            break;
                        case 3:
                            treatmentCost = 1200;
                            break;
                        case 4:
                            treatmentCost = 5000;
                            break;
                        case 5:
                            treatmentCost = 6000;
                            break;
                        default:
                            Console.WriteLine("Invalid department choice. Setting treatment cost to 0.");
                            break;
                    }

                    Patient patient = new Patient
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Gender = gender,
                        Age = age,
                        PhoneNumber = phoneNumber,
                        State = state,
                        Pincode = pincode,
                        Department = (Department)departmentChoice,
                        TreatmentCost = treatmentCost
                    };

                    patients.Add(patient);

                    Console.WriteLine("Patient details added successfully!\n");
                }

                Console.Write("Enter Phone Number to search: ");
                string searchPhoneNumber = Console.ReadLine();

                Patient foundPatient = patients.Find(p => p.PhoneNumber == searchPhoneNumber);

                if (foundPatient != null)
                {
                    Console.WriteLine("Patient Found:");
                    Console.WriteLine($"Name: {foundPatient.FirstName} {foundPatient.LastName}");
                    Console.WriteLine($"Gender: {foundPatient.Gender}");
                    Console.WriteLine($"Age: {foundPatient.Age}");
                    Console.WriteLine($"Phone Number: {foundPatient.PhoneNumber}");
                    Console.WriteLine($"State: {foundPatient.State}");
                    Console.WriteLine($"Pincode: {foundPatient.Pincode}");
                    Console.WriteLine($"Department: {foundPatient.Department}");
                    Console.WriteLine($"Treatment Cost: {foundPatient.TreatmentCost}");

                    // Generate and display the bill
                    Console.WriteLine("\n------ Patient Bill ------");
                    Console.WriteLine($"Patient Name: {foundPatient.FirstName} {foundPatient.LastName}");
                    Console.WriteLine($"Phone Number: {foundPatient.PhoneNumber}");
                    Console.WriteLine($"Department: {foundPatient.Department}");
                    Console.WriteLine($"Treatment Cost: {foundPatient.TreatmentCost}");
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }
        }

        public class Patient
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public string PhoneNumber { get; set; }
            public string State { get; set; }
            public string Pincode { get; set; }
            public Department Department { get; set; }
            public int TreatmentCost { get; set; }
        }

        public enum Department
        {
            General = 1,
            ENT = 2,
            Cardiology = 3,
            OperationTheater = 4,
            IntensiveCareUnit = 5
        }
    }

}
    
