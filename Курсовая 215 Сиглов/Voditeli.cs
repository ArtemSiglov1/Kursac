using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_215_Сиглов
{

    internal class Voditeli:водителиDataSet
    {
       //public abstract string водителиDataSet()
            

            
    string surname;
        string name;
        string otchestvo;
        double stag;
        double oklad;
        string marshr;
        DateTime grafik;

        public string Surname { get => surname == "" ? "Фамилия не введена":surname; set => surname = value; }
        public string Name { get => name == "" ? "Имя не введено" : name; set => name = value; }
        public string Otchestvo { get => otchestvo == "" ? "Отчество не введено" : otchestvo; set => otchestvo = value; }
        public double Stag { get => stag; set => stag = value; }
        public double Oklad { get => oklad; set => oklad = value; }
        public string Marshr { get => marshr == "" ? "Маршрут не введен" : marshr; set => marshr = value; }
        public DateTime Grafik { get => grafik; set => grafik = value; }

        public Voditeli(string surname) { this.surname = surname; }
        public Voditeli(string surname, string name, string otchestvo, double stag, double oklad, string marshr, DateTime grafik )
        {
            Surname =surname;
            Name = name;
            Otchestvo = otchestvo;
            Stag = stag;
            Oklad = oklad;
            Marshr = marshr;
            Grafik = grafik;
            
            
        }
        
    }
    
}
