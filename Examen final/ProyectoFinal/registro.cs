using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{

    public partial class registro : Form

        

    {
        private List<estudiante> registroestudiante= new List<estudiante>();
        int i = 1;
        int posicion;
        public registro()
        {
            InitializeComponent();
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.Items.Add("Programacion");
            cmbMateria.Items.Add("Desarrollo web");
            cmbMateria.Items.Add("Contabilidad");
            cmbMateria.Items.Add("Diseño grafico");
            cmbMateria.Items.Add("Multimedia y realidad virtual");


        }

       /* private void btnregistrar_Click(object sender, EventArgs e)
        { 
            dataGridView1.Rows.Add(i + " ", txtnombre.Text,cmbMateria.Text,  txtnotas.Text);
            i = i + 1;
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = dataGridView1[1, posicion].Value.ToString();
            txtnotas.Text =  dataGridView1[2, posicion].Value.ToString();
           cmbMateria.Text=  dataGridView1[3, posicion].Value.ToString();

        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnotas_TextChanged(object sender, EventArgs e)
        {
            if(txtnotas.Text.Length>100)
            {
                txtnotas.Text = txtnotas.Text.Substring(0, 100);
                txtnotas.SelectionStart = txtnotas.Text.Length;
            }    
            

            
        }

        private void txtnotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void cmbMateria_Validating(object sender, CancelEventArgs e)
        {
            if(cmbMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una opcion en el ComboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtnotas_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtnotas.Text))
            {
                MessageBox.Show("Ingrese las notas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            if (txtnotas.Text.Length > 100)
            {
                txtnotas.Text = txtnotas.Text.Substring(0, 100);
                txtnotas.SelectionStart = txtnotas.Text.Length;

                MessageBox.Show("Los datos ingresados no deben superar los el numero 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnregistrar_Click_1(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(i + " ", txtnombre.Text, cmbMateria.Text, txtnotas.Text);
            i = i + 1;
        }

    }
}
