﻿using System;

namespace Model.buisness
{
    public class Fromage
    {
        private int _id;
        private Pays _idpays;
        private string _nom;
        private string _DateCreation;
        private string _image;



        public Fromage(int unID, Pays Unpays, string UnNom, string uneDate, string UneImage)
        {
            _id = unID;
            _idpays = Unpays;
            _nom = UnNom;
            _DateCreation = uneDate;
            _image = UneImage;
        }

        public int Id { get => _id; set => _id = value; }
        public Pays Idpays { get => _idpays; set => _idpays = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Creation { get => _DateCreation; set => _DateCreation = value; }
        public string Image { get => _image; set => _image = value; }
    }
}
