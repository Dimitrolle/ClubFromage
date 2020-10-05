using MySql.Data.MySqlClient;
using System;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {
            DBAL MaBDD = new DBAL();
            Console.WriteLine("Bonjour !");
            daoPays db = new daoPays(DBAL);
            db.Insert(Console.ReadLine());
            db.Update(Console.ReadLine());
            db.Delete(Console.ReadLine());


        }
    }
}
