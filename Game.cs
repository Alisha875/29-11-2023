using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    public class Game
    {
        public delegate void WinnerDelegate(object sender, SpinEventArgs e);
        public event WinnerDelegate OnWinnerFound;

        private int _noOfSpin = 5;
        private int _energyLevel = 1;
        private int _winningProbability = 100;

        public Game(int noOfSpin)
        {
            _noOfSpin = noOfSpin;
        }

        public void Play()
        {
            for (int i = 1; i <= _noOfSpin; i++)
            {
                int random = new Random().Next(1, 4);

                switch (random)
                {
                    case 1:
                        _energyLevel++;
                        _winningProbability += 10;
                        break;
                    case 2:
                        _energyLevel += 2;
                        _winningProbability += 20;
                        break;
                    case 3:
                        _energyLevel -= 3;
                        _winningProbability -= 30;
                        break;
                }

                Console.WriteLine($"{i} Spin: Energy Level {_energyLevel}, Winning Probability {_winningProbability}");

                if (i == _noOfSpin && _energyLevel >= 4 && _winningProbability > 60)
                {
                    OnWinnerFound?.Invoke(this, new SpinEventArgs { SpinNumber = i, EnergyLevel = _energyLevel, WinningProbability = _winningProbability });
                }
            }
        }
    }
}
