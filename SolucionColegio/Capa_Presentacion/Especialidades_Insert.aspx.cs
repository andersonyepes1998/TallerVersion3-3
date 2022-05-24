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
    public partial class Especialidades_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CE_Especialidad nuevo = new CE_Especialidad();
            nuevo.Id_Especialidad = Id_Especialidad.Text;
            nuevo.Nom_Especialidad = Nom_Especialidad.Text;

            CN_Especialidad capaNegocio = new CN_Especialidad();

            capaNegocio.guardar_especialidad(nuevo);

            Response.Redirect("Especialidades_Select.aspx");
        }
    }
}