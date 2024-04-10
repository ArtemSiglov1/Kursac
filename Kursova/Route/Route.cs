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
        public string GosNom {  get; set; }
        public int VoditelId { get; set; }
        public Route() { }
        public Route(int id, int nom, string start, string end, DateTime timestart, DateTime timeend,string gosNom , int voditelId)
        {
            Id = id;
            Nom = nom;
            Start = start;
            End = end;
            Timestart = timestart;
            Timeend = timeend;
            GosNom = gosNom;
            VoditelId=voditelId;
        }
        public override string ToString()
        {
            return $"Id-{Id}\nNom-{Nom}\nStart-{Start}\nEnd-{End}\nTime Start-{Timestart}\nTime";
        }
        public Route Init()
        {
            Console.WriteLine("Id:");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Nom:");
            int nom=int.Parse(Console.ReadLine());
            Console.WriteLine("Start:");
            string start = Console.ReadLine();
            Console.WriteLine("End:");
            string end = Console.ReadLine();
            Console.WriteLine("Time Start:");
            DateTime timeStart=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Time End:");
            DateTime timeEnd=DateTime.Parse(Console.ReadLine());
            
            string gosNom="";
           
            int voditelId = 0;
            return new Route(id,nom,start,end,timeStart,timeEnd,gosNom,voditelId);
        }
       
    }
}
