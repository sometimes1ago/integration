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
            Auth auth = new Auth(this);
            Hide();
            auth.Show();
        }


        private void Welcome_Load(object sender, EventArgs e)
        {
            //Установка значений по умолчанию
            SortSpByOpt.SelectedItem = "Фамилии";
            OrderSpByOpt.SelectedItem = "Убыванию";
            SortEvtOpt.SelectedItem = "Названию";
            OrderEvtOpt.SelectedItem = "Убыванию";

            //Получение данных
            NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
            SpData.DataSource = Data.GetSpData(SortSpByOpt.SelectedItem.ToString(), OrderSpByOpt.SelectedItem.ToString());
        }

        private void ShowSortedSpButton_Click(object sender, EventArgs e)
        {
            SpData.DataSource = Data.GetSpData(SortSpByOpt.SelectedItem.ToString(), OrderSpByOpt.SelectedItem.ToString());
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
        }

        private void DirectSearchButton_Click(object sender, EventArgs e)
        {
            NearestEventsData.DataSource = Data.DirectEvtDataSearch(SearchByOpt.SelectedItem.ToString(), DirectSearchInput.Text);
        }

        private void DirectSpSearchButton_Click(object sender, EventArgs e)
        {
            SpData.DataSource = Data.DirectSpDataSearch(DirectSpSearchOpt.SelectedItem.ToString(), DirectSpSearchInput.Text);
        }
    }
}
