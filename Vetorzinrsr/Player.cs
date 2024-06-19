using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetorzinrsr
{
    internal class Player
    {
        //Atributos
       private string _name;
       private int _score;
       private TimeSpan _gametime;

        public Player(string name) {
            _name = name;
            _score = 0;
            _gametime = TimeSpan.FromSeconds(0);
        }

        public string Name
        {
            get { return _name; }
            set { 
                if (string .IsNullOrEmpty(value))
                    _name = value;
            }
        }
    }
}
