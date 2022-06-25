using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DTO
{
    public class Medidor
    {
        private string nombre;

        private string codigo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
