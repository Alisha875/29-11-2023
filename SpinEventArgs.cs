using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    public class SpinEventArgs : EventArgs
    {
        public int SpinNumber { get; set; }
        public int EnergyLevel { get; set; }
        public int WinningProbability { get; set; }
    }
}
