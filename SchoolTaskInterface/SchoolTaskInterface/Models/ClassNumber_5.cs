using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTaskInterface.Models
{
    internal class ClassNumber_5 : Students
    {
        public override void ClassHours()
        {
            Console.WriteLine("Students of this class have 30 lessons per week");
        }
        public override void ToStudy()
        {
            Console.WriteLine("Students should be educated");
        }

        public override void UniformWear()
        {
            Console.WriteLine("The students must wear a uniform");
        }
    }
}
