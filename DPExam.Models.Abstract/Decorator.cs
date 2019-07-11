using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models.Abstract
{
    public abstract class Decorator : Computer
    {
        protected Computer _component;


        public Decorator(Computer component)
        {
            _component = component;
        }


        public override int GetCost()
        {
            if (_component != null)
            {
                return _component.GetCost();
            }
            else
            {
                return 0;
            }
        }
    }
}
