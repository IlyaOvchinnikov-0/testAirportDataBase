
namespace testAirportDataBase
{
    partial class Form5
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
            this.кодБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодРейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерМестаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоБилетовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.билетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airport1DataSet1 = new testAirportDataBase.Airport1DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.билетыTableAdapter = new testAirportDataBase.Airport1DataSet1TableAdapters.БилетыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодБилетаDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.кодРейсаDataGridViewTextBoxColumn,
            this.номерМестаDataGridViewTextBoxColumn,
            this.количествоБилетовDataGridViewTextBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.билетыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодБилетаDataGridViewTextBoxColumn
            // 
            this.кодБилетаDataGridViewTextBoxColumn.DataPropertyName = "КодБилета";
            this.кодБилетаDataGridViewTextBoxColumn.HeaderText = "КодБилета";
            this.кодБилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодБилетаDataGridViewTextBoxColumn.Name = "кодБилетаDataGridViewTextBoxColumn";
            this.кодБилетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодРейсаDataGridViewTextBoxColumn
            // 
            this.кодРейсаDataGridViewTextBoxColumn.DataPropertyName = "КодРейса";
            this.кодРейсаDataGridViewTextBoxColumn.HeaderText = "КодРейса";
            this.кодРейсаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодРейсаDataGridViewTextBoxColumn.Name = "кодРейсаDataGridViewTextBoxColumn";
            this.кодРейсаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерМестаDataGridViewTextBoxColumn
            // 
            this.номерМестаDataGridViewTextBoxColumn.DataPropertyName = "НомерМеста";
            this.номерМестаDataGridViewTextBoxColumn.HeaderText = "НомерМеста";
            this.номерМестаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерМестаDataGridViewTextBoxColumn.Name = "номерМестаDataGridViewTextBoxColumn";
            this.номерМестаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоБилетовDataGridViewTextBoxColumn
            // 
            this.количествоБилетовDataGridViewTextBoxColumn.DataPropertyName = "КоличествоБилетов";
            this.количествоБилетовDataGridViewTextBoxColumn.HeaderText = "КоличествоБилетов";
            this.количествоБилетовDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоБилетовDataGridViewTextBoxColumn.Name = "количествоБилетовDataGridViewTextBoxColumn";
            this.количествоБилетовDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "КодСотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "КодСотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            this.кодСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // билетыBindingSource
            // 
            this.билетыBindingSource.DataMember = "Билеты";
            this.билетыBindingSource.DataSource = this.airport1DataSet1;
            // 
            // airport1DataSet1
            // 
            this.airport1DataSet1.DataSetName = "Airport1DataSet1";
            this.airport1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "КодБилета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "КодРейса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "НомерМеста";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "КоличествоБилетов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "КодСотрудника";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(810, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 99);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 451);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 451);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 451);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(386, 451);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(523, 451);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(683, 451);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1039, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "КодБилета";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1042, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(1042, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 99);
            this.button2.TabIndex = 16;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // билетыTableAdapter
            // 
            this.билетыTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1209, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Билеты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
        private Airport1DataSet1 airport1DataSet1;
        private System.Windows.Forms.BindingSource билетыBindingSource;
        private Airport1DataSet1TableAdapters.БилетыTableAdapter билетыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерМестаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоБилетовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
    }
}