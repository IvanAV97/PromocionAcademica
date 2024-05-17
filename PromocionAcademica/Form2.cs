using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromocionAcademica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aspirante aspirante = new Aspirante();
            aspirante.Nombre = txtNombre.Text;
            aspirante.CorreoE = txtCorreoE.Text;
            aspirante.Numtelefono = txtNumtelefono.Text;
            aspirante.EscuelaProcedencia =txtEscuelaProce.Text;

            int result = AspirantesDal.AgregarAspirantes(aspirante);
            if (result > 0)
            {
                MessageBox.Show("!!!Gracias por tu interes¡¡¡, Seras Contactado para mayor información");
                txtNombre.Clear();
                txtCorreoE.Clear();
                txtNumtelefono.Clear();
                txtEscuelaProce.Clear();
            }
            else
            {
                MessageBox.Show("!!!Error al Guardar¡¡¡");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
