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
    public partial class Docentes_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CN_Docente capaNegocio = new CN_Docente();

            CE_Docente x = capaNegocio.Consultar_Docente(Request["Id"]);

            Id_Oculto.Value = x.Id_Docente;
            Id_Docente.Text = x.Id_Docente;

            Nom_Docente.Text = x.Nom_Docente;
            Dire_Docente.Text = x.Dire_Docente;
            Tel_Docente.Text = Convert.ToString(x.Tel_Docente);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Id_Docente = Request["Id_Oculto"];

            CN_Docente capaNegocio = new CN_Docente();

            capaNegocio.Eliminar_Docente(Id_Docente);

            Response.Redirect("Docentes_Select.aspx");
        }
    }
}