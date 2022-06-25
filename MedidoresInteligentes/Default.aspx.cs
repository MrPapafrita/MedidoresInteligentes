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
    public partial class Default : System.Web.UI.Page
    {
        private IMedidor medidoresDal = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Medidor> medidor = medidoresDal.ObtenerMedidor();
                this.grillaMedidores.DataSource = medidor;
                this.grillaMedidores.DataBind();
            }

        }

        protected void CargaGrilla()
        {


            List<Medidor> medidor = medidoresDal.ObtenerMedidor();
            this.grillaMedidores.DataSource = medidor;
            this.grillaMedidores.DataBind();


        }


        protected void grillaMedidores_RowCommand(object sender,GridViewCommandEventArgs e )
        {


        }



    }
}