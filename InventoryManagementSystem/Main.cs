using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            LoginForm loginForm = new LoginForm();
            loginForm.Dock = DockStyle.Fill;

            // Assuming panelContainer is the name of your Panel
            panelContainer.Controls.Add(loginForm);
        }
        public void LoadUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
