using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           textBox1.Text = "Odabrali ste: " + comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
