using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{

    //This class exists to store the functions that have the basic validity checks that are to be used in the AdminProgram class
    //Beyond that, it basically shows the program what is required information for a new user to exist.
    //Static is used here because I want these checks to exist before a new user is instantiated.

    internal class User
    {
        //Getters and setters are both public, since I want the UserEdit function to be able to access them later.
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public User(string name, string address, string phoneNumber, int age)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Age = age;
        }

        public static bool IsValidName(string name)
        {
            //For when someone inputs nothing
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            // Checks each character in the string "name" for a digit, if it's a digit the name is considered invalid.
            foreach (char letter in name)
            {
                if (char.IsDigit(letter))
                {
                    return false;
                }
            }

            return true;
        }

        //House Address requires both letters and numbers, so I'm leaving the input check simple.
        public static bool IsValidAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return false;
            }

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                char c = phoneNumber[i];

                
                if (c == '+' && i == 0)
                {
                    continue;
                }

                //Same thing as the foreach loop in the name, but insteads only accepts digits, since most phone numbers don't have letters anymore.
                if (char.IsDigit(c) || c == ' ' || c == '-')
                {
                    continue;
                }

                return false;
            }

            return true;
        }


        //The most simple check, it'll only return as true if the age is between 0 and 130, and anything else will return as false.
        //The oldest person alive was apperantly 122, so I don't want it to be too much higher than that.
        public static bool IsValidAge(int age)
        {
            return age >= 0 && age <= 130;
        }

    }
}