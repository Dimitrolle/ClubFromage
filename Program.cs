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
            daoPays daoP = new daoPays(MaBDD); // nouvel instance dao avec un DBAL
            //daoP.Insert(Console.ReadLine());
            //Console.WriteLine("insert fait");
            //daoP.Update(Console.ReadLine());
            //Console.WriteLine("update fait");
            //daoP.Delete(Console.ReadLine());
            //Console.WriteLine("delete fait");
            daoFromage daoF = new daoFromage(MaBDD, daoP);
            daoF.Insert(Console.ReadLine());
            Console.WriteLine("insert fait");
            daoF.Update(Console.ReadLine());
            Console.WriteLine("update fait");
            daoF.Delete(Console.ReadLine());
            Console.WriteLine("delete fait");

        }

    }
}
