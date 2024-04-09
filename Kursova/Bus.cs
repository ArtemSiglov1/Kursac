using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Bus
    {
        public Bus() { }
        public string GosNom {  get; set; }
        public string Tip { get; set; }
        private string IsValidGosNom(string gosNom)
        {
            if (gosNom == null || !Regex.IsMatch(gosNom, @"^[А-С]{1}\d{3}[А-Я]{2}$"))
            {
                throw new ArgumentException("Номер телефона должен начинаться с '+37377' и содержать одну цифру от 4 до 9, а затем любые 5 цифр.");
            }
            return gosNom;
        }
    }
}
