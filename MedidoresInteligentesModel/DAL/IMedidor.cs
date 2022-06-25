using MedidoresInteligentesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresInteligentesModel.DAL
{
    public interface IMedidor
    {

        List<Medidor> ObtenerMedidor();


        void AgregarMedidor(Medidor medidor);




    }
}
