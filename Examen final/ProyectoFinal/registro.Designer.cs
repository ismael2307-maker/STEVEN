namespace ProyectoFinal
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.label1 = new System.Windows.Forms.Label();
            this.notasEstudiantes = new System.Windows.Forms.Label();
            this.nombreEstudiante = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgloginmorado = new System.Windows.Forms.PictureBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgloginmorado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(180, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Materia:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notasEstudiantes
            // 
            this.notasEstudiantes.AutoSize = true;
            this.notasEstudiantes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasEstudiantes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notasEstudiantes.Location = new System.Drawing.Point(180, 189);
            this.notasEstudiantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notasEstudiantes.Name = "notasEstudiantes";
            this.notasEstudiantes.Size = new System.Drawing.Size(49, 19);
            this.notasEstudiantes.TabIndex = 18;
            this.notasEstudiantes.Text = "Notas:";
            // 
            // nombreEstudiante
            // 
            this.nombreEstudiante.AutoSize = true;
            this.nombreEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEstudiante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nombreEstudiante.Location = new System.Drawing.Point(177, 112);
            this.nombreEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreEstudiante.Name = "nombreEstudiante";
            this.nombreEstudiante.Size = new System.Drawing.Size(63, 19);
            this.nombreEstudiante.TabIndex = 17;
            this.nombreEstudiante.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.materia,
            this.nota});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(156, 286);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(359, 159);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            // 
            // materia
            // 
            this.materia.HeaderText = "materia";
            this.materia.MinimumWidth = 8;
            this.materia.Name = "materia";
            // 
            // nota
            // 
            this.nota.HeaderText = "nota";
            this.nota.MaxInputLength = 100;
            this.nota.MinimumWidth = 8;
            this.nota.Name = "nota";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnregistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.Location = new System.Drawing.Point(240, 238);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(170, 34);
            this.btnregistrar.TabIndex = 14;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click_1);
            // 
            // txtnotas
            // 
            this.txtnotas.Location = new System.Drawing.Point(240, 189);
            this.txtnotas.Margin = new System.Windows.Forms.Padding(2);
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.Size = new System.Drawing.Size(171, 20);
            this.txtnotas.TabIndex = 13;
            this.txtnotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnotas.TextChanged += new System.EventHandler(this.txtnotas_TextChanged);
            this.txtnotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnotas_KeyPress);
            this.txtnotas.Validating += new System.ComponentModel.CancelEventHandler(this.txtnotas_Validating);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(244, 112);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(171, 20);
            this.txtnombre.TabIndex = 12;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            this.txtnombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtnombre_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 445);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imgloginmorado
            // 
            this.imgloginmorado.Image = ((System.Drawing.Image)(resources.GetObject("imgloginmorado.Image")));
            this.imgloginmorado.Location = new System.Drawing.Point(210, 6);
            this.imgloginmorado.Margin = new System.Windows.Forms.Padding(2);
            this.imgloginmorado.Name = "imgloginmorado";
            this.imgloginmorado.Size = new System.Drawing.Size(207, 88);
            this.imgloginmorado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgloginmorado.TabIndex = 16;
            this.imgloginmorado.TabStop = false;
            // 
            // cmbMateria
            // 
            this.cmbMateria.BackColor = System.Drawing.Color.White;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(241, 148);
            this.cmbMateria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(171, 21);
            this.cmbMateria.TabIndex = 20;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            this.cmbMateria.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMateria_Validating);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(429, 251);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(86, 21);
            this.btnCerrarSesion.TabIndex = 21;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 445);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notasEstudiantes);
            this.Controls.Add(this.nombreEstudiante);
            this.Controls.Add(this.imgloginmorado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtnotas);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "registro";
            this.Text = "registro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgloginmorado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label notasEstudiantes;
        private System.Windows.Forms.Label nombreEstudiante;
        private System.Windows.Forms.PictureBox imgloginmorado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txtnotas;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
    }
}