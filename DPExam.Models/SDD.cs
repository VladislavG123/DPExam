using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{
    public class SSD : Decorator
    {
        public SSD(Computer comp) : base(comp)
        {
            Cost = 30000;
        }

        public override int GetCost()
        {
            return base.GetCost() + Cost;
        }

        public override string ToString()
        {
            return "SDD 256Gb " + Cost + "KZT";
        }
    }
}
