using MySql.Data.MySqlClient;
using System.IO;
using System;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {

            DBAL MaBDD = new DBAL();//nouvel instance DBAL
            Console.WriteLine("Bonjour !");
            daoPays db = new daoPays(MaBDD); // nouvel instance dao avec un DBAL
            db.Insert(Console.ReadLine());
            Console.WriteLine("insert fait");
            db.Update(Console.ReadLine());
            Console.WriteLine("update fait");
            db.Delete(Console.ReadLine());
            Console.WriteLine("delete fait");


        }

    }
}
