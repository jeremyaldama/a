using EduSoftController.DAO;
using EduSoftController.MySQL;
using EduSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSoft
{
    public partial class frmBusquedaProgramasAcademicos : Form
    {
        ProgramaAcademicoDAO _daoProgramaAcademico;
        ProgramaAcademico _programaAcademicoSeleccionado;

        public ProgramaAcademico ProgramaAcademicoSeleccionado { get => _programaAcademicoSeleccionado; set => _programaAcademicoSeleccionado = value; }

        public frmBusquedaProgramasAcademicos()
        {
            _daoProgramaAcademico = new ProgramaAcademicoMySQL();
            InitializeComponent();
            dgvProgramas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProgramas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProgramas.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProgramas.DataSource = _daoProgramaAcademico.listarPorNombreClave(txtNombreClave.Text);
        }

        private void dgvProgramas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProgramaAcademico pa = (ProgramaAcademico)dgvProgramas.Rows[e.RowIndex].DataBoundItem;
            dgvProgramas.Rows[e.RowIndex].Cells[0].Value = pa.IdProgramaAcademico;
            dgvProgramas.Rows[e.RowIndex].Cells[1].Value = pa.Clave;
            dgvProgramas.Rows[e.RowIndex].Cells[2].Value = pa.Nombre;
            if (pa.TipoProgramaAcademico == 'C')
            {
                Curso curso = (Curso)dgvProgramas.Rows[e.RowIndex].DataBoundItem;
                dgvProgramas.Rows[e.RowIndex].Cells[3].Value = curso.CantidadCreditos;
                dgvProgramas.Rows[e.RowIndex].Cells[4].Value = curso.FechaInicio.ToString("dd-MM-yyyy");
            } else
            {
                Taller taller = (Taller)dgvProgramas.Rows[e.RowIndex].DataBoundItem;
                dgvProgramas.Rows[e.RowIndex].Cells[3].Value = taller.CantidadHoras;
                dgvProgramas.Rows[e.RowIndex].Cells[4].Value = taller.FechaRealizacion.ToString("dd-MM-yyyy");
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProgramas.CurrentRow != null)
            {
                ProgramaAcademicoSeleccionado = (ProgramaAcademico)dgvProgramas.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
