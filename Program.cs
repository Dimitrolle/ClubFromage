﻿using MySql.Data.MySqlClient;
using System.IO;
using System;
using Model.buisness;
using Model.data;
using System.ComponentModel.Design;
using System.Data;

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

            //DataSet RQUERY
            //DataSet dataS = MaBDD.RQuery("Select * from pays ;"); //instancie un objet dataset (bdd) grace a ma MaBDD.query
            //foreach (DataRow Undata in dataS.Tables[0].Rows)
            //{
            //    //pour un objet datarow qui sera dans Undata dans la tables dataS a chaque ligne
                    
            //        Console.WriteLine(Undata["id"]+ " "+ Undata["nom"]);
                   
                

            //}





            //daoP.MainCSV();


            // Pays p3 = new Pays(3,"Chine");
            // Fromage fromage1 = new Fromage(1, p3, "tome", "2010-03-19", "ttt");

            //daoF.Insert(fromage1);

            //daoP.Insert(p3);
            //daoP.Update(p3);
            //daoP.Delete(p3);


        }

    }
}
