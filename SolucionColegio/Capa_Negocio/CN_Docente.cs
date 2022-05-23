using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Docente
    {
        CD_Docente capaDatos = new CD_Docente();

        public bool guardar_Docente(CE_Docente oprefesor4)
        {
            return capaDatos.guardar_Docente(oprefesor4);
        }

        public bool Modificar_Docente(CE_Docente oprofesor5)
        {
            return capaDatos.Modificar_Docente(oprofesor5);
        }

        public bool Eliminar_Docente(string id)
        {
            return capaDatos.Eliminar_Docente(id);
        }

        public CE_Docente Consultar_Docente(string id)
        {
            return capaDatos.Consultar_Docente(id);
        }

        public List<CE_Docente> Consultar_Docentes()
        {
            return capaDatos.Consultar_Docentes();
        }
    }
}
