using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolTaskInterface.Models
{
    internal class FirstGuard:SchoolSecuritys
    {
        
        public override void PersonalInformation()
        {

            this.Name = "Royal";
            this.SureName = "Musayev";
            this.Age = 30;


            Console.WriteLine($"Guard's name: {Name}");
            Console.WriteLine($"Guard's surename: {SureName}");
            Console.WriteLine($"Guard's age: {Age}");
        }

        public override void TimeAtSchool()
        {
            Console.WriteLine("The guard spends 12 hours a day at school");
        }
        public override void UniformWear()
        {
            Console.WriteLine("The guard must wear a uniform");
        }
    }
}
