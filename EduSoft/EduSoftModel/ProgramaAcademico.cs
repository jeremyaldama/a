using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftModel
{
    public class ProgramaAcademico
    {
        private int _idProgramaAcademico;
        private char _tipoProgramaAcademico;
        private string _nombre;
        private string _clave;
        public int IdProgramaAcademico { get => _idProgramaAcademico; set => _idProgramaAcademico = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public char TipoProgramaAcademico { get => _tipoProgramaAcademico; set => _tipoProgramaAcademico = value; }

        public void leer(MySqlDataReader lector)
        {
            Console.WriteLine("PROGRAMA ACADEMICO");
            _idProgramaAcademico = lector.GetInt32("id_programa_academico");
            _tipoProgramaAcademico = lector.GetChar("fid_tipo_programa_academico");
            _clave = lector.GetString("clave");
            _nombre = lector.GetString("nombre");
        }
    }
}
