using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Nota_musical
{
    class BD
    {
        string conection= @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\USUARIO\Downloads\music-school-master\music-school-master\music-school-master\Nota musical\NotaMusical.accdb";
        string SQL;
        OleDbDataAdapter Adapter = new OleDbDataAdapter();
        DataTable studentTable = new DataTable();
        DataTable courseTable = new DataTable();
        DataTable valueTable = new DataTable();
        public DataTable selectStudents()
        {
            studentTable = new DataTable();
            SQL = "SELECT * FROM estudiante";
            Adapter = new OleDbDataAdapter(SQL, conection);
            Adapter.Fill(studentTable);
            return studentTable;
        }
        public void insertStudents(string name,string lastname,string date,int value)
        {
            SQL = "INSERT INTO estudiante (nombre,apellidos,fecha,valor_matricula) values('" + name + "','" + lastname + "','" + date + "','" + value + "');";
            Adapter = new OleDbDataAdapter(SQL, conection);
            Adapter.Fill(studentTable);
        }
        public void insertCourses(string nameCourse, double value, string teacher)
        {
            SQL = "INSERT INTO curso (nombre,valor,instructor) values('" + nameCourse + "','" + value + "','" + teacher + "');";
            Adapter = new OleDbDataAdapter(SQL, conection);
            Adapter.Fill(courseTable);
        }
        public void insertStudentsCourse(int idCourse,int idStudent)
        {
            SQL = "Insert into curso_estudiante( Id_curso, id_estudiante) values('" + idCourse + "', '" + idStudent + "');";
            Adapter = new OleDbDataAdapter(SQL, conection);
            Adapter.Fill(valueTable);
        }
        public void updateCourseValue(int id,double newValue)
        {
            SQL = "UPDATE curso SET valor='" + newValue + "' WHERE Id ="+ id +";";
            Adapter = new OleDbDataAdapter(SQL, conection);
            Adapter.Fill(courseTable);
        }
    }
}
