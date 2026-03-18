using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{

    //This class exists to edit information within the User Class
    //This class will be intended to: Add users, Remove users, Adjust/Edit user information
    //To summarize, this Class will specialize in writing and sending user information to the User class.
    internal class UserEdit
    {

        private string _name;
        private string _homeAdress;
        private string _phoneNumber;
        private string _emailAdress;
        private string _ageInput;
        private int _age;



        //The AddUser class will use getters and setters to only write to and provide access to the User class
        private void AddUser() 
        {
            UserAddEditInput();

            Console.WriteLine($"New user information has been sent to be verified in the database.");
            User newUser = new User(_name, _homeAdress, _phoneNumber, _emailAdress, _age);
        }


        //The EditUser class will use getters and setters to only receive from, write to and provide access for the User class
        private void EditUser() 
        {
            Console.WriteLine($"What user do you want to edit?");
            Console.Write($"Input the user's ID number here: ");
            Console.ReadLine();

            UserAddEditInput();
        }



        private void UserAddEditInput() 
        {
            Console.Write($"Please insert a name: ");
            _name = Console.ReadLine();
            Console.Clear();

            Console.Write($"Please insert your adress: ");
            _homeAdress = Console.ReadLine();
            Console.Clear();

            Console.Write($"Please insert your phone number: ");
            _phoneNumber = Console.ReadLine();
            Console.Clear();

            Console.Write($"Please insert your e-mail adress: ");
            _emailAdress = Console.ReadLine();
            Console.Clear();

            Console.Write($"Please insert your current age: ");
            _ageInput = Console.ReadLine();
            if (!Int32.TryParse(_ageInput, out _age))
            {

            }
            else
            {
                Console.WriteLine($"Incorrect age input, try again.");

            }
            Console.Clear();

        }

    }
}




