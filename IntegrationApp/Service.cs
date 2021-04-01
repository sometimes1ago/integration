using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IntegrationApp
{
    /// <summary>
    /// Служебный класс для различных операций по типу генерации секретного ключа или разделения строк
    /// </summary>
    class Service
    {
        //Логин авторизованного пользователя
        public static string AuthorizedUser;

        /// <summary>
        /// Метод генерирующий секретный ключ используемый при регистрации или добавлении пользователей
        /// </summary>
        /// <param name="length">Длина генерируемой строки</param>
        /// <returns></returns>
        public static string GenerateSecretKey(int length)
        {
            string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789";
            int position;
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(length - 1);

            for (int i = 0; i < length; i++)
            {
                position = rnd.Next(0, alphabet.Length - 1);
                sb.Append(alphabet[position]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Метод, получающий порядок сортировки при выполнении запроса
        /// </summary>
        /// <param name="SelectedItem">Выбранный элемент комбобокса</param>
        /// <returns></returns>
        public static string GetOrderParameter(string SelectedItem)
        {
            switch (SelectedItem)
            {
                case "Возрастанию":
                    SelectedItem = "DESC";
                    break;
                case "Убыванию":
                    SelectedItem = "ASC";
                    break;
            }

            return SelectedItem;
        }

        /// <summary>
        /// Метод, получающий сортировочный параметр
        /// </summary>
        /// <param name="SelectedItem">Выбранный элемент комбобокса</param>
        /// <returns></returns>
        public static string GetSortByParameter(string SelectedItem)
        {
            switch (SelectedItem)
            {
                case "Фамилии":
                    SelectedItem = "Фамилия";
                    break;
                case "Гражданству":
                    SelectedItem = "Гражданство";
                    break;
                case "Росту":
                    SelectedItem = "Рост_см";
                    break;
                case "Весу":
                    SelectedItem = "Вес_кг";
                    break;
                case "Команде":
                    SelectedItem = "Команда";
                    break;
                case "Дате":
                    SelectedItem = "Дата_проведения";
                    break;
                case "Времени":
                    SelectedItem = "Время_проведения";
                    break;
                case "Типу":
                    SelectedItem = "Тип_мероприятия";
                    break;
                case "Месту":
                    SelectedItem = "Место_проведения";
                    break;
                case "Названию":
                    SelectedItem = "Название";
                    break;
            }

            return SelectedItem;
        }

        /// <summary>
        /// Метод, устанвливающий какой именно пользователь авторизовался
        /// </summary>
        /// <param name="UserLogin">Логин пользователя</param>
        public static void SetAuthorizedUser(string UserLogin)
        {
            AuthorizedUser = UserLogin;
        }

        /// <summary>
        /// Метод, разделяющий выбранный элемент комбобокса согласно разделителю
        /// </summary>
        /// <param name="SelectedItem">Выбранный элемент комбобокса</param>
        /// <param name="Separator">Разделитель</param>
        /// <returns></returns>
        public static string[] SpitComboboxItem(string SelectedItem, char Separator)
        {
            string SelectedString = SelectedItem;
            string[] SplStrArr = SelectedString.Split(Separator);
            return SplStrArr;
        }

        /// <summary>
        /// Метод, проверяющий корректность ввода ФИО, чтобы она была только на русском языке без других символов
        /// </summary>
        /// <param name="Surname">Фамилия</param>
        /// <param name="Name">Имя</param>
        /// <param name="LastName">Отчество</param>
        /// <returns></returns>
        public static bool FIOMatcher(string Surname, string Name, string LastName)
        {
            Regex Regex = new Regex(@"^[А-Я][а-я]+(-[А-Я][а-я]+)?$");
            Match SurnameMatch = Regex.Match(Surname);
            Match NameMatch = Regex.Match(Name);
            Match LastNameMatch = Regex.Match(LastName);

            if (SurnameMatch.Success && NameMatch.Success && LastNameMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод, создающий нового пользователя определенного типа
        /// </summary>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        /// <param name="UserType">Тип пользователя</param>
        public static void CreateNewUser(string Login, string Password, int UserType)
        {
            string CreateNewUserQuery = "execute CreateNewUser " + "\'" + Login + "\'" + "," + "\'" + Password + "\'"
                + "," + "\'" + UserType + "\'";
            DB.Execute(CreateNewUserQuery);
        }

        public static int GetNewUserID(string Userlogin)
        {
            string GetQuery = "select ID_Пользователя"
        }
    }
}
