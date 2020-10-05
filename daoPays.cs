using ClubFromage;
using Org.BouncyCastle.Asn1.Cmp;
using System;

public class daoPays
{


	private DBAL _connectionDBAL = new DBAL() ;

	public void Insert(string larequete)
    {
		_connectionDBAL.Insert("INSERT INTO pays " + larequete + " ;" );
        
    }

    public void Update(string larequete)
    {
        _connectionDBAL.Insert("UPDATE " + larequete + " ;"); ;

    }

    public void Delete(string larequete)
    {
        _connectionDBAL.Insert("DELETE FROM " + larequete + " ;");

    }


}
