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
using Stock_Exchange_WPF.Stock_ExchangeDataSetTableAdapters;

namespace Stock_Exchange_WPF
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            Login_TextBox.MaxLength = 29;
            Password_TextBox.MaxLength = 29;
        }

        User_Stock_ExchangeTableAdapter userAdapter = new User_Stock_ExchangeTableAdapter();

        private void Entry_Button_Click(object sender, RoutedEventArgs e)
        {
            var allLogin = userAdapter.GetData();

            for (int i = 0; i < allLogin.Count; i++)
            {
                Login_Mistake_TextBlock.Text = null;
                Password_Mistake_TextBlock.Text = null;
                if (allLogin[i][1].ToString() == Login_TextBox.Text && allLogin[i][2].ToString() == Password_TextBox.Password)
                {
                    int ID_UserReg = i;
                    if(allLogin[i][3].ToString() == "1")
                    {
                        BrokerWindow brokerWindow = new BrokerWindow(ID_UserReg);
                        Close();
                        brokerWindow.Show();
                    }
                    else if(allLogin[i][3].ToString() == "2")
                    {
                        ClientWindow registerClientWindow = new ClientWindow(ID_UserReg);
                        Close();
                        registerClientWindow.Show();
                    }
                    else if (allLogin[i][3].ToString() == "3")
                    {
                        MainWindow mainWindow = new MainWindow();
                        Close(); 
                        mainWindow.Show();
                    }
                    break;
                }
                else
                {
                    Login_Mistake_TextBlock.Text = null;
                    Password_Mistake_TextBlock.Text = null;
                    if (allLogin[i][1].ToString() == Login_TextBox.Text && allLogin[i][2].ToString() != Password_TextBox.Password)
                    {
                        Password_Mistake_TextBlock.Text = "Неверный пароль";
                        break;
                    }
                    else
                    {
                        Login_Mistake_TextBlock.Text = "Неверный логин";
                        Password_Mistake_TextBlock.Text = "Неверный пароль";
                        
                    }

                }
            }
            
        }
    }
}
