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
    public partial class Form4 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Airport1.mdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airport1DataSet1.Пассажиры". При необходимости она может быть перемещена или удалена.
            this.пассажирыTableAdapter.Fill(this.airport1DataSet1.Пассажиры);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox9.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                int kod = Convert.ToInt32(textBox1.Text);
                string Name = textBox2.Text;
                string Surname = textBox3.Text;
                string PhoneNumber = textBox4.Text;
                string Passport = textBox5.Text;
                int Age = Convert.ToInt32(textBox9.Text);
                int kodTicket = Convert.ToInt32(textBox6.Text);
                string Counrty = textBox7.Text;

                bool flag = false;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {

                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == Convert.ToString(kod))
                    {
                        MessageBox.Show("Запись с данным ID существует");
                        flag = true;
                        break;
                    }

                }
                if (!flag)
                {

                    string q = "INSERT INTO Пассажиры ([КодПассажира], Имя, Фамилия, Телефон, НомерПаспорта, [Возраст], " +
                    "[КодБилета], Страна) VALUES (" + kod + ",'" + Name + "','" + Surname + "','" + PhoneNumber + "','" + Passport + "'," + Age + "," + kodTicket + ",'" + Counrty + "')";
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Пассажир добавлен");
                    this.пассажирыTableAdapter.Fill(this.airport1DataSet1.Пассажиры);
                }
            }
            else
            {
                MessageBox.Show("Введите все значения");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                bool flag = true;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox8.Text)
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                {
                    int kod = Convert.ToInt32(textBox8.Text);
                    string q = "DELETE FROM Пассажиры WHERE [КодПассажира] = " + kod;
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Пассажир удален");
                    this.пассажирыTableAdapter.Fill(this.airport1DataSet1.Пассажиры);
                }
                else
                {
                    MessageBox.Show("Не существует записи с данным ID");
                }
            }
            else
            {
                MessageBox.Show("Введите значение");
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
