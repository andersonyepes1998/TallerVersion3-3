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
    public class CN_Especialidad
    {
        CD_Especialidad CapaDato = new CD_Especialidad();

        public bool guardar_especialidad(CE_Especialidad oespe4)
        {
            return CapaDato.guardar_especialidad(oespe4);
        }

        public bool modificar_especialidad(CE_Especialidad especialidad)
        {
            return CapaDato.modificar_especialidad(especialidad);
        }

        public bool eliminar_especialidad(string Id)
        {
            return CapaDato.eliminar_Especialidad(Id);
        }

        /*public bool anular_especialidad(CE_Especialidad oespe5)
        {
            return CapaDato.anular_especialidad(oespe5);
        }*/

        public  CE_Especialidad consultar_especialidad(string Id)
        {
            return CapaDato.consultar_especialidad(Id);
        }

        public List<CE_Especialidad> consultar_Especialidades()
        {
            return CapaDato.consultar_Especialidades();
        }
    }
}
