using EduSoftController.DAO;
using EduSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EduSoftDBManager;

namespace EduSoftController.MySQL
{
    public class TipoSedeMySQL : TipoSedeDAO
    {
        private MySqlConnection con;
        // similar al CallableStatement
        private MySqlCommand comando;
        // ResultSet de Java
        private MySqlDataReader lector;
        public BindingList<TipoSede> listarTodos()
        {
        BindingList<TipoSede> tiposSede = new BindingList<TipoSede>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                // comando = con.CreateCommand();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_TIPOS_SEDE_TODOS";

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    TipoSede tipoSede = new TipoSede();
                    tipoSede.IdTipoSede = lector.GetInt32("id_tipo_sede");
                    tipoSede.Nombre = lector.GetString("nombre");
                    tiposSede.Add(tipoSede);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return tiposSede;
        }
    }
}
