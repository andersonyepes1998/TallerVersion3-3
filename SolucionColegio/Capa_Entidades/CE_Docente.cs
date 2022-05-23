using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Docente
    {
        private string id_Docente;
        private string nom_Docente;
        private string dire_Docente;
        private int tel_Docente;

        public string Id_Docente { get => id_Docente; set => id_Docente = value; }
        public string Nom_Docente { get => nom_Docente; set => nom_Docente = value; }
        public string Dire_Docente { get => dire_Docente; set => dire_Docente = value; }
        public int Tel_Docente { get => tel_Docente; set => tel_Docente = value; }
    }
}
