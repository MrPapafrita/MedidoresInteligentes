using MedidoresInteligentesModel.DAL;
using MedidoresInteligentesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresInteligentes
{

   
    public partial class VerLecturas : System.Web.UI.Page
    {

        private ILectura lecturaDal = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Lectura> lecturas = lecturaDal.ObtenerLectura();
            this.grillaLecturas.DataSource = lecturas;

            this.grillaLecturas.DataBind();


        }

        protected void CargaGrilla()
        {

            List<Lectura> lecturas = lecturaDal.ObtenerLectura();
            this.grillaLecturas.DataSource = lecturas;

            this.grillaLecturas.DataBind();


        }
        
    }
}