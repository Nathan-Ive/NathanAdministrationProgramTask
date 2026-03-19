using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgramNathan
{
    internal class AdministrationProgram
    {
        public void StartProgram() 
        {
            NavigationCommands navigationCommands = new NavigationCommands();
            UserDatabase userDatabase = new UserDatabase();
            navigationCommands.StartingInput();
        }

        private void EndProgram() 
        {
            DatabaseFileSaver databaseFileSaver = new DatabaseFileSaver();
        }
    }
}
