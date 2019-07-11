using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{
    public class Keyboard : Decorator
    {
        public Keyboard(Computer comp) : base(comp)
        {
            Cost = 5000;
        }

        public override int GetCost()
        {
            return base.GetCost() + Cost;
        }

        public override string ToString()
        {
            return "KeyBoard " + Cost + "KZT";
        }

    }
}
