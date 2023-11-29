using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(10);
            game.OnWinnerFound += (sender, e) => Console.WriteLine($"Winner: Spin Number {e.SpinNumber}, Energy Level {e.EnergyLevel}, Winning Probability {e.WinningProbability}");
            game.Play();
            Console.ReadKey();
        }
    }
}
