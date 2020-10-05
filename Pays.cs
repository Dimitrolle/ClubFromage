using System;

public class Pays
{
    private int _id;
    private string _nom;
	public Pays(int UnID,string UnNom)
	{
		_id = UnID;
		_nom = UnNom;
	}

    public string Nom { get => _nom; set => _nom = value; }
    protected int Id { get => _id; set => _id = value; }
}
