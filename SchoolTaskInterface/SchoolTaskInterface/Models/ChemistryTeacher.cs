using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTaskInterface.Models
{
    public class ChemistryTeacher : Teachers
    {
        
        public override void PersonalInformation()
        {

            this.Name="Sudabe";
            this.SureName = "Memmedova";
            this.Age = 45;

            Console.WriteLine($"Teacher's name: {Name}");
            Console.WriteLine($"Teacher's surename: {SureName}");
            Console.WriteLine($"Teacher's age: {Age}");
        }

        public override void TimeAtSchool()
        {
            Console.WriteLine("Chemistry teacher spends 50 hours a week at school");
        }
        public override void ClassHours()
        {
            Console.WriteLine("The chemistry teacher teaches 30 hours a week");
        }
        public override void Toteach()
        {
            Console.WriteLine("Chemistry teachers must teach chemistry the students");
        }
    }
}
