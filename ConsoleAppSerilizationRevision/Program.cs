using ConsoleAppSerializationRevision;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSerilizationRevision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {
                Id = 1,
                Name = "Test",
                Team = "Team"
            };
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\Users\\mohit\\Desktop\\MphasisWork\\DOTNET Projects\\ConsoleAppSerilizationRevision\\Player.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, player);
            stream.Close();

            stream = new FileStream("C:\\Users\\mohit\\Desktop\\MphasisWork\\DOTNET Projects\\ConsoleAppSerilizationRevision\\Player.txt", FileMode.Open, FileAccess.Read);
            Player dslrPlayer = (Player)formatter.Deserialize(stream);
            Console.WriteLine("Player Details");
            Console.WriteLine("Player id " + player.Id);
            Console.WriteLine("Player Name " + player.Name);
            Console.WriteLine("Player Team "+ player.Team);
            Console.ReadLine();

        }
    }
}
