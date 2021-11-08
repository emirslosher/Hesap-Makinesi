using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int say1, say2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToInt32(txtSay1.Text);
            say2 = Convert.ToInt32(txtSay2.Text);
            lblSonuc.Text = ("Sonuç = " + say1 * say2).ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToInt32(txtSay1.Text);
            say2 = Convert.ToInt32(txtSay2.Text);
            lblSonuc.Text = "Sonuç = " + (say1 - say2).ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToInt32(txtSay1.Text);
            say2 = Convert.ToInt32(txtSay2.Text);
            lblSonuc.Text = ("Sonuç = "+ say1 / say2).ToString();
        }


        private void btnTopla_Click(object sender, EventArgs e)
        {
            say1 = Convert.ToInt32(txtSay1.Text);
            say2 = Convert.ToInt32(txtSay2.Text);
            lblSonuc.Text =  ("Sonuç = ") + (say1 + say2).ToString();

        }



        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.Text = "Hesap Makinesi";
            lblSonuc.Text = "0";

        }
    }
}
