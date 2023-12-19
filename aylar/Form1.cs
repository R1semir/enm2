using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aylar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum aylar
        {
           Bulunamadı,Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int girilenay = Convert.ToInt16(textBox1.Text);
            aylar bul;
            bul = (aylar)girilenay;
            label2.Text = bul.ToString();
        }
    }
}
