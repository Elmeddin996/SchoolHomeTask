using SchoolTaskInterface.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SchoolTaskInterface.Models
{
    public abstract class Teachers : ISchool
    {
        public string Name;
        public string SureName;
        public int Age;
        public virtual void PersonalInformation()
        {
            
        }

        public virtual void TimeAtSchool()
        {
            
        }
        public virtual void ClassHours()
        {

        }

        public abstract void Toteach();
       
    }
}
