using Storage_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Storage_App.Windows
{
    public partial class Edit_User : Window
    {
        User user;
        public Edit_User(User user)
        {
            InitializeComponent();
            this.user = user;
            fNameTxt.Text = user.First_Name;
            lNameTxt.Text = user.Last_Name;
            loginTxt.Text = user.Login;
            passTxt.Text = user.Password;
            roleTxt.Text = user.Role;
            ageTxt.Text = user.Age;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = (this.Owner as Show_Users).list.Items.IndexOf(this.user);
                int id = user.Id;
                User update = new User
                {
                    First_Name = fNameTxt.Text,
                    Last_Name = lNameTxt.Text,
                    Login = loginTxt.Text,
                    Password = passTxt.Text,
                    Role = roleTxt.Text,
                    Age = ageTxt.Text,
                    Date_Register = DateTime.Now
                };

                //(this.Owner as Show_Users).list.Items.RemoveAt(index);
                (this.Owner as Show_Users).list.Items.Insert(index, update);

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System Exception..Failed..",
MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
