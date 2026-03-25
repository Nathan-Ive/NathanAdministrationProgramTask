using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{
    //This class stores all the User information in a list.
    //To do that, it instantiates a new user and stores it in the list that's created thanks to the constructor.
    //The functions in this class exist to fetch information for the program itself to use in its private functions.

    

    internal class UserDatabase
    {
        private List<User> userList;
        public UserDatabase() 
        {
            userList = new List<User>();
        }


        //This is public since I want the Handler functions to access this.
        public void AddUser(User user)
        {
            userList.Add(user);
            Console.WriteLine($"\nUser '{user.Name}' has been added successfully.");
        }

        public void ViewAllUsers()
        {
            if (userList.Count == 0)
            {
                Console.WriteLine("\nNo users found in the database.");
                return;
            }

            Console.WriteLine("\n===== User List =====");

            // Using a for loop to have a "ID" number next to every user.
            // This way the user will know what to input when UserEdit is added.
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine($"\n--- User {"ID: " + (i + 1)} ---");
                Console.WriteLine($"    Name:           {userList[i].Name}");
                Console.WriteLine($"    Address:        {userList[i].Address}");
                Console.WriteLine($"    Phone Number:   {userList[i].PhoneNumber}");
                Console.WriteLine($"    Age:            {userList[i].Age}");
            }

            Console.WriteLine("\n=========================");
            Console.ReadLine();
        }

        //These are public, since it's necessary for the UserEdit and UserRemove functions to know the "ID" of the user.
        public int GetUserCount()
        {
            return userList.Count;
        }


        public User GetUserAtIndex(int index)
        {
            return userList[index];
        }

        public void RemoveUser(int index)
        {
            string removedName = userList[index].Name;
            userList.RemoveAt(index);
            Console.WriteLine($"\nUser '{removedName}' has been removed from the database.");
        }



    }
}
