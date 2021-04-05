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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private int GetPositionIDByName(string SelectedItem)
        {
            string GetPositionID = "select ID_Типа_пользователей from Типы_пользователей where Наименование_типа = " + "\'" + SelectedItem + "\'";
            DB.SearchValuesQuery(GetPositionID);
            int PositionID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());
            return PositionID;
        }

        private void ClearAddEmpFields()
        {
            EmpSurnameInput.Text = "";
            EmpNameInput.Text = "";
            EmpLastNameInput.Text = "";
            EmpLoginInput.Text = "";
            EmpPassInput.Text = "";
            EmpPassConfirmInput.Text = "";
        }
        
        private void EmpAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpSurnameInput.Text != "" && EmpNameInput.Text != "" && EmpLastNameInput.Text != "" &&
                    EmpPositionsOpt.Text != "" && EmpLoginInput.Text != "" && EmpPassInput.Text != "" && EmpPassConfirmInput.Text != "")
                {
                    if (Service.FIOMatcher(EmpSurnameInput.Text, EmpNameInput.Text, EmpLastNameInput.Text))
                    {
                        if (EmpPassInput.Text == EmpPassConfirmInput.Text)
                        {
                            int UserTypeID = GetPositionIDByName(EmpPositionsOpt.SelectedItem.ToString());
                            Service.CreateNewUser(EmpLoginInput.Text, EmpPassInput.Text, UserTypeID);
                            int NewUserID = Service.GetNewUserID(EmpLoginInput.Text);

                            string AddNewEmployee = "execute AddNewEmployee" + "\'" + EmpSurnameInput.Text + "\'" + "," + "\'" + EmpNameInput.Text + "\'" +
                                "," + "\'" + EmpLastNameInput.Text + "\'" + "," + "\'" + NewUserID + "\'";
                            DB.Execute(AddNewEmployee);

                            MessageBox.Show("Сотрудник успешно добавлен");
                            EmpData.DataSource = GetEmployeeData();
                            ClearAddEmpFields();
                        }
                        else
                        {
                            throw new Exception("Пароли не совпадают!");
                        }
                    }
                    else
                    {
                        throw new Exception("Фамилия, имя и отчество могут быть только на русском языке и начинаться с заглавной буквы!");
                    }
                }
                else
                {
                    throw new Exception("Для добавление сотрудника заполните все поля!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object GetEmployeeData()
        {
            string GetEmpData = "select * from GetEmployeeData";
            return DB.SearchValuesQuery(GetEmpData);
        }

        private void FillEmpList()
        {
            string GetEmpDataList = "select Фамилия, Имя, Отчество from GetEmployeeData";
            DB.SearchValuesQuery(GetEmpDataList);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                EmpOpt.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString() + " " + DB.ds.Tables[0].Rows[i][1].ToString() + " " +
                    DB.ds.Tables[0].Rows[i][2].ToString());
            }
        }

        private void FillDropableEmpList()
        {
            string GetEmpDataList = "select Фамилия, Имя, Отчество from GetEmployeeData";
            DB.SearchValuesQuery(GetEmpDataList);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                DropableEmpOpt.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString() + " " + DB.ds.Tables[0].Rows[i][1].ToString() + " " +
                    DB.ds.Tables[0].Rows[i][2].ToString());
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SortSpByOpt.SelectedItem = "Фамилии";
            OrderSpByOpt.SelectedItem = "Убыванию";
            SortEvtOpt.SelectedItem = "Названию";
            OrderEvtOpt.SelectedItem = "Убыванию";
            EmpData.DataSource = GetEmployeeData();
            ChangableEmpData.DataSource = GetEmployeeData();
            GreetingsLabel.Text += Data.GetEmpSurnameNameByLogin(Service.AuthorizedUser);
            NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
            SpData.DataSource = Data.GetSpData(SortSpByOpt.SelectedItem.ToString(), OrderSpByOpt.SelectedItem.ToString());
            FillEmpList();
            FillDropableEmpList();

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Service.AuthorizedUser = null;
            Auth auth = new Auth();
            Hide();
            auth.Show();
        }


        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChangeValueInput.Text != "" && ToChangeOpt.Text != "")
                {

                    string[] Splited = Service.SpitComboboxItem(EmpOpt.SelectedItem.ToString(), ' ');
                    int EmpID = Data.GetEmpIDBySurnameName(Splited[0], Splited[1]);
                    string ChangeQuery = "update Сотрудники set " + ToChangeOpt.SelectedItem.ToString() + " = " + "\'" + ChangeValueInput.Text + "\'" + " where ID_Сотрудника = " + "\'" + EmpID + "\'";
                    DB.Execute(ChangeQuery);
                    MessageBox.Show("Данные успешно обновлены");
                    ChangableEmpData.DataSource = GetEmployeeData();
                }
                else
                {
                    throw new Exception("Для изменения нужно выбрать что изменить и ввести на что поменять!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DropEmpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DropableEmpOpt.Text != "")
                {
                    string[] Splited = Service.SpitComboboxItem(DropableEmpOpt.SelectedItem.ToString(), ' ');
                    int EmpID = Data.GetEmpIDBySurnameName(Splited[0], Splited[1]);
                    string GetUserID = "select Данные_для_входа from Сотрудники where ID_Сотрудника = " + "\'" + EmpID + "\'";
                    DB.SearchValuesQuery(GetUserID);
                    int UserID = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());

                    string DropEmp = "delete from Сотрудники where ID_Сотрудника = " + "\'" + EmpID + "\'";
                    DB.Execute(DropEmp);

                    string DropUser = "delete from Пользователи where ID_Пользователя = " + "\'" + UserID + "\'";
                    DB.Execute(DropUser);

                    MessageBox.Show("Сотрудник успешно удален!");
                    ChangableEmpData.DataSource = GetEmployeeData();
                }
                else
                {
                    throw new Exception("Сначала выберите сотрудника, чтобы его удалить!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
