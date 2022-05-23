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
    public class CD_Docente
    {
        Conexion profesores = new Conexion();
        SqlCommand saber = new SqlCommand();

        public bool guardar_Docente(CE_Docente oprofesor1)
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "Insertar_Docente";
                saber.Parameters.Add("@ID_Docente", oprofesor1.Id_Docente);
                saber.Parameters.Add("@Nom_Docente", oprofesor1.Nom_Docente);
                saber.Parameters.Add("@Dire_Docente", oprofesor1.Dire_Docente);
                saber.Parameters.Add("@Tel_Docente", oprofesor1.Tel_Docente);
                saber.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Eliminar_Docente(string id)
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "Borrar_Docente";
                saber.Parameters.Add("@ID_Docente", id);
                saber.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Modificar_Docente(CE_Docente oprofesor5)
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "Modif_Docente";
                saber.Parameters.Add("@ID_Docente", oprofesor5.Id_Docente);
                saber.Parameters.Add("@Nom_Docente", oprofesor5.Nom_Docente);
                saber.Parameters.Add("@Dire_Docente", oprofesor5.Dire_Docente);
                saber.Parameters.Add("@Tel_Docente", oprofesor5.Tel_Docente);
                saber.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool anular_Docente(CE_Docente oprofesor2)
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "modificar_Docente";
                saber.Parameters.Add("@ID_Docente", oprofesor2.Id_Docente);
                saber.Parameters.Add("@Nom_Docente", oprofesor2.Nom_Docente);
                saber.Parameters.Add("@Dire_Docente", oprofesor2.Dire_Docente);
                saber.Parameters.Add("@Tel_Docente", oprofesor2.Tel_Docente);
                saber.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CE_Docente Consultar_Docente(string id)
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "Consul_Docente";
                saber.Parameters.Add("@ID_Docente", id);
                SqlDataAdapter info = new SqlDataAdapter(saber);
                DataSet consulta = new DataSet();
                info.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                CE_Docente item = new CE_Docente();

                DataRow row = dt.Rows[0];

                CE_Docente x = new CE_Docente();

                x.Id_Docente = Convert.ToString(row["Id_Docente"]);
                x.Tel_Docente = Convert.ToInt32(row["Tel_Docente"]);
                x.Nom_Docente = Convert.ToString(row["Nom_Docente"]);
                x.Dire_Docente = Convert.ToString(row["Dire_Docente"]);

                return x;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CE_Docente> Consultar_Docentes()
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "Consul_Docentes";
                SqlDataAdapter info = new SqlDataAdapter(saber);
                DataSet consulta = new DataSet();
                info.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                List<CE_Docente> lista = new List<CE_Docente>();

                foreach (DataRow row in dt.Rows)
                {
                    CE_Docente x = new CE_Docente();

                    x.Id_Docente = Convert.ToString(row["Id_Docente"]);
                    x.Tel_Docente = Convert.ToInt32(row["Tel_Docente"]);
                    x.Nom_Docente = Convert.ToString(row["Nom_Docente"]);
                    x.Dire_Docente = Convert.ToString(row["Dire_Docente"]);

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
