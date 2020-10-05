using MySql.Data.MySqlClient;
using System.IO;
using System;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bonjour !");
            //DBAL db = new DBAL();
            //db.Insert(Console.ReadLine());

            
                int compteur = 0;
                string ligne;
                Char caractere = ';';
            //sans CSVhelper
                StreamReader fichier = new StreamReader(@"D:\Dimitri DEFRESNE\fichier csv\Pays.csv");

                while ((ligne = fichier.ReadLine()) != null)
                {
                    String[] substrings = ligne.Split(caractere);

                    foreach (var substring in substrings)
                    {
                    
                        Console.WriteLine(substring);
                    }

                    compteur++;
                 
                }

                fichier.Close();
                System.Console.WriteLine("Nombre de lignes : {0}.", compteur);
            }

        
    }
}
