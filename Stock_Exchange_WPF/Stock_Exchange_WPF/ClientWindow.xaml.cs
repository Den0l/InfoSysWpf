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

namespace Stock_Exchange_WPF
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public int ID_UserReg { get; }
        Buy_Client_Page buy_client_page;
        RegisterWindow registerWindow = new RegisterWindow();
        Receipt_Client_Page receipt_client_page;
        public ClientWindow(int UserReg)
        {
            InitializeComponent();
            ID_UserReg = UserReg;

        }

        private void Exit_Client_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            registerWindow.Show();
        }

        private void Buy_Client_Button_Click(object sender, RoutedEventArgs e)
        {
            buy_client_page = new Buy_Client_Page(ID_UserReg);
            ClientPageFrame.Content = buy_client_page;

        }

        private void Receipt_Client_Button_Click(object sender, RoutedEventArgs e)
        {
            receipt_client_page = new Receipt_Client_Page(ID_UserReg);
            ClientPageFrame.Content = receipt_client_page;
        }
    }
}
