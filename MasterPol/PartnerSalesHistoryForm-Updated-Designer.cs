namespace MasterPol
{
    partial class PartnerSalesHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblЗаголовок;
        private System.Windows.Forms.Label lblПартнер;
        private System.Windows.Forms.DataGridView dgvИстория;
        private System.Windows.Forms.Label lblСтатистика;
        private System.Windows.Forms.Label lblВсегоЗаказов;
        private System.Windows.Forms.Label lblОбщаяСумма;
        private System.Windows.Forms.Label lblПоследнийЗаказ;
        private System.Windows.Forms.Button btnЗакрыть;
        private System.Windows.Forms.DateTimePicker dtpС;
        private System.Windows.Forms.DateTimePicker dtpПо;
        private System.Windows.Forms.Label lblПериод;
        private System.Windows.Forms.Button btnОтфильтровать;
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnОтфильтровать = new System.Windows.Forms.Button();
            this.dtpПо = new System.Windows.Forms.DateTimePicker();
            this.dtpС = new System.Windows.Forms.DateTimePicker();
            this.lblПериод = new System.Windows.Forms.Label();
            this.lblПартнер = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblЗаголовок = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnЗакрыть = new System.Windows.Forms.Button();
            this.lblПоследнийЗаказ = new System.Windows.Forms.Label();
            this.lblОбщаяСумма = new System.Windows.Forms.Label();
            this.lblВсегоЗаказов = new System.Windows.Forms.Label();
            this.lblСтатистика = new System.Windows.Forms.Label();
            this.dgvИстория = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvИстория)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelTop.Controls.Add(this.btnОтфильтровать);
            this.panelTop.Controls.Add(this.dtpПо);
            this.panelTop.Controls.Add(this.dtpС);
            this.panelTop.Controls.Add(this.lblПериод);
            this.panelTop.Controls.Add(this.lblПартнер);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.lblЗаголовок);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(824, 69);
            this.panelTop.TabIndex = 0;
            // 
            // btnОтфильтровать
            // 
            this.btnОтфильтровать.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnОтфильтровать.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnОтфильтровать.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnОтфильтровать.ForeColor = System.Drawing.Color.White;
            this.btnОтфильтровать.Location = new System.Drawing.Point(583, 15);
            this.btnОтфильтровать.Name = "btnОтфильтровать";
            this.btnОтфильтровать.Size = new System.Drawing.Size(86, 22);
            this.btnОтфильтровать.TabIndex = 6;
            this.btnОтфильтровать.Text = "Фильтровать";
            this.btnОтфильтровать.UseVisualStyleBackColor = false;
            this.btnОтфильтровать.Visible = false;
            this.btnОтфильтровать.Click += new System.EventHandler(this.btnОтфильтровать_Click);
            // 
            // dtpПо
            // 
            this.dtpПо.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpПо.Location = new System.Drawing.Point(489, 16);
            this.dtpПо.Name = "dtpПо";
            this.dtpПо.Size = new System.Drawing.Size(86, 20);
            this.dtpПо.TabIndex = 5;
            this.dtpПо.Visible = false;
            // 
            // dtpС
            // 
            this.dtpС.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpС.Location = new System.Drawing.Point(394, 16);
            this.dtpС.Name = "dtpС";
            this.dtpС.Size = new System.Drawing.Size(86, 20);
            this.dtpС.TabIndex = 4;
            this.dtpС.Visible = false;
            // 
            // lblПериод
            // 
            this.lblПериод.AutoSize = true;
            this.lblПериод.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblПериод.ForeColor = System.Drawing.Color.White;
            this.lblПериод.Location = new System.Drawing.Point(343, 17);
            this.lblПериод.Name = "lblПериод";
            this.lblПериод.Size = new System.Drawing.Size(52, 15);
            this.lblПериод.TabIndex = 3;
            this.lblПериод.Text = "Период:";
            this.lblПериод.Visible = false;
            // 
            // lblПартнер
            // 
            this.lblПартнер.AutoSize = true;
            this.lblПартнер.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblПартнер.ForeColor = System.Drawing.Color.White;
            this.lblПартнер.Location = new System.Drawing.Point(13, 43);
            this.lblПартнер.Name = "lblПартнер";
            this.lblПартнер.Size = new System.Drawing.Size(76, 20);
            this.lblПартнер.TabIndex = 2;
            this.lblПартнер.Text = "Партнер: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblЗаголовок
            // 
            this.lblЗаголовок.AutoSize = true;
            this.lblЗаголовок.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblЗаголовок.ForeColor = System.Drawing.Color.White;
            this.lblЗаголовок.Location = new System.Drawing.Point(51, 13);
            this.lblЗаголовок.Name = "lblЗаголовок";
            this.lblЗаголовок.Size = new System.Drawing.Size(196, 30);
            this.lblЗаголовок.TabIndex = 0;
            this.lblЗаголовок.Text = "История продаж";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.btnЗакрыть);
            this.panelMain.Controls.Add(this.lblПоследнийЗаказ);
            this.panelMain.Controls.Add(this.lblОбщаяСумма);
            this.panelMain.Controls.Add(this.lblВсегоЗаказов);
            this.panelMain.Controls.Add(this.lblСтатистика);
            this.panelMain.Controls.Add(this.dgvИстория);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 69);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(824, 451);
            this.panelMain.TabIndex = 1;
            // 
            // btnЗакрыть
            // 
            this.btnЗакрыть.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnЗакрыть.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnЗакрыть.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnЗакрыть.ForeColor = System.Drawing.Color.White;
            this.btnЗакрыть.Location = new System.Drawing.Point(725, 407);
            this.btnЗакрыть.Name = "btnЗакрыть";
            this.btnЗакрыть.Size = new System.Drawing.Size(73, 30);
            this.btnЗакрыть.TabIndex = 6;
            this.btnЗакрыть.Text = "Закрыть";
            this.btnЗакрыть.UseVisualStyleBackColor = false;
            this.btnЗакрыть.Click += new System.EventHandler(this.btnЗакрыть_Click);
            // 
            // lblПоследнийЗаказ
            // 
            this.lblПоследнийЗаказ.AutoSize = true;
            this.lblПоследнийЗаказ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblПоследнийЗаказ.Location = new System.Drawing.Point(371, 381);
            this.lblПоследнийЗаказ.Name = "lblПоследнийЗаказ";
            this.lblПоследнийЗаказ.Size = new System.Drawing.Size(129, 19);
            this.lblПоследнийЗаказ.TabIndex = 4;
            this.lblПоследнийЗаказ.Text = "Последний заказ: -";
            // 
            // lblОбщаяСумма
            // 
            this.lblОбщаяСумма.AutoSize = true;
            this.lblОбщаяСумма.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblОбщаяСумма.Location = new System.Drawing.Point(182, 381);
            this.lblОбщаяСумма.Name = "lblОбщаяСумма";
            this.lblОбщаяСумма.Size = new System.Drawing.Size(125, 19);
            this.lblОбщаяСумма.TabIndex = 3;
            this.lblОбщаяСумма.Text = "Общая сумма: 0 ₽";
            // 
            // lblВсегоЗаказов
            // 
            this.lblВсегоЗаказов.AutoSize = true;
            this.lblВсегоЗаказов.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblВсегоЗаказов.Location = new System.Drawing.Point(13, 381);
            this.lblВсегоЗаказов.Name = "lblВсегоЗаказов";
            this.lblВсегоЗаказов.Size = new System.Drawing.Size(110, 19);
            this.lblВсегоЗаказов.TabIndex = 2;
            this.lblВсегоЗаказов.Text = "Всего заказов: 0";
            // 
            // lblСтатистика
            // 
            this.lblСтатистика.AutoSize = true;
            this.lblСтатистика.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblСтатистика.Location = new System.Drawing.Point(13, 355);
            this.lblСтатистика.Name = "lblСтатистика";
            this.lblСтатистика.Size = new System.Drawing.Size(96, 21);
            this.lblСтатистика.TabIndex = 1;
            this.lblСтатистика.Text = "Статистика";
            // 
            // dgvИстория
            // 
            this.dgvИстория.AllowUserToAddRows = false;
            this.dgvИстория.AllowUserToDeleteRows = false;
            this.dgvИстория.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvИстория.BackgroundColor = System.Drawing.Color.White;
            this.dgvИстория.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvИстория.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvИстория.Location = new System.Drawing.Point(13, 13);
            this.dgvИстория.Name = "dgvИстория";
            this.dgvИстория.ReadOnly = true;
            this.dgvИстория.RowHeadersVisible = false;
            this.dgvИстория.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvИстория.Size = new System.Drawing.Size(746, 329);
            this.dgvИстория.TabIndex = 0;
            // 
            // PartnerSalesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 520);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartnerSalesHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История продаж партнера - Мастер пол";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvИстория)).EndInit();
            this.ResumeLayout(false);

        }
    }
}