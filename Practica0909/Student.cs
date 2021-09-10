using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0909
{
    class Student
    {
        public int idStudent { get; set; }
        public string fistName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }


        //metodo con la colleccion de datos
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                 new Student { idStudent = 1001, fistName = "Jose", lastName = "Robles", age = 25, nationality = "Cubano-Americano" },
                 new Student { idStudent = 1002, fistName = "Fatima", lastName = "Ayala", age = 27, nationality="Salvadoreña" },
                 new Student { idStudent = 1003, fistName = "Daniel", lastName = "Medina", age = 23, nationality="Mexicano" },
                 new Student { idStudent = 1004, fistName = "David", lastName = "Lopez", age = 22, nationality="Colombiano" },
                 new Student { idStudent = 1005, fistName = "Mariana", lastName = "Avila", age = 26, nationality="Venezolana" },
            };
            return students; //Retornamos la coleccion
        }


    } 
}
