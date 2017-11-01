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
        string conection= @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\USUARIO\Desktop\music-school\Nota musical\NotaMusical.accdb";
        string SQL;
        OleDbDataAdapter Adapter = new OleDbDataAdapter();
        DataTable studentTable = new DataTable();

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
    }
}
