
namespace ProyectoFinal
{
    partial class Frminicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.Pbcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ves que si funciona maje";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(355, 159);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(109, 38);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // Pbcerrar
            // 
            this.Pbcerrar.BackColor = System.Drawing.Color.Transparent;
            this.Pbcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pbcerrar.Image = global::ProyectoFinal.Properties.Resources.images2;
            this.Pbcerrar.Location = new System.Drawing.Point(462, 0);
            this.Pbcerrar.Name = "Pbcerrar";
            this.Pbcerrar.Size = new System.Drawing.Size(15, 15);
            this.Pbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbcerrar.TabIndex = 16;
            this.Pbcerrar.TabStop = false;
            this.Pbcerrar.Click += new System.EventHandler(this.Pbcerrar_Click);
            // 
            // Frminicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrarSesion;
            this.ClientSize = new System.Drawing.Size(476, 199);
            this.Controls.Add(this.Pbcerrar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frminicio2";
            this.Text = "Frminicio2";
            this.Load += new System.EventHandler(this.Frminicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox Pbcerrar;
    }
}