using MySql.Data.MySqlClient;
using System;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour !");
            Connection db = new Connection();
            db.Insert();
            

            
        }
    }
}
