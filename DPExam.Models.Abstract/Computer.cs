using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models.Abstract
{
    // Абстрактный класс компьютера который позволяет выводить и вводить цену и получать стоимость всех компонентов
    public abstract class Computer
    {
        public int Cost { get; set; }

        public abstract int GetCost();
    }
}
