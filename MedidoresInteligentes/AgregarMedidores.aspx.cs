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

    public partial class AgregarMedidores : System.Web.UI.Page
    {
        private IMedidor medidorDal = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AgregarMedidorBtn_Click(object sender, EventArgs e)
        {

            String nombre = this.Nombre.Text.Trim();

            String codigo = this.Codigo.Text.Trim();

            Medidor medidor = new Medidor()
            {
                Nombre = nombre,
                Codigo = codigo

            };
            medidorDal.AgregarMedidor(medidor);

            this.mensajeLbl.Text = "medidor ingreso :D";

            Response.Redirect("Default.aspx");
        }
    }
}