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
        private int _age;


        public void AddUser() 
        {
            Console.Write($"Please insert a name: ");
            Console.ReadLine();
            Console.Clear();
            Console.Write($"Please insert your adress: ");
            Console.ReadLine();
            Console.Clear();
            Console.Write($"Please insert your phone number: ");
            Console.ReadLine();
            Console.Clear();
            Console.Write($"Please insert your e-mail adress: ");
            Console.ReadLine();
            Console.Clear();
            Console.Write($"Please insert your current age: ");
            Console.ReadLine();
            Console.Clear();

            User newUser = new User(_name, _homeAdress, _phoneNumber, _emailAdress, _age);

        }

    }
}
