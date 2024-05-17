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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 Profesores = new Form4();
            Profesores.Show();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void visionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formar ciudadanos integrales y competentes, con sentido crítico, ético y de responsabilidad social, altamente capacitados para desempeñarse con éxito y generar conocimiento, con base en un innovador modelo educativo para el desarrollo integral con enfoque en competencias profesionales, Programas Educativos pertinentes, gestión de calidad y transparencia, con la finalidad de contribuir a la consolidación de una sociedad más justa, democrática, pacífica, solidaria y respetuosa del ambiente y el desarrollo sustentable.", "Nuestra Mision: ");
        }

        private void misionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La Universidad Autónoma de Occidente es una institución ampliamente reconocida en el país por su contribución al desarrollo sostenible de la sociedad sinaloense, de la región y de México; utilizando criterios de calidad, pertinencia, equidad e inclusión implementa procesos de generación, aplicación y transferencia del conocimiento y de promoción de la cultura y el arte.");
        }

        private void cargoAcademicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 CargaAcademica = new Form3();
            CargaAcademica.Show();
        }

        private void solicitarMásInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Datosaspirante = new Form2();
            Datosaspirante.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Profesores = new Form4();
            Profesores.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Eventos = new Form5();
            Eventos.Show();
        }
    }
    
}
