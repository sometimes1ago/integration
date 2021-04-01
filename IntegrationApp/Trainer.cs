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
                                DB.Execute(InsertNewSportsmanQuery);

                                string GetTeamName = "select Наименование from Команды where ID_Команды = " + "\'" + TeamID + "\'";
                                DB.SearchValuesQuery(GetTeamName);
                                string TeamName = DB.ds.Tables[0].Rows[0][0].ToString();

                                MessageBox.Show($@"Спортсмен {SurnameSpInput.Text} {NameSpInput.Text} {LastNameInput.Text} успешно добавлен в команду {TeamName}");
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
    }
}
