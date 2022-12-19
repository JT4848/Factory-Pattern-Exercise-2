namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of database would you like to use?  ");
            Console.WriteLine();
            Console.WriteLine("Type \"list\" for a list data access");
            Console.WriteLine("Type \"sql\" for a sql data access");
            Console.WriteLine("Type \"mongo\" for a mongo data access");


            string userInput = Console.ReadLine();

            IDataAccess databaseObject = DataAccessFactory.GetDataAccessType(userInput);


            databaseObject.LoadData();
            databaseObject.SaveData();
        }
    }
}
