using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{

    //This class will display all Customer(User) Information
    //Intended to be used with: View users, Searching user information, Reading saved customer information from a JSON file
    
    //Note: Does NOT contain user information, that information will be written and stored in a different "Database" Class.
    
    //To summarize, this Class will specialize in reading and presenting user information that is created in the UserEdit Class.
    //It will also be able to read and present data from an existing JSON file on startup that contains the relevant information for the program.
    internal class User
    {

        public string Name { get; private set; }
        public string Adress { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public int Age { get; private set; }

        public User(string name, string adress, string phoneNumber, string email, int age)
        {
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Email = email;
            Age = age;
        }


        private void VerifyUserInfo() 
        { 

        
        
        }

        private void SendUserInfoToDB() 
        {
            

        
        
        }

    }
}
