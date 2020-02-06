using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MICHAŁ_KALINA_LAB3
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Polaczenie z baza danych
        /// </summary>
        SqlConnection connection;
        //private object tableName;
        

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=KALINA\MICHALSQL; database=MichalKalinaLab3;Trusted_connection=yes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewGrades_Click(object sender, EventArgs e)
        {
            ShowData("GradesView");
            /*SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT*FROM GradesView", connection);
            DataTable table = new DataTable();
            //Wypelnianie tablicy
            dataAdapter.Fill(table);
            //Wyswietlanie
            dataGridViewData.DataSource = table;
            */
        }


        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO Courses( Name, Teacher) VALUES (@Name, @Teacher)",connection);
            //Dodawanie parametrow kwerendy
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxCourse.Text;
            command.Parameters.Add("@Teacher", SqlDbType.NVarChar).Value = textBoxName.Text;
            //Wykonywanie kwerendy
            connection.Open();
            //daje mozliwosc edycji
            command.ExecuteNonQuery();

            //Dodawanie nowego kursu do bazy danych
           
            connection.Close(); //zamyka polaczenie


        }
        /// <summary>
        /// Wyswielanie danych
        /// </summary>
        /// <param name="table"></param>
        private void ShowData(string tableName)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}  ", connection);
            DataTable table = new DataTable();
            //Wypelnianie tablicy
            dataAdapter.Fill(table);
            //Wyswietlanie
            dataGridViewData.DataSource = table;

        }

        private void buttonViewCourses_Click(object sender, EventArgs e)
        {
            ShowData("Courses");
        }

        private void labelCourse_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
