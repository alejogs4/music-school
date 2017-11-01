using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nota_musical
{
    public partial class Form1 : Form
    {
        BD dataBase = new BD();
        DataTable students = new DataTable();
        List<string> names = new List<string>();
        List<string> ids = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_inscribir_Click(object sender, EventArgs e)
        {
            try
            {
                insertStudents();
            } catch(Exception x)
            {
                Console.Write(x.Message);
            }
        }

        public void insertStudents()
        {
            if (txt_nombre_estudiante.Text != "" && txt_apellidos.Text != "" && maskedTextBox1.Text != "")
            {
                dataBase.insertStudents(txt_nombre_estudiante.Text, txt_apellidos.Text, maskedTextBox1.Text, 0);
                MessageBox.Show("Estudiante ingresado satisfactoriamente");
                updateComboBox();
                clear();
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataBase.selectStudents();
            MessageBox.Show(names.Count + "");
        }
        public void updateComboBox()
        {
            names.Clear();
            ids.Clear();
            dataGridView1.DataSource = null;
            cmb_estudiantes.DataSource = null;
            DataTable StudentTable = dataBase.selectStudents();
            dataGridView1.DataSource = StudentTable;
            StudentTable = null;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                names.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                ids.Add((dataGridView1.Rows[i].Cells[0].Value.ToString()));
            }
            cmb_estudiantes.DataSource = names;
            cmb_estudiantes.ValueMember = ids;
        }
        public void clear()
        {
            txt_nombre_estudiante.Text = "";
            txt_apellidos.Text = "";
            maskedTextBox1.Text = "";
            txt_instructor.Text = "";
            txt_nombre_curso.Text = "";
            txt_valor.Text = "";
        }
    }
}
