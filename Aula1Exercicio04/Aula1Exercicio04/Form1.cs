using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1Exercicio04
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            Msg1.Visible= true;
            Msg1.Text = "Essa cor é vermelha";  
            Msg1.ForeColor= Color.Red;
        }

        private void lime_Click(object sender, EventArgs e)
        {
            Msg1.Visible= true;
            Msg1.Text = "Essa cor é verde";
            Msg1.ForeColor = Color.Lime;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            Msg1.Visible= true;
            Msg1.Text = "Essa cor é azul";
            Msg1.ForeColor = Color.Aqua;
        }
    }
}
