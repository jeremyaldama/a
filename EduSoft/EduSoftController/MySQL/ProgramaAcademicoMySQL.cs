using EduSoftController.DAO;
using EduSoftDBManager;
using EduSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSoftController.MySQL
{
    public class ProgramaAcademicoMySQL : ProgramaAcademicoDAO
    {
        private MySqlConnection con;
        // similar al CallableStatement
        private MySqlCommand comando;
        // ResultSet de Java
        private MySqlDataReader lector;

        public BindingList<ProgramaAcademico> listarPorIdSede(int idSede)
        {
            BindingList<ProgramaAcademico> programasAcademicos = new BindingList<ProgramaAcademico>();
            try
            {
                char tipoProg;
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_PROGRAMAS_ACADEMICOS_X_ID_SEDE";
                comando.Parameters.AddWithValue("_id_sede", idSede);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    tipoProg = lector.GetChar("fid_tipo_programa_academico");
                    if (tipoProg == 'C')
                    {
                        Curso curso = new Curso();
                        curso.TipoProgramaAcademico = lector.GetChar("fid_tipo_programa_academico");
                        curso.IdProgramaAcademico = lector.GetInt32("id_programa_academico");
                        curso.Clave = lector.GetString("clave");
                        curso.Nombre = lector.GetString("nombre");
                        curso.CantidadCreditos = lector.GetInt32("cantidad_creditos");
                        curso.FechaInicio = lector.GetDateTime("fecha_inicio");
                        programasAcademicos.Add(curso);
                        /*programaAcademico.Cant = lector.GetInt32("cantidad_creditos");
                        programaAcademico.IdProgramaAcademico = lector.GetInt32("fecha_inicio");
                        programaAcademico.IdProgramaAcademico = lector.GetInt32("cantidad_horas");
                        programaAcademico.IdProgramaAcademico = lector.GetInt32("fecha_realizacion");*/
                    }
                    else
                    {
                        Taller taller = new Taller();
                        taller.TipoProgramaAcademico = lector.GetChar("fid_tipo_programa_academico");
                        taller.IdProgramaAcademico = lector.GetInt32("id_programa_academico");
                        taller.Clave = lector.GetString("clave");
                        taller.Nombre = lector.GetString("nombre");
                        taller.CantidadHoras = lector.GetInt32("cantidad_horas");
                        taller.FechaRealizacion = lector.GetDateTime("fecha_realizacion");
                        programasAcademicos.Add(taller);
                    }
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return programasAcademicos;
        }

        public BindingList<ProgramaAcademico> listarPorNombreClave(string nombreClave)
        {
            BindingList<ProgramaAcademico> programasAcademicos = new BindingList<ProgramaAcademico>();
            try
            {
                char tipo;
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_PROGRAMAS_ACADEMICOS_X_NOMBRE_CLAVE";
                comando.Parameters.AddWithValue("_nombre_clave", nombreClave);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    tipo = lector.GetChar("fid_tipo_programa_academico");
                    if (tipo == 'C')
                    {
                        Curso curso = new Curso();
                        curso.IdProgramaAcademico = lector.GetInt32("id_programa_academico");
                        curso.TipoProgramaAcademico = lector.GetChar("fid_tipo_programa_academico");
                        curso.Clave = lector.GetString("clave");
                        curso.Nombre = lector.GetString("nombre");
                        curso.CantidadCreditos = lector.GetInt32("cantidad_creditos");
                        curso.FechaInicio = lector.GetDateTime("fecha_inicio");
                        programasAcademicos.Add(curso);
                    } else
                    {
                        Taller taller = new Taller();
                        taller.IdProgramaAcademico = lector.GetInt32("id_programa_academico");
                        taller.TipoProgramaAcademico = lector.GetChar("fid_tipo_programa_academico");
                        taller.Clave = lector.GetString("clave");
                        taller.Nombre = lector.GetString("nombre");
                        taller.CantidadHoras = lector.GetInt32("cantidad_horas");
                        taller.FechaRealizacion = lector.GetDateTime("fecha_realizacion");
                        programasAcademicos.Add(taller);
                    }
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
            return programasAcademicos;
        }
    }
}
