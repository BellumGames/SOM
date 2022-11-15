using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM
{
    class Neuron 
    {
        public float x { get; set; }
        public float y { get; set; }
        public int row { get; set; }
        public int col { get; set; }
        public Neuron(Neuron temp)
        {
            x = temp.x;
            y = temp.y;
            row = temp.row;
            col = temp.col;
        }

        public Neuron()
        {
        }
    }
}
