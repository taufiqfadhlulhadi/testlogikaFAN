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
    public partial class Form1 : Form
    {
        string[] pasang_sepatu;
        int pasang_terjual = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void txtbox_to_array()
        {
            pasang_sepatu = txtBox1.Text.Split(',');
            int[] pasang_sepatu_int = Array.ConvertAll(pasang_sepatu, int.Parse);
            int check_sama = pasang_sepatu_int[0];
            int temp_array = 0;
            Array.Sort(pasang_sepatu_int);
            //MessageBox.Show(pasang_sepatu_int.ToString());
            for (int i = 0; i < pasang_sepatu_int.Length; i++)
            {
                if (pasang_sepatu_int[i] == check_sama )
                {
                    temp_array++;
                    if (temp_array >= 2)
                    {
                        temp_array = 0;
                        pasang_terjual++;
                    }   
                } else
                {
                    check_sama = pasang_sepatu_int[i];
                    if (pasang_sepatu_int[i] == check_sama)
                    {
                        temp_array++;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox_to_array();
            label1.Text = "Pasang terjual : " + pasang_terjual.ToString();
            pasang_terjual = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soal2 soalke2 = new soal2();
            soalke2.ShowDialog();
        }
    }
}
