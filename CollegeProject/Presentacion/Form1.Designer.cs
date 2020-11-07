namespace CollegeProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelPractica = new System.Windows.Forms.Label();
            this.labelParcial = new System.Windows.Forms.Label();
            this.labelExamen = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxPractica = new System.Windows.Forms.TextBox();
            this.textBoxParcial = new System.Windows.Forms.TextBox();
            this.textBoxExamen = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.listAlumnos = new System.Windows.Forms.ListView();
            this.columnHeaderCodigo = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNombres = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPractica = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderParcial = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderExamen = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPromedio = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNivel = new System.Windows.Forms.ColumnHeader();
            this.labelMejorAlumno = new System.Windows.Forms.Label();
            this.labelPeorAlumno = new System.Windows.Forms.Label();
            this.textBoxMejorAlumno = new System.Windows.Forms.TextBox();
            this.textBoxPeorAlumno = new System.Windows.Forms.TextBox();
            this.textBoxPromedioClase = new System.Windows.Forms.TextBox();
            this.textBoxAprobados = new System.Windows.Forms.TextBox();
            this.textBoxDesaprobados = new System.Windows.Forms.TextBox();
            this.labelDesaprobados = new System.Windows.Forms.Label();
            this.labelAprobados = new System.Windows.Forms.Label();
            this.labelPromedioClase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(44, 26);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(49, 15);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo:";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(44, 55);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(59, 15);
            this.labelNombres.TabIndex = 1;
            this.labelNombres.Text = "Nombres:";
            // 
            // labelPractica
            // 
            this.labelPractica.AutoSize = true;
            this.labelPractica.Location = new System.Drawing.Point(44, 84);
            this.labelPractica.Name = "labelPractica";
            this.labelPractica.Size = new System.Drawing.Size(52, 15);
            this.labelPractica.TabIndex = 2;
            this.labelPractica.Text = "Practica:";
            // 
            // labelParcial
            // 
            this.labelParcial.AutoSize = true;
            this.labelParcial.Location = new System.Drawing.Point(44, 113);
            this.labelParcial.Name = "labelParcial";
            this.labelParcial.Size = new System.Drawing.Size(45, 15);
            this.labelParcial.TabIndex = 3;
            this.labelParcial.Text = "Parcial:";
            // 
            // labelExamen
            // 
            this.labelExamen.AutoSize = true;
            this.labelExamen.Location = new System.Drawing.Point(44, 142);
            this.labelExamen.Name = "labelExamen";
            this.labelExamen.Size = new System.Drawing.Size(52, 15);
            this.labelExamen.TabIndex = 4;
            this.labelExamen.Text = "Examen:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(146, 23);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 23);
            this.textBoxCodigo.TabIndex = 5;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(146, 52);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(100, 23);
            this.textBoxNombres.TabIndex = 6;
            // 
            // textBoxPractica
            // 
            this.textBoxPractica.Location = new System.Drawing.Point(146, 81);
            this.textBoxPractica.Name = "textBoxPractica";
            this.textBoxPractica.Size = new System.Drawing.Size(100, 23);
            this.textBoxPractica.TabIndex = 7;
            // 
            // textBoxParcial
            // 
            this.textBoxParcial.Location = new System.Drawing.Point(146, 110);
            this.textBoxParcial.Name = "textBoxParcial";
            this.textBoxParcial.Size = new System.Drawing.Size(100, 23);
            this.textBoxParcial.TabIndex = 8;
            // 
            // textBoxExamen
            // 
            this.textBoxExamen.Location = new System.Drawing.Point(146, 139);
            this.textBoxExamen.Name = "textBoxExamen";
            this.textBoxExamen.Size = new System.Drawing.Size(100, 23);
            this.textBoxExamen.TabIndex = 9;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(347, 45);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(103, 35);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(347, 104);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(103, 35);
            this.buttonQuitar.TabIndex = 11;
            this.buttonQuitar.Text = "Quitar";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            // 
            // listAlumnos
            // 
            this.listAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodigo,
            this.columnHeaderNombres,
            this.columnHeaderPractica,
            this.columnHeaderParcial,
            this.columnHeaderExamen,
            this.columnHeaderPromedio,
            this.columnHeaderNivel});
            this.listAlumnos.HideSelection = false;
            this.listAlumnos.Location = new System.Drawing.Point(44, 185);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.Size = new System.Drawing.Size(448, 205);
            this.listAlumnos.TabIndex = 12;
            this.listAlumnos.UseCompatibleStateImageBehavior = false;
            this.listAlumnos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "Codigo";
            // 
            // columnHeaderNombres
            // 
            this.columnHeaderNombres.Text = "Nombres";
            // 
            // columnHeaderPractica
            // 
            this.columnHeaderPractica.Text = "Práctica";
            // 
            // columnHeaderParcial
            // 
            this.columnHeaderParcial.Text = "Parcial";
            // 
            // columnHeaderExamen
            // 
            this.columnHeaderExamen.Text = "Examen";
            // 
            // columnHeaderPromedio
            // 
            this.columnHeaderPromedio.Text = "Promedio";
            // 
            // columnHeaderNivel
            // 
            this.columnHeaderNivel.Text = "Nivel";
            // 
            // labelMejorAlumno
            // 
            this.labelMejorAlumno.AutoSize = true;
            this.labelMejorAlumno.Location = new System.Drawing.Point(44, 419);
            this.labelMejorAlumno.Name = "labelMejorAlumno";
            this.labelMejorAlumno.Size = new System.Drawing.Size(87, 15);
            this.labelMejorAlumno.TabIndex = 13;
            this.labelMejorAlumno.Text = "Mejor Alumno:";
            // 
            // labelPeorAlumno
            // 
            this.labelPeorAlumno.AutoSize = true;
            this.labelPeorAlumno.Location = new System.Drawing.Point(44, 459);
            this.labelPeorAlumno.Name = "labelPeorAlumno";
            this.labelPeorAlumno.Size = new System.Drawing.Size(80, 15);
            this.labelPeorAlumno.TabIndex = 14;
            this.labelPeorAlumno.Text = "Peor Alumno:";
            // 
            // textBoxMejorAlumno
            // 
            this.textBoxMejorAlumno.Location = new System.Drawing.Point(146, 416);
            this.textBoxMejorAlumno.Name = "textBoxMejorAlumno";
            this.textBoxMejorAlumno.Size = new System.Drawing.Size(100, 23);
            this.textBoxMejorAlumno.TabIndex = 15;
            // 
            // textBoxPeorAlumno
            // 
            this.textBoxPeorAlumno.Location = new System.Drawing.Point(146, 456);
            this.textBoxPeorAlumno.Name = "textBoxPeorAlumno";
            this.textBoxPeorAlumno.Size = new System.Drawing.Size(100, 23);
            this.textBoxPeorAlumno.TabIndex = 16;
            // 
            // textBoxPromedioClase
            // 
            this.textBoxPromedioClase.Location = new System.Drawing.Point(392, 416);
            this.textBoxPromedioClase.Name = "textBoxPromedioClase";
            this.textBoxPromedioClase.Size = new System.Drawing.Size(100, 23);
            this.textBoxPromedioClase.TabIndex = 17;
            // 
            // textBoxAprobados
            // 
            this.textBoxAprobados.Location = new System.Drawing.Point(392, 456);
            this.textBoxAprobados.Name = "textBoxAprobados";
            this.textBoxAprobados.Size = new System.Drawing.Size(100, 23);
            this.textBoxAprobados.TabIndex = 18;
            // 
            // textBoxDesaprobados
            // 
            this.textBoxDesaprobados.Location = new System.Drawing.Point(392, 496);
            this.textBoxDesaprobados.Name = "textBoxDesaprobados";
            this.textBoxDesaprobados.Size = new System.Drawing.Size(100, 23);
            this.textBoxDesaprobados.TabIndex = 19;
            // 
            // labelDesaprobados
            // 
            this.labelDesaprobados.AutoSize = true;
            this.labelDesaprobados.Location = new System.Drawing.Point(287, 499);
            this.labelDesaprobados.Name = "labelDesaprobados";
            this.labelDesaprobados.Size = new System.Drawing.Size(85, 15);
            this.labelDesaprobados.TabIndex = 21;
            this.labelDesaprobados.Text = "Desaprobados:";
            // 
            // labelAprobados
            // 
            this.labelAprobados.AutoSize = true;
            this.labelAprobados.Location = new System.Drawing.Point(287, 459);
            this.labelAprobados.Name = "labelAprobados";
            this.labelAprobados.Size = new System.Drawing.Size(68, 15);
            this.labelAprobados.TabIndex = 22;
            this.labelAprobados.Text = "Aprobados:";
            // 
            // labelPromedioClase
            // 
            this.labelPromedioClase.AutoSize = true;
            this.labelPromedioClase.Location = new System.Drawing.Point(287, 419);
            this.labelPromedioClase.Name = "labelPromedioClase";
            this.labelPromedioClase.Size = new System.Drawing.Size(93, 15);
            this.labelPromedioClase.TabIndex = 23;
            this.labelPromedioClase.Text = "Promedio Clase:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 553);
            this.Controls.Add(this.labelPromedioClase);
            this.Controls.Add(this.labelAprobados);
            this.Controls.Add(this.labelDesaprobados);
            this.Controls.Add(this.textBoxDesaprobados);
            this.Controls.Add(this.textBoxAprobados);
            this.Controls.Add(this.textBoxPromedioClase);
            this.Controls.Add(this.textBoxPeorAlumno);
            this.Controls.Add(this.textBoxMejorAlumno);
            this.Controls.Add(this.labelPeorAlumno);
            this.Controls.Add(this.labelMejorAlumno);
            this.Controls.Add(this.listAlumnos);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxExamen);
            this.Controls.Add(this.textBoxParcial);
            this.Controls.Add(this.textBoxPractica);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelExamen);
            this.Controls.Add(this.labelParcial);
            this.Controls.Add(this.labelPractica);
            this.Controls.Add(this.labelNombres);
            this.Controls.Add(this.labelCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelPractica;
        private System.Windows.Forms.Label labelParcial;
        private System.Windows.Forms.Label labelExamen;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxPractica;
        private System.Windows.Forms.TextBox textBoxParcial;
        private System.Windows.Forms.TextBox textBoxExamen;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.ListView listAlumnos;
        private System.Windows.Forms.Label labelMejorAlumno;
        private System.Windows.Forms.Label labelPeorAlumno;
        private System.Windows.Forms.TextBox textBoxMejorAlumno;
        private System.Windows.Forms.TextBox textBoxPeorAlumno;
        private System.Windows.Forms.TextBox textBoxPromedioClase;
        private System.Windows.Forms.TextBox textBoxAprobados;
        private System.Windows.Forms.TextBox textBoxDesaprobados;
        private System.Windows.Forms.Label labelDesaprobados;
        private System.Windows.Forms.Label labelAprobados;
        private System.Windows.Forms.Label labelPromedioClase;
        private System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.ColumnHeader columnHeaderNombres;
        private System.Windows.Forms.ColumnHeader columnHeaderPractica;
        private System.Windows.Forms.ColumnHeader columnHeaderParcial;
        private System.Windows.Forms.ColumnHeader columnHeaderExamen;
        private System.Windows.Forms.ColumnHeader columnHeaderPromedio;
        private System.Windows.Forms.ColumnHeader columnHeaderNivel;
    }
}

