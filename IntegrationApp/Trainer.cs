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
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }

        private void AddSportsmanButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SurnameSpInput.Text != "" && NameSpInput.Text != "" && LastNameInput.Text != "" && CitizenshipInput.Text != "" &&
                    BirthdateInput.Text != "" && WeightInput.Text != "" && HeightInput.Text != "" && LoginInput.Text != "" && PasswordInput.Text != ""
                    && PassConfirmInput.Text != "")
                {
                    if (Service.FIOMatcher(SurnameSpInput.Text, NameSpInput.Text, LastNameInput.Text) == true)
                    {
                        if (int.TryParse(WeightInput.Text, out int Weight) && int.TryParse(HeightInput.Text, out int Height))
                        {
                            if (PasswordInput.Text == PassConfirmInput.Text)
                            {
                                //Создание нового пользователя для спортсмена
                                Service.CreateNewUser(LoginInput.Text, PasswordInput.Text, 3);
                                int UserID = Service.GetNewUserID(LoginInput.Text);

                                //Вставка данных нового спортсмена
                                string InsertNewSportsmanQuery = "execute AddNewSportsman " + "\'" + SurnameSpInput.Text + "\'" + "," + "\'" +
                                    NameSpInput.Text + "\'" + "," + "\'" + LastNameInput.Text + "\'" + "," + "\'" + CitizenshipInput.Text + "\'" + "," +
                                    "\'" + BirthdateInput.Text + "\'" + "," + "\'" + Weight + "\'" + "," + "\'" + Height + "\'" + "," + "\'" + UserID + "\'";
                                DB.Execute(InsertNewSportsmanQuery);

                                //Получение ID добавленного спортсмена
                                string GetNewSportsmanID = "select max(ID_Спортсмена) from Спортсмены";
                                DB.SearchValuesQuery(GetNewSportsmanID);
                                int NewSpID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());

                                //Получение ID тренера
                                int TrainerID = Data.GetEmployeeIDByUserlogin(Service.AuthorizedUser);

                                //Получение ID команды по тренеру
                                string GetTeamIdByTrainer = "select ID_Команды from Команды where Тренер = " + "\'" + TrainerID + "\'";
                                DB.SearchValuesQuery(GetTeamIdByTrainer);
                                int TeamID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());

                                //Добавление спортсмена в команду тренера
                                string InsertSportsmanIntoTeamQuery = "insert into Спортсмены_в_команде(Команда, Спортсмен) values(" +
                                    "\'" + TeamID + "\'" + "," + "\'" + NewSpID + "\'" + ")";
                                DB.Execute(InsertSportsmanIntoTeamQuery);

                                //Получение названия команды по ее ID
                                string GetTeamName = "select Наименование from Команды where ID_Команды = " + "\'" + TeamID + "\'";
                                DB.SearchValuesQuery(GetTeamName);
                                string TeamName = DB.ds.Tables[0].Rows[0][0].ToString();

                                MessageBox.Show($@"Спортсмен {SurnameSpInput.Text} {NameSpInput.Text} {LastNameInput.Text} успешно добавлен в команду {TeamName}");
                                SpData.DataSource = Data.GetSpData("Фамилии", "Убыванию");
                            }
                            else
                            {
                                throw new Exception("Пароли не совпадают!");
                            }
                        }
                        else
                        {
                            throw new Exception("Рост или вес могут быть только целочисленными значениями");
                        }
                    }
                    else
                    {
                        throw new Exception("Фамилия, имя и отчество могут содержать только русские буквы!");
                    }
                }
                else
                {
                    throw new Exception("Все поля обязательны для заполнения! Проверьте правильность ввода данных!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Trainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Trainer_Load(object sender, EventArgs e)
        {
            GreetingsLabel.Text += Data.GetEmpSurnameNameByLogin(Service.AuthorizedUser);

            SpData.DataSource = GetTrainerSpData();
        }

        private static object GetTrainerSpData()
        {
            string Query = "execute GetTrainerSpData " + "\'" + Data.GetEmployeeIDByUserlogin(Service.AuthorizedUser) + "\'";
            return DB.SearchValuesQuery(Query);
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Service.AuthorizedUser = null;
            Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void SportsmanDeletingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SurnameInput.Text != "" && NameInput.Text != "")
                {
                    //Получение ID спортсмена
                    string GetSpID = "select ID_Спортсмена from Спортсмены where Фамилия = " + "\'" + SurnameInput.Text + "\'" +
                        " and Имя = " + "\'" + NameInput.Text + "\'";
                    DB.SearchValuesQuery(GetSpID);
                    int SpID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());

                    //Получение пользователя спортсмена
                    string GetSpUserID = "select Данные_для_входа from Спортсмены where ID_Спортсмена = " + "\'" + SpID + "\'";
                    DB.SearchValuesQuery(GetSpUserID);
                    int UserID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());

                    //Удаление спортсмена из команды
                    string DropSportsmanFromTeam = "delete from Спортсмены_в_команде where Спортсмен = " + "\'" + SpID + "\'";
                    DB.Execute(DropSportsmanFromTeam);

                    //Удаление спортсмена
                    string DropSportsmanQuery = "delete from Спортсмены where ID_Спортсмена = " + "\'" + SpID + "\'";
                    DB.Execute(DropSportsmanQuery);

                    //Удаление пользователя спортсмена
                    string DropSpUser = "string delete from Пользователи where ID_Пользователя = " + "\'" + UserID + "\'";
                    DB.Execute(DropSpUser);

                    MessageBox.Show($@"Спортсмен {SurnameInput.Text} {NameInput.Text} успешно удален");
                }
                else
                {
                    throw new Exception("Фамилия и имя при удалении не могут быть пустыми!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
