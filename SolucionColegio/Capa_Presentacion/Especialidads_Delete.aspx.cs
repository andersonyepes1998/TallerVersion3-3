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
    public partial class Especialidads_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CN_Especialidad capaNegocio = new CN_Especialidad();

            CE_Especialidad x = capaNegocio.consultar_especialidad(Request["Id"]);

            Id_Oculto.Value = x.Id_Especialidad;
            Id_Especialidad.Text = x.Id_Especialidad;
            Nom_Especialidad.Text = x.Nom_Especialidad;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Id_Especialidad = Request["Id_Oculto"];

            CN_Especialidad capaNegocio = new CN_Especialidad();

            capaNegocio.eliminar_especialidad(Id_Especialidad);

            Response.Redirect("Especialidades_Select.aspx");
        }
    }
}