using System;

public class Fromage 
{
	private int _id;
    private Pays _idpays;
    private string _nom;
    private DateTime _creation;
    private string _image;

   

    public Fromage(int unID,Pays Unpays,string UnNom,DateTime uneDate,string UneImage)
	{
        _id = unID;
        _idpays = Unpays;
        _nom = UnNom;
        _creation = uneDate;
        _image = UneImage;
	}

    public int Id { get => _id; set => _id = value; }
    public Pays Idpays { get => _idpays; set => _idpays = value; }
    public string Nom { get => _nom; set => _nom = value; }
    public DateTime Creation { get => _creation; set => _creation = value; }
    public string Image { get => _image; set => _image = value; }
}
