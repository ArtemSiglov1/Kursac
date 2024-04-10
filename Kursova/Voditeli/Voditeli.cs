using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Voditeli
    {
        public int Id { get; set; }
       public FullName FullName{get;set;}
        public double Experience {  get; set; }
        public int ExperienceLevel { get; set; }
        public double Salary {  get; set; }
        public int Route {  get; set; }
        public int Schedule {  get; set; }
        public Voditeli() { }
        public Voditeli(int id, FullName fullName, double experience, int experienceLevel, int route, int schedule)
        {
            Id = id;
            FullName = ValidateFullName(fullName);
            Experience = experience;
            ExperienceLevel = experienceLevel;
            Salary = Salary1();
            Route = route;
            Schedule = schedule;
        }
        public static Voditeli Init()
        {
            try
            {
                Console.WriteLine("id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Full Name:");
                FullName fullName = FullName.Init();
                Console.WriteLine("Experience:");
                double exp = double.Parse(Console.ReadLine());
                Console.WriteLine("Experience Level:");
                int expLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Route:");
                int route = int.Parse(Console.ReadLine());
                Console.WriteLine("Schedule:");
                int schedule = int.Parse(Console.ReadLine());
                return new Voditeli(id, fullName, exp, expLevel, route, schedule);
            }
            catch { return Init(); }
        }
        private FullName ValidateFullName(FullName fullName)
        {
            try
            {
                if (string.IsNullOrEmpty(fullName.FirstName) ||
                    string.IsNullOrEmpty(fullName.LastName))
                {
                    throw new Exception();
                }
            }
            catch { Console.WriteLine(new ArgumentException("Имя и фамилия не могут быть пустыми")) ;fullName= FullName.Init(); }
            
            
            try
            {
                foreach (char c in fullName.FirstName + fullName.LastName + fullName.MiddleName)
                {
                    if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                    {
                        throw new Exception();
                    }
                }
            }
            catch { Console.WriteLine( new ArgumentException("буквы только русской расскладки")); fullName = FullName.Init(); }
            return fullName;

        }

        int  Salary1()
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
            return $"Id-{Id}\nFIO:\n{FullName.ToString()}\nСтаж-{Experience}\nКласс-{ExperienceLevel}\nДоход-{Salary}\nМаршрут-{Route}\nГрафик-{Schedule}";
        }
        
        
    }
}
