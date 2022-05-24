using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Data;

namespace Capa_Datos
{
    public class CD_Especialidad
    {
        Conexion titulo = new Conexion();
        SqlCommand experiencia = new SqlCommand();

        public bool guardar_especialidad(CE_Especialidad oespe1)
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "insertar_especialidad";
                experiencia.Parameters.Add("@Id_Especialidad", oespe1.Id_Especialidad);
                experiencia.Parameters.Add("@Nom_Especialidad", oespe1.Nom_Especialidad);
                experiencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool modificar_especialidad(CE_Especialidad especialidad)
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "Modif_Especialidad";
                experiencia.Parameters.Add("@Id_Especialidad", especialidad.Id_Especialidad);
                experiencia.Parameters.Add("@Nom_Especialidad", especialidad.Nom_Especialidad);
                experiencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminar_Especialidad(string Id)
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "Borrar_Especialidad";
                experiencia.Parameters.Add("@Id_Especialidad", Id);
                experiencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /* public bool anular_especialidad(CE_Especialidad oespe2)
         {
             try
             {
                 experiencia.CommandType = CommandType.StoredProcedure;
                 experiencia.Connection = titulo.conectar("BD_Colegio");
                 experiencia.CommandText = "modificar_especialidad";
                 experiencia.Parameters.Add("@Id_Especialidad", oespe2.Id_Especialidad1);
                 experiencia.Parameters.Add("@Nom_Especialidad", oespe2.Id_Especialidad1);
                 experiencia.ExecuteNonQuery();
                 return true;
             }
             catch (Exception)
             {

                 throw;
             }
         }*/

        public CE_Especialidad consultar_especialidad(string Id_Especialidad)
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "Consul_Especialidad";
                experiencia.Parameters.Add("@Id_Especialidad", Id_Especialidad);
                SqlDataAdapter info = new SqlDataAdapter(experiencia);
                DataSet consulta = new DataSet();
                info.Fill(consulta);

                DataTable dt = consulta.Tables[0];
                DataRow row = dt.Rows[0];

                CE_Especialidad Especialidad = new CE_Especialidad();

                Especialidad.Id_Especialidad = Convert.ToString(row["Id_Especialidad"]);
                Especialidad.Nom_Especialidad = Convert.ToString(row["Nom_Especialidad"]);

                return Especialidad;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<CE_Especialidad> consultar_Especialidades()
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "Consul_Especialidades";

                SqlDataAdapter informe = new SqlDataAdapter(experiencia);
                DataSet consulta = new DataSet();
                informe.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                List<CE_Especialidad> lista = new List<CE_Especialidad>();

                foreach (DataRow row in dt.Rows)
                {
                    CE_Especialidad x = new CE_Especialidad();
                    x.Id_Especialidad = Convert.ToString(row["Id_Especialidad"]);
                    x.Nom_Especialidad = Convert.ToString(row["Nom_Especialidad"]);
                    lista.Add(x);
                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
