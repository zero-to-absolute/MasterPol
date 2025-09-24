using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MasterPol
{
    public partial class DiscountInfoForm : Form
    {
        private int партнерКод;
        private string партнерНаименование;
        
        public DiscountInfoForm(int кодПартнера, string наименование)
        {
            InitializeComponent();
            this.партнерКод = кодПартнера;
            this.партнерНаименование = наименование;
            
            this.Load += DiscountInfoForm_Load;
        }
        
        private void DiscountInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Отображаем название партнера
                lblПартнер.Text = $"Партнер: {партнерНаименование}";
                
                // Рассчитываем и отображаем скидку
                CalculateAndDisplayDiscount();
                
                // Заполняем условия скидки
                FillDiscountConditions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CalculateAndDisplayDiscount()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                
                // Запрос для подсчета общего количества продаж партнера
                string query = @"
                    SELECT 
                        ISNULL(SUM(пз.Количество), 0) AS ОбщееКоличество,
                        ISNULL(SUM(з.Сумма), 0) AS ОбщаяСумма
                    FROM Заказы з
                    INNER JOIN ПозицииЗаказов пз ON з.КодЗаказа = пз.КодЗаказа
                    WHERE з.КодПартнера = @КодПартнера AND з.Статус = 'Завершен'";
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@КодПартнера", партнерКод);
                        
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int общееКоличество = Convert.ToInt32(reader["ОбщееКоличество"]);
                                decimal общаяСумма = Convert.ToDecimal(reader["ОбщаяСумма"]);
                                
                                // Рассчитываем скидку согласно правилам из модуля 2
                                int процентСкидки = CalculateDiscountPercent(общееКоличество);
                                
                                // Отображаем данные
                                DisplayDiscountData(общееКоличество, общаяСумма, процентСкидки);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка расчета скидки: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private int CalculateDiscountPercent(int количество)
        {
            // Согласно модулю 2: до 10000 – 0%, 10000-50000 – 5%, 50000-300000 – 10%, более 300000 – 15%
            if (количество < 10000)
                return 0;
            else if (количество < 50000)
                return 5;
            else if (количество < 300000)
                return 10;
            else
                return 15;
        }
        
        private void DisplayDiscountData(int количество, decimal сумма, int процентСкидки)
        {
            // Отображаем процент скидки
            lblПроцентСкидки.Text = $"{процентСкидки}%";
            lblПроцентСкидки.ForeColor = процентСкидки > 0 ? Color.FromArgb(46, 125, 50) : Color.FromArgb(231, 76, 60);
            
            // Отображаем количество и сумму
            lblКоличествоЗначение.Text = количество.ToString("N0");
            lblСуммаЗначение.Text = сумма.ToString("N2") + " ₽";
            
            // Настраиваем прогресс-бар
            SetupProgressBar(количество);
        }
        
        private void SetupProgressBar(int количество)
        {
            // Устанавливаем максимальное значение и текущее для прогресс-бара
            progressВыполнение.Maximum = 300000; // Максимум для 15% скидки
            progressВыполнение.Value = Math.Min(количество, 300000);
            
            // Меняем цвет в зависимости от уровня
            if (количество < 10000)
                progressВыполнение.ForeColor = Color.FromArgb(231, 76, 60); // Красный
            else if (количество < 50000)
                progressВыполнение.ForeColor = Color.FromArgb(243, 156, 18); // Оранжевый
            else if (количество < 300000)
                progressВыполнение.ForeColor = Color.FromArgb(52, 152, 219); // Синий
            else
                progressВыполнение.ForeColor = Color.FromArgb(46, 125, 50); // Зеленый
        }
        
        private void FillDiscountConditions()
        {
            rtbУсловия.Clear();
            rtbУсловия.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            rtbУсловия.SelectionColor = Color.FromArgb(52, 73, 94);
            rtbУсловия.AppendText("Условия получения скидки:\n\n");
            
            rtbУсловия.SelectionFont = new Font("Segoe UI", 9F);
            rtbУсловия.SelectionColor = Color.Black;
            
            rtbУсловия.AppendText("🔸 До 10,000 единиц: ");
            rtbУсловия.SelectionColor = Color.FromArgb(231, 76, 60);
            rtbУсловия.AppendText("0% скидки\n");
            
            rtbУсловия.SelectionColor = Color.Black;
            rtbУсловия.AppendText("🔸 10,000 - 49,999 единиц: ");
            rtbУсловия.SelectionColor = Color.FromArgb(243, 156, 18);
            rtbУсловия.AppendText("5% скидки\n");
            
            rtbУсловия.SelectionColor = Color.Black;
            rtbУсловия.AppendText("🔸 50,000 - 299,999 единиц: ");
            rtbУсловия.SelectionColor = Color.FromArgb(52, 152, 219);
            rtbУсловия.AppendText("10% скидки\n");
            
            rtbУсловия.SelectionColor = Color.Black;
            rtbУсловия.AppendText("🔸 300,000+ единиц: ");
            rtbУсловия.SelectionColor = Color.FromArgb(46, 125, 50);
            rtbУсловия.AppendText("15% скидки\n\n");
            
            rtbУсловия.SelectionColor = Color.FromArgb(127, 140, 141);
            rtbУсловия.SelectionFont = new Font("Segoe UI", 8F, FontStyle.Italic);
            rtbУсловия.AppendText("* Скидка рассчитывается на основе общего количества продаж за весь период работы с завершенными заказами.");
        }
        
        private void btnЗакрыть_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}