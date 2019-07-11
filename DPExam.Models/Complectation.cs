using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{
    public class Complectation
    {
        private List<object> _parts = new List<object>();
        
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < _parts.Count; i++)
            {
                str += _parts[i].ToString() + " \n";
            }

            str = str.Remove(str.Length - 2);

            return "Computer parts: \n" + str + "\n";
        }
    }
}
