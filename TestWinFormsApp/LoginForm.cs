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
        private bool navigating = false;

        public LoginForm(IMainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.FormClosing += FormIsClosing;
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (!navigating)
            {
                // Close button clicked by user, so we need to close
                // the whole app
                ((Form)mainForm).Close();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Hide this form, and ask the main form to
            // open our calendar form for us
            this.navigating = true;
            this.Close();
            mainForm.OpenForm("Calendar");
        }


    }
}
