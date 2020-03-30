namespace Storage_App
{
    using System;
    using System.Windows;
    using Storage_App.Models;
    using Storage_App.Windows;

    public partial class Show_Infos : Window
    {

        public Show_Infos()
        {
            InitializeComponent();
            try
            {
                list.ItemsSource = ReadFromDatabase.Read_All_Infos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Exception..Failed..",
MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            Work_Area selected_recordt = list.SelectedItem as Work_Area;
            Edit_Datas editForm = new Edit_Datas(selected_recordt);
            editForm.Owner = this;
            editForm.ShowDialog();
        }
    }
}
