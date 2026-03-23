using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{

    //This class dictates the user information, name, adress, contact info and age.
    //Since the constructor is immediately called on when a user is made, I have to make sure that the program doesn't allow for wrong information for any of these.
    
    //The name can't have numbers or symbols in it
    //The Phone number can't be longer than a certain amount of characters
    //The age can't be below zero or above a certain amount of the highest recorded age.
    //So, this class will be the only place 
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

        //I need this to happen before User gets saved to a list, therefore it has to be public static, since I want this to always be checked.
        //This should be fine since it's just a boolean. 
        //I'll be following the same logic for the other three input fields.
        public static bool IsValidName(string name)
        {
            //For when someone inputs too many spaces in their name
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


        //The most simple one, it'll only return as true if the age is between 0 and 150, and anything else will return as false.
        public static bool IsValidAge(int age)
        {
            return age >= 0 && age <= 150;
        }

    }
}
