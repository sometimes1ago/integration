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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void ToAuthLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Auth auth = new Auth();
            Hide();
            auth.Show();
        }
    }
}
