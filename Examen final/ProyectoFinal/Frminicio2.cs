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
    public partial class Frminicio2 : Form
    {
        public Frminicio2()
        {
            InitializeComponent();
        }

        private void Frminicio2_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            
           
        }

      

        private void Pbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
