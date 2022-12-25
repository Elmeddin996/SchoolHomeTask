using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTaskInterface.Models
{
    internal class SportTeacher:Teachers
    {
      
        public override void PersonalInformation()
        {
            this.Name = "Ilkin";
            this.SureName = "Memmedov";
            this.Age = 35;


            Console.WriteLine($"Teacher's name: {Name}");
            Console.WriteLine($"Teacher's surename: {SureName}");
            Console.WriteLine($"Teacher's age: {Age}");
        }

        public override void TimeAtSchool()
        {
            Console.WriteLine("Sports teacher spends 30 hours a week at school");
        }

        public override void ClassHours()
        {
            Console.WriteLine("The sports teacher teaches 20 hours a week");
        }
        public override void Toteach()
        {
            Console.WriteLine("Sport teachers must teach sport the students");
        }
    }
}
