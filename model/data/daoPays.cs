using ClubFromage;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Bcpg;
using System;
using System.IO;
using System.Globalization;
using CsvHelper;
using Model.data;
namespace Model.data
{

    public class daoPays
{
    private DBAL _mydbal;
    

    public daoPays(DBAL BDD)
    {
       
        _mydbal = BDD;
    }

    public void Insert(Pays Unpays) //insérer une ligne

    {
        Console.WriteLine("INSERT INTO pays (id,nom) values (" + Unpays.Id + ", '" + Unpays.Nom + "');");
        _mydbal.Insert("INSERT INTO pays (id,nom) values (" + Unpays.Id +", '"+ Unpays.Nom.Replace("'", "''") + "');" );
        
    }

    public void Update(Pays Unpays)// mettre à jour une ligne
    {
        _mydbal.Update("UPDATE pays set id = " + Unpays.Id+", nom = '"+Unpays.Nom+"' where  id = "+Unpays.Id + " ;"); ;

    }

    public void Delete(Pays Unpays) //supprimer une ligne
    {
        _mydbal.Delete("DELETE FROM pays where id = " + Unpays.Id + " ;");

    }
    //CSVHelper
    public void MainCSV()
    {
        using (var reader = new StreamReader("pays.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Configuration.Delimiter = ";";
            csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
            //var records = csv.GetRecords<Pays>();
            var record = new Pays();
            var records = csv.EnumerateRecords(record);

            foreach (var item in records)
            {
                this.Insert(item);
            }
        }
    }





}
}