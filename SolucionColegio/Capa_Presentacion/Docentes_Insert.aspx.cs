using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa_Presentacion
{
    public partial class Docentes_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CE_Docente nuevo = new CE_Docente();
            nuevo.Id_Docente = Id_Docente.Text;
            nuevo.Nom_Docente = Nom_Docente.Text;
            nuevo.Dire_Docente = Dir_Docente.Text;
            nuevo.Tel_Docente = Convert.ToInt32(Tel_Docente.Text);

            CN_Docente capaNegocio = new CN_Docente();

            capaNegocio.guardar_Docente(nuevo);

            Response.Redirect("Docentes_Select.aspx");
        }
    }
}