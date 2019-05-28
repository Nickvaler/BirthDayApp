namespace BirthDayDates
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаПодключенияКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИнформациюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИнформациюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.добавитьИнформациюToolStripMenuItem1,
            this.изменитьИнформациюToolStripMenuItem1,
            this.удалитьИнформациюToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаПодключенияКБДToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // проверкаПодключенияКБДToolStripMenuItem
            // 
            this.проверкаПодключенияКБДToolStripMenuItem.Name = "проверкаПодключенияКБДToolStripMenuItem";
            this.проверкаПодключенияКБДToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.проверкаПодключенияКБДToolStripMenuItem.Text = "Проверка подключения к БД";
            this.проверкаПодключенияКБДToolStripMenuItem.Click += new System.EventHandler(this.проверкаПодключенияКБДToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(234, 22);
            this.toolStripMenuItem2.Text = "Обновить";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // добавитьИнформациюToolStripMenuItem1
            // 
            this.добавитьИнформациюToolStripMenuItem1.Name = "добавитьИнформациюToolStripMenuItem1";
            this.добавитьИнформациюToolStripMenuItem1.Size = new System.Drawing.Size(150, 20);
            this.добавитьИнформациюToolStripMenuItem1.Text = "Добавить информацию";
            this.добавитьИнформациюToolStripMenuItem1.Click += new System.EventHandler(this.добавитьИнформациюToolStripMenuItem1_Click);
            // 
            // изменитьИнформациюToolStripMenuItem1
            // 
            this.изменитьИнформациюToolStripMenuItem1.Name = "изменитьИнформациюToolStripMenuItem1";
            this.изменитьИнформациюToolStripMenuItem1.Size = new System.Drawing.Size(154, 20);
            this.изменитьИнформациюToolStripMenuItem1.Text = "Изменить Информацию";
            this.изменитьИнформациюToolStripMenuItem1.Click += new System.EventHandler(this.изменитьИнформациюToolStripMenuItem1_Click);
            // 
            // удалитьИнформациюToolStripMenuItem
            // 
            this.удалитьИнформациюToolStripMenuItem.Name = "удалитьИнформациюToolStripMenuItem";
            this.удалитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.удалитьИнформациюToolStripMenuItem.Text = "Удалить информацию";
            this.удалитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.удалитьИнформациюToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "О программе";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(15, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(801, 174);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 217);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация по дням рождения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИнформациюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьИнформациюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаПодключенияКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

