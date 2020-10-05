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

    public void Insert(string larequete)
    {
        _mydbal.Insert("INSERT INTO fromage (id,pays_origine_id,nom,creation,image) values (" + larequete + ") ;");

    }

    public void Update(string coloneetvaleur,string condition)
    {
        _mydbal.Insert("UPDATE fromage set " + coloneetvaleur + " Where "+ condition + " ;"); ;

    }

    public void Delete(string condition)
    {
        _mydbal.Insert("DELETE FROM fromage where " + condition + " ;");

    }

}
