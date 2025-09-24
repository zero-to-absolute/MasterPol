namespace MasterPol
{
    partial class MaterialCalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblParameter1;
        private System.Windows.Forms.NumericUpDown numParameter1;
        private System.Windows.Forms.Label lblParameter2;
        private System.Windows.Forms.NumericUpDown numParameter2;
        
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResultText;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtDetails;
        
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblParameter1 = new System.Windows.Forms.Label();
            this.numParameter1 = new System.Windows.Forms.NumericUpDown();
            this.lblParameter2 = new System.Windows.Forms.Label();
            this.numParameter2 = new System.Windows.Forms.NumericUpDown();
            
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResultText = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParameter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParameter2)).BeginInit();
            this.SuspendLayout();
            
            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.grpResult);
            this.panelMain.Controls.Add(this.grpInput);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 380);
            this.panelMain.TabIndex = 1;
            
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(600, 70);
            this.panelTop.TabIndex = 0;
            
            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Controls.Add(this.btnClear);
            this.panelBottom.Controls.Add(this.btnCalculate);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 450);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(600, 60);
            this.panelBottom.TabIndex = 2;
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(70, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Калькулятор материалов";
            
            // pictureBox1
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            
            // grpInput
            this.grpInput.Controls.Add(this.numParameter2);
            this.grpInput.Controls.Add(this.lblParameter2);
            this.grpInput.Controls.Add(this.numParameter1);
            this.grpInput.Controls.Add(this.lblParameter1);
            this.grpInput.Controls.Add(this.numQuantity);
            this.grpInput.Controls.Add(this.lblQuantity);
            this.grpInput.Controls.Add(this.cmbMaterialType);
            this.grpInput.Controls.Add(this.lblMaterialType);
            this.grpInput.Controls.Add(this.cmbProductType);
            this.grpInput.Controls.Add(this.lblProductType);
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.grpInput.Location = new System.Drawing.Point(20, 20);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(560, 180);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Параметры расчета";
            
            // lblProductType
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProductType.ForeColor = System.Drawing.Color.Black;
            this.lblProductType.Location = new System.Drawing.Point(20, 30);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(90, 15);
            this.lblProductType.TabIndex = 0;
            this.lblProductType.Text = "Тип продукции:";
            
            // cmbProductType
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(140, 27);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(200, 23);
            this.cmbProductType.TabIndex = 1;
            
            // lblMaterialType
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaterialType.ForeColor = System.Drawing.Color.Black;
            this.lblMaterialType.Location = new System.Drawing.Point(20, 65);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(89, 15);
            this.lblMaterialType.TabIndex = 2;
            this.lblMaterialType.Text = "Тип материала:";
            
            // cmbMaterialType
            this.cmbMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Location = new System.Drawing.Point(140, 62);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(200, 23);
            this.cmbMaterialType.TabIndex = 3;
            
            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(20, 100);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 15);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Количество:";
            
            // numQuantity
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuantity.Location = new System.Drawing.Point(140, 98);
            this.numQuantity.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.numQuantity.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(100, 23);
            this.numQuantity.TabIndex = 5;
            this.numQuantity.Value = new decimal(new int[] {1, 0, 0, 0});
            
            // lblParameter1
            this.lblParameter1.AutoSize = true;
            this.lblParameter1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblParameter1.ForeColor = System.Drawing.Color.Black;
            this.lblParameter1.Location = new System.Drawing.Point(280, 30);
            this.lblParameter1.Name = "lblParameter1";
            this.lblParameter1.Size = new System.Drawing.Size(76, 15);
            this.lblParameter1.TabIndex = 6;
            this.lblParameter1.Text = "Параметр 1:";
            
            // numParameter1
            this.numParameter1.DecimalPlaces = 4;
            this.numParameter1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numParameter1.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.numParameter1.Location = new System.Drawing.Point(370, 28);
            this.numParameter1.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numParameter1.Minimum = new decimal(new int[] {1, 0, 0, 262144});
            this.numParameter1.Name = "numParameter1";
            this.numParameter1.Size = new System.Drawing.Size(100, 23);
            this.numParameter1.TabIndex = 7;
            this.numParameter1.Value = new decimal(new int[] {1, 0, 0, 0});
            
            // lblParameter2
            this.lblParameter2.AutoSize = true;
            this.lblParameter2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblParameter2.ForeColor = System.Drawing.Color.Black;
            this.lblParameter2.Location = new System.Drawing.Point(280, 65);
            this.lblParameter2.Name = "lblParameter2";
            this.lblParameter2.Size = new System.Drawing.Size(76, 15);
            this.lblParameter2.TabIndex = 8;
            this.lblParameter2.Text = "Параметр 2:";
            
            // numParameter2
            this.numParameter2.DecimalPlaces = 4;
            this.numParameter2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numParameter2.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.numParameter2.Location = new System.Drawing.Point(370, 63);
            this.numParameter2.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numParameter2.Minimum = new decimal(new int[] {1, 0, 0, 262144});
            this.numParameter2.Name = "numParameter2";
            this.numParameter2.Size = new System.Drawing.Size(100, 23);
            this.numParameter2.TabIndex = 9;
            this.numParameter2.Value = new decimal(new int[] {1, 0, 0, 0});
            
            // grpResult
            this.grpResult.Controls.Add(this.txtDetails);
            this.grpResult.Controls.Add(this.lblUnit);
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Controls.Add(this.lblResultText);
            this.grpResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpResult.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.grpResult.Location = new System.Drawing.Point(20, 220);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(560, 150);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Результат расчета";
            
            // lblResultText
            this.lblResultText.AutoSize = true;
            this.lblResultText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResultText.ForeColor = System.Drawing.Color.Black;
            this.lblResultText.Location = new System.Drawing.Point(20, 30);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(149, 15);
            this.lblResultText.TabIndex = 0;
            this.lblResultText.Text = "Необходимо материала:";
            
            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblResult.Location = new System.Drawing.Point(190, 25);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(25, 30);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "0";
            
            // lblUnit
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnit.ForeColor = System.Drawing.Color.Gray;
            this.lblUnit.Location = new System.Drawing.Point(300, 32);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(32, 19);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "шт.";
            
            // txtDetails
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtDetails.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.txtDetails.Location = new System.Drawing.Point(20, 65);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(520, 75);
            this.txtDetails.TabIndex = 3;
            
            // btnCalculate
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(340, 15);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            
            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(450, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            
            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(550, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            
            // MaterialCalculatorForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 510);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Калькулятор материалов - Мастер пол";
            
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParameter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParameter2)).EndInit();
            this.ResumeLayout(false);
        }
    }
}