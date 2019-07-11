using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPExam.Models.Abstract
{
    public interface IComputerBuilder
    {
        void BuildBody();

        void BuildVideoCard();

        void BuildMainCard();

        void BuildAudioCard();

        void BuildNetworkCard();

        void BuildHDD();

        void BuildSSD();

        void BuildMouse();

        void BuildKeyboard();
    }
}
