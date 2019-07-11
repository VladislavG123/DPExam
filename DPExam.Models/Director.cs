using DPExam.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models
{

    public class Director
    {
        private IComputerBuilder _builder;

        public IComputerBuilder Builder
        {
            set { _builder = value; }
        }

        public void Basic()
        {
            _builder.BuildBody();
            _builder.BuildMainCard();
            _builder.BuildAudioCard();
            _builder.BuildNetworkCard();
            _builder.BuildHDD();
        }

        public void Full()
        {
            _builder.BuildBody();
            _builder.BuildVideoCard();
            _builder.BuildMainCard();
            _builder.BuildAudioCard();
            _builder.BuildNetworkCard();
            _builder.BuildHDD();
            _builder.BuildSSD();
            _builder.BuildMouse();
            _builder.BuildKeyboard();
        }
    }
}
