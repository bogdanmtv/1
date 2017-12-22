namespace lab4
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
            this.классыСМассивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.одномерныйМассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двумерныйМассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСоСтрокамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.классыСМассивамиToolStripMenuItem,
            this.строкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // классыСМассивамиToolStripMenuItem
            // 
            this.классыСМассивамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.одномерныйМассивToolStripMenuItem,
            this.двумерныйМассивToolStripMenuItem});
            this.классыСМассивамиToolStripMenuItem.Name = "классыСМассивамиToolStripMenuItem";
            this.классыСМассивамиToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.классыСМассивамиToolStripMenuItem.Text = "Классы с массивами";
            this.классыСМассивамиToolStripMenuItem.Click += new System.EventHandler(this.классыСМассивамиToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // одномерныйМассивToolStripMenuItem
            // 
            this.одномерныйМассивToolStripMenuItem.Name = "одномерныйМассивToolStripMenuItem";
            this.одномерныйМассивToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.одномерныйМассивToolStripMenuItem.Text = "Одномерный массив";
            this.одномерныйМассивToolStripMenuItem.Click += new System.EventHandler(this.одномерныйМассивToolStripMenuItem_Click);
            // 
            // двумерныйМассивToolStripMenuItem
            // 
            this.двумерныйМассивToolStripMenuItem.Name = "двумерныйМассивToolStripMenuItem";
            this.двумерныйМассивToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.двумерныйМассивToolStripMenuItem.Text = "Двумерный массив";
            this.двумерныйМассивToolStripMenuItem.Click += new System.EventHandler(this.двумерныйМассивToolStripMenuItem_Click);
            // 
            // строкиToolStripMenuItem
            // 
            this.строкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСоСтрокамиToolStripMenuItem});
            this.строкиToolStripMenuItem.Name = "строкиToolStripMenuItem";
            this.строкиToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.строкиToolStripMenuItem.Text = "Строки";
            // 
            // работаСоСтрокамиToolStripMenuItem
            // 
            this.работаСоСтрокамиToolStripMenuItem.Name = "работаСоСтрокамиToolStripMenuItem";
            this.работаСоСтрокамиToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.работаСоСтрокамиToolStripMenuItem.Text = "Работа со строками";
            this.работаСоСтрокамиToolStripMenuItem.Click += new System.EventHandler(this.работаСоСтрокамиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 33);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem классыСМассивамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem одномерныйМассивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двумерныйМассивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСоСтрокамиToolStripMenuItem;
    }
}

