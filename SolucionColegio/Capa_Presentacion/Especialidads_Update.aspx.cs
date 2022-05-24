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
    public partial class Especialidads_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request["Id"];

            CN_Especialidad capaNegocio = new CN_Especialidad();

            CE_Especialidad x = capaNegocio.consultar_especialidad(Id);

            Id_Especialidad.Text = x.Id_Especialidad;
            Nom_Especialidad.Text = x.Nom_Especialidad;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CE_Especialidad existente = new CE_Especialidad();
            existente.Id_Especialidad = Request["Id_Especialidad"];
            existente.Nom_Especialidad = Request["Nom_Especialidad"];

            CN_Especialidad capaNegocio = new CN_Especialidad();

            capaNegocio.modificar_especialidad(existente);

            Response.Redirect("Especialidades_Select.aspx");
        }
    }
}