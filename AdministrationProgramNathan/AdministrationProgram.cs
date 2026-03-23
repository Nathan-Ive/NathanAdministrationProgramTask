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
            Console.WriteLine($"Welcome to the Administration Program!");

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
                    case "add customer":
                        //HandleAddUser();
                        break;
                    case "2":
                    case "two":
                    case "view customers":
                        //database.ViewAllUsers();
                        break;
                    case "3":
                    case "three":
                    case "edit customer":
                        //HandleEditUser();
                        break;
                    case "4":
                    case "four":
                    case "remove customer":
                        //HandleRemoveUser();
                        break;
                    case "5":
                    case "five":
                    case "search by age":
                        //HandleSearchByAge();
                        break;
                    case "6":
                    case "six":
                    case "exit":
                        Console.WriteLine($"Goodbye!");
                        isRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Invalid input. Please choose a number between 1 and 6.");
                        break;
                }

            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine($"===== Main Menu =====");
            Console.WriteLine($"1. Add User");
            Console.WriteLine($"2. View Users");
            Console.WriteLine($"3. Edit Users");
            Console.WriteLine($"4. Remove User");
            Console.WriteLine($"5. Search by Age");
            Console.WriteLine($"6. Exit");
            Console.Write($"\nInput an option: ");
        }

        //At the moment this is just an example for the function here. When the User and UserDatabase classes are done, this can be made.

        private void HandleAddUser()
        {
            Console.WriteLine("\n--- Add New Customer ---");

            string name = PromptForName("Enter name: ");
            string address = PromptForAddress("Enter address: ");
            string phoneNumber = PromptForPhoneNumber("Enter phone number: ");
            int age = PromptForAge("Enter age: ");


            User newUser = new User(name, address, phoneNumber, age);
            //database.AddUser(newUser);
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


    }
}
