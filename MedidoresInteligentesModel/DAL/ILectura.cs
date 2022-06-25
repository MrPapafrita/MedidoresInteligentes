using MedidoresInteligentesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DAL
{
    public interface ILectura
    {
        List<Lectura> ObtenerLectura();

        void AgregarLectura(Lectura lectura);



    }
}
