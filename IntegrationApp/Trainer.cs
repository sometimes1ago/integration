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
                                Service.CreateNewUser(LoginInput.Text, PasswordInput.Text, 3);


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
