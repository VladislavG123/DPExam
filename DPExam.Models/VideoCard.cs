using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{
    public class VideoCard : Decorator
    {
        public VideoCard(Computer comp) : base(comp)
        {
            Cost = 50000;
        }

        public override int GetCost()
        {
            return base.GetCost() + Cost;
        }

        public override string ToString()
        {
            return "GTX 1050Ti " + Cost + "KZT";
        }
    }
}
