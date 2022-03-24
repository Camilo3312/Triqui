using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Areglos
{
    public class Player : Board
    {
        private int id { get; set; }
        private string username { get; set; }

        public Player (int id_, string username_) : base (3,3)
        {
            id = id_;
            username = username_;
        }

    }
}
