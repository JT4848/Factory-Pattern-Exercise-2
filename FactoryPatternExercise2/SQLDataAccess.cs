using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading SQL Database");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving SQL Database");
        }
    }
}
