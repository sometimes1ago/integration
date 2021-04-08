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
    public partial class TestDBv2 : Form
    {
        public TestDBv2()
        {
            InitializeComponent();
        }

        private object GetEvtData()
        {
            string Query = "select * from GetEventsData where Название = @0";
            string Name = "Тестовое";

            List<string> Params = new List<string>()
            {
                Name
            };

            return DBv2.ReturnableQuery(Query, Params);
        }

        private void TestDBv2_Load(object sender, EventArgs e)
        {
            SortSpByOpt.SelectedItem = "Фамилии";
            OrderSpByOpt.SelectedItem = "Убыванию";
            SortEvtOpt.SelectedItem = "Названию";
            OrderEvtOpt.SelectedItem = "Убыванию";
            NearestEventsData.DataSource = GetEvtData();

        }
    }
}
