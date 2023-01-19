
namespace testAirportDataBase
{
    partial class Form6
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
            this.кодРейсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоНазначенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОтправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОтправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airport1DataSet1 = new testAirportDataBase.Airport1DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.рейсыTableAdapter = new testAirportDataBase.Airport1DataSet1TableAdapters.РейсыTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПассажировРейсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport1DataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРейсаDataGridViewTextBoxColumn,
            this.местоНазначенияDataGridViewTextBoxColumn,
            this.кодСамолетаDataGridViewTextBoxColumn,
            this.датаОтправленияDataGridViewTextBoxColumn,
            this.времяОтправленияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.рейсыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодРейсаDataGridViewTextBoxColumn
            // 
            this.кодРейсаDataGridViewTextBoxColumn.DataPropertyName = "КодРейса";
            this.кодРейсаDataGridViewTextBoxColumn.HeaderText = "КодРейса";
            this.кодРейсаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодРейсаDataGridViewTextBoxColumn.Name = "кодРейсаDataGridViewTextBoxColumn";
            this.кодРейсаDataGridViewTextBoxColumn.Width = 125;
            // 
            // местоНазначенияDataGridViewTextBoxColumn
            // 
            this.местоНазначенияDataGridViewTextBoxColumn.DataPropertyName = "МестоНазначения";
            this.местоНазначенияDataGridViewTextBoxColumn.HeaderText = "МестоНазначения";
            this.местоНазначенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местоНазначенияDataGridViewTextBoxColumn.Name = "местоНазначенияDataGridViewTextBoxColumn";
            this.местоНазначенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСамолетаDataGridViewTextBoxColumn
            // 
            this.кодСамолетаDataGridViewTextBoxColumn.DataPropertyName = "КодСамолета";
            this.кодСамолетаDataGridViewTextBoxColumn.HeaderText = "КодСамолета";
            this.кодСамолетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСамолетаDataGridViewTextBoxColumn.Name = "кодСамолетаDataGridViewTextBoxColumn";
            this.кодСамолетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОтправленияDataGridViewTextBoxColumn
            // 
            this.датаОтправленияDataGridViewTextBoxColumn.DataPropertyName = "ДатаОтправления";
            this.датаОтправленияDataGridViewTextBoxColumn.HeaderText = "ДатаОтправления";
            this.датаОтправленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаОтправленияDataGridViewTextBoxColumn.Name = "датаОтправленияDataGridViewTextBoxColumn";
            this.датаОтправленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяОтправленияDataGridViewTextBoxColumn
            // 
            this.времяОтправленияDataGridViewTextBoxColumn.DataPropertyName = "ВремяОтправления";
            this.времяОтправленияDataGridViewTextBoxColumn.HeaderText = "ВремяОтправления";
            this.времяОтправленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяОтправленияDataGridViewTextBoxColumn.Name = "времяОтправленияDataGridViewTextBoxColumn";
            this.времяОтправленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.airport1DataSet1;
            // 
            // airport1DataSet1
            // 
            this.airport1DataSet1.DataSetName = "Airport1DataSet1";
            this.airport1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "КодРейса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "МестоНазначения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "КодСамолета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ДатаОтправления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "ВремяОтправления";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 433);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(421, 433);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(566, 433);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 22);
            this.textBox5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(747, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 115);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(902, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "КодРейса";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(905, 65);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(92, 22);
            this.textBox6.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(905, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 115);
            this.button2.TabIndex = 14;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПассажировРейсаToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // списокПассажировРейсаToolStripMenuItem
            // 
            this.списокПассажировРейсаToolStripMenuItem.Name = "списокПассажировРейсаToolStripMenuItem";
            this.списокПассажировРейсаToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.списокПассажировРейсаToolStripMenuItem.Text = "Список пассажиров рейса";
            this.списокПассажировРейсаToolStripMenuItem.Click += new System.EventHandler(this.списокПассажировРейсаToolStripMenuItem_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1062, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.Text = "Рейсы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport1DataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private Airport1DataSet1 airport1DataSet1;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private Airport1DataSet1TableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРейсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоНазначенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСамолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОтправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОтправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПассажировРейсаToolStripMenuItem;
    }
}