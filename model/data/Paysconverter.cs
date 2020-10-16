using System;
using System.Collections.Generic;
using System.Text;
using Model.buisness;
using CsvHelper.Expressions;
using CsvHelper.TypeConversion;
using System.IO;
using Model.data;
using System.Globalization;
using System.Data;

namespace Model.data
{
    
    public class Paysconverter : DefaultTypeConverter
    {
        public Pays ConvertFromString(string text)
        {
            return new Pays(
                int.Parse(text.Substring(0,text.IndexOf(';'))),
                text.Substring(text.IndexOf(';') + 1));
        }

        public string ConvertToString(object value)
        {
            return Paysconverter.SerializeObject(value);
        }
    }
}
