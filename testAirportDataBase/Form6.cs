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
    public partial class Form6 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Airport1.mdb";
        private OleDbConnection myConnection;
        public Form6()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airport1DataSet1.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.airport1DataSet1.Рейсы);

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                int kod = Convert.ToInt32(textBox1.Text);
                string Destination = textBox2.Text;
                int kodPlane = Convert.ToInt32(textBox3.Text);
                string Date = textBox4.Text;
                string Time = textBox5.Text;

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
                    string q = "INSERT INTO Рейсы ([КодРейса], МестоНазначения, [КодСамолета], ДатаОтправления, ВремяОтправления) " +
                    "VALUES (" + kod + ",'" + Destination + "'," + kodPlane + ",'" + Date + "','" + Time + "')";
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Рейс добавлен");
                    this.рейсыTableAdapter.Fill(this.airport1DataSet1.Рейсы);
                }
            }
            else
            {
                MessageBox.Show("Введите все значения");
            }
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
                    string q = "DELETE FROM Рейсы WHERE [КодРейса] = " + kod;
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Билет удален");
                    this.рейсыTableAdapter.Fill(this.airport1DataSet1.Рейсы);
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

        private void списокПассажировРейсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }
    }
}
