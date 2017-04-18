using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MaquinaDeSomar : Form
    {
        public MaquinaDeSomar()
        {
            InitializeComponent();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valor1 = Convert.ToDouble(textBox1.Text);
            double valor2 = Convert.ToDouble(textBox2.Text);
            double resultado = valor1 + valor2;
            textBox3.Text = Convert.ToString(resultado);
            label1.Text = Convert.ToString(resultado);
            label2.Show();
        }

        
    }
}
