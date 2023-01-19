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
    public partial class Form3 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Airport1.mdb";
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airport1DataSet1.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.airport1DataSet1.Должность);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bool flag = true;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox1.Text)
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                {
                    int kod = Convert.ToInt32(textBox1.Text);
                    string q = "DELETE FROM Должность WHERE [КодДолжности] = " + kod;
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Должность удалена");
                    this.должностьTableAdapter.Fill(this.airport1DataSet1.Должность);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                int kod = Convert.ToInt32(textBox2.Text);
                string Name = textBox3.Text;
                int Salary = Convert.ToInt32(textBox4.Text);

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
                    string q = "INSERT INTO Должность ([КодДолжности], НазваниеДолжности, Оклад) " +
                    "VALUES (" + kod + ",'" + Name + "','" + Salary + "')";
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Должность добавлена");
                    this.должностьTableAdapter.Fill(this.airport1DataSet1.Должность);
                }

            }
            else
            {
                MessageBox.Show("Введите все значения");
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
