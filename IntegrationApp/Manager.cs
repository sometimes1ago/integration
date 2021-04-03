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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            SortEvtOpt.SelectedItem = "Названию";
            OrderEvtOpt.SelectedItem = "Убыванию";
            SearchByOpt.SelectedItem = "Команде";
            EventTypeOpt.SelectedItem = "Турнир";
            GreetingsLabel.Text += Data.GetEmpSurnameNameByLogin(Service.AuthorizedUser);
            NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
            FillEventsList();
            FillTeamsList();
            FillDeletableEvtList();
        }

        private string SwitchEventType(string EventType)
        {
            switch (EventType)
            {
                case "Турнир":
                    EventType = "1";
                    break;
                case "Соревнование":
                    EventType = "2";
                    break;
                case "Олимпиада":
                    EventType = "3";
                    break;
            }

            return EventType;
        }

        private void FillEventsList()
        {
            SelectEvtOpt.Items.Clear();

            string GetEvtNames = "select Наименование from Мероприятия";
            DB.SearchValuesQuery(GetEvtNames);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                SelectEvtOpt.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void FillTeamsList()
        {
            SelectTeamOpt.Items.Clear();

            string GetTeamsNames = "select Наименование from Команды";
            DB.SearchValuesQuery(GetTeamsNames);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                SelectTeamOpt.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void FillDeletableEvtList()
        {
            SelectDelEvtOpt.Items.Clear();

            string GetEvtNames = "select Наименование from Мероприятия";
            DB.SearchValuesQuery(GetEvtNames);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                SelectDelEvtOpt.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ClearAddInputs()
        {
            EventNameInput.Text = "";
            EventPlaceInput.Text = "";
            EventTimeInput.Text = "";
            EventDateInput.Text = "";
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventNameInput.Text != "" && EventTimeInput.Text != "" && EventDateInput.Text != "" && EventPlaceInput.Text != "")
                {
                    int SwitchedEvtType = Convert.ToInt32(SwitchEventType(EventTypeOpt.SelectedItem.ToString()));
                    string CreateEvtQuery = "execute CreateNewEvent " + "\'" + EventNameInput.Text + "\'" + "," +
                        "\'" + SwitchedEvtType + "\'" + "," + "\'" + Convert.ToDateTime(EventDateInput.Text) + "\'" + "," +
                        "\'" + Convert.ToDateTime(EventTimeInput.Text) + "\'" + "," + "\'" + EventPlaceInput.Text + "\'" + "," + "'Новый'";
                    DB.Execute(CreateEvtQuery);

                    MessageBox.Show("Мероприятие успешно создано");
                    NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
                    FillEventsList();
                    FillDeletableEvtList();
                    ClearAddInputs();
                }
                else
                {
                    throw new Exception("Необходимо заполнить все поля для создания мероприятия!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddTeamToEvtButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectEvtOpt.Text != "" && SelectTeamOpt.Text != "")
                {
                    string GetEvtID = "select ID_Мероприятия from Мероприятия where Наименование = " + "\'" + SelectEvtOpt.SelectedItem.ToString() + "\'";
                    DB.SearchValuesQuery(GetEvtID);
                    int EvtID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());

                    string GetTeamID = "select ID_Команды from Команды where Наименование = " + "\'" + SelectTeamOpt.SelectedItem.ToString() + "\'";
                    DB.SearchValuesQuery(GetTeamID);
                    int TeamID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());

                    string ConnectEvtWithTeam = "insert into Команды_на_мероприятии(Мероприятие, Команда) values(" + "\'" + EvtID + "\'" + "," + "\'" +
                        TeamID + "\'" + ")";
                    DB.Execute(ConnectEvtWithTeam);

                    MessageBox.Show("Команда успешно добавлена на мероприятие");

                    NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
                    FillEventsList();
                    FillTeamsList();
                    FillDeletableEvtList();
                }
                else
                {
                    throw new Exception("Необходимо выбрать мероприятие и команду!");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
        }

        private void DirectSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectSearchInput.Text != "")
                {
                    NearestEventsData.DataSource = Data.DirectEvtDataSearch(SearchByOpt.SelectedItem.ToString(), DirectSearchInput.Text);
                }
                else
                {
                    throw new Exception("Для прямого поиска нужно ввести значение!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Service.AuthorizedUser = null;
            Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void DeleteEvtButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectDelEvtOpt.Text != "")
                {
                    string GetEvtID = "select ID_Мероприятия from Мероприятия where Наименование = " + "\'" + SelectDelEvtOpt.SelectedItem.ToString() + "\'";
                    DB.SearchValuesQuery(GetEvtID);
                    int EvtID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());

                    string DropTeamsOnEvt = "delete from Команды_на_мероприятии where Мероприятие = " + "\'" + EvtID + "\'";
                    DB.Execute(DropTeamsOnEvt);

                    string DropEvt = "delete from Мероприятия where ID_Мероприятия = " + "\'" + EvtID + "\'";
                    DB.Execute(DropEvt);

                    MessageBox.Show("Мероприятие успешно удалено!");

                    NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
                    FillEventsList();
                    FillDeletableEvtList();
                }
                else
                {
                    throw new Exception("Для удаления мероприятия необходимо его выбрать из списка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
