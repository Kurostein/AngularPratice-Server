using System.IO;

namespace PizzaStore.Data.Logger
{
    public class SqlLogger
    {
        public SqlLogger()
        {

        }

        public static void WriteSql(string data)
        {
            string path = "C:\\Users\\Cloudbuilt\\Documents\\Visual Studio 2015\\Projects\\WebApplication2\\Log.txt";
            File.AppendAllText(path, data);
        }
    }
}
