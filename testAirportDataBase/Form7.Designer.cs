
namespace testAirportDataBase
{
    partial class Form7
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
            this.кодСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеСамолетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.главныйПилотDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.самолетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airport1DataSet1 = new testAirportDataBase.Airport1DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.самолетыTableAdapter = new testAirportDataBase.Airport1DataSet1TableAdapters.СамолетыTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокРейсовСамолетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airport1DataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСамолетаDataGridViewTextBoxColumn,
            this.названиеСамолетаDataGridViewTextBoxColumn,
            this.главныйПилотDataGridViewTextBoxColumn,
            this.числоМестDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.самолетыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодСамолетаDataGridViewTextBoxColumn
            // 
            this.кодСамолетаDataGridViewTextBoxColumn.DataPropertyName = "КодСамолета";
            this.кодСамолетаDataGridViewTextBoxColumn.HeaderText = "КодСамолета";
            this.кодСамолетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСамолетаDataGridViewTextBoxColumn.Name = "кодСамолетаDataGridViewTextBoxColumn";
            this.кодСамолетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеСамолетаDataGridViewTextBoxColumn
            // 
            this.названиеСамолетаDataGridViewTextBoxColumn.DataPropertyName = "НазваниеСамолета";
            this.названиеСамолетаDataGridViewTextBoxColumn.HeaderText = "НазваниеСамолета";
            this.названиеСамолетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеСамолетаDataGridViewTextBoxColumn.Name = "названиеСамолетаDataGridViewTextBoxColumn";
            this.названиеСамолетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // главныйПилотDataGridViewTextBoxColumn
            // 
            this.главныйПилотDataGridViewTextBoxColumn.DataPropertyName = "ГлавныйПилот";
            this.главныйПилотDataGridViewTextBoxColumn.HeaderText = "ГлавныйПилот";
            this.главныйПилотDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.главныйПилотDataGridViewTextBoxColumn.Name = "главныйПилотDataGridViewTextBoxColumn";
            this.главныйПилотDataGridViewTextBoxColumn.Width = 125;
            // 
            // числоМестDataGridViewTextBoxColumn
            // 
            this.числоМестDataGridViewTextBoxColumn.DataPropertyName = "ЧислоМест";
            this.числоМестDataGridViewTextBoxColumn.HeaderText = "ЧислоМест";
            this.числоМестDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.числоМестDataGridViewTextBoxColumn.Name = "числоМестDataGridViewTextBoxColumn";
            this.числоМестDataGridViewTextBoxColumn.Width = 125;
            // 
            // самолетыBindingSource
            // 
            this.самолетыBindingSource.DataMember = "Самолеты";
            this.самолетыBindingSource.DataSource = this.airport1DataSet1;
            // 
            // airport1DataSet1
            // 
            this.airport1DataSet1.DataSetName = "Airport1DataSet1";
            this.airport1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "КодСамолета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "НазваниеСамолета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ГлавныйПилот";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ЧислоМест";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(304, 387);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(492, 387);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(619, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 120);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "КодСамолета";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(772, 63);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(772, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 97);
            this.button2.TabIndex = 12;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // самолетыTableAdapter
            // 
            this.самолетыTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокРейсовСамолетаToolStripMenuItem});
            this.поискToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // списокРейсовСамолетаToolStripMenuItem
            // 
            this.списокРейсовСамолетаToolStripMenuItem.Name = "списокРейсовСамолетаToolStripMenuItem";
            this.списокРейсовСамолетаToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.списокРейсовСамолетаToolStripMenuItem.Text = "Список рейсов самолета";
            this.списокРейсовСамолетаToolStripMenuItem.Click += new System.EventHandler(this.списокРейсовСамолетаToolStripMenuItem_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(924, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.Text = "Самолеты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private Airport1DataSet1 airport1DataSet1;
        private System.Windows.Forms.BindingSource самолетыBindingSource;
        private Airport1DataSet1TableAdapters.СамолетыTableAdapter самолетыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСамолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеСамолетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn главныйПилотDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокРейсовСамолетаToolStripMenuItem;
    }
}