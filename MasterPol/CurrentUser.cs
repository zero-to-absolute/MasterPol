using System;

namespace MasterPol
{
    public static class CurrentUser
    {
        public static string КодПользователя { get; set; }
        public static string Логин { get; set; }
        public static string ФИО { get; set; }
        public static string Роль { get; set; }
        public static bool IsAuthenticated { get; set; } = false;

        public static void Login(string кодПользователя, string логин, string фио, string роль)
        {
            КодПользователя = кодПользователя;
            Логин = логин;
            ФИО = фио;
            Роль = роль;
            IsAuthenticated = true;
        }

        public static void Logout()
        {
            КодПользователя = null;
            Логин = null;
            ФИО = null;
            Роль = null;
            IsAuthenticated = false;
        }

        public static bool IsManager() => Роль == "Менеджер" || Роль == "Администратор";
        public static bool IsPartner() => Роль == "Партнер";
        public static bool IsSupplier() => Роль == "Поставщик";
        public static bool IsAdmin() => Роль == "Администратор";
    }
}
