using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Areglos
{
    public class Positions
    {
        public int position { get; set; }
        public bool Available { get; set; }

        public Positions(int id, bool availability)
        {
            this.position = id;
            this.Available = availability;
        }

    }

}
