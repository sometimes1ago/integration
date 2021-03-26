using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegrationApp
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void ToAuthLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Auth auth = new Auth();
            Hide();
            auth.Show();
        }


        /// <summary>
        /// Метод, получающий сортировочный параметр у спортсменов
        /// </summary>
        /// <param name="SelectedItem">Выбранный элемент комбобокса</param>
        /// <returns></returns>
        private string GetSortByParameter(string SelectedItem)
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
            }

            return SelectedItem;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            SortSpByOpt.SelectedItem = "Фамилии";
            OrderSpByOpt.SelectedItem = "Убыванию";
            string GetSportsmenData = "select * from GetSportsmanData order by " + GetSortByParameter(SortSpByOpt.SelectedItem.ToString())  +
                " " + Service.GetOrderParameter(OrderSpByOpt.SelectedItem.ToString());
            SpData.DataSource = DB.SearchValuesQuery(GetSportsmenData);
        }

        private void ShowSortedSpButton_Click(object sender, EventArgs e)
        {
            string GetSportsmenData = "select * from GetSportsmanData order by " + GetSortByParameter(SortSpByOpt.SelectedItem.ToString()) +
                " " + Service.GetOrderParameter(OrderSpByOpt.SelectedItem.ToString());
            SpData.DataSource = DB.SearchValuesQuery(GetSportsmenData);
        }
    }
}
