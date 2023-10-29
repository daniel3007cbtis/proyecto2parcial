using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto2parcial.Formas;

namespace proyecto2parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ValidateForm()
        {
            if (textBox1.Text.Length < 10)
            {
                MessageBox.Show("Son 10 caracteres mínimo en el usuario");
                return false;
            }

            if (!textBox1.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("La terminación debe ser @gmail.com en usuario");
                return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                FormaHome inicio = new FormaHome();
                inicio.Show();
                Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormaRegistro home = new FormaRegistro();
            home.Show();
            Hide();
        }
    }
}
