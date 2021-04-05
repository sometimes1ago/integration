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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static object GetSpData()
        {
            string GetSportsmenData = "select * from GetSportsmanData";
            return DBv2.ReturnableQuery(GetSportsmenData, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SortSpByOpt.SelectedItem = "Фамилии";
            OrderSpByOpt.SelectedItem = "Убыванию";
            SortEvtOpt.SelectedItem = "Названию";
            OrderEvtOpt.SelectedItem = "Убыванию";
            NearestEventsData.DataSource = GetSpData();
        }
    }
}
