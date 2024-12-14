using System;
using System.Collections.Generic;

namespace PersonManagementSystem
{
    public class Person
    {
        private int personID;
        private string name;
        private int age;
        private string address;

        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"PersonID: {personID}, Name: {name}, Age: {age}, Address: {address}");
        }

        public void UpdateAddress(string newAddress)
        {
            address = newAddress;
            Console.WriteLine("Address updated successfully.");
        }
    }

    public class PersonManager
    {
        private List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            if (persons.Exists(p => p.PersonID == person.PersonID))
            {
                Console.WriteLine("Error: PersonID must be unique.");
                return;
            }
            persons.Add(person);
            Console.WriteLine("Person added successfully.");
        }

        public void DisplayAllPersons()
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("No persons found.");
                return;
            }

            foreach (var person in persons)
            {
                person.DisplayInfo();
            }
        }

        public void SearchPerson(string name)
        {
            var foundPersons = persons.FindAll(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (foundPersons.Count == 0)
            {
                Console.WriteLine("No person found with the given name.");
            }
            else
            {
                foreach (var person in foundPersons)
                {
                    person.DisplayInfo();
                }
            }
        }

        public void UpdatePersonAddress(int id, string newAddress)
        {
            var person = persons.Find(p => p.PersonID == id);
            if (person != null)
            {
                person.UpdateAddress(newAddress);
            }
            else
            {
                Console.WriteLine("No person found with the given ID.");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            PersonManager manager = new PersonManager();
            while (true)
            {
                Console.WriteLine("\nPerson Information Management System");
                Console.WriteLine("1. Add a Person");
                Console.WriteLine("2. Display All Persons");
                Console.WriteLine("3. Search for a Person");
                Console.WriteLine("4. Update Address");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Person ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();

                        Person person = new Person
                        {
                            PersonID = id,
                            Name = name,
                            Age = age,
                            Address = address
                        };
                        manager.AddPerson(person);
                        break;

                    case 2:
                        manager.DisplayAllPersons();
                        break;

                    case 3:
                        Console.Write("Enter Name to search: ");
                        string searchName = Console.ReadLine();
                        manager.SearchPerson(searchName);
                        break;

                    case 4:
                        Console.Write("Enter Person ID to update address: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter new address: ");
                        string newAddress = Console.ReadLine();
                        manager.UpdatePersonAddress(updateId, newAddress);
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
