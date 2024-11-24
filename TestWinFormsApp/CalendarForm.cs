using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinFormsApp
{
    public partial class CalendarForm : Form
    {
        private IMainForm mainForm;

        public CalendarForm(IMainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void StudentListButton_Click(object sender, EventArgs e)
        {
            // Hide this form, and ask the main form to
            // open our student list form for us
            this.Close();
            mainForm.OpenForm("Students");
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            // Hide this form, and ask the main form to
            // open our login form for us
            this.Close();
            mainForm.OpenForm("Login");
        }
    }
}
