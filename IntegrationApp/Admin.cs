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

        private void Admin_Load(object sender, EventArgs e)
        {
            SortSpByOpt.SelectedItem = "Фамилии";
            OrderSpByOpt.SelectedItem = "Убыванию";
            SortEvtOpt.SelectedItem = "Названию";
            OrderEvtOpt.SelectedItem = "Убыванию";
            EmpData.DataSource = GetEmployeeData();
            NearestEventsData.DataSource = Data.GetEvtData(SortEvtOpt.SelectedItem.ToString(), OrderEvtOpt.SelectedItem.ToString());
            SpData.DataSource = Data.GetSpData(SortSpByOpt.SelectedItem.ToString(), OrderSpByOpt.SelectedItem.ToString());
        }
    }
}
