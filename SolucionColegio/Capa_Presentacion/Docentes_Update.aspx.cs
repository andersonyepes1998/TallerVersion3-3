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
    public partial class Docentes_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request["Id"];

            CN_Docente capaNegocio = new CN_Docente();

            CE_Docente x = capaNegocio.Consultar_Docente(Id);

            Id_Docente.Text = x.Id_Docente;
            Nom_Docente.Text = x.Nom_Docente;
            Dire_Docente.Text = x.Dire_Docente;
            Tel_Docente.Text = Convert.ToString(x.Tel_Docente);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CE_Docente existente = new CE_Docente();
            existente.Id_Docente = Request["Id_Docente"];
            existente.Nom_Docente = Request["Nom_Docente"];
            existente.Dire_Docente = Request["Dire_Docente"];
            existente.Tel_Docente = Convert.ToInt32(Request["Tel_Docente"]);

            CN_Docente capaNegocio = new CN_Docente();

            capaNegocio.Modificar_Docente(existente);

            Response.Redirect("Docentes_Select.aspx");
        }
    }
}