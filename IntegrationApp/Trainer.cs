using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private bool Matcher(string Surname, string Name, string LastName)
        {
            Regex Regex = new Regex(@"^[А-ЯЁ][а-яё]*$");
            Match SurnameMatch = Regex.Match(Surname);
            Match NameMatch = Regex.Match(Name);
            Match LastNameMatch = Regex.Match(LastName);

            if (SurnameMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddSportsmanButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (SurnameSpInput.Text != "" && NameSpInput.Text != "" && LastNameInput.Text != "" && CitizenshipInput.Text != "" &&
                    BirthdateInput.Text != "" && WeightInput.Text != "" && HeightInput.Text != "" && LoginInput.Text != "" && PasswordInput.Text != ""
                    && PassConfirmInput.Text != "")
                {
                    if (Matcher(SurnameInput.Text, NameInput.Text, LastNameInput.Text) == true)
                    {
                        MessageBox.Show("Все ок");
                    }
                    else
                    {
                        throw new Exception("Неправильная регулярка");
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
    }
}
