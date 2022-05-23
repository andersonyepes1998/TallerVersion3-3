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
    public partial class Docentes_Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string contenido = "";

            CN_Docente capaNegocio = new CN_Docente();

            List<CE_Docente> lista = capaNegocio.Consultar_Docentes();

            foreach (CE_Docente x in lista)
            {
                contenido = contenido + "<tr>";
                contenido = contenido + "<td>" + x.Id_Docente + "</td>";
                contenido = contenido + "<td>" + x.Nom_Docente + "</td>";
                contenido = contenido + "<td>" + x.Dire_Docente + "</td>";
                contenido = contenido + "<td>" + x.Tel_Docente + "</td>";
                contenido = contenido + "<td><a href='Docentes_Update.aspx?Id=" + x.Id_Docente + "'>modificar</a></td>";
                contenido = contenido + "<td><a href='Docentes_Delete.aspx?Id=" + x.Id_Docente + "'>eliminar</a></td>";
                contenido = contenido + "</tr>";

            }

            tabla_body.InnerHtml = contenido;
        }
    }
}