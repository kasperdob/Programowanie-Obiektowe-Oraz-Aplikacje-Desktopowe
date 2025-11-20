namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPasssword.Text;

            if (IsUserValid(login, password))
            {
                FormHome form = new FormHome();
                form.Show();
            }
            else 
            {
                MessageBox.Show("Invalid login or password");
            }
        }

        private bool IsUserValid(string login, string password)
        {
            var usersRepository = new UsersRepository();

            var isValid = usersRepository.Users.Any(u => u.Login == login && u.Password == password);
            return isValid;
        }
    }
}
