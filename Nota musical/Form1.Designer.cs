﻿namespace Nota_musical
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_inscribir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_estudiante = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_inscribir_curso = new System.Windows.Forms.Button();
            this.txt_instructor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre_curso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_matricular = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaMusicalDataSet = new Nota_musical.NotaMusicalDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_estudiantes = new System.Windows.Forms.ComboBox();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_costo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_estudiante_matricula = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id_course = new System.Windows.Forms.MaskedTextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.cmb_actualizar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_cursos_recogido = new System.Windows.Forms.Button();
            this.dgv_panel = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_curso_reporte = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.estudianteTableAdapter = new Nota_musical.NotaMusicalDataSetTableAdapters.estudianteTableAdapter();
            this.cursoTableAdapter = new Nota_musical.NotaMusicalDataSetTableAdapters.cursoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaMusicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_costo)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_panel)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.btn_inscribir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre_estudiante);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos estudiante";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 169);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(188, 20);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btn_inscribir
            // 
            this.btn_inscribir.BackColor = System.Drawing.Color.Teal;
            this.btn_inscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscribir.ForeColor = System.Drawing.Color.White;
            this.btn_inscribir.Location = new System.Drawing.Point(10, 234);
            this.btn_inscribir.Name = "btn_inscribir";
            this.btn_inscribir.Size = new System.Drawing.Size(184, 45);
            this.btn_inscribir.TabIndex = 8;
            this.btn_inscribir.Text = "Inscribir estudiante";
            this.btn_inscribir.UseVisualStyleBackColor = false;
            this.btn_inscribir.Click += new System.EventHandler(this.btn_inscribir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingresa los datos para la inscripcion de estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(6, 118);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(188, 20);
            this.txt_apellidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre_estudiante
            // 
            this.txt_nombre_estudiante.Location = new System.Drawing.Point(6, 69);
            this.txt_nombre_estudiante.Name = "txt_nombre_estudiante";
            this.txt_nombre_estudiante.Size = new System.Drawing.Size(188, 20);
            this.txt_nombre_estudiante.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_inscribir_curso);
            this.groupBox2.Controls.Add(this.txt_instructor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_valor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_nombre_curso);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(423, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos cursos";
            // 
            // btn_inscribir_curso
            // 
            this.btn_inscribir_curso.BackColor = System.Drawing.Color.Teal;
            this.btn_inscribir_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscribir_curso.ForeColor = System.Drawing.Color.White;
            this.btn_inscribir_curso.Location = new System.Drawing.Point(7, 234);
            this.btn_inscribir_curso.Name = "btn_inscribir_curso";
            this.btn_inscribir_curso.Size = new System.Drawing.Size(188, 45);
            this.btn_inscribir_curso.TabIndex = 10;
            this.btn_inscribir_curso.Text = "Inscribir curso";
            this.btn_inscribir_curso.UseVisualStyleBackColor = false;
            this.btn_inscribir_curso.Click += new System.EventHandler(this.btn_inscribir_curso_Click);
            // 
            // txt_instructor
            // 
            this.txt_instructor.Location = new System.Drawing.Point(7, 169);
            this.txt_instructor.Name = "txt_instructor";
            this.txt_instructor.Size = new System.Drawing.Size(188, 20);
            this.txt_instructor.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Instructor del curso";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(7, 117);
            this.txt_valor.Mask = "9999999";
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(188, 20);
            this.txt_valor.TabIndex = 13;
            this.txt_valor.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor del curso";
            // 
            // txt_nombre_curso
            // 
            this.txt_nombre_curso.Location = new System.Drawing.Point(7, 68);
            this.txt_nombre_curso.Name = "txt_nombre_curso";
            this.txt_nombre_curso.Size = new System.Drawing.Size(188, 20);
            this.txt_nombre_curso.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre del curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingresa los datos del curso";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(76, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 469);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matricular estudiante";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_matricular);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmb_estudiantes);
            this.groupBox3.Location = new System.Drawing.Point(179, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 284);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos matricula";
            // 
            // btn_matricular
            // 
            this.btn_matricular.BackColor = System.Drawing.Color.Teal;
            this.btn_matricular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_matricular.ForeColor = System.Drawing.Color.White;
            this.btn_matricular.Location = new System.Drawing.Point(180, 161);
            this.btn_matricular.Name = "btn_matricular";
            this.btn_matricular.Size = new System.Drawing.Size(186, 45);
            this.btn_matricular.TabIndex = 5;
            this.btn_matricular.Text = "Matricular";
            this.btn_matricular.UseVisualStyleBackColor = false;
            this.btn_matricular.Click += new System.EventHandler(this.btn_matricular_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Curso";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cursoBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Id";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "curso";
            this.cursoBindingSource.DataSource = this.notaMusicalDataSet;
            // 
            // notaMusicalDataSet
            // 
            this.notaMusicalDataSet.DataSetName = "NotaMusicalDataSet";
            this.notaMusicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Estudiante";
            // 
            // cmb_estudiantes
            // 
            this.cmb_estudiantes.DataSource = this.estudianteBindingSource;
            this.cmb_estudiantes.DisplayMember = "nombre";
            this.cmb_estudiantes.FormattingEnabled = true;
            this.cmb_estudiantes.Location = new System.Drawing.Point(180, 77);
            this.cmb_estudiantes.Name = "cmb_estudiantes";
            this.cmb_estudiantes.Size = new System.Drawing.Size(186, 21);
            this.cmb_estudiantes.TabIndex = 2;
            this.cmb_estudiantes.ValueMember = "Id";
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "estudiante";
            this.estudianteBindingSource.DataSource = this.notaMusicalDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(340, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Matricular estudiante";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_costo);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.cmb_estudiante_matricula);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(836, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Valor matricula";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_costo
            // 
            this.dgv_costo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_costo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_costo.Location = new System.Drawing.Point(51, 134);
            this.dgv_costo.Name = "dgv_costo";
            this.dgv_costo.Size = new System.Drawing.Size(737, 295);
            this.dgv_costo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(270, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label14.Location = new System.Drawing.Point(263, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 39);
            this.label14.TabIndex = 1;
            this.label14.Text = "Valor matricula";
            // 
            // cmb_estudiante_matricula
            // 
            this.cmb_estudiante_matricula.DataSource = this.estudianteBindingSource;
            this.cmb_estudiante_matricula.DisplayMember = "nombre";
            this.cmb_estudiante_matricula.FormattingEnabled = true;
            this.cmb_estudiante_matricula.Location = new System.Drawing.Point(270, 56);
            this.cmb_estudiante_matricula.Name = "cmb_estudiante_matricula";
            this.cmb_estudiante_matricula.Size = new System.Drawing.Size(243, 21);
            this.cmb_estudiante_matricula.TabIndex = 0;
            this.cmb_estudiante_matricula.ValueMember = "Id";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.txt_id_course);
            this.tabPage4.Controls.Add(this.btn_actualizar);
            this.tabPage4.Controls.Add(this.cmb_actualizar);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(836, 443);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Actualizar datos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(342, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Nuevo valor del curso";
            // 
            // txt_id_course
            // 
            this.txt_id_course.Location = new System.Drawing.Point(300, 201);
            this.txt_id_course.Mask = "99999999999999999999";
            this.txt_id_course.Name = "txt_id_course";
            this.txt_id_course.Size = new System.Drawing.Size(191, 20);
            this.txt_id_course.TabIndex = 3;
            this.txt_id_course.ValidatingType = typeof(int);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Teal;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Location = new System.Drawing.Point(300, 241);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(191, 45);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // cmb_actualizar
            // 
            this.cmb_actualizar.DataSource = this.cursoBindingSource;
            this.cmb_actualizar.DisplayMember = "nombre";
            this.cmb_actualizar.FormattingEnabled = true;
            this.cmb_actualizar.Location = new System.Drawing.Point(300, 139);
            this.cmb_actualizar.Name = "cmb_actualizar";
            this.cmb_actualizar.Size = new System.Drawing.Size(191, 21);
            this.cmb_actualizar.TabIndex = 1;
            this.cmb_actualizar.ValueMember = "Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label12.Location = new System.Drawing.Point(205, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(406, 39);
            this.label12.TabIndex = 0;
            this.label12.Text = "Actualizar valor del curso";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgv_panel);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(836, 443);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Reportes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_cursos_recogido
            // 
            this.btn_cursos_recogido.BackColor = System.Drawing.Color.Teal;
            this.btn_cursos_recogido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cursos_recogido.ForeColor = System.Drawing.Color.White;
            this.btn_cursos_recogido.Location = new System.Drawing.Point(101, 188);
            this.btn_cursos_recogido.Name = "btn_cursos_recogido";
            this.btn_cursos_recogido.Size = new System.Drawing.Size(213, 45);
            this.btn_cursos_recogido.TabIndex = 3;
            this.btn_cursos_recogido.Text = "Generar reporte cursos";
            this.btn_cursos_recogido.UseVisualStyleBackColor = false;
            this.btn_cursos_recogido.Click += new System.EventHandler(this.btn_cursos_recogido_Click);
            // 
            // dgv_panel
            // 
            this.dgv_panel.BackgroundColor = System.Drawing.Color.White;
            this.dgv_panel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_panel.Location = new System.Drawing.Point(520, 51);
            this.dgv_panel.Name = "dgv_panel";
            this.dgv_panel.Size = new System.Drawing.Size(313, 249);
            this.dgv_panel.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_cursos_recogido);
            this.groupBox5.Controls.Add(this.btn_generar);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.cmb_curso_reporte);
            this.groupBox5.Location = new System.Drawing.Point(3, 51);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(407, 249);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estudiantes";
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.Teal;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.ForeColor = System.Drawing.Color.White;
            this.btn_generar.Location = new System.Drawing.Point(101, 117);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(213, 45);
            this.btn_generar.TabIndex = 2;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(172, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Curso";
            // 
            // cmb_curso_reporte
            // 
            this.cmb_curso_reporte.DataSource = this.cursoBindingSource;
            this.cmb_curso_reporte.DisplayMember = "nombre";
            this.cmb_curso_reporte.FormattingEnabled = true;
            this.cmb_curso_reporte.Location = new System.Drawing.Point(101, 76);
            this.cmb_curso_reporte.Name = "cmb_curso_reporte";
            this.cmb_curso_reporte.Size = new System.Drawing.Size(213, 21);
            this.cmb_curso_reporte.TabIndex = 0;
            this.cmb_curso_reporte.ValueMember = "Id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label15.Location = new System.Drawing.Point(242, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(281, 39);
            this.label15.TabIndex = 0;
            this.label15.Text = "Generar reportes";
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 494);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Nota musical";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaMusicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_costo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_panel)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_estudiante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btn_inscribir;
        private System.Windows.Forms.MaskedTextBox txt_valor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombre_curso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_inscribir_curso;
        private System.Windows.Forms.TextBox txt_instructor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_estudiantes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private NotaMusicalDataSet notaMusicalDataSet;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private NotaMusicalDataSetTableAdapters.estudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private NotaMusicalDataSetTableAdapters.cursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.Button btn_matricular;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.ComboBox cmb_actualizar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txt_id_course;
        private System.Windows.Forms.DataGridView dgv_costo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_estudiante_matricula;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgv_panel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_curso_reporte;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_cursos_recogido;
    }
}

