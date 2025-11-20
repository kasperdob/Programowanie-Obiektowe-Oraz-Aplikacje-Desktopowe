namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public List<User> users = new List<User> { 
            new User { Login = "a", Password = "b" }, 
            new User { Login = "b", Password = "c" } };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            var wartoscodusera = textBoxLogin.Text;

            MessageBox.Show($"Wartosc textbox: {wartoscodusera} Wartosc nud:");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPass.Text;

            var user = users.SingleOrDefault(user => user.Login == login && user.Password == password);

            if (user == null)
            {
                MessageBox.Show("Niepoprawne dane logowania");
                return;
            }

            var aplikacja = new FormAplikacja();
            aplikacja.ShowDialog();
        }
    }
}
