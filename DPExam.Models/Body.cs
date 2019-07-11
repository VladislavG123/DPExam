using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{
    public class Body : Decorator
    {
        public Body(Computer comp) : base(comp)
        {
            Cost = 10000;
        }

        public override int GetCost()
        {
            return base.GetCost() + Cost;
        }

        public override string ToString()
        {
            return "Body " + Cost + "KZT";
        }
    }
}
