namespace PEA1_ALDO_LIZA
{
    partial class frmdocumento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvtipodocumento = new System.Windows.Forms.DataGridView();
            this.btncargardatos = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipodocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtipodocumento
            // 
            this.dgvtipodocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtipodocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipodocumento.Location = new System.Drawing.Point(-1, 96);
            this.dgvtipodocumento.Name = "dgvtipodocumento";
            this.dgvtipodocumento.Size = new System.Drawing.Size(338, 193);
            this.dgvtipodocumento.TabIndex = 0;
            this.dgvtipodocumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtipodocumento_CellContentClick);
            // 
            // btncargardatos
            // 
            this.btncargardatos.Location = new System.Drawing.Point(256, 29);
            this.btncargardatos.Name = "btncargardatos";
            this.btncargardatos.Size = new System.Drawing.Size(75, 23);
            this.btncargardatos.TabIndex = 1;
            this.btncargardatos.Text = "cargar datos";
            this.btncargardatos.UseVisualStyleBackColor = true;
            this.btncargardatos.Click += new System.EventHandler(this.btncargardatos_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(-1, 29);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 2;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(89, 29);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "nuevo";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(183, 29);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(61, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // frmdocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 289);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btncargardatos);
            this.Controls.Add(this.dgvtipodocumento);
            this.Name = "frmdocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tipo documento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipodocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtipodocumento;
        private System.Windows.Forms.Button btncargardatos;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btneliminar;
    }
}

