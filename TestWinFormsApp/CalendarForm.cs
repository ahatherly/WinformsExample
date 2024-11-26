namespace TestWinFormsApp
{
    public partial class CalendarForm : Form
    {
        private IMainForm mainForm;
        private bool navigating = false;

        public CalendarForm(IMainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.FormClosing += FormIsClosing;
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (!navigating) {
                // Close button clicked by user, so we need to close
                // the whole app
                ((Form)mainForm).Close();
            }
        }

        private void StudentListButton_Click(object sender, EventArgs e)
        {
            // Hide this form, and ask the main form to
            // open our student list form for us
            this.navigating = true;
            this.Close();
            mainForm.OpenForm("Students");
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            // Hide this form, and ask the main form to
            // open our login form for us
            this.navigating = true;
            this.Close();
            mainForm.OpenForm("Login");
        }
    }
}
