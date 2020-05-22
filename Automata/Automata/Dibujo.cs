using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata
{
    public partial class Dibujo : Form
    {
        private Form1 formas;
        public Dibujo()
        {
            InitializeComponent();
        }

        private void Dibujo_Load(object sender, EventArgs e)
        {
            formas = new Form1();
            
            label1.Text = "Los estados dentro del Automata son:"+ formas.num_estados;
            label2.Text = "El estado inicial es:";
            label3.Text = "Los estados de finalizacion son:";
            label4.Text = "El alfabeto del AFD es:";

        }
    }
}
