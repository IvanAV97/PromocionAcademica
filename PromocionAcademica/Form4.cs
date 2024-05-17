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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maestro maestro = new Maestro();
            maestro.NumeroDeEmpleado = Convert.ToInt32(txtNumEmpleado.Text);
            maestro.Nombre = txtNombreMaestro.Text;
            maestro.Apellido = txtApellidoMaestro.Text;
            maestro.CorreoElectronico = ttxtCorreoMaestro.Text;
            maestro.NumeroTelefono = txtNumTelMaestro.Text;
            maestro.AreaProfesional = CbAreaProfesional.Text;


            int result = MaestrosDal.AgregarMaestro(maestro);
            if (result > 0)
            {
                MessageBox.Show("El Maestro ha sido dado de alta Exitosamente!!", "FELICIDADES!!");
                txtNombreMaestro.Clear();
                txtNombreMaestro.Clear();
                txtApellidoMaestro.Clear();
                ttxtCorreoMaestro.Clear();
                txtNumTelMaestro.Clear();
                




            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
        }
    }
}
