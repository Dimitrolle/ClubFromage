using ClubFromage;
using Org.BouncyCastle.Asn1.Cmp;
using System;

public class daoPays
{
	//public daoPays()
 //   {

 //   }

	private DBAL _connectionDBAL = new DBAL() ;

	public void Insert(string larequete)
    {
		_connectionDBAL.Insert("INSERT INTO pays " + larequete + " ;" );
    }
	
}
