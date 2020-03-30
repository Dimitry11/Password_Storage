namespace Storage_App
{
    using System;
    using System.Windows;
    using Storage_App.Models;
    using Storage_App.Windows;

    public partial class Show_Users : Window
    {
        public Show_Users()
        {
            InitializeComponent();
            try
            {
                list.ItemsSource = ReadFromDatabase.Read_All_Users();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Exception..Failed..",
MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex != 0) // Если мы что то выбрали с листбокса
            {
                User selected = list.SelectedItem as User;
                Edit_User edit_window = new Edit_User(selected);
                edit_window.Owner = this;
                edit_window.ShowDialog();
            }
            else
                MessageBox.Show("You don't selected nothing..", "..Not selected..", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }


}
