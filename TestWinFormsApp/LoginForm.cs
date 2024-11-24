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
    public partial class LoginForm : Form
    {
        private IMainForm mainForm;
        public LoginForm(IMainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Hide this form, and ask the main form to
            // open our calendar form for us
            this.Hide();
            mainForm.OpenForm("Calendar");
        }


    }
}
