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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            ShowPass();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = false;

            try
            {
                if (LoginInput.Text != "" && PasswordInput.Text != "")
                {
                    string GetAuthData = "select * from GetAuthData";
                    DB.SearchValuesQuery(GetAuthData);

                    for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
                    {
                        if (LoginInput.Text == DB.ds.Tables[0].Rows[i][0].ToString() && PasswordInput.Text == DB.ds.Tables[0].Rows[i][1].ToString())
                        {
                            isCorrect = true;

                            switch(DB.ds.Tables[0].Rows[i][2].ToString())
                            {
                                case "Тренер":
                                    Trainer tr = new Trainer();
                                    Hide();
                                    tr.Show();
                                    break;
                                case "Менеджер":
                                    Manager manager = new Manager();
                                    Hide();
                                    manager.Show();
                                    break;
                                case "Спортсмен":
                                    Sportsman sp = new Sportsman();
                                    Hide();
                                    sp.Show();
                                    break;
                                case "Администратор":
                                    Admin admin = new Admin();
                                    Hide();
                                    admin.Show();
                                    break;
                            }
                        }
                    }
                    if (!isCorrect)
                    {
                        throw new Exception("Неправильный логин или пароль!");
                    }
                }
                else
                {
                    throw new Exception("Логин и пароль не могут быть пустыми!");
                }

                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowPassControl_CheckedChanged(object sender, EventArgs e)
        {
            ShowPass();
        }

        /// <summary>
        /// Метод, показывающий пароль при клике на чекбокс
        /// </summary>
        private void ShowPass()
        {
            if (ShowPassControl.Checked == true)
            {
                PasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = true;
            }
        }
    }
}
