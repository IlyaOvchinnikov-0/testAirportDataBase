
namespace testAirportDataBase
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airport1DataSet1 = new testAirportDataBase.Airport1DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.должностьTableAdapter = new testAirportDataBase.Airport1DataSet1TableAdapters.ДолжностьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДолжностиDataGridViewTextBoxColumn,
            this.названиеДолжностиDataGridViewTextBoxColumn,
            this.окладDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.должностьBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(534, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодДолжностиDataGridViewTextBoxColumn
            // 
            this.кодДолжностиDataGridViewTextBoxColumn.DataPropertyName = "КодДолжности";
            this.кодДолжностиDataGridViewTextBoxColumn.HeaderText = "КодДолжности";
            this.кодДолжностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодДолжностиDataGridViewTextBoxColumn.Name = "кодДолжностиDataGridViewTextBoxColumn";
            this.кодДолжностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеДолжностиDataGridViewTextBoxColumn
            // 
            this.названиеДолжностиDataGridViewTextBoxColumn.DataPropertyName = "НазваниеДолжности";
            this.названиеДолжностиDataGridViewTextBoxColumn.HeaderText = "НазваниеДолжности";
            this.названиеДолжностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеДолжностиDataGridViewTextBoxColumn.Name = "названиеДолжностиDataGridViewTextBoxColumn";
            this.названиеДолжностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // окладDataGridViewTextBoxColumn
            // 
            this.окладDataGridViewTextBoxColumn.DataPropertyName = "Оклад";
            this.окладDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.окладDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.окладDataGridViewTextBoxColumn.Name = "окладDataGridViewTextBoxColumn";
            this.окладDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.airport1DataSet1;
            // 
            // airport1DataSet1
            // 
            this.airport1DataSet1.DataSetName = "Airport1DataSet1";
            this.airport1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(189, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите код должности";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(555, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Код Должности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Оклад";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Название Должности";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(555, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(555, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(555, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 22);
            this.textBox4.TabIndex = 9;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Должность";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private Airport1DataSet1 airport1DataSet1;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private Airport1DataSet1TableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окладDataGridViewTextBoxColumn;
    }
}