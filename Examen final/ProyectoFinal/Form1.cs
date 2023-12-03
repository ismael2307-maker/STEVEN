using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Properties;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pbcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lbtres_Click(object sender, EventArgs e)
        {

        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";

                txtUsuario.ForeColor = Color.Gray;
            }
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";

                txtContraseña.ForeColor = Color.Gray;

                
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;

            }
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "ROMMEL" && txtContraseña.Text == "GARCIA")
            {
                registro registnote = new registro();
                registnote.ShowDialog();
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son los correctos");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }

        private void PbNomostrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                if (txtContraseña.Text == "Contraseña" || txtContraseña.Text == "")
                {
                    txtContraseña.UseSystemPasswordChar = true;
                }
                else
                {
                    txtContraseña.UseSystemPasswordChar = false;
                    PbNomostrar.Image = Resources.Nomostrar;
                }
            }
            else
            {
                if (txtContraseña.Text == "Contraseña" || txtContraseña.Text == "")
                {
                    txtContraseña.UseSystemPasswordChar = false;
                }
                else
                {
                    txtContraseña.UseSystemPasswordChar = true;
                    PbNomostrar.Image = Resources.Mostrar;
                }
            }
        }

        private void Pbminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

