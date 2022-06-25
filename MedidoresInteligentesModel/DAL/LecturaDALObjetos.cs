using MedidoresInteligentesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DAL
{
    public class LecturaDALObjetos : ILectura
    {

        private static List<Lectura> lecturas = new List<Lectura>();

        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
            

        }


        public List<Lectura> ObtenerLectura()
        {
            return lecturas;



        }



    }
}
