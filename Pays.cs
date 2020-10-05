using System;

public class Pays
{
	private int _id;
	private string _nom;
	public Pays(int UnID,string NomPays)
	{
		_id = UnID;
		_nom = NomPays;


	}

    public int Id { get => _id; set => _id = value; }
    public string Nom { get => _nom; set => _nom = value; }
}
