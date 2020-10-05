using MySql.Data.MySqlClient;
using System;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {
            DBAL MaBDD = new DBAL(); //instanciation d'un nouvel connection BDD
            daoPays db = new daoPays(MaBDD); //

            Console.WriteLine("Bonjour !"); //messag de bienvenue
            db.Insert(Console.ReadLine()); //insérer des données dans la BDD
            db.Update(Console.ReadLine()); //mise à jour d'un donnée
            db.Delete(Console.ReadLine()); //supprimé les données


        }
    }
}
