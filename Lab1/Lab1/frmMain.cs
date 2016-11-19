using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ShowAbout()
        {
            frmAbout f = new frmAbout();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Нажата кнопка 1";
        }

      
    }
}
