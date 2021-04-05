using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationApp
{
    /// <summary>
    /// Класс для работы с данными. Служит для избежания дублирования обработки схожего функционала у нескольких
    /// групп пользователей
    /// </summary>
    class Data
    {
        /// <summary>
        /// Метод, получающий данные спортсменов при прямом поиске согласно условию выборки
        /// </summary>
        /// <param name="SearchBy">Условие выборки</param>
        /// <param name="SearchValue">Значение по которому производится выборка</param>
        /// <returns></returns>
        public static object DirectSpDataSearch(string SearchBy, string SearchValue)
        {
            string DirectSearchQuery = "select * from GetSportsmanData where " + Service.GetSortByParameter(SearchBy) +
                " = " + "\'" + SearchValue + "\'";
            return DB.SearchValuesQuery(DirectSearchQuery);
        }

        /// <summary>
        /// Метод, получающий данные о мероприятиях при прямом поиске согласно условию выборки
        /// </summary>
        /// <param name="SearchBy">Условие выборки</param>
        /// <param name="SearchValue">Значение по которому производится выборка</param>
        /// <returns></returns>
        public static object DirectEvtDataSearch(string SearchBy, string SearchValue)
        {
            string DirectSearchQuery = "select * from GetEventsData where " + Service.GetSortByParameter(SearchBy) +
                " = " + "\'" + SearchValue + "\'";
            return DB.SearchValuesQuery(DirectSearchQuery);
        }

        public static object DirectSpEvtDataSearch(string SearchBy, string SearchValue)
        {
            int SpID = GetSportsmanIDByUserlogin(Service.AuthorizedUser);

            string GetTeamName = "select Команды.Наименование from Спортсмены_в_команде inner join Команды on Спортсмены_в_команде.Команда=Команды.ID_Команды where Спортсмен = " + "\'" + SpID + "\'";
            DB.SearchValuesQuery(GetTeamName);
            string TeamName = DB.ds.Tables[0].Rows[0][0].ToString();

            string DirectSearchQuery = "select * from GetEventsData where Команда = " + "\'" + TeamName + "\'" + Service.GetSortByParameter(SearchBy) +
                " = " + "\'" + SearchValue + "\'";
            return DB.SearchValuesQuery(DirectSearchQuery);
        }

        /// <summary>
        /// Метод, получающий данные спортсменов, согласно параметру сортировки и упорядочивания
        /// </summary>
        /// <param name="SortBy">Сортировочный параметр</param>
        /// <param name="OrderBy">Сортировочный параметр</param>
        /// <returns></returns>
        public static object GetSpData(string SortBy, string OrderBy)
        {
            string GetSportsmenData = "select * from GetSportsmanData order by " + Service.GetSortByParameter(SortBy) +
                " " + Service.GetOrderParameter(OrderBy);
            return DB.SearchValuesQuery(GetSportsmenData);
        }

        public static object GetAuthSpData(string Userlogin)
        {
            int SpID = GetSportsmanIDByUserlogin(Service.AuthorizedUser);
            string GetSportsmenData = "select Фамилия, Имя, Отчество, Гражданство, Дата_рождения, Рост_см, Вес_кг from Спортсмены where ID_Спортсмена = " + "\'" + SpID + "\'";
            return DB.SearchValuesQuery(GetSportsmenData);
        }


        /// <summary>
        /// Метод, получающий данные о мероприятиях, согласно параметру сортировки и упорядочивания
        /// </summary>
        /// <param name="SortBy">Сортировочный параметр</param>
        /// <param name="OrderBy">Сортировочный параметр</param>
        /// <returns></returns>
        public static object GetEvtData(string SortBy, string OrderBy)
        {
            string GetEventsData = "select * from GetEventsData order by " + Service.GetSortByParameter(SortBy) +
                " " + Service.GetOrderParameter(OrderBy);
            return DB.SearchValuesQuery(GetEventsData);
        }

        /// <summary>
        /// Метод, получающий данные о мероприятиях, согласно параметру сортировки и упорядочивания для конкретного спортсмена
        /// </summary>
        /// <param name="SortBy">Сортировочный параметр</param>
        /// <param name="OrderBy">Сортировочный параметр</param>
        /// <returns></returns>
        public static object GetSpEvtData(string Userlogin, string SortBy, string OrderBy)
        {
            int SpID = GetSportsmanIDByUserlogin(Service.AuthorizedUser);

            string GetTeamName = "select Команды.Наименование from Спортсмены_в_команде inner join Команды on Спортсмены_в_команде.Команда=Команды.ID_Команды where Спортсмен = " + "\'" + SpID + "\'";
            DB.SearchValuesQuery(GetTeamName);
            string TeamName = DB.ds.Tables[0].Rows[0][0].ToString();

            string GetEventsData = "select * from GetEventsData where Команда = " + "\'" + TeamName + "\'" + " order by " + Service.GetSortByParameter(SortBy) +
                " " + Service.GetOrderParameter(OrderBy);
            return DB.SearchValuesQuery(GetEventsData);
        }

        /// <summary>
        /// Метод, получающий фио пользователя, согласно его логину
        /// </summary>
        /// <param name="Userlogin">Логин авторизованного пользователя</param>
        /// <returns></returns>
        public static object GetAuthorizedUserData(string Userlogin)
        {
            string Query = "execute GetAuthUserData " + "\'" + Service.AuthorizedUser + "\'";
            return DB.SearchValuesQuery(Query);
        }

        /// <summary>
        /// Метод, получающий ID авторизованного пользователя
        /// </summary>
        /// <param name="Userlogin"></param>
        /// <returns></returns>
        public static int GetEmployeeIDByUserlogin(string Userlogin)
        {
            string GetIDQuery = "execute GetEmpIDByAuthUser " + "\'" + Userlogin + "\'";
            DB.SearchValuesQuery(GetIDQuery);
            int EmpID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());
            return EmpID;
        }

        public static int GetSportsmanIDByUserlogin(string Userlogin)
        {
            string GetIDQuery = "execute GetSportsmanIDByUserlogin " + "\'" + Userlogin + "\'";
            DB.SearchValuesQuery(GetIDQuery);
            int SpID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());
            return SpID;
        }

        public static int GetEmpIDBySurnameName(string surname, string name)
        {
            string GetEmpID = "execute GetEmpIDBySurnameName " + "\'" + surname + "\'" + "," + "\'" + name + "\'";
            DB.SearchValuesQuery(GetEmpID);
            int EmpID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());
            return EmpID;
        }

        public static string GetEmpSurnameNameByLogin(string Login)
        {
            string GetData = "execute GetSurnameNameByLogin " + "\'" + Service.AuthorizedUser + "\'";
            DB.SearchValuesQuery(GetData);
            string SurnameName = DB.ds.Tables[0].Rows[0][0].ToString() + " " + DB.ds.Tables[0].Rows[0][1].ToString();
            return SurnameName;
        }
    }
}
