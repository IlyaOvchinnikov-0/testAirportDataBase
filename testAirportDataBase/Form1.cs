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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Airport1.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airport1DataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.airport1DataSet1.Сотрудники);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                int kod = Convert.ToInt32(textBox1.Text);
                string Name = textBox2.Text;
                string Surname = textBox3.Text;
                string Adres = textBox4.Text;
                int kod_position = Convert.ToInt32(textBox5.Text);

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

                    string q = "INSERT INTO Сотрудники ([КодСотрудника], Имя, Фамилия, Адрес, [КодДолжности]) " +
                    "VALUES (" + kod + ",'" + Name + "','" + Surname + "','" + Adres + "','" + kod_position + "')";
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник добавлен");
                    this.сотрудникиTableAdapter.Fill(this.airport1DataSet1.Сотрудники);
                }
            }
            else
            {
                MessageBox.Show("Введите все значения");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                bool flag = true;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox6.Text)
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                {
                    int kod = Convert.ToInt32(textBox6.Text);
                string q = "DELETE FROM Сотрудники WHERE [КодСотрудника] = " + kod;
                OleDbCommand com = new OleDbCommand(q, myConnection);
                com.ExecuteNonQuery();
                MessageBox.Show("Сотрудник удален");
                this.сотрудникиTableAdapter.Fill(this.airport1DataSet1.Сотрудники);
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
    }
}
