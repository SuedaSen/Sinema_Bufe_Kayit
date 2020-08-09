using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(TxtMısır.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtÇay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " TL  ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = " ";
            TxtÇay.Text = " ";
            TxtMısır.Text = " ";
            TxtSu.Text = " ";
            TxtMısır.Focus()  ;
        }
    }
}
