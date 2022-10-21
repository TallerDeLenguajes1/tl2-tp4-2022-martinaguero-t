using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCtest.Models
{
    public class Turno
    {
        private int idTurno;
        private string nombreCliente;

        public int IdTurno { get => idTurno; set => idTurno = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
    }
}