using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado1_T3_G9
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }
        //Genera el formulario Proyecto 1
        private void btn_Proyect1_Click(object sender, EventArgs e)
        {
            Proyecto1 G9_frm = new Proyecto1();
            G9_frm.ShowDialog();
        }
        //Genera el formulario Proyecto 2
        private void btn_Proyect2_Click(object sender, EventArgs e)
        {
            Proyecto2 G9_frm = new Proyecto2();
            G9_frm.ShowDialog();
        }
    }
}
