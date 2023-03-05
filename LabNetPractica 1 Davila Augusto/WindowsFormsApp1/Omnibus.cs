using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Omnibus
    {
        private int pasajeros;

        public int PPasajeros { get; set; }

        public Omnibus(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public void avanzar()
        {

        }
        public void detenerse()
        {

        }
    }
}
