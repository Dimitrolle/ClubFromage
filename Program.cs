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
            Pays p3 = new Pays(3,"Chine");
            //daoP.Insert(p3);
            //p3.Nom = "Japon";
            //daoP.Update(p3);
            //daoP.Delete(p3);


        }

    }
}
