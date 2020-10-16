using ClubFromage;
using System;
using Model.data;
using Model.buisness;
using System.Collections.Generic;
using System.Data;
using CsvHelper.TypeConversion;

namespace Model.data
{


public class daoFromage
{
    private DBAL _mydbal;
    private daoPays _myDaoPays;

    public daoFromage(DBAL BDD, daoPays DaoPays)
    {
        _mydbal = BDD;
        _myDaoPays = DaoPays;
    }

    public void Insert(Fromage Unfromage)
    {
        Console.WriteLine("INSERT INTO fromage (id,pays_origine_id,nom,creation,image) values (" + Unfromage.Id + ", " + Unfromage.Idpays.Id + ", '" + Unfromage.Nom + "', " + Unfromage.Creation + ", '" + Unfromage.Image + "') ;");
        _mydbal.Insert("INSERT INTO fromage (id,pays_origine_id,nom,creation,image) values (" + Unfromage.Id + ", " + Unfromage.Idpays.Id + ", '" + Unfromage.Nom + "', '" + Unfromage.Creation + "', '" + Unfromage.Image + "') ;");

    }

    public void Update(Fromage UnFromage)
    {
        _mydbal.Insert("UPDATE fromage set id = " + UnFromage.Id + ", id_pays_origin = " + UnFromage.Idpays.Id + ", nom = " + UnFromage.Nom + ",creation = '" + UnFromage.Creation + "', image = " + UnFromage.Image + " Where id = " + UnFromage.Id + " ;");

    }

    public void Delete(Fromage UnFromage)
    {
        _mydbal.Insert("DELETE FROM fromage where " + UnFromage.Id + " ;");

    }

    public List<Fromage>SelectAll()
        {
            List<Fromage> lesfromage = new List<Fromage>();
            foreach (DataRow DataR in _mydbal.SelectALL("fromage").Rows)
            {
                lesfromage.Add(new Fromage
                    (
                    (int)DataR["id"],
                    _myDaoPays.selectByID((int)DataR["pays_origin_id"]),
                    (string)DataR["nom"],
                    (string)DataR["creation"],
                    (string)DataR["image"]
                    )
                    );
              
            }

            return lesfromage;
        }

}
}