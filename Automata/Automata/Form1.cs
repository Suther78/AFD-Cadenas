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
    public partial class Form1 : Form
    {
        int contador;
        char[] charArr;
        bool aceptado;
        public int num_estados;
        string inicial, final;
        string alfabeto;
        
        private Dibujo dib;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dibujo dib = new Dibujo();
            dib.Visible = true;
            num_estados = int.Parse(textBox1.Text);
            inicial = textBox3.Text;
            final = textBox4.Text;
            alfabeto = textBox2.Text;
            charArr = alfabeto.ToCharArray();
            var resultstring = "";
            foreach (char ch in alfabeto.ToCharArray())
            {
                resultstring +=  "Alfabeto : " + ch.ToString() + "\n";
            }
            dib.label1.Text = "Los estados dentro del Automata son:" + num_estados ;
            dib.label2.Text = "El estado inicial es: "+ inicial;
            dib.label3.Text = "Los estados de finalizacion son:" + final;
            dib.label4.Text = "Alfabeto: "+resultstring;
            

        }
    }
}
