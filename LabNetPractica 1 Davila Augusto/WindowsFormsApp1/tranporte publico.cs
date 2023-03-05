using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Vehiculo
    {
        public string Nombre { get; set; }
        public int NumPasajeros { get; set; }
        public string Tipo { get; set; } // Propiedad para almacenar el tipo de vehículo

        public override string ToString()
        {
            return $"{Nombre} ({NumPasajeros} pasajeros)";
        }
    }
}
