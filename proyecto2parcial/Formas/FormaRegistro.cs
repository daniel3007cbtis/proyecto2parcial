using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2parcial.Formas
{
    public partial class FormaRegistro : Form
    {
        public FormaRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Error en algún campo. No se ingresó ningún valor.");
                return;
            }
            if (textBox1.Text.Length < 10)
            {
                MessageBox.Show("Son 10 caracteres mínimo en el usuario.");
                return;
            }

            if (!textBox1.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("La terminación debe ser @gmail.com en usuario.");
                return;
            }

            if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("Debe tener 5 caracteres como mínimo su contraseña si no puede ser algo insegura.");
                return;
            }
            if (!textBox3.Text.All(char.IsLetter) || !textBox4.Text.All(char.IsLetter))
            {
                MessageBox.Show("Solo se permite letras en los campos nombre y apellidos.");
                return;
            }
            if (textBox3.Text.Length < 3 || textBox4.Text.Length < 3)
            {
                MessageBox.Show("Nombre o apellido muy corto.");
                return;
            }

            

            if (!textBox5.Text.All(char.IsDigit))
            {
                MessageBox.Show("Solo se puede ingresar números en el numero de celular.");
                return;
            }

            if (dateTimePicker1.Value.Year > 2013)
            {
                MessageBox.Show("Eres muy pequeño para tener cuenta.");
                return;
            }

           

            MessageBox.Show("Cuenta añadida al sistema.");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
