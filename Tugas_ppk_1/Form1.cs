using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_ppk_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt16(textBox1.Text);
            int y = Convert.ToInt16(textBox2.Text);

            int hasil = x + y;

            textBox3.Text = Convert.ToString(hasil);

        }
    }
}
