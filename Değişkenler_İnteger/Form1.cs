using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_İnteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa_kenar, uzun_kenar, alan, cevre;
            kisa_kenar = Convert.ToInt16(textBox1.Text);
            uzun_kenar = Convert.ToInt16(textBox2.Text);
            alan = kisa_kenar * uzun_kenar;
            cevre = 2 * (kisa_kenar + uzun_kenar);
            listBox1.Items.Add("Alan:  " + alan + "  Cevre: " + cevre);
        }
    }
}
