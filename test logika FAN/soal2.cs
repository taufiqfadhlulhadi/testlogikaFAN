using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_logika_FAN
{
    public partial class soal2 : Form
    {
        string[] kalimat;
        int jumlah_kata = 0;
        public soal2()
        {
            InitializeComponent();
        }

        public void check()
        {
            kalimat = textBox1.Text.Split(' ');
            for (int i = 0; i < kalimat.Length;i++)
            {
                if (check_special_character(kalimat[i]) == false)
                {
                    jumlah_kata++;
                }
            }
        }

        //titik(.), koma(.), strip(-), tanda seru(!) termasuk didalam karakter special
        public bool check_special_character(string kata)
        {
            return kata.Any(ch => !Char.IsLetterOrDigit(ch));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jumlah_kata = 0;
            check();
            label1.Text = "Jumlah kata = " + jumlah_kata.ToString();
                
        }
    }
}
