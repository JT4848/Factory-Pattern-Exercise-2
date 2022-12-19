using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading List Database");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving List Database");
        }
    }
}
