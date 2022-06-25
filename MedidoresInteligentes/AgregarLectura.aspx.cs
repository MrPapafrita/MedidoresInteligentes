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
    public partial class AgregarLectura : System.Web.UI.Page
    {

        private ILectura lecturaDal = new LecturaDALObjetos();
        private IMedidor medidorDal = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Medidor> medidores = medidorDal.ObtenerMedidor();
            this.medidorDdl.DataSource = medidores;
            this.medidorDdl.DataTextField ="Nombre";
            this.medidorDdl.DataTextField = "Codigo";
            this.medidorDdl.DataBind();
        }


        protected void AgregarLecturaBtn_Click(object sender, EventArgs e)
        {
            String medidorNombre = this.medidorDdl.SelectedItem.Text;

            String medidorCodigo = this.medidorDdl.SelectedItem.Text;

            String fecha = this.Fecha.Text.Trim();

            int hora = Convert.ToInt32(this.Hora.Text.Trim());

            int minuto = Convert.ToInt32(this.Minuto.Text.Trim());

            int cantidad = Convert.ToInt32(this.Cantidad.Text.Trim());

           

            List<Medidor> medidores = medidorDal.ObtenerMedidor();

            Medidor medidor = medidores.Find(b => b.Codigo == this.medidorDdl.SelectedItem.Value);

            

            Lectura lectura = new Lectura()
            {
              Medidor =  medidor,
              Fecha = fecha,
              Hora = hora,
              Minuto = minuto,
              Cantidad = cantidad




            };
            lecturaDal.AgregarLectura(lectura);

            this.mensajeLbl.Text = "lectura ingresado :D";

            Response.Redirect("VerLecturas.aspx");
        }
    }
}