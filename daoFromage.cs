using ClubFromage;
using System;

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
        _mydbal.Insert("UPDATE fromage set id = " + UnFromage.Id + ", id_pays_origin = " + UnFromage.Idpays + ", nom = " + UnFromage.Nom + ",creation = " + UnFromage.Creation + ", image = " + UnFromage.Image + " Where id = " + UnFromage.Id + " ;");

    }

    public void Delete(Fromage UnFromage)
    {
        _mydbal.Insert("DELETE FROM fromage where " + UnFromage.Id + " ;");

    }

}
