using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{
    //This class will store the information created in the User class
    //Unlike the User Class, this class will have no function related to viewing or reading information related to a user.
    //This class purely exists for the other functions to read from, and data will only be received from the User Class

    //The steps for creating a User will be like this: UserEdit --> User --> Database
    //The steps for removing a User will be like this: Database --> UserEdit --> User --> Database
    //The steps for editing a User will be like this: Database --> UserEdit --> User --> Database
    //The steps for viewing and searching Users will be like this: Database --> User

    //The common thread in all of these cases is that UserEdit either writes for User or reads from Database
    //User and Database never write information, only presenting information written from UserEdit to the Class that asks for that information.


    //When it comes to the creation, re-creation or removal of data, the end destination should always be Database.
    //This should be obvious for the creation and re-creation of data.

    //When it comes to the removal, the reason for this is because UserEdit will tell User which User to remove,
    //and the User class will verify the existance of this data before telling the Database to delete the data that matches the request.

    

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
            Console.WriteLine($"\nCustomer '{removedName}' has been removed from the database.");
        }



    }
}
