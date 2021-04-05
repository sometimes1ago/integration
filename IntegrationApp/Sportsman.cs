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
    public partial class Sportsman : Form
    {
        public Sportsman()
        {
            InitializeComponent();
        }

        private void Sportsman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void LoadSpData()
        {
            Data.GetAuthSpData(Service.AuthorizedUser);
            SurnameLabel.Text += DB.ds.Tables[0].Rows[0][0].ToString();
            NameLabel.Text += DB.ds.Tables[0].Rows[0][1].ToString();
            LastNameLabel.Text += DB.ds.Tables[0].Rows[0][2].ToString();
            CitizenshipLabel.Text += DB.ds.Tables[0].Rows[0][3].ToString();
            BirthDate.Text += DB.ds.Tables[0].Rows[0][4].ToString();
            HeightLabel.Text += DB.ds.Tables[0].Rows[0][5].ToString();
            WeightLabel.Text += DB.ds.Tables[0].Rows[0][6].ToString();
        }

        private object GetSpEvents(string SpLogin)
        {
            int SpID = Data.GetSportsmanIDByUserlogin(Service.AuthorizedUser);

            string GetTeamName = "select Команды.Наименование from Спортсмены_в_команде inner join Команды on Спортсмены_в_команде.Команда=Команды.ID_Команды where Спортсмен = " + "\'" + SpID + "\'";
            DB.SearchValuesQuery(GetTeamName);
            string TeamName = DB.ds.Tables[0].Rows[0][0].ToString();

            string GetTeamEvents = "select * from GetEventsData where Команда = " + "\'" + TeamName + "\'";
            return DB.SearchValuesQuery(GetTeamEvents);
        }

        private void Sportsman_Load(object sender, EventArgs e)
        {
            SortEvtOpt.SelectedItem = "Названию";
            OrderEvtOpt.SelectedItem = "Убыванию";

            NearestEventsData.DataSource = Data.GetSpEvtData(Service.AuthorizedUser, SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
            LoadSpData();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Service.AuthorizedUser = null;
            Auth auth = new Auth();
            Hide();
            auth.Show();
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            NearestEventsData.DataSource = Data.GetSpEvtData(Service.AuthorizedUser, SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
        }

        private void DirectSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectSearchInput.Text != "")
                {
                    NearestEventsData.DataSource = Data.DirectSpEvtDataSearch(SearchByOpt.SelectedItem.ToString(), DirectSearchInput.Text);
                }
                else
                {
                    throw new Exception("Для поиска введите значение!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
