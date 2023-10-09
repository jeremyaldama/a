using EduSoftController.DAO;
using EduSoftController.MySQL;
using EduSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSoft
{
    /* Coloque sus datos
        * -------------------------------------------------
        * Nombre Completo:
        * Código PUCP:
        * Fecha de Modificación: 
    */
    public partial class frmGestionarSedes : Form
    {

        private Estado _estado;
        private string _rutaFotoLocal;
        private TipoSedeDAO _daoTipoSede;
        private SedeDAO _daoSede;
        private Ejecutivo _ejecutivo;
        private Sede _sede;
        private ProgramaAcademico _programaAcademico;
        private ProgramaAcademicoDAO _daoProgramaAcademico;
        public frmGestionarSedes()
        {
            _daoTipoSede = new TipoSedeMySQL();
            _daoSede = new SedeMySQL();
            _daoProgramaAcademico = new ProgramaAcademicoMySQL();
            InitializeComponent();
            dgvProgramasAcademicos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProgramasAcademicos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            cboTipoSede.DataSource = _daoTipoSede.listarTodos();
            cboTipoSede.DisplayMember = "Nombre";
            cboTipoSede.ValueMember = "IdTipoSede";

            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();

            dgvProgramasAcademicos.AutoGenerateColumns = false;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnBuscarEjecutivoResponsable.Enabled = false;
                    btnBuscarPrograma.Enabled = false;
                    btnAgregarProgramaAcademico.Enabled = false;
                    btnEliminarProgramaAcademico.Enabled = false;
                    txtIDSede.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNombre.ReadOnly = false;
                    txtDireccion.Enabled = false;
                    txtDireccion.ReadOnly = false;
                    dtpFechaInauguracion.Enabled = false;
                    cboTipoSede.Enabled = false;
                    txtCantAulas.Enabled = false;
                    txtCantAulas.ReadOnly = false;
                    txtAforo.Enabled = false;
                    txtAforo.ReadOnly = false;
                    txtDNIEjecutivoResp.Enabled = false;
                    txtNombreEjecutivoResp.Enabled = false;
                    cbAuditorio.Enabled = false;
                    cbBiblioteca.Enabled = false;
                    cbEstacionamiento.Enabled = false;
                    cbSalasEstudio.Enabled = false;
                    cbCafeteria.Enabled = false;
                    txtClavePrograma.Enabled = false;
                    txtTipoPrograma.Enabled = false;
                    txtNombrePrograma.Enabled = false;
                    dgvProgramasAcademicos.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    btnBuscarEjecutivoResponsable.Enabled = true;
                    btnBuscarPrograma.Enabled = true;
                    btnAgregarProgramaAcademico.Enabled = true;
                    btnEliminarProgramaAcademico.Enabled = true;
                    txtIDSede.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtDireccion.Enabled = true;
                    txtDireccion.ReadOnly = false;
                    dtpFechaInauguracion.Enabled = true;
                    cboTipoSede.Enabled = true;
                    txtCantAulas.Enabled = true;
                    txtCantAulas.ReadOnly = false;
                    txtAforo.Enabled = true;
                    txtAforo.ReadOnly = false;
                    txtDNIEjecutivoResp.Enabled = true;
                    txtNombreEjecutivoResp.Enabled = true;
                    cbAuditorio.Enabled = true;
                    cbBiblioteca.Enabled = true;
                    cbEstacionamiento.Enabled = true;
                    cbSalasEstudio.Enabled = true;
                    cbCafeteria.Enabled = true;
                    txtClavePrograma.Enabled = true;
                    txtTipoPrograma.Enabled = true;
                    txtNombrePrograma.Enabled = true;
                    dgvProgramasAcademicos.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnBuscarEjecutivoResponsable.Enabled = false;
                    btnBuscarPrograma.Enabled = false;
                    btnAgregarProgramaAcademico.Enabled = false;
                    btnEliminarProgramaAcademico.Enabled = false;
                    txtIDSede.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = true;
                    txtDireccion.Enabled = true;
                    txtDireccion.ReadOnly = true;
                    dtpFechaInauguracion.Enabled = false;
                    cboTipoSede.Enabled = false;
                    txtCantAulas.Enabled = true;
                    txtCantAulas.ReadOnly = true;
                    txtAforo.Enabled = true;
                    txtAforo.ReadOnly = true;
                    txtDNIEjecutivoResp.Enabled = true;
                    txtNombreEjecutivoResp.Enabled = true;
                    cbAuditorio.Enabled = false;
                    cbBiblioteca.Enabled = false;
                    cbEstacionamiento.Enabled = false;
                    cbSalasEstudio.Enabled = false;
                    cbCafeteria.Enabled = false;
                    txtClavePrograma.Enabled = false;
                    txtTipoPrograma.Enabled = false;
                    txtNombrePrograma.Enabled = false;
                    dgvProgramasAcademicos.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDSede.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            dtpFechaInauguracion.Value = DateTime.Now;
            cboTipoSede.SelectedIndex = -1;
            txtCantAulas.Text = "";
            txtAforo.Text = "";
            pbFoto.Image = null;
            txtDNIEjecutivoResp.Text = "";
            txtNombreEjecutivoResp.Text = "";
            cbAuditorio.Checked = false;
            cbBiblioteca.Checked = false;
            cbEstacionamiento.Checked = false;
            cbSalasEstudio.Checked = false;
            cbCafeteria.Checked = false;
            dgvProgramasAcademicos.DataSource = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _sede = new Sede();
            _sede.ProgramasAcademicos = new BindingList<ProgramaAcademico>();
            dgvProgramasAcademicos.DataSource = _sede.ProgramasAcademicos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoLocal = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFotoLocal);
                    FileStream fs = new FileStream(_rutaFotoLocal, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _sede.Foto = br.ReadBytes((int)fs.Length);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaSedes frmBusqSed = new frmBusquedaSedes();
            if (frmBusqSed.ShowDialog() == DialogResult.OK)
            {
                _sede = frmBusqSed.SedeSeleccionada;
                txtIDSede.Text = _sede.IdSede.ToString();
                txtNombre.Text = _sede.Nombre;
                txtDireccion.Text = _sede.Direccion;
                dtpFechaInauguracion.Value = _sede.FechaInauguracion;
                cboTipoSede.SelectedValue = _sede.TipoSede.IdTipoSede;
                txtCantAulas.Text = _sede.CantidadAulas.ToString();
                txtAforo.Text = _sede.AforoTotal.ToString();
                txtDNIEjecutivoResp.Text = _sede.Ejecutivo.DNI;
                txtNombreEjecutivoResp.Text = _sede.Ejecutivo.Nombre + " " + _sede.Ejecutivo.ApellidoPaterno;

                if (_sede.TieneAuditorio == true)
                {
                    cbAuditorio.Checked = true;
                }
                else
                {
                    cbAuditorio.Checked = false;
                }

                if (_sede.TieneBiblioteca == true)
                {
                    cbBiblioteca.Checked = true;
                }
                else
                {
                    cbBiblioteca.Checked = false;
                }

                if (_sede.TieneCafeteria == true)
                {
                    cbCafeteria.Checked = true;
                }
                else
                {
                    cbCafeteria.Checked = false;
                }

                if (_sede.TieneEstacionamiento == true)
                {
                    cbEstacionamiento.Checked = true;
                }
                else
                {
                    cbEstacionamiento.Checked = false;
                }

                if (_sede.TieneSalasEstudio == true)
                {
                    cbSalasEstudio.Checked = true;
                }
                else
                {
                    cbSalasEstudio.Checked = false;
                }

                MemoryStream ms = new MemoryStream(_sede.Foto);
                pbFoto.Image = new Bitmap(ms);

                //dgvProgramasAcademicos.DataSource = _daoProgramaAcademico.listarPorIdSede(_sede.IdSede);
                dgvProgramasAcademicos.DataSource = _sede.ProgramasAcademicos;

            }
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void cboTipoSede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarEjecutivoResponsable_Click(object sender, EventArgs e)
        {
            frmBusquedaEjecutivos frmBusEjec = new frmBusquedaEjecutivos();
            if (frmBusEjec.ShowDialog() == DialogResult.OK)
            {
                _ejecutivo = frmBusEjec.EjecutivoSeleccionado;
                txtDNIEjecutivoResp.Text = _ejecutivo.DNI;
                txtNombreEjecutivoResp.Text = _ejecutivo.Nombre + " " + _ejecutivo.ApellidoPaterno;
            }
        }

        private void btnBuscarPrograma_Click(object sender, EventArgs e)
        {
            frmBusquedaProgramasAcademicos frmBusqPA = new frmBusquedaProgramasAcademicos();
            if (frmBusqPA.ShowDialog() == DialogResult.OK)
            {
                _programaAcademico = frmBusqPA.ProgramaAcademicoSeleccionado;
                txtClavePrograma.Text = _programaAcademico.Clave;
                txtNombrePrograma.Text = _programaAcademico.Nombre;
                if (_programaAcademico.TipoProgramaAcademico == 'C')
                    txtTipoPrograma.Text = "CURSO";
                else txtTipoPrograma.Text = "TALLER";
            }
        }

        private void dgvProgramasAcademicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProgramaAcademico pa = (ProgramaAcademico)dgvProgramasAcademicos.Rows[e.RowIndex].DataBoundItem;
            dgvProgramasAcademicos.Rows[e.RowIndex].Cells[0].Value = pa.IdProgramaAcademico;
            dgvProgramasAcademicos.Rows[e.RowIndex].Cells[1].Value = pa.Clave;
            dgvProgramasAcademicos.Rows[e.RowIndex].Cells[2].Value = pa.Nombre;
            if (pa.TipoProgramaAcademico == 'C')
            {
                Curso curso = (Curso)dgvProgramasAcademicos.Rows[e.RowIndex].DataBoundItem;
                dgvProgramasAcademicos.Rows[e.RowIndex].Cells[3].Value = curso.CantidadCreditos;
                dgvProgramasAcademicos.Rows[e.RowIndex].Cells[4].Value = curso.FechaInicio.ToString("dd-MM-yyyy");
            }
            else
            {
                Taller taller = (Taller)dgvProgramasAcademicos.Rows[e.RowIndex].DataBoundItem;
                dgvProgramasAcademicos.Rows[e.RowIndex].Cells[3].Value = taller.CantidadHoras;
                dgvProgramasAcademicos.Rows[e.RowIndex].Cells[4].Value = taller.FechaRealizacion.ToString("dd-MM-yyyy");
            }
        }

        private void btnAgregarProgramaAcademico_Click(object sender, EventArgs e)
        {
            if (txtClavePrograma.Text == "")
            {
                MessageBox.Show("Debe seleccionar un programa academico", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _sede.ProgramasAcademicos.Add(_programaAcademico);
            txtNombrePrograma.Text = txtTipoPrograma.Text = txtClavePrograma.Text = "";
        }

        private void btnEliminarProgramaAcademico_Click(object sender, EventArgs e)
        {
            if (dgvProgramasAcademicos.CurrentRow != null)
            {
                ProgramaAcademico pa = (ProgramaAcademico)dgvProgramasAcademicos.CurrentRow.DataBoundItem;
                _sede.ProgramasAcademicos.Remove(pa);
                txtNombrePrograma.Text = txtTipoPrograma.Text = txtClavePrograma.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _sede.Nombre = txtNombre.Text;
            _sede.Direccion = txtDireccion.Text;
            _sede.FechaInauguracion = dtpFechaInauguracion.Value;
            _sede.TipoSede = new TipoSede();
            _sede.TipoSede.IdTipoSede = (int)cboTipoSede.SelectedValue;
            _sede.CantidadAulas = Int32.Parse(txtCantAulas.Text);
            _sede.AforoTotal = Int32.Parse(txtAforo.Text);
            _sede.Ejecutivo = new Ejecutivo();
            _sede.Ejecutivo.IdEjecutivo = _ejecutivo.IdEjecutivo;
            if (cbAuditorio.Checked == true)
            {
                _sede.TieneAuditorio = true;
            }
            else
            {
                _sede.TieneAuditorio = false;
            }

            if (cbBiblioteca.Checked == true)
            {
                _sede.TieneBiblioteca = true;
            }
            else
            {
                _sede.TieneBiblioteca = false;
            }

            if (cbCafeteria.Checked == true)
            {
                _sede.TieneCafeteria = true;
            }
            else
            {
                _sede.TieneCafeteria = false;
            }

            if (cbEstacionamiento.Checked == true)
            {
                _sede.TieneEstacionamiento = true;
            }
            else
            {
                _sede.TieneEstacionamiento = false;
            }

            if (cbSalasEstudio.Checked == true)
            {
                _sede.TieneSalasEstudio = true;
            }
            else
            {
                _sede.TieneSalasEstudio = false;
            }
            int resultado = _daoSede.insertar(_sede);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDSede.Text = resultado.ToString();
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            } else
            {
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGestionarSedes_Load(object sender, EventArgs e)
        {

        }
    }
}
