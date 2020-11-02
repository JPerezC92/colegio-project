using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem("123");
            lista.SubItems.Add("Nombre");
            lista.SubItems.Add("Practica");
            lista.SubItems.Add("Parcial");
            lista.SubItems.Add("Examen");
            lista.SubItems.Add("Promedio");
            lista.SubItems.Add("Nivel");
            listAlumnos.Items.Add(lista);

        }
    }
}
