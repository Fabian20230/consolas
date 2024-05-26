using consolas.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static consolas.Data.CONSOLAS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace consolas
{
    public partial class Form1 : Form
    {

        ConexionMYSQL CLscone = new ConexionMYSQL();
        consolasdd clsd = new consolasdd();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLscone.Insertar(textBoxCONSOLA.Text, textBoxCOMPAÑIA.Text, dateTimePickerFECHA.Value, textBoxGENERACION.Text);
            MessageBox.Show("REGISTRO AGRAGADO CORRECTAMENTE");

        }

        private void dateTimePickerFECHA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clsd.nombre_consola = textBoxCONSOLA.Text;
            clsd.compania = textBoxCOMPAÑIA.Text;
            clsd.anio_lanzamiento = dateTimePickerFECHA.Value;
            clsd.generacion = textBoxGENERACION.Text;
            CLscone.Insertar(clsd);
            MessageBox.Show("registro correcto");
        }
    }
}
