using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AdministrationProgram AdminProgram = new AdministrationProgram();
            AdminProgram.StartProgram();

        }


        //Bonus Notes:
        //New things I learned during this project
        //  1. The existence of \n for structure in the console.
        //  2. The proper way a public static modifier can be used.
        //  3. The instances where a function should be private and how to incorperate that into the rest of the class.
        //  4. Continue statements, and how to use them.
        //  5. Alternative uses for the "return" statement within void functions.
        //  6. 

        //Things that were challenging during this project
        //  1. Researching and finding the reason why static modifiers would be used.
        //  2. Initially, thinking of what functions should be private and public, and why they should be public.
        //      The challenge comes from public functions requiring me to think ahead as to what could possibly want to use them.
        //  3. 



        //Things I was unable to do during this project
        //  1. For the name validity verification, I was unable to make it so that I could detect special characters like @ or ? and !.
        //      I was hoping to be able to have the program detect all special characters without including the spacebar,
        //      but I couldn't find any way of doing that. So, in the end I had to settle with just excluding numbers.
        //  2. 
    }
}
