using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MasterPol
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnВход_Click(object sender, EventArgs e)
        {
            string логин = txtLogin.Text.Trim();
            string пароль = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(логин) || string.IsNullOrEmpty(пароль))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (AuthenticateUser(логин, пароль))
                {
                    MessageBox.Show($"Добро пожаловать, {CurrentUser.ФИО}!",
                        "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();

                    // После закрытия возвращаемся к авторизации
                    CurrentUser.Logout();
                    txtLogin.Clear();
                    txtPassword.Clear();
                    this.Show();
                    txtLogin.Focus();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string логин, string пароль)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            string query = @"SELECT КодПользователя, Логин, ФИО, Роль 
                           FROM Пользователи 
                           WHERE Логин = @login AND Пароль = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", логин);
                    command.Parameters.AddWithValue("@password", пароль);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CurrentUser.Login(
                                reader["КодПользователя"].ToString(),
                                reader["Логин"].ToString(),
                                reader["ФИО"].ToString(),
                                reader["Роль"].ToString()
                            );
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnОтмена_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
