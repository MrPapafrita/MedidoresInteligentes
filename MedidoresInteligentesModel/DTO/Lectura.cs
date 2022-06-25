using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DTO
{
    public class Lectura
    {
        private Medidor medidor;
        private String fecha;
        private int hora;
        private int minuto;
      private int cantidad;

        public Medidor Medidor { get => medidor; set => medidor = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Minuto { get => minuto; set => minuto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
