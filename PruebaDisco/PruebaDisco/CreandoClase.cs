using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDisco
{
    public class CreandoClase
    {
        private string prueba;
        private int count;
        public CreandoClase()
        {

        }

        public string Prueba { get => prueba; set => prueba = value; }
        public int Count { get => count; set => count = value; }
        public CreandoClase(string prueba, int count)
        {
            this.prueba = prueba;
            this.count = count;
        }

    }
}
