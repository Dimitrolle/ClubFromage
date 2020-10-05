using ClubFromage;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Bcpg;
using System;

public class daoPays
{
    private DBAL _connectionBDD;

    public daoPays(DBAL BDD)
    {
        _connectionBDD = BDD;
    }

    public void Insert(string larequete)
    {
		_connectionBDD.Insert("INSERT INTO pays " + larequete + " ;" );
        
    }

    public void Update(string larequete)
    {
        _connectionBDD.Insert("UPDATE pays set " + larequete + " ;"); ;

    }

    public void Delete(string condition)
    {
        _connectionBDD.Insert("DELETE FROM pays where " + condition + " ;");

    }
    

}
