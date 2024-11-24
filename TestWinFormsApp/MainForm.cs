namespace TestWinFormsApp
{
    // Our main form will always exist while the app
    // is running, but we can hide it when we're not
    // wanting to show it. The child forms can be
    // created and destroyed as needed when the user
    // navigates around
    public partial class MainForm : Form, IMainForm
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            OpenForm("Login");
        }

        public void OpenForm(string requestedForm)
        {
            // When we open a new form, we will
            // pass a reference to the main form to it
            // so that the child form can call
            // back to the main form to request a new
            // form be opened

            switch(requestedForm)
            {
                case "Login":
                    LoginForm login = new LoginForm(this);
                    this.Hide(); // Hide the main form
                    login.Show(); // Show the new form
                    break;
                case "Calendar":
                    CalendarForm cal = new CalendarForm(this);
                    this.Hide(); // Hide the main form
                    cal.Show(); // Show the new form
                    break;
                case "Students":
                    StudentListForm students = new StudentListForm(this);
                    this.Hide(); // Hide the main form
                    students.Show(); // Show the new form
                    break;
                case "Main":
                    this.Show(); // Show the main form
                    break;
            }
        }
    }
}
