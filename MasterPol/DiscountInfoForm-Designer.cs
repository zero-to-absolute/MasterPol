namespace MasterPol
{
    partial class DiscountInfoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblЗаголовок;
        private System.Windows.Forms.Label lblПартнер;
        private System.Windows.Forms.Label lblТекущаяСкидка;
        private System.Windows.Forms.Label lblПроцентСкидки;
        private System.Windows.Forms.Label lblОбщееКоличество;
        private System.Windows.Forms.Label lblОбщаяСумма;
        private System.Windows.Forms.Label lblКоличествоЗначение;
        private System.Windows.Forms.Label lblСуммаЗначение;
        private System.Windows.Forms.Label lblУсловияСкидки;
        private System.Windows.Forms.RichTextBox rtbУсловия;
        private System.Windows.Forms.Button btnЗакрыть;
        private System.Windows.Forms.ProgressBar progressВыполнение;
        private System.Windows.Forms.PictureBox pictureBox1;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblЗаголовок = new System.Windows.Forms.Label();
            this.lblПартнер = new System.Windows.Forms.Label();
            this.lblТекущаяСкидка = new System.Windows.Forms.Label();
            this.lblПроцентСкидки = new System.Windows.Forms.Label();
            this.lblОбщееКоличество = new System.Windows.Forms.Label();
            this.lblОбщаяСумма = new System.Windows.Forms.Label();
            this.lblКоличествоЗначение = new System.Windows.Forms.Label();
            this.lblСуммаЗначение = new System.Windows.Forms.Label();
            this.lblУсловияСкидки = new System.Windows.Forms.Label();
            this.rtbУсловия = new System.Windows.Forms.RichTextBox();
            this.btnЗакрыть = new System.Windows.Forms.Button();
            this.progressВыполнение = new System.Windows.Forms.ProgressBar();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            
            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnЗакрыть);
            this.panelMain.Controls.Add(this.rtbУсловия);
            this.panelMain.Controls.Add(this.lblУсловияСкидки);
            this.panelMain.Controls.Add(this.lblСуммаЗначение);
            this.panelMain.Controls.Add(this.lblКоличествоЗначение);
            this.panelMain.Controls.Add(this.lblОбщаяСумма);
            this.panelMain.Controls.Add(this.lblОбщееКоличество);
            this.panelMain.Controls.Add(this.lblПроцентСкидки);
            this.panelMain.Controls.Add(this.lblТекущаяСкидка);
            this.panelMain.Controls.Add(this.lblПартнер);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.lblЗаголовок);
            this.panelMain.Controls.Add(this.progressВыполнение);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(480, 420);
            this.panelMain.TabIndex = 0;
            
            // lblЗаголовок
            this.lblЗаголовок.AutoSize = true;
            this.lblЗаголовок.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblЗаголовок.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblЗаголовок.Location = new System.Drawing.Point(70, 20);
            this.lblЗаголовок.Name = "lblЗаголовок";
            this.lblЗаголовок.Size = new System.Drawing.Size(180, 30);
            this.lblЗаголовок.TabIndex = 0;
            this.lblЗаголовок.Text = "Скидка партнера";
            
            // pictureBox1
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            
            // lblПартнер
            this.lblПартнер.AutoSize = true;
            this.lblПартнер.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblПартнер.Location = new System.Drawing.Point(20, 70);
            this.lblПартнер.Name = "lblПартнер";
            this.lblПартнер.Size = new System.Drawing.Size(80, 21);
            this.lblПартнер.TabIndex = 2;
            this.lblПартнер.Text = "Партнер: ";
            
            // lblТекущаяСкидка
            this.lblТекущаяСкидка.AutoSize = true;
            this.lblТекущаяСкидка.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblТекущаяСкидка.Location = new System.Drawing.Point(20, 110);
            this.lblТекущаяСкидка.Name = "lblТекущаяСкидка";
            this.lblТекущаяСкидка.Size = new System.Drawing.Size(120, 20);
            this.lblТекущаяСкидка.TabIndex = 3;
            this.lblТекущаяСкидка.Text = "Текущая скидка:";
            
            // lblПроцентСкидки
            this.lblПроцентСкидки.AutoSize = true;
            this.lblПроцентСкидки.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblПроцентСкидки.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblПроцентСкидки.Location = new System.Drawing.Point(150, 100);
            this.lblПроцентСкидки.Name = "lblПроцентСкидки";
            this.lblПроцентСкидки.Size = new System.Drawing.Size(60, 37);
            this.lblПроцентСкидки.TabIndex = 4;
            this.lblПроцентСкидки.Text = "0%";
            
            // lblОбщееКоличество
            this.lblОбщееКоличество.AutoSize = true;
            this.lblОбщееКоличество.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblОбщееКоличество.Location = new System.Drawing.Point(20, 160);
            this.lblОбщееКоличество.Name = "lblОбщееКоличество";
            this.lblОбщееКоличество.Size = new System.Drawing.Size(180, 19);
            this.lblОбщееКоличество.TabIndex = 5;
            this.lblОбщееКоличество.Text = "Общее количество продаж:";
            
            // lblКоличествоЗначение
            this.lblКоличествоЗначение.AutoSize = true;
            this.lblКоличествоЗначение.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblКоличествоЗначение.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblКоличествоЗначение.Location = new System.Drawing.Point(210, 160);
            this.lblКоличествоЗначение.Name = "lblКоличествоЗначение";
            this.lblКоличествоЗначение.Size = new System.Drawing.Size(17, 19);
            this.lblКоличествоЗначение.TabIndex = 6;
            this.lblКоличествоЗначение.Text = "0";
            
            // lblОбщаяСумма
            this.lblОбщаяСумма.AutoSize = true;
            this.lblОбщаяСумма.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblОбщаяСумма.Location = new System.Drawing.Point(20, 190);
            this.lblОбщаяСумма.Name = "lblОбщаяСумма";
            this.lblОбщаяСумма.Size = new System.Drawing.Size(100, 19);
            this.lblОбщаяСумма.TabIndex = 7;
            this.lblОбщаяСумма.Text = "Общая сумма:";
            
            // lblСуммаЗначение
            this.lblСуммаЗначение.AutoSize = true;
            this.lblСуммаЗначение.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblСуммаЗначение.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblСуммаЗначение.Location = new System.Drawing.Point(130, 190);
            this.lblСуммаЗначение.Name = "lblСуммаЗначение";
            this.lblСуммаЗначение.Size = new System.Drawing.Size(48, 19);
            this.lblСуммаЗначение.TabIndex = 8;
            this.lblСуммаЗначение.Text = "0,00 ₽";
            
            // progressВыполнение
            this.progressВыполнение.Location = new System.Drawing.Point(20, 220);
            this.progressВыполнение.Name = "progressВыполнение";
            this.progressВыполнение.Size = new System.Drawing.Size(440, 23);
            this.progressВыполнение.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressВыполнение.TabIndex = 9;
            
            // lblУсловияСкидки
            this.lblУсловияСкидки.AutoSize = true;
            this.lblУсловияСкидки.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblУсловияСкидки.Location = new System.Drawing.Point(20, 260);
            this.lblУсловияСкидки.Name = "lblУсловияСкидки";
            this.lblУсловияСкидки.Size = new System.Drawing.Size(120, 19);
            this.lblУсловияСкидки.TabIndex = 10;
            this.lblУсловияСкидки.Text = "Условия скидки:";
            
            // rtbУсловия
            this.rtbУсловия.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.rtbУсловия.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbУсловия.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbУсловия.Location = new System.Drawing.Point(20, 290);
            this.rtbУсловия.Name = "rtbУсловия";
            this.rtbУсловия.ReadOnly = true;
            this.rtbУсловия.Size = new System.Drawing.Size(440, 80);
            this.rtbУсловия.TabIndex = 11;
            this.rtbУсловия.Text = "";
            
            // btnЗакрыть
            this.btnЗакрыть.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnЗакрыть.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnЗакрыть.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnЗакрыть.ForeColor = System.Drawing.Color.White;
            this.btnЗакрыть.Location = new System.Drawing.Point(380, 380);
            this.btnЗакрыть.Name = "btnЗакрыть";
            this.btnЗакрыть.Size = new System.Drawing.Size(80, 30);
            this.btnЗакрыть.TabIndex = 12;
            this.btnЗакрыть.Text = "Закрыть";
            this.btnЗакрыть.UseVisualStyleBackColor = false;
            this.btnЗакрыть.Click += new System.EventHandler(this.btnЗакрыть_Click);
            
            // DiscountInfoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Скидка партнера - Мастер пол";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}