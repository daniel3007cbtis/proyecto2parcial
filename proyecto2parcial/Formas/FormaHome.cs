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
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Asegúrate de que haya al menos una columna en el DataGridView
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Columna1", "Columna 1");
                dataGridView1.Columns.Add("Columna2", "Columna 2");
                dataGridView1.Columns.Add("Columna3", "Columna 3");
                dataGridView1.Columns.Add("Columna4", "Columna 4");
                dataGridView1.Columns.Add("Columna5", "Columna 5");
            }

            // Añade los datos ingresados en los 5 textboxes a la DataGridView
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = "¿desea eliminar mensaje?";
            string titulo = "eliminar el registro";
            if (!(dataGridView1.CurrentRow is null)) {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }




            }
            else
            {
                MessageBox.Show("debes seleccionar un renglon ", "eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private bool isEditable = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (isEditable)
            {
                // Si el DataGridView ya está en modo edición, se desactiva
                dataGridView1.ReadOnly = true;
                isEditable = false;
            }
            else
            {
                // Se muestra un MessageBox preguntando si se desea modificar la columna
                var result = MessageBox.Show("¿Quiere modificar la columna?", "Editar columna", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Si se desea modificar la columna, se activa el modo edición
                    dataGridView1.ReadOnly = false;
                    isEditable = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }
    }
}

    


