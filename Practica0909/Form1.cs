using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica0909
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamado al metodo selecName
            selecName();
        }

        //metodo para obtener los nombre de la coleccion 
        private void selecName()
        {
            //consultas
            List<string> query = (
                from student in Student.GetStudents()
                select student.fistName
                ).ToList();

            //recorrer lista y llenar lastName
            foreach(var name in query)
            {
                //llena lastNames
                lstNames.Items.Add(name);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

        }
    }
}
