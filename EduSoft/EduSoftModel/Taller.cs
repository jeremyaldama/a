using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftModel
{
    public class Taller : ProgramaAcademico
    {
        private int _cantidadHoras;
        private DateTime _fechaRealizacion;
        public int CantidadHoras { get => _cantidadHoras; set => _cantidadHoras = value; }
        public DateTime FechaRealizacion { get => _fechaRealizacion; set => _fechaRealizacion = value; }

        public void leer(MySqlDataReader lector)
        {
            base.leer(lector);
            _cantidadHoras = lector.GetInt32("cantidad_horas");
            _fechaRealizacion = lector.GetDateTime("fecha_realizacion");
        }
    }
}
