using SchoolTaskInterface.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTaskInterface.Models
{
    public abstract class Students:ISchool
    {
        public abstract void ToStudy();
        
        public void TimeAtSchool()
        {
        }

        public virtual void ClassHours()
        {
        }

        public virtual void UniformWear()
        {
        }

    }
}
