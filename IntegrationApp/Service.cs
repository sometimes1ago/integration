using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationApp
{
    /// <summary>
    /// Служебный класс для различных операций по типу генерации секретного ключа или разделения строк
    /// </summary>
    class Service
    {
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
        /// Метод устанвливающий какой именно пользователь авторизовался
        /// </summary>
        /// <param name="UserLogin">Логин пользователя</param>
        public static void SetAuthorizedUser(string UserLogin)
        {
            DB.AuthorizedUser = UserLogin;
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
    }
}
