namespace Storage_App
{
    using System.Linq;
    using System.Windows;
    using Storage_App.Models;

    public partial class MainWindow : Window
    {
        My_Context db;
        readonly string currLogin;
        public MainWindow()
        {
            InitializeComponent();
            db = new My_Context();
            currLogin = "123456";
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = db.Users.FirstOrDefault(u => u.Login == currLogin);
            string login = loginTxt.Text;
            string password = passTxt.Password;
            if(login == user.Login && password == user.Password && user.Role == "admin")
            {
                if (rememberCheck.IsChecked == true)
                    new Main_Area().ShowDialog();
                else if (rememberCheck.IsChecked == false)
                {
                    new Main_Area().ShowDialog();
                    loginTxt.Text = "";
                    passTxt.Password = "";
                }
            }
            else
            {
                MessageBox.Show("Wrong login & password.. Try again", "Incorrect of user",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            new Register_Window().ShowDialog();
        }
    }
}
