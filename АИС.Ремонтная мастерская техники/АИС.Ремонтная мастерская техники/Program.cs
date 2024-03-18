using System;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());
        }
    }
    static class Database
    {
        // Публичный метод для подключения БД к форме.
        public static string ConnectionString = @"Data Source=database.db; Integrated Security=False; MultipleActiveResultSets=True";
    }
    // Описание всех таблиц из БД.
    #region table_DB
    static class Table_Clients
    {
        public static string main = "Clients";
        public static string ID = "ID";
        public static string ClientName = "ClientName";
        public static string Login = "Login";
        public static string PassWord = "PassWord";
        public static string DateofRegistration = "DateofRegistration";
    }
    static class Table_BankDetails
    {
        public static string main = "BankDetails";
        public static string ID = "ID";
        public static string CardCode = "CardCode";
        public static string ValidityPeriod = "ValidityPeriod";
        public static string CVC = "CVC";
        public static string NameANDSurname = "NameANDSurname";
        public static string Ballance = "Ballance";
    }
    static class Table_Employees
    {
        public static string main = "Employees";
        public static string ID = "ID";
        public static string Login = "Login";
        public static string PassWord = "PassWord";
        public static string EmployeeName = "EmployeeName";
        public static string PhoneNumber = "PhoneNumber";
        public static string Dokuments = "Dokuments";
        public static string AdmissionDate = "AdmissionDate";
        public static string Salary = "Salary";
        public static string Specialization = "Specialization";
    }
    static class Table_Orders
    {
        public static string main = "Orders";
        public static string ID = "ID";
        public static string ClientName = "ClientName";
        public static string OrderDate = "OrderDate";
        public static string TheCostOfTheOrder = "TheCostOfTheOrder";
        public static string OrderItem = "OrderItem";
        public static string Servirse = "Servise";
    }
    static class Table_Questions
    {
        public static string main = "Questions";
        public static string ID = "ID";
        public static string ClientName = "ClientName";
        public static string QuestionName = "Question";
        public static string ClientPhone = "ClientPhone";
        public static string QuestionDate = "QuestionDate";
    }
    static class Table_Trashcan
    {
        public static string main = "Trashcan";
        public static string ID = "ID";
        public static string FileName = "FileName";
        public static string DateOfDelation = "DateOfDelation";
    }
    static class Table_sqlite_sequence
    {
        public static string name = "name";
        public static string seq = "seq";
    }
    public class DataCase
    {
        public static string Name { get; set; }
        public static string Login { get; set; }
    }
    #endregion
}