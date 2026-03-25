using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{
    //Handles menu navigation and user interface tasks, instantiates all other classes as well.

    internal class AdministrationProgram
    {
        UserDatabase database;

        public AdministrationProgram()
        {
            database = new UserDatabase();
        }

        public void StartProgram()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Administration Program!");

            bool isRunning = true;

            //The while loop runs the program until the user decides to exit with option 6.
            while (isRunning)
            {
                
                DisplayMenu();
                string input = Console.ReadLine();

                // The only switch cases that can function at the moment are AddUser and ViewAllUsers.
                // All the other ones like EditUser and RemoveUser will be made later and in a seperate feature branch, but they'll all be made in this class.
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                    case "add user":
                    case "add users":
                        HandleAddUser();
                        break;
                    case "2":
                    case "two":
                    case "view user":
                    case "view users":
                        database.ViewAllUsers();
                        Console.Clear();
                        break;
                    case "3":
                    case "three":
                    case "edit user":
                    case "edit users":
                        //HandleEditUser();
                        break;
                    case "4":
                    case "four":
                    case "remove user":
                    case "remove users":
                        HandleRemoveUser();
                        break;
                    case "5":
                    case "five":
                    case "search by age":
                        //HandleSearchByAge();
                        break;
                    case "6":
                    case "six":
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        isRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Invalid input. Please choose a number between 1 and 6.");
                        break;
                }

            }
        }




        //All private functions for this class go below here.



        private void DisplayMenu()
        {
            Console.WriteLine("===== Main Menu =====");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. View Users");
            Console.WriteLine("3. Edit Users");
            Console.WriteLine("4. Remove User");
            Console.WriteLine("5. Search by Age");
            Console.WriteLine("6. Exit");
            Console.Write("\nInput an option: ");
        }

        //At the moment this is just an example for the function here. When the User and UserDatabase classes are done, this can be made.

        private void HandleAddUser()
        {
            Console.Clear();
            Console.WriteLine("\n--- Add New User ---");

            string name = PromptForName("Enter name: ");
            string address = PromptForAddress("Enter home address: ");
            string phoneNumber = PromptForPhoneNumber("Enter phone number: ");
            int age = PromptForAge("Enter age: ");


            User newUser = new User(name, address, phoneNumber, age);
            database.AddUser(newUser);
        }

        private void HandleEditUser()
        {
            Console.Clear();
            Console.WriteLine("\n--- Add New User ---");
            // TODO: — implement this method.
            // General approach:
            // 1. Check if the database is empty first (use database.GetUserCount())

            int count = database.GetUserCount();
            if (count == 0) 
            {
                Console.WriteLine("\nNo users found in the database.");
                return;
            }

            // 2. Show all users so the person can pick one (database.ViewAllUsers())
            database.ViewAllUsers();


            // 3. Ask which customer number to edit
            Console.WriteLine("Enter the ID number of the user you want to edit.");
            Console.WriteLine("Edit User: ");
            string input = Console.ReadLine();

            // 4. Ask which field to edit (name, address, phone, age)
            Console.WriteLine("Enter the aspect of the user you want to edit");
            Console.WriteLine("\n---Name, Home Address, Phone Number, Age---");
            Console.WriteLine("Change User: ");

            // 5. Use the same PromptFor methods to get validated new input

            switch (input.ToLower()) 
            {
                case "name":
                    string name = PromptForName("Enter new name: ");
                    
                    break;
                case "home address":
                case "homeaddress":
                    string address = PromptForAddress("Enter new address: ");
                    break;
                case "phone number":
                case "phonenumber":
                    string phoneNumber = PromptForPhoneNumber("Enter new phone number: ");
                    break;
                case "age":
                    int age = PromptForAge("Enter new age: ");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input, please specify one of the provided aspects.");
                    
                    break;
            
            }

            // 6. Use the User's public setters to update the value
            // Something like: database.GetUserAtIndex(index).Name = newName;

        }



        private void HandleRemoveUser()
        {
            if (database.GetUserCount() == 0)
            {
                Console.WriteLine("\nNo customers found in the database.");
                return;
            }

            database.ViewAllUsers();
            int userCount = database.GetUserCount();

            while (true)
            {
                Console.Write("\nEnter the customer number to remove: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice >= 1 && choice <= userCount)
                {
                    //Subtract by 1 for the index number.
                    int index = choice - 1;
                    database.RemoveUser(index);
                    return;
                }
                Console.WriteLine($"Invalid choice. Please enter a number between 1 and {userCount}.");
            }
        }




        private string PromptForName(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (User.IsValidName(input))
                {
                    return input;
                }

                Console.WriteLine("Invalid name. Names cannot be empty or contain numbers.");
            }
        }

        private string PromptForAddress(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (User.IsValidAddress(input))
                {
                    return input;
                }

                Console.WriteLine("Invalid address. Address cannot be empty.");
            }
        }

        private string PromptForPhoneNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (User.IsValidPhoneNumber(input))
                {
                    return input;
                }

                Console.WriteLine("Invalid phone number. Use only digits, spaces, dashes, or a leading +.");
            }
        }

        private int PromptForAge(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int age))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (User.IsValidAge(age))
                {
                    return age;
                }

                Console.WriteLine("Invalid age. Age must be between 0 and 130.");
            }
        }

    }
}
