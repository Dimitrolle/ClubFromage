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
            daoFromage daoF = new daoFromage(MaBDD, daoP);
            Pays p3 = new Pays(3,"Chine");
            Fromage fromage1 = new Fromage(1, p3, "tome", "2010-03-19", "ttt");

            daoF.Insert(fromage1);
           // daoF.Delete(fromage1);


            //daoP.Insert(p3);
            //daoP.Update(p3);
            //daoP.Delete(p3);


        }

    }
}
