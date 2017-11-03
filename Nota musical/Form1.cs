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
                
                clear();
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }
        }

        public void insertCourses()
        {
            if (txt_nombre_curso.Text != "" && txt_valor.Text != "" && txt_instructor.Text != "")
            {
                dataBase.insertCourses(txt_nombre_curso.Text, Double.Parse(txt_valor.Text), txt_instructor.Text);
                MessageBox.Show("Curso registrado exitosamente");
                this.cursoTableAdapter.Fill(this.notaMusicalDataSet.curso);
                comboBox1.DataSource = this.cursoBindingSource;
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notaMusicalDataSet.curso' table. You can move, or remove it, as needed.
            this.cursoTableAdapter.Fill(this.notaMusicalDataSet.curso);
            // TODO: This line of code loads data into the 'notaMusicalDataSet.estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.notaMusicalDataSet.estudiante);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_costo.DataSource = dataBase.selectStudents();
            
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

        private void btn_inscribir_curso_Click(object sender, EventArgs e)
        {
            try
            {
                insertCourses();
            }catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        private void btn_matricular_Click(object sender, EventArgs e)
        {
            try
            {
                insertStudentCourse();
            }catch(Exception x)
            {
                MessageBox.Show(x+"");
            }
        }
        private void insertStudentCourse()
        {
            if (cmb_estudiantes.Text != "" && comboBox1.Text != "")
            {
                dataBase.insertStudentsCourse(int.Parse(comboBox1.SelectedValue.ToString()),int.Parse(cmb_estudiantes.SelectedValue.ToString()));
                MessageBox.Show("Estudiante matriculado exitosamente en el curso");
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                updateCourseValue();
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void updateCourseValue()
        {
            if (cmb_actualizar.Text != "" && txt_id_course.Text != "")
            {
                dataBase.updateCourseValue(int.Parse(cmb_actualizar.SelectedValue.ToString()), Double.Parse(txt_id_course.Text));
                MessageBox.Show("Valor del curso actualizado");
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                showStudentCost();
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void showStudentCost()
        {
            if (cmb_estudiante_matricula.Text != "")
            {
                dgv_costo.DataSource=dataBase.selectStudentCost(int.Parse(cmb_estudiante_matricula.SelectedValue.ToString()));

            }
            else
            {
                MessageBox.Show("Debes seleccionar un estudiante");
            }
        }
    }
}
