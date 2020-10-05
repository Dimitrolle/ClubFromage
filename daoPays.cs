using ClubFromage;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Bcpg;
using System;

public class daoPays
{
    private DBAL _mydbal;
    

    public daoPays(DBAL BDD)
    {
       
        _mydbal = BDD;
    }

    public void Insert(Pays Unpays)

    {
        _mydbal.Insert("INSERT INTO pays (id,nom) values (" + Unpays.Id +", '"+ Unpays.Nom + "');" );
        
    }

    public void Update(Pays Unpays)
    {
        _mydbal.Insert("UPDATE pays set id = " + Unpays.Id+", nom = '"+Unpays.Nom+"' where  id = "+Unpays.Id + " ;"); ;

    }

    public void Delete(Pays Unpays)
    {
        _mydbal.Insert("DELETE FROM pays where id = " + Unpays.Id + " ;");

    }
    

}
