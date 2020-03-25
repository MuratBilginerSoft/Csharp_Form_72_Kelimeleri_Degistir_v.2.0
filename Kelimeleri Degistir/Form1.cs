using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kelimeleri_Degistir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = textBox1.Text.Contains(textBox2.Text);

            if (x)

            textBox1.Text = textBox1.Text.Replace(textBox2.Text, textBox3.Text);
        }
    }
}
