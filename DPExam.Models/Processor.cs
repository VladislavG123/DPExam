using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{
    public class Processor : Computer
    {
        public Processor()
        {
            Cost = 20000;
        }

        public override int GetCost()
        {
            return Cost;
        }

        public override string ToString()
        {
            return "Processsor " + Cost + "KZT";
        }
    }
}
