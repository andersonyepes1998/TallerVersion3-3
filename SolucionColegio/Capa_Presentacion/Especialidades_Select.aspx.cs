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
    public partial class Especialidades_Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string contenido = "";

            CN_Especialidad capaNegocio = new CN_Especialidad();

            List<CE_Especialidad> lista = capaNegocio.consultar_Especialidades();

            foreach (CE_Especialidad x in lista)
            {
                contenido = contenido + "<tr>";
                contenido = contenido + "<td>" + x.Id_Especialidad + "</td>";
                contenido = contenido + "<td>" + x.Nom_Especialidad + "</td>";
                contenido = contenido + "<td><a href='Especialidads_Update.aspx?Id=" + x.Id_Especialidad + "'>modificar</a></td>";
                contenido = contenido + "<td><a href='Especialidads_Delete.aspx?Id=" + x.Id_Especialidad + "'>eliminar</a></td>";
                contenido = contenido + "</tr>";

            }

            tabla_body.InnerHtml = contenido;
        }
    }
}