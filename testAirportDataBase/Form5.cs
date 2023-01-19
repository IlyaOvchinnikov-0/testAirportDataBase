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
    public partial class Form5 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Airport1.mdb";
        private OleDbConnection myConnection;
        public Form5()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airport1DataSet1.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.airport1DataSet1.Билеты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                int kod = Convert.ToInt32(textBox1.Text);
                int Price = Convert.ToInt32(textBox2.Text);
                int kodFlight = Convert.ToInt32(textBox3.Text);
                int NumberPlace = Convert.ToInt32(textBox4.Text);
                int Tickets = Convert.ToInt32(textBox5.Text);
                int kodWorker = Convert.ToInt32(textBox6.Text);

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
                    string q = "INSERT INTO Билеты ([КодБилета], [Стоимость], [КодРейса], [НомерМеста], [КоличествоБилетов], " +
                    "[КодСотрудника]) VALUES (" + kod + "," + Price + "," + kodFlight + "," + NumberPlace + "," + Tickets + "," + kodWorker + ")";
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Билет добавлен");
                    this.билетыTableAdapter.Fill(this.airport1DataSet1.Билеты);
                }
            }
            else
            {
                MessageBox.Show("Введите все значения");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                bool flag = true;
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox7.Text)
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                {
                    int kod = Convert.ToInt32(textBox7.Text);
                    string q = "DELETE FROM Билеты WHERE [КодБилета] = " + kod;
                    OleDbCommand com = new OleDbCommand(q, myConnection);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Билет удален");
                    this.билетыTableAdapter.Fill(this.airport1DataSet1.Билеты); ;
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

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
