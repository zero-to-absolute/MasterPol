using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MasterPol
{
    public partial class MaterialCalculatorForm : Form
    {
        public MaterialCalculatorForm()
        {
            InitializeComponent();
            this.Load += MaterialCalculatorForm_Load;
        }
        
        private void MaterialCalculatorForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Загружаем данные в ComboBox'ы
                LoadProductTypes();
                LoadMaterialTypes();
                
                // Устанавливаем значения по умолчанию
                numParameter1.Value = 1.0m;
                numParameter2.Value = 1.0m;
                numQuantity.Value = 1;
                
                // Настраиваем результат
                lblResult.Text = "0";
                lblResult.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки формы: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadProductTypes()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                string query = "SELECT КодПродукции, НазваниеПродукции FROM Продукция ORDER BY НазваниеПродукции";
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            cmbProductType.Items.Clear();
                            cmbProductType.DisplayMember = "Text";
                            cmbProductType.ValueMember = "Value";
                            
                            while (reader.Read())
                            {
                                cmbProductType.Items.Add(new 
                                {
                                    Text = reader["НазваниеПродукции"].ToString(),
                                    Value = Convert.ToInt32(reader["КодПродукции"])
                                });
                            }
                        }
                    }
                }
                
                if (cmbProductType.Items.Count > 0)
                    cmbProductType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки типов продукции: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void LoadMaterialTypes()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                string query = "SELECT КодТипаМатериала, НазваниеТипа FROM ТипыМатериалов ORDER BY НазваниеТипа";
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            cmbMaterialType.Items.Clear();
                            cmbMaterialType.DisplayMember = "Text";
                            cmbMaterialType.ValueMember = "Value";
                            
                            while (reader.Read())
                            {
                                cmbMaterialType.Items.Add(new 
                                {
                                    Text = reader["НазваниеТипа"].ToString(),
                                    Value = Convert.ToInt32(reader["КодТипаМатериала"])
                                });
                            }
                        }
                    }
                }
                
                if (cmbMaterialType.Items.Count > 0)
                    cmbMaterialType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки типов материалов: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем выбор типов
                if (cmbProductType.SelectedItem == null)
                {
                    MessageBox.Show("Выберите тип продукции!", "Внимание", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (cmbMaterialType.SelectedItem == null)
                {
                    MessageBox.Show("Выберите тип материала!", "Внимание", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Получаем параметры
                int productTypeId = (int)((dynamic)cmbProductType.SelectedItem).Value;
                int materialTypeId = (int)((dynamic)cmbMaterialType.SelectedItem).Value;
                int quantity = (int)numQuantity.Value;
                double parameter1 = (double)numParameter1.Value;
                double parameter2 = (double)numParameter2.Value;
                
                // Вызываем метод расчета
                int result = CalculateMaterialQuantity(productTypeId, materialTypeId, quantity, parameter1, parameter2);
                
                // Отображаем результат
                if (result == -1)
                {
                    lblResult.Text = "Ошибка расчета";
                    lblResult.ForeColor = Color.Red;
                    txtDetails.Text = "Не удалось выполнить расчет. Проверьте правильность введенных данных.";
                }
                else
                {
                    lblResult.Text = result.ToString();
                    lblResult.ForeColor = Color.Green;
                    
                    // Показываем детали расчета
                    ShowCalculationDetails(productTypeId, materialTypeId, quantity, parameter1, parameter2, result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при расчете: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                lblResult.Text = "Ошибка";
                lblResult.ForeColor = Color.Red;
            }
        }
        
        private int CalculateMaterialQuantity(int productTypeId, int materialTypeId, int quantity, double parameter1, double parameter2)
        {
            try
            {
                // Проверяем входные данные
                if (quantity <= 0 || parameter1 <= 0 || parameter2 <= 0)
                    return -1;
                
                string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                
                // Получаем коэффициент типа продукции
                double productCoefficient = GetProductCoefficient(productTypeId, connectionString);
                if (productCoefficient <= 0)
                    return -1;
                
                // Получаем процент брака материала
                double wastePercentage = GetMaterialWastePercentage(materialTypeId, connectionString);
                if (wastePercentage < 0)
                    return -1;
                
                // Рассчитываем количество материала на одну единицу продукции
                double materialPerUnit = parameter1 * parameter2 * productCoefficient;
                
                // Общее количество материала без учета брака
                double baseMaterialQuantity = materialPerUnit * quantity;
                
                // Учитываем брак материала
                double totalMaterialQuantity = baseMaterialQuantity * (1.0 + wastePercentage / 100.0);
                
                // Округляем вверх до целого числа
                return (int)Math.Ceiling(totalMaterialQuantity);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка расчета материала: {ex.Message}");
                return -1;
            }
        }
        
        private double GetProductCoefficient(int productTypeId, string connectionString)
        {
            try
            {
                // Если нет таблицы коэффициентов, используем значения по умолчанию
                // В реальной системе это должно браться из базы данных
                
                // Примеры коэффициентов для разных типов продукции
                switch (productTypeId % 5) // Простая имитация разных типов
                {
                    case 0: return 1.2; // Ламинат - коэффициент 1.2
                    case 1: return 1.5; // Паркет - коэффициент 1.5
                    case 2: return 1.1; // Линолеум - коэффициент 1.1
                    case 3: return 1.3; // Ковролин - коэффициент 1.3
                    case 4: return 1.4; // Плитка - коэффициент 1.4
                    default: return 1.0;
                }
            }
            catch
            {
                return -1;
            }
        }
        
        private double GetMaterialWastePercentage(int materialTypeId, string connectionString)
        {
            try
            {
                // Если нет таблицы процентов брака, используем значения по умолчанию
                // В реальной системе это должно браться из базы данных
                
                // Примеры процентов брака для разных типов материалов
                switch (materialTypeId % 6) // Простая имитация разных типов
                {
                    case 0: return 5.0;  // Дерево - 5% брака
                    case 1: return 3.0;  // Пластик - 3% брака  
                    case 2: return 2.0;  // Металл - 2% брака
                    case 3: return 8.0;  // Ткань - 8% брака
                    case 4: return 4.0;  // Керамика - 4% брака
                    case 5: return 6.0;  // Композит - 6% брака
                    default: return 5.0;
                }
            }
            catch
            {
                return -1;
            }
        }
        
        private void ShowCalculationDetails(int productTypeId, int materialTypeId, int quantity, 
            double parameter1, double parameter2, int result)
        {
            try
            {
                double productCoefficient = GetProductCoefficient(productTypeId, ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
                double wastePercentage = GetMaterialWastePercentage(materialTypeId, ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
                
                double materialPerUnit = parameter1 * parameter2 * productCoefficient;
                double baseMaterialQuantity = materialPerUnit * quantity;
                
                string details = $"Детали расчета:\n\n" +
                               $"• Параметр 1: {parameter1:F2}\n" +
                               $"• Параметр 2: {parameter2:F2}\n" +
                               $"• Коэффициент продукции: {productCoefficient:F2}\n" +
                               $"• Материал на единицу: {materialPerUnit:F4}\n" +
                               $"• Количество продукции: {quantity}\n" +
                               $"• Базовое количество материала: {baseMaterialQuantity:F2}\n" +
                               $"• Процент брака: {wastePercentage:F1}%\n" +
                               $"• Итоговое количество (с учетом брака): {result}";
                
                txtDetails.Text = details;
            }
            catch (Exception ex)
            {
                txtDetails.Text = $"Ошибка отображения деталей: {ex.Message}";
            }
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                // Сбрасываем все поля
                if (cmbProductType.Items.Count > 0)
                    cmbProductType.SelectedIndex = 0;
                if (cmbMaterialType.Items.Count > 0)
                    cmbMaterialType.SelectedIndex = 0;
                    
                numQuantity.Value = 1;
                numParameter1.Value = 1.0m;
                numParameter2.Value = 1.0m;
                
                lblResult.Text = "0";
                lblResult.ForeColor = Color.Blue;
                txtDetails.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при очистке: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}