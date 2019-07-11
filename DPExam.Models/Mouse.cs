using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{
    public class Mouse : Decorator
    {
        public Mouse(Computer comp) : base(comp)
        {
            Cost = 1000;
        }

        public override int GetCost()
        {
            return base.GetCost() + Cost;
        }

        public override string ToString()
        {
            return "Mouse " + Cost + "KZT";
        }
    }
}


