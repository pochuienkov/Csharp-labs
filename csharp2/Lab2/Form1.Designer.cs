namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлінняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиКлонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(14, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Назва";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Адреса";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Кімнат";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Студентів";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Персоналу";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Дохід від гуртожитку";
            this.Column6.Name = "Column6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додати кімнати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Заселити студентів";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Виселити студентів";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(570, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Додати їдальню";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "За місяць",
            "За півроку",
            "За рік"});
            this.listBox1.Location = new System.Drawing.Point(669, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(93, 43);
            this.listBox1.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(669, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "Визначити дохід";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлінняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлінняToolStripMenuItem
            // 
            this.управлінняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toStringToolStripMenuItem,
            this.створитиКлонаToolStripMenuItem});
            this.управлінняToolStripMenuItem.Name = "управлінняToolStripMenuItem";
            this.управлінняToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.управлінняToolStripMenuItem.Text = "Програма";
            // 
            // toStringToolStripMenuItem
            // 
            this.toStringToolStripMenuItem.Name = "toStringToolStripMenuItem";
            this.toStringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toStringToolStripMenuItem.Text = "Метод ToString";
            this.toStringToolStripMenuItem.Click += new System.EventHandler(this.toStringToolStripMenuItem_Click);
            // 
            // створитиКлонаToolStripMenuItem
            // 
            this.створитиКлонаToolStripMenuItem.Name = "створитиКлонаToolStripMenuItem";
            this.створитиКлонаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.створитиКлонаToolStripMenuItem.Text = "Створити клона";
            this.створитиКлонаToolStripMenuItem.Click += new System.EventHandler(this.створитиКлонаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 353);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Campus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлінняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиКлонаToolStripMenuItem;
    }
}

