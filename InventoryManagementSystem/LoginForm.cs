namespace InventoryManagementSystem
{
    public partial class LoginForm : UserControl
    {
        // Assuming users list is available for authentication
        private List<User> users = new List<User>();

        public LoginForm()
        {
            InitializeComponent();
            users = User.LoadUsers();
        }
        private void UsernameEntry_TextChanged(object sender, EventArgs e)
        {
            // Code for handling text change in the username entry
        }

        private void PasswordEntry_TextChanged(object sender, EventArgs e)
        {
            // Code for handling text change in the password entry
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;
            Console.WriteLine($"Attempting login with username: {username} and password: {password}");


            // Validate the username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password cannot be empty.");
                return;
            }

            // Authenticate the user
            User user = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.ValidatePassword(password));
            if (user == null)
            {
                MessageBox.Show("Incorrect username or password.");
                return;
            }

            User.CurrentUser = user;
            Main mainForm = (Main)this.ParentForm; // Getting reference to Main form
            // Assuming user is a valid User object that you want to pass to the Dashboard
            Dashboard dashboard = new Dashboard(user);

            mainForm.LoadUserControl(dashboard);
        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            // Code for handling the cancel button click
            Application.Exit();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}