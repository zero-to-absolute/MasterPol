using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MasterPol
{
    public partial class PartnerSalesHistoryForm : Form
    {
        private int партнерКод;
        private string партнерНаименование;
        
        public PartnerSalesHistoryForm(int кодПартнера, string наименование)
        {
            InitializeComponent();
            this.партнерКод = кодПартнера;
            this.партнерНаименование = наименование;
            
            this.Load += PartnerSalesHistoryForm_Load;
        }
        
        private void PartnerSalesHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Отображаем название партнера
                lblПартнер.Text = $"Партнер: {партнерНаименование} (Код: {партнерКод})";
                
                // Скрываем элементы фильтрации по дате
                lblПериод.Visible = false;
                dtpС.Visible = false;
                dtpПо.Visible = false;
                btnОтфильтровать.Visible = false;
                
                // Загружаем всю историю продаж
                LoadSalesHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки истории продаж: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadSalesHistory()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                
                // Используем детальный запрос для истории продаж конкретного партнера
                string query = @"
                    SELECT 
                        з.НомерЗаказа,
                        з.Дата,
                        з.Сумма AS СуммаЗаказа,
                        з.Статус,
                        пр.Наименование,
                        пз.Количество,
                        пз.Цена,
                        (пз.Количество * пз.Цена) AS Сумма,
                        п.Наименование AS НаименованиеПартнера,
                        п.КодПартнера
                    FROM Заказы з
                    INNER JOIN Партнеры п ON з.КодПартнера = п.КодПартнера
                    INNER JOIN ПозицииЗаказов пз ON з.КодЗаказа = пз.КодЗаказа
                    INNER JOIN Продукция пр ON пз.КодПродукта = пр.КодПродукта
                    WHERE п.КодПартнера = @КодПартнера
                    ORDER BY з.Дата DESC, з.НомерЗаказа DESC";
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@КодПартнера", партнерКод);
                        
                        DataTable historyTable = new DataTable();
                        adapter.Fill(historyTable);
                        
                        // Привязываем данные к DataGridView
                        dgvИстория.DataSource = historyTable;
                        
                        // Настраиваем заголовки столбцов
                        ConfigureDataGridView();
                        
                        // Обновляем статистику
                        UpdateStatistics(historyTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                // Показываем пустую таблицу в случае ошибки
                dgvИстория.DataSource = new DataTable();
            }
        }
        
        private void ConfigureDataGridView()
        {
            try
            {
                // Скрываем служебные столбцы
                if (dgvИстория.Columns["НаименованиеПартнера"] != null)
                    dgvИстория.Columns["НаименованиеПартнера"].Visible = false;
                if (dgvИстория.Columns["КодПартнера"] != null)
                    dgvИстория.Columns["КодПартнера"].Visible = false;
                
                // Настраиваем заголовки столбцов на русском
                if (dgvИстория.Columns["НомерЗаказа"] != null)
                    dgvИстория.Columns["НомерЗаказа"].HeaderText = "№ Заказа";
                
                if (dgvИстория.Columns["Дата"] != null)
                {
                    dgvИстория.Columns["Дата"].HeaderText = "Дата";
                    dgvИстория.Columns["Дата"].DefaultCellStyle.Format = "dd.MM.yyyy";
                    dgvИстория.Columns["Дата"].Width = 100;
                }
                
                if (dgvИстория.Columns["НазваниеПродукции"] != null)
                {
                    dgvИстория.Columns["НазваниеПродукции"].HeaderText = "Продукция";
                    dgvИстория.Columns["НазваниеПродукции"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                
                if (dgvИстория.Columns["Количество"] != null)
                {
                    dgvИстория.Columns["Количество"].HeaderText = "Количество";
                    dgvИстория.Columns["Количество"].DefaultCellStyle.Format = "N0";
                    dgvИстория.Columns["Количество"].Width = 80;
                }
                
                if (dgvИстория.Columns["Цена"] != null)
                {
                    dgvИстория.Columns["Цена"].HeaderText = "Цена за ед.";
                    dgvИстория.Columns["Цена"].DefaultCellStyle.Format = "N2";
                    dgvИстория.Columns["Цена"].Width = 100;
                }
                
                if (dgvИстория.Columns["Сумма"] != null)
                {
                    dgvИстория.Columns["Сумма"].HeaderText = "Сумма позиции";
                    dgvИстория.Columns["Сумма"].DefaultCellStyle.Format = "N2";
                    dgvИстория.Columns["Сумма"].Width = 100;
                }
                
                if (dgvИстория.Columns["СуммаЗаказа"] != null)
                {
                    dgvИстория.Columns["СуммаЗаказа"].HeaderText = "Сумма заказа";
                    dgvИстория.Columns["СуммаЗаказа"].DefaultCellStyle.Format = "N2";
                    dgvИстория.Columns["СуммаЗаказа"].Width = 100;
                }
                
                if (dgvИстория.Columns["Статус"] != null)
                {
                    dgvИстория.Columns["Статус"].HeaderText = "Статус";
                    dgvИстория.Columns["Статус"].Width = 100;
                }
                
                // Стилизация строк
                dgvИстория.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                dgvИстория.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dgvИстория.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvИстория.ReadOnly = true;
                dgvИстория.AllowUserToAddRows = false;
                dgvИстория.AllowUserToDeleteRows = false;
                dgvИстория.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка настройки DataGridView: {ex.Message}");
            }
        }
        
        private void UpdateStatistics(DataTable data)
        {
            try
            {
                if (data == null || data.Rows.Count == 0)
                {
                    lblВсегоЗаказов.Text = "Всего заказов: 0";
                    lblОбщаяСумма.Text = "Общая сумма: 0,00 ₽";
                    lblПоследнийЗаказ.Text = "Последний заказ: -";
                    return;
                }
                
                // Подсчет уникальных заказов
                int всегоЗаказов = data.AsEnumerable()
                    .Select(row => row.Field<string>("НомерЗаказа"))
                    .Where(x => x != null)
                    .Distinct()
                    .Count();
                
                // Общая сумма по позициям
                decimal общаяСумма = 0;
                foreach (DataRow row in data.Rows)
                {
                    if (row["Сумма"] != DBNull.Value)
                    {
                        общаяСумма += Convert.ToDecimal(row["Сумма"]);
                    }
                }
                
                // Дата последнего заказа
                DateTime? последнийЗаказ = data.AsEnumerable()
                    .Select(row => row.Field<DateTime?>("Дата"))
                    .Where(x => x.HasValue)
                    .OrderByDescending(date => date)
                    .FirstOrDefault();
                
                // Обновляем лейблы статистики
                lblВсегоЗаказов.Text = $"Всего заказов: {всегоЗаказов}";
                lblОбщаяСумма.Text = $"Общая сумма: {общаяСумма:N2} ₽";
                
                if (последнийЗаказ.HasValue)
                    lblПоследнийЗаказ.Text = $"Последний заказ: {последнийЗаказ.Value:dd.MM.yyyy}";
                else
                    lblПоследнийЗаказ.Text = "Последний заказ: -";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка обновления статистики: {ex.Message}");
                lblВсегоЗаказов.Text = "Всего заказов: -";
                lblОбщаяСумма.Text = "Общая сумма: -";
                lblПоследнийЗаказ.Text = "Последний заказ: -";
            }
        }
        
        private void btnОтфильтровать_Click(object sender, EventArgs e)
        {
            // Метод больше не используется, так как фильтрация убрана
        }
        
        private void btnЗакрыть_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}