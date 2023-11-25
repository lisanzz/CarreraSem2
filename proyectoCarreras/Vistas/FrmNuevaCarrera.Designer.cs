namespace proyectoCarreras.Vistas
{
    partial class FrmNuevaCarrera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbPrimerCuat = new System.Windows.Forms.RadioButton();
            this.rbSegundoCuat = new System.Windows.Forms.RadioButton();
            this.dgvNuevaCarrera = new System.Windows.Forms.DataGridView();
            this.ColIdAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombAs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(110, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de carrera";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMateria.Location = new System.Drawing.Point(448, 80);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(62, 20);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAño.Location = new System.Drawing.Point(678, 80);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(121, 20);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de cursado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitulo.Location = new System.Drawing.Point(393, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(164, 29);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Nueva carrera";
            // 
            // rbPrimerCuat
            // 
            this.rbPrimerCuat.AutoSize = true;
            this.rbPrimerCuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbPrimerCuat.Location = new System.Drawing.Point(129, 205);
            this.rbPrimerCuat.Name = "rbPrimerCuat";
            this.rbPrimerCuat.Size = new System.Drawing.Size(164, 24);
            this.rbPrimerCuat.TabIndex = 6;
            this.rbPrimerCuat.TabStop = true;
            this.rbPrimerCuat.Text = "Primer cuatrimestre";
            this.rbPrimerCuat.UseVisualStyleBackColor = true;
            // 
            // rbSegundoCuat
            // 
            this.rbSegundoCuat.AutoSize = true;
            this.rbSegundoCuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbSegundoCuat.Location = new System.Drawing.Point(398, 205);
            this.rbSegundoCuat.Name = "rbSegundoCuat";
            this.rbSegundoCuat.Size = new System.Drawing.Size(184, 24);
            this.rbSegundoCuat.TabIndex = 7;
            this.rbSegundoCuat.TabStop = true;
            this.rbSegundoCuat.Text = "Segundo cuatrimestre";
            this.rbSegundoCuat.UseVisualStyleBackColor = true;
            // 
            // dgvNuevaCarrera
            // 
            this.dgvNuevaCarrera.AllowUserToAddRows = false;
            this.dgvNuevaCarrera.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNuevaCarrera.ColumnHeadersHeight = 30;
            this.dgvNuevaCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdAsig,
            this.ColNombAs,
            this.ColAño,
            this.ColCuatrimestre});
            this.dgvNuevaCarrera.Location = new System.Drawing.Point(114, 249);
            this.dgvNuevaCarrera.Name = "dgvNuevaCarrera";
            this.dgvNuevaCarrera.Size = new System.Drawing.Size(709, 209);
            this.dgvNuevaCarrera.TabIndex = 8;
            // 
            // ColIdAsig
            // 
            this.ColIdAsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColIdAsig.HeaderText = "Id Asignatura";
            this.ColIdAsig.Name = "ColIdAsig";
            // 
            // ColNombAs
            // 
            this.ColNombAs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombAs.HeaderText = "Nombre Asignatura";
            this.ColNombAs.Name = "ColNombAs";
            // 
            // ColAño
            // 
            this.ColAño.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAño.HeaderText = "Año";
            this.ColAño.Name = "ColAño";
            // 
            // ColCuatrimestre
            // 
            this.ColCuatrimestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCuatrimestre.HeaderText = "Cuatrimestre";
            this.ColCuatrimestre.Name = "ColCuatrimestre";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(114, 121);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(169, 20);
            this.txtCarrera.TabIndex = 9;
            this.txtCarrera.TextChanged += new System.EventHandler(this.txtCarrera_TextChanged);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(654, 122);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(169, 20);
            this.txtAño.TabIndex = 10;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(398, 121);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(169, 21);
            this.cboMateria.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(702, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 31);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.Location = new System.Drawing.Point(124, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 31);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirmar.Location = new System.Drawing.Point(702, 477);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 31);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 520);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.dgvNuevaCarrera);
            this.Controls.Add(this.rbSegundoCuat);
            this.Controls.Add(this.rbPrimerCuat);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmNuevaCarrera";
            this.Text = "FrmNuevaCarrera";
            this.Load += new System.EventHandler(this.FrmNuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbPrimerCuat;
        private System.Windows.Forms.RadioButton rbSegundoCuat;
        private System.Windows.Forms.DataGridView dgvNuevaCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombAs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatrimestre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfirmar;
    }
}