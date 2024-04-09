using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Route
    {
        public int Id { get; set; }
        public int Nom {  get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public DateTime Timestart { get; set; }
        public DateTime Timeend { get; set; }
        public Route() { }
    }
}
