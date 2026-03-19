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

        public UserDatabase() 
        {
            Console.WriteLine($"Welcome to the User Administration Program");
            Console.WriteLine();
            Console.WriteLine($"1. Add new user");
            Console.WriteLine($"2. Remove existing user");
            Console.WriteLine($"3. Edit existing user");
            Console.WriteLine($"4. View existing user");
            Console.WriteLine($"5. Search by category");
            Console.WriteLine($"6. Exit Program & Save Database");
            Console.WriteLine();
            Console.Write($"Input Field: ");
        }


        public List<User> userDB = new List<User>();


        public void ReceiveUserInfo() 
        {
            
        }

    }
}
