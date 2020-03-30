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
    public partial class Edit_Datas : Window
    {
        Work_Area currentDatas;
        public Edit_Datas(Work_Area currentDatas)
        {
            InitializeComponent();
            this.currentDatas = currentDatas;
            nameTxt.Text = currentDatas.Site_Name;
            emailTxt.Text = currentDatas.Email;
            loginTxt.Text = currentDatas.Login;
            passTxt.Text = currentDatas.Password;
            urlTxt.Text = currentDatas.URL;
            phoneTxt.Text = currentDatas.Phone;
            commentTxt.Text = currentDatas.Comments;
            createdTxt.Text = currentDatas.DateCreated.ToString();
        }

        private void editBtn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Work_Area updates = new Work_Area();
                updates.Site_Name = nameTxt.Text;
                updates.Email = emailTxt.Text;
                updates.Login = loginTxt.Text;
                updates.Password = passTxt.Text;
                updates.URL = urlTxt.Text;
                updates.Phone = phoneTxt.Text;
                updates.Comments = commentTxt.Text;
                updates.DateCreated = DateTime.Now;
                int index = (this.Owner as Show_Infos).list.Items.IndexOf(this.currentDatas);
                int id = currentDatas.Id;
                (this.Owner as Show_Infos).list.Items.RemoveAt(index);
                (this.Owner as Show_Infos).list.Items.Insert(index, updates);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Exception..Failed..",
                  MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
