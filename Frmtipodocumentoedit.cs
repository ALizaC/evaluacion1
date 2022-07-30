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
    public partial class Frmtipodocumentoedit : Form
    {
        private int? id;
        public Frmtipodocumentoedit(int? id=null)
        {
            InitializeComponent();
            this.id = id;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int estado = chkestado.Checked ? 1 : 0;
            String nombre = txtnombre.Text;
            var adaptador = new dsAppTableAdapters.TipoDocumentoTableAdapter();
            if(this.id==null)
            {
                adaptador.ADD(nombre, (byte)estado);
            }else
            {
                adaptador.EDIT(nombre, (byte)estado, (int)this.id);
            }
            this.Close();
        }

        private void Frmtipodocumentoedit_Load(object sender, EventArgs e)
        {
            if(this.id != null)
            {
                this.Text = "editar";
                var adaptador = new dsAppTableAdapters.TipoDocumentoTableAdapter();
                var tabla = adaptador.GetDataById((int)this.id);
                var fila = (dsApp.TipoDocumentoRow)tabla.Rows[0];
                txtnombre.Text = fila.Nombre;
                chkestado.Checked = fila.Estado == 1 ? true : false;
            }
            else
            {
                this.Text = "nuevo";
            }
        }
    }
}
