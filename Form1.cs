using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEA1_ALDO_LIZA
{
    public partial class frmdocumento : Form
    {
        public frmdocumento()
        {
            InitializeComponent();
        }

        private void dgvtipodocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncargardatos_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
         private void cargarDatos()
        {
            var adaptador = new dsAppTableAdapters.TipoDocumentoTableAdapter();
            var tabla = adaptador.GetData();
            dgvtipodocumento.DataSource = tabla;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            int id = getId();
            if(id > 0)
            {
                var frm = new Frmtipodocumentoedit(id);
                frm.ShowDialog();
                cargarDatos();
            }else
            {
                MessageBox.Show("selecione un id valido ", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int getId()
        {
            try
            {
                DataGridViewRow filaActual = dgvtipodocumento.CurrentRow;
                if(filaActual== null)
                {
                    return 0;

                }
                return int.Parse(dgvtipodocumento.Rows[filaActual.Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            var frm = new Frmtipodocumentoedit();
            frm.ShowDialog();
            cargarDatos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id = getId();
            if (id > 0)
            {
                DialogResult respuesta = MessageBox.Show("realmente desea eliminar el registro?", "sistema", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(respuesta == DialogResult.Yes)
                {
                    var adaptador = new dsAppTableAdapters.TipoDocumentoTableAdapter();
                    adaptador.REMOVE(id);
                    MessageBox.Show("registro eliminado", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos();
                }else
                {
                    MessageBox.Show("debes selecionar un id valido", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
