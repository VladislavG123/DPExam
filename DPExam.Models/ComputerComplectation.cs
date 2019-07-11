using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{
    public class ComputerComplectation : IComputerBuilder
    {
        private Complectation _complectation = new Complectation();
        
        public ComputerComplectation()
        {
            Reset();
        }

        public void Reset()
        {
            _complectation = new Complectation();
        }

        public void BuildAudioCard()
        {
            _complectation.Add("AudioCard");
        }

        public void BuildBody()
        {
            _complectation.Add("Body");
        }

        public void BuildHDD()
        {
            _complectation.Add("HDD 1Tb");
        }

        public void BuildKeyboard()
        {
            _complectation.Add("Keyboard");
        }

        public void BuildMainCard()
        {
            _complectation.Add("Maincard");
        }

        public void BuildMouse()
        {
            _complectation.Add("Mouse");
        }

        public void BuildNetworkCard()
        {
            _complectation.Add("Network Card");
        }

        public void BuildSSD()
        {
            _complectation.Add("SSD 265Gb");
        }

        public void BuildVideoCard()
        {
            _complectation.Add("GTX 1050Ti");
        }

        public Complectation GetComplectation()
        {
            Complectation result = _complectation;

            Reset();

            return result;
        }
    }
}
