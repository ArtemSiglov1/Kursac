using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Voditeli
    {
        public Guid Id { get; set; }
        public string Surname {  get; set; }
        public string Name {  get; set; }
        public string MidleName {  get; set; }
        public double Experience {  get; set; }
        public int ExperienceLevel { get; set; }
        public double Salary {  get; set; }
        public int Route {  get; set; }
        public int Schedule {  get; set; }
        public Voditeli() { }
        public Voditeli(Guid id, string surname, string name, string midleName, double experience, int experienceLevel, int route, int schedule)
        {
            Id = id;
            Surname = surname;
            Name = name;
            MidleName = midleName;
            Experience = experience;
            ExperienceLevel = experienceLevel;
            Salary = Salary1();
            Route = route;
            Schedule = schedule;
        }

        int Salary1()
        {
            if(Experience<5||ExperienceLevel==3)
            {
                return 3600;
            }
            else if(Experience>5&&Experience<10||ExperienceLevel==2) {
                return 4200;
            }
            else if(Experience >10 || ExperienceLevel == 1){
                return 5400;
            }
            else { return 1500; }
        }
        public override string ToString()
        {
            return $"Фамилия-{Surname}\nИмя-{Name}\nФамилия{MidleName}\nСтаж-{Experience}\nКласс-{ExperienceLevel}\nДоход-{Salary}\nМаршрут-{Route}\nГрафик-{Schedule}";
        }
        
    }
}
