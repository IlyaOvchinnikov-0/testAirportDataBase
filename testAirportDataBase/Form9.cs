using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace testAirportDataBase
{
    public partial class Form9 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Airport1.mdb";
        private OleDbConnection myConnection;
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                int kod = Convert.ToInt32(textBox1.Text);
                string q = "SELECT DISTINCT Пассажиры.Имя, Пассажиры.Фамилия, Пассажиры.Возраст, Пассажиры.Телефон FROM Пассажиры, " +
                    "Билеты, Рейсы WHERE Билеты.КодРейса = " + kod + " AND Билеты.КодБилета = Пассажиры.КодБилета";
                OleDbDataAdapter command = new OleDbDataAdapter(q, myConnection);
                DataTable dt = new DataTable();
                command.Fill(dt);
                dataGridView1.DataSource = dt;
                myConnection.Close();
            }
            else
            {
                MessageBox.Show("Введите значение");
            }
        }
    }
}
