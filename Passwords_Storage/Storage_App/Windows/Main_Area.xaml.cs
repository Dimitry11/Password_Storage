namespace Storage_App
{
    using System;
    using System.Windows;
    using Storage_App.Models;

    public partial class Main_Area : Window
    {
        My_Context db;
        public Main_Area()
        {
            InitializeComponent();
            db = new My_Context();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Work_Area area = new Work_Area
                {
                    Site_Name = nameTxt.Text,
                    Email = emailTxt.Text,
                    Login = loginTxt.Text,
                    Password = passTxt.Text,
                    URL = urlTxt.Text,
                    Phone = phoneTxt.Text,
                    Comments = commentTxt.Text
                };
                db.Works_Datas.Add(area);
                db.SaveChanges();
                MessageBox.Show($"Datas about sitename {nameTxt.Text} was added successfully!",
                    "Congratulate!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                // After correct adding clear all text fields:
                nameTxt.Text = emailTxt.Text = loginTxt.Text =
                passTxt.Text = urlTxt.Text = phoneTxt.Text = commentTxt.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System Exception..Failed..",
                  MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            new Show_Infos().Show();
        }

        private void usersBtn_Click(object sender, RoutedEventArgs e)
        {
            new Show_Users().Show();
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
