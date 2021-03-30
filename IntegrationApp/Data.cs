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
        /// Метод, получающий фио пользователя, согласно его логину
        /// </summary>
        /// <param name="Userlogin">Логин авторизованного пользователя</param>
        /// <returns></returns>
        public static object GetAuthorizedUserData(string Userlogin)
        {
            string Query = "execute GetAuthUserData " + "\'" + Service.AuthorizedUser + "\'";
            return DB.SearchValuesQuery(Query);
        }
    }
}
