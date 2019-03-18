using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            sombra_izquierda.Height = button1.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
            relatividad1.Visible = false;
            graviacion_Universal1.Visible = false;
            pitagoras1.Visible = false;
            dilatacion_Tiempo1.Visible = false;
            primera_Ley1.Visible = false;
            segunda_Ley1.Visible = false;
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sombra_izquierda.Height = button1.Height;
            sombra_izquierda.Top = button1.Top;
            button1.BackColor = Color.FromArgb(1,68,87);
            button2.BackColor = Color.FromArgb(11, 32,39);
            button3.BackColor = Color.FromArgb(11, 32,39);
            button4.BackColor = Color.FromArgb(11, 32,39);
            button5.BackColor = Color.FromArgb(11, 32,39);
            button6.BackColor = Color.FromArgb(11, 32,39);


            relatividad1.BringToFront();
            relatividad1.Visible = true;

            relatividad1.Location = new Point(243, 37);
            relatividad1.Size = new Size(859, 601);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            sombra_izquierda.Height = button2.Height;
            sombra_izquierda.Top = button2.Top;
            
            button1.BackColor = Color.FromArgb(11, 32,39);
            button2.BackColor = Color.FromArgb(1, 68, 87);
            button3.BackColor = Color.FromArgb(11, 32,39);
            button4.BackColor = Color.FromArgb(11, 32,39);
            button5.BackColor = Color.FromArgb(11, 32,39);
            button6.BackColor = Color.FromArgb(11, 32,39);

            graviacion_Universal1.BringToFront();
            graviacion_Universal1.Visible = true;

            graviacion_Universal1.Location = new Point(243, 37);
            graviacion_Universal1.Size = new Size(859, 601);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sombra_izquierda.Height = button3.Height;
            sombra_izquierda.Top = button3.Top;
            button1.BackColor = Color.FromArgb(11, 32,39);
            button2.BackColor = Color.FromArgb(11, 32,39);
            button3.BackColor = Color.FromArgb(1, 68, 87);
            button4.BackColor = Color.FromArgb(11, 32,39);
            button5.BackColor = Color.FromArgb(11, 32,39);
            button6.BackColor = Color.FromArgb(11, 32,39);

            pitagoras1.BringToFront();
            pitagoras1.Visible = true;

            pitagoras1.Location = new Point(243, 37);
            pitagoras1.Size = new Size(859, 601);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sombra_izquierda.Height = button4.Height;
            sombra_izquierda.Top = button4.Top;

            button1.BackColor = Color.FromArgb(11, 32,39);
            button2.BackColor = Color.FromArgb(11, 32,39);
            button3.BackColor = Color.FromArgb(11, 32,39);
            button4.BackColor = Color.FromArgb(1, 68, 87);
            button5.BackColor = Color.FromArgb(11, 32,39);
            button6.BackColor = Color.FromArgb(11, 32,39);

            dilatacion_Tiempo1.BringToFront();
            dilatacion_Tiempo1.Visible = true;

            dilatacion_Tiempo1.Location = new Point(243, 37);
            dilatacion_Tiempo1.Size = new Size(859, 601);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sombra_izquierda.Height = button5.Height;
            sombra_izquierda.Top = button5.Top;
            
            button1.BackColor = Color.FromArgb(11, 32,39);
            button2.BackColor = Color.FromArgb(11, 32,39);
            button3.BackColor = Color.FromArgb(11, 32,39);
            button4.BackColor = Color.FromArgb(11, 32,39);
            button5.BackColor = Color.FromArgb(1, 68, 87);
            button6.BackColor = Color.FromArgb(11, 32,39);

            primera_Ley1.BringToFront();
            primera_Ley1.Visible = true;

            primera_Ley1.Location = new Point(243, 37);
            primera_Ley1.Size = new Size(859, 601);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sombra_izquierda.Height = button6.Height;
            sombra_izquierda.Top = button6.Top;

            button1.BackColor = Color.FromArgb(11, 32,39);
            button2.BackColor = Color.FromArgb(11, 32,39);
            button3.BackColor = Color.FromArgb(11, 32,39);
            button4.BackColor = Color.FromArgb(11, 32,39);
            button5.BackColor = Color.FromArgb(11, 32,39);
            button6.BackColor = Color.FromArgb(1, 68, 87);

            segunda_Ley1.BringToFront();
            segunda_Ley1.Visible = true;

            segunda_Ley1.Location = new Point(243, 37);
            segunda_Ley1.Size = new Size(859, 601);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
