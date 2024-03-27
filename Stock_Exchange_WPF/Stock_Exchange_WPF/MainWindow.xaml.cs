using Stock_Exchange_WPF.Stock_ExchangeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stock_Exchange_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string table = "broker";
        SecuritiesTableAdapter securitiesAdapter = new SecuritiesTableAdapter();
        Receipt_of_PaymentTableAdapter receiptAdapter = new Receipt_of_PaymentTableAdapter();
        Broker_Stock_ExchangeTableAdapter brokerAdapter = new Broker_Stock_ExchangeTableAdapter();
        Diploma_TrainingTableAdapter diplomaAdapter = new Diploma_TrainingTableAdapter();
        Brokerage_OfficeTableAdapter brokOffAdapter = new Brokerage_OfficeTableAdapter();
        User_Stock_ExchangeTableAdapter userAdapter = new User_Stock_ExchangeTableAdapter();
        Role_Stock_ExchangeTableAdapter roleAdapter =new Role_Stock_ExchangeTableAdapter();
        ClientsTableAdapter clientsAdapter = new ClientsTableAdapter();
        BanksTableAdapter banksAdapter = new BanksTableAdapter();
        Method_of_PaymentTableAdapter methodAdapter = new Method_of_PaymentTableAdapter();
        Securities_TransactionTableAdapter transAdapter = new Securities_TransactionTableAdapter();
        SecuritiesTableAdapter secAdapter = new SecuritiesTableAdapter();
        Information_About_SecuritiesTableAdapter infoAdapter = new Information_About_SecuritiesTableAdapter();
        Securities_Type_TableTableAdapter secTypeAdapter = new Securities_Type_TableTableAdapter(); 
        Owner_of_SecuritiesTableAdapter ownerAdapter = new Owner_of_SecuritiesTableAdapter();
        Transaction_Status_TableTableAdapter statusAdapter = new Transaction_Status_TableTableAdapter();
        QueriesTableAdapter querry = new QueriesTableAdapter();

        RegisterWindow registerWindow = new RegisterWindow();
        private string DateComplUser;
        private string DateCreatUser;

        public MainWindow()
        {
            InitializeComponent();
            Main_DataGrid.ItemsSource = brokerAdapter.GetData();
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
            First_TextBox.MaxLength = 29;
            Second_TextBox.MaxLength = 29;
            Third_TextBox.MaxLength = 29;
            Fourth_TextBox.MaxLength = 29;
            Five_TextBox.MaxLength = 29;
            Six_TextBox.MaxLength = 29;
        }

        private void DisableButton(Button bu1, Button bu2)
        {
            if (bu1.IsEnabled == true && bu2.IsEnabled == true)
            {
                bu1.IsEnabled = false;
                bu2.IsEnabled = false;
            }
            else
            {
                if (CUD_Button.Content != null) CUD_Button.Content = null;
                bu1.IsEnabled = true;
                bu2.IsEnabled = true;
            }
        }

        private void Menu_Transaction_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = transAdapter.GetTransID();
            table = "trans";
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Дата созд:";
            Second_TextBox.Visibility = Visibility.Visible;
            Second_TextBlock.Text = "Дата совер:";
            Third_TextBox.Visibility = Visibility.Visible;
            Third_TextBlock.Text = "Кол-во:";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "Цен.Бум:";
            Seven_ComboBox.DisplayMemberPath = "Securities_Name";
            Seven_ComboBox.ItemsSource = infoAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Visible;
            Eight_TextBlock.Text = "Способ опл:";
            Eight_ComboBox.DisplayMemberPath = "Method_of_Payment";
            Eight_ComboBox.ItemsSource = methodAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Visible;
            Nine_TextBlock.Text = "Статус:";
            Nine_ComboBox.DisplayMemberPath = "Transaction_Status";
            Nine_ComboBox.ItemsSource = statusAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Visible;
            Ten_TextBlock.Text = "Брокер:";
            Ten_ComboBox.DisplayMemberPath = "Last_Name_Broker";
            Ten_ComboBox.ItemsSource = brokerAdapter.GetData();
            Ten_ComboBox.Visibility = Visibility.Visible;
            Eleven_TextBlock.Text = "Клиенты:";
            Eleven_ComboBox.DisplayMemberPath = "Last_Name_Client";
            Eleven_ComboBox.ItemsSource = clientsAdapter.GetData();
            Eleven_ComboBox.Visibility = Visibility.Visible;


            Main_DataGrid.Columns[4].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[5].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[6].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[7].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[8].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[9].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[10].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[12].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[14].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[16].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[18].Visibility = Visibility.Collapsed;
        }

        private void Menu_Receipt_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = receiptAdapter.GetData();
            table = "receipt";
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Итог сум:";
            Second_TextBox.Visibility = Visibility.Visible;
            Second_TextBlock.Text = "Внес сум:";
            Third_TextBox.Visibility = Visibility.Visible;
            Third_TextBlock.Text = "Сдача:";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "Сделка:";
            Seven_ComboBox.DisplayMemberPath = "Securities_Transaction_ID";
            Seven_ComboBox.ItemsSource = transAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Visible;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Menu_Broker_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = brokerAdapter.GetBroker();
            table = "broker";

            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Фамилия:";
            Second_TextBox.Visibility = Visibility.Visible;
            Second_TextBlock.Text = "Имя:";
            Third_TextBox.Visibility = Visibility.Visible;
            Third_TextBlock.Text = "Отчесвто:";
            Fourth_TextBox.Visibility = Visibility.Visible;
            Fourth_TextBlock.Text = "Комиссия:";
            Five_TextBox.Visibility = Visibility.Visible;
            Five_TextBlock.Text = "Дата рожд:";
            Six_TextBox.Visibility = Visibility.Visible;
            Six_TextBlock.Text = "Номер телеф:";
            Seven_TextBlock.Text = "Диплом:";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Visible;
            Eight_TextBlock.Text = "Брокер контора:";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Visible;
            Nine_TextBlock.Text = "Логин:";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Visible;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;

            Main_DataGrid.Columns[0].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[7].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[8].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[9].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[10].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[12].Visibility = Visibility.Collapsed;
        }

        private void Menu_Diploma_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = diplomaAdapter.GetData();
            table = "diploma";

            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Название:";
            Second_TextBox.Visibility = Visibility.Collapsed;
            Second_TextBlock.Text = "";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Menu_BrokerOffice_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = brokOffAdapter.GetData();
            table = "brokOff";

            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Название:";
            Second_TextBox.Visibility = Visibility.Collapsed;
            Second_TextBlock.Text = "";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Menu_Clients_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = clientsAdapter.GetClientBank();
            table = "clients";

            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Фамилия:";
            Second_TextBox.Visibility = Visibility.Visible;
            Second_TextBlock.Text = "Имя:";
            Third_TextBox.Visibility = Visibility.Visible;
            Third_TextBlock.Text = "Отчесвто:";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Visible;
            Five_TextBlock.Text = "Дата рожд:";
            Six_TextBox.Visibility = Visibility.Visible;
            Six_TextBlock.Text = "Номер телеф:";
            Seven_TextBlock.Text = "Банк:";
            Seven_ComboBox.DisplayMemberPath = "Name_Bank";
            Seven_ComboBox.ItemsSource = banksAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Visible;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Visible;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;

            Main_DataGrid.Columns[0].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[6].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[7].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[8].Visibility = Visibility.Collapsed;

        }

        private void Menu_Banks_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = banksAdapter.GetData();
            table = "banks";

            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Навзвание:";
            Second_TextBox.Visibility = Visibility.Collapsed;
            Second_TextBlock.Text = "";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Menu_MethodPay_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = methodAdapter.GetData();
            table = "method";
           
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Метод:";
            Second_TextBox.Visibility = Visibility.Collapsed;
            Second_TextBlock.Text = "";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;

        }

        private void Menu_Securities_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = secAdapter.GetSec();
            table = "sec";
           
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Кол-во:";
            Second_TextBox.Visibility = Visibility.Visible;
            Second_TextBlock.Text = "";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "Владелец:";
            Seven_ComboBox.DisplayMemberPath = "Last_Name_Owner";
            Seven_ComboBox.ItemsSource = ownerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Visible;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Securities_Name";
            Eight_ComboBox.ItemsSource = infoAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Visible;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;

            Main_DataGrid.Columns[0].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[2].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[3].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[4].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[7].Visibility = Visibility.Collapsed;

        }

        private void Menu_InfoSec_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = infoAdapter.GetInfo();
            table = "info";
           
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Навзание:";
            Second_TextBox.Visibility = Visibility.Visible;
            Second_TextBlock.Text = "Цена:";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "Тип:";
            Seven_ComboBox.DisplayMemberPath = "Securities_Type";
            Seven_ComboBox.ItemsSource = secTypeAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Visible;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;


            Main_DataGrid.Columns[0].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[3].Visibility = Visibility.Collapsed;
            Main_DataGrid.Columns[4].Visibility = Visibility.Collapsed;
        }

        private void Menu_Owner_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = ownerAdapter.GetData();
            table = "owner";
           
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Фамилия:";
            Second_TextBox.Visibility = Visibility.Visible;
            Second_TextBlock.Text = "Имя:";
            Third_TextBox.Visibility = Visibility.Visible;
            Third_TextBlock.Text = "Отчесвто:";
            Fourth_TextBox.Visibility = Visibility.Visible;
            Fourth_TextBlock.Text = "Комиссия:";
            Five_TextBox.Visibility = Visibility.Visible;
            Five_TextBlock.Text = "Дата рожд:";
            Six_TextBox.Visibility = Visibility.Visible;
            Six_TextBlock.Text = "Номер телеф:";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Menu_TypeSec_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = secTypeAdapter.GetData();
            table = "secType";
            
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Тип:";
            Second_TextBox.Visibility = Visibility.Collapsed;
            Second_TextBlock.Text = "";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Menu_StatusTrans_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = statusAdapter.GetData();
            table = "status";
            
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Статус:";
            Second_TextBox.Visibility = Visibility.Collapsed;
            Second_TextBlock.Text = "";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Menu_Users_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = userAdapter.GetData();
            table = "user";
           
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Логин:";
            Second_TextBox.Visibility = Visibility.Visible;
            Second_TextBlock.Text = "Пароль:";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Role_User";
            Seven_ComboBox.ItemsSource = roleAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Visible;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Menu_Role_Click(object sender, RoutedEventArgs e)
        {
            Main_DataGrid.ItemsSource = null;
            Main_DataGrid.ItemsSource = roleAdapter.GetData();
            table = "role";
          
            First_TextBox.Visibility = Visibility.Visible;
            First_TextBlock.Text = "Роль:";
            Second_TextBox.Visibility = Visibility.Collapsed;
            Second_TextBlock.Text = "";
            Third_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Text = "";
            Fourth_TextBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Text = "";
            Five_TextBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Text = "";
            Six_TextBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Text = "";
            Seven_TextBlock.Text = "";
            Seven_ComboBox.DisplayMemberPath = "Diploma_Training_ID";
            Seven_ComboBox.ItemsSource = brokerAdapter.GetData();
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Eight_TextBlock.Text = "";
            Eight_ComboBox.DisplayMemberPath = "Brokerage_Office_ID";
            Eight_ComboBox.ItemsSource = brokerAdapter.GetData();
            Eight_ComboBox.Visibility = Visibility.Collapsed;
            Nine_TextBlock.Text = "";
            Nine_ComboBox.DisplayMemberPath = "User_Stock_Exchange_ID";
            Nine_ComboBox.ItemsSource = brokerAdapter.GetData();
            Nine_ComboBox.Visibility = Visibility.Collapsed;
            Ten_TextBlock.Text = "";
            Ten_ComboBox.Visibility = Visibility.Collapsed;
            Eleven_TextBlock.Text = "";
            Eleven_ComboBox.Visibility = Visibility.Collapsed;
        }

        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            CUD_Button.Content = "Создать";
            DisableButton(Update_Button, Delete_Button);
        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            CUD_Button.Content = "Изменить";
            DisableButton(Create_Button, Delete_Button);
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            CUD_Button.Content = "Удалить";
            DisableButton(Create_Button, Update_Button);
            if (First_TextBox.IsEnabled == true || Second_TextBox.IsEnabled == true || Seven_ComboBox.IsEnabled == true)
            {
                First_TextBox.IsEnabled = false;
                Second_TextBox.IsEnabled = false;
                Third_TextBox.IsEnabled = false;
                Fourth_TextBox.IsEnabled = false;
                Five_TextBox.IsEnabled = false;
                Six_TextBox.IsEnabled = false;
                Seven_ComboBox.IsEnabled = false;
                Eight_ComboBox.IsEnabled = false;
                Nine_ComboBox.IsEnabled = false;
                Ten_ComboBox.IsEnabled = false;
                Eleven_ComboBox.IsEnabled = false;
            }
            else
            {
                First_TextBox.IsEnabled = true;
                Second_TextBox.IsEnabled = true;
                Third_TextBox.IsEnabled = true;
                Fourth_TextBox.IsEnabled = true;
                Five_TextBox.IsEnabled = true;
                Six_TextBox.IsEnabled = true;
                Seven_ComboBox.IsEnabled = true;
                Eight_ComboBox.IsEnabled = true;
                Nine_ComboBox.IsEnabled = true;
                Ten_ComboBox.IsEnabled = true;
                Eleven_ComboBox.IsEnabled = true;
            }

            
        }

        private void CUD_Button_Click(object sender, RoutedEventArgs e)
        {

          /*table = "trans";
            table = "receipt";
            table = "broker";
            table = "diploma";
            table = "brokOff";
            table = "clients";
            table = "banks";
            table = "method";
            table = "sec";
            table = "info";
            table = "owner";
            table = "secType";
            table = "status";
            table = "user";
            table = "role";*/

            int idRow = 0;
            bool bo = true;
            int quantity = 0;
            DateTime enteredDate;
            if (table == "trans")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if ((First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Eleven_ComboBox.SelectedItem == null || Seven_ComboBox.SelectedItem == null
                         || Eight_ComboBox.SelectedItem == null || Nine_ComboBox.SelectedItem == null || Ten_ComboBox.SelectedItem == null) && bo)
                        {
                            MessageBox.Show("Заполните все поля");
                            bo = false;
                        }
                        if (Int32.TryParse(Third_TextBox.Text, out int result) && bo)
                        {
                            quantity = result;
                            bo = true;
                        }
                        else if (!Int32.TryParse(Third_TextBox.Text, out int result1) && bo)
                        {
                            MessageBox.Show("Введите целое число");
                            bo = false;
                        }
                        if (DateTime.TryParseExact(First_TextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out enteredDate) && bo)
                        {
                            if (enteredDate < DateTime.Today)
                            {
                                MessageBox.Show("Нельзя совершить сделку в прошлом");
                                bo = false;
                            }
                            else
                            {
                                DateCreatUser = First_TextBox.Text;
                                bo = true;
                            }
                        }
                        else if (bo)
                        {
                            MessageBox.Show("Некорректный формат даты");
                            bo = false;
                        }
                        if (DateTime.TryParseExact(Second_TextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out enteredDate) && bo)
                        {
                            if (enteredDate < DateTime.Today)
                            {
                                MessageBox.Show("Нельзя совершить сделку в прошлом");
                                bo = false;
                            }
                            else
                            {
                                DateComplUser = First_TextBox.Text;
                                bo = true;
                            }
                        }
                        else if (bo)
                        {
                            MessageBox.Show("Некорректный формат даты");
                            bo = false;
                        }

                        if (bo)
                        {
                            transAdapter.InsertTrans(DateCreatUser, DateComplUser, quantity,
                            Seven_ComboBox.SelectedIndex + 1, Eight_ComboBox.SelectedIndex + 1, Nine_ComboBox.SelectedIndex + 1, Ten_ComboBox.SelectedIndex + 1, Eleven_ComboBox.SelectedIndex + 1);
                            First_TextBox.Text = null; Second_TextBox.Text = null; Third_TextBox.Text = null;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Неверный формат добваления");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {

                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                            bo = false;
                        }
                        if ((First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Eleven_ComboBox.SelectedItem == null || Seven_ComboBox.SelectedItem == null
                         || Eight_ComboBox.SelectedItem == null || Nine_ComboBox.SelectedItem == null || Ten_ComboBox.SelectedItem == null) && bo)
                        {
                            MessageBox.Show("Заполните все поля");
                            bo = false;
                        }
                        if (Int32.TryParse(Third_TextBox.Text, out int result) && bo)
                        {
                            quantity = result;
                            bo = true;
                        }
                        else if (!Int32.TryParse(Third_TextBox.Text, out int result1) && bo)
                        {
                            MessageBox.Show("Введите целое число");
                            bo = false;
                        }
                        if (DateTime.TryParseExact(First_TextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out enteredDate) && bo)
                        {
                            if (enteredDate < DateTime.Today)
                            {
                                MessageBox.Show("Нельзя совершить сделку в прошлом");
                                bo = false;
                            }
                            else
                            {
                                DateCreatUser = First_TextBox.Text;
                                bo = true;
                            }
                        }
                        else if (bo)
                        {
                            MessageBox.Show("Некорректный формат даты");
                            bo = false;
                        }
                        if (DateTime.TryParseExact(Second_TextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out enteredDate) && bo)
                        {
                            if (enteredDate < DateTime.Today)
                            {
                                MessageBox.Show("Нельзя совершить сделку в прошлом");
                                bo = false;
                            }
                            else
                            {
                                DateComplUser = First_TextBox.Text;
                                bo = true;
                            }
                        }
                        else if (bo)
                        {
                            MessageBox.Show("Некорректный формат даты");
                            bo = false;
                        }

                        else if (bo)
                        {
                            transAdapter.UpdateTrans(DateCreatUser, DateComplUser, quantity,
                            Seven_ComboBox.SelectedIndex + 1, Eight_ComboBox.SelectedIndex + 1, Nine_ComboBox.SelectedIndex + 1, Ten_ComboBox.SelectedIndex + 1, Eleven_ComboBox.SelectedIndex + 1, idRow);
                            First_TextBox.Text = null; Second_TextBox.Text = null; Third_TextBox.Text = null;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Неверный формат добваления");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            transAdapter.DeleteTrans(idRow);
                        }
                        else if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = transAdapter.GetData();
            }
            else if (table == "receipt")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Seven_ComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                    else if (Double.TryParse(First_TextBox.Text, out double f) & Double.TryParse(Second_TextBox.Text, out double s) & Double.TryParse(Third_TextBox.Text, out double t))
                    {
                        receiptAdapter.InsertReceipt(f, s, t, Seven_ComboBox.SelectedIndex + 1);
                    }
                    else
                    {
                        MessageBox.Show("Введите числовое значение");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                              idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Seven_ComboBox.SelectedItem == null)
                        {
                          MessageBox.Show("Заполните все поля");
                        }
                        else if (Double.TryParse(First_TextBox.Text, out double f) & Double.TryParse(Second_TextBox.Text, out double s) & Double.TryParse(Third_TextBox.Text, out double t))
                        {
                            receiptAdapter.UpdateReceipt(f, s, t, Seven_ComboBox.SelectedIndex + 1, idRow);
                        }
                        else
                        {   
                            MessageBox.Show("Введите числовое значение");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            receiptAdapter.DeleteReceipt(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = receiptAdapter.GetData();
            }
            else if(table == "broker")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try { 
                    if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Fourth_TextBox.Text == null || Five_TextBox.Text == null || Six_TextBox.Text == null
                        || Seven_ComboBox.SelectedItem == null || Eight_ComboBox.SelectedItem == null || Nine_ComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                    else if (Int32.TryParse(Six_TextBox.Text, out int f) & Double.TryParse(Fourth_TextBox.Text, out double s))
                    {
                        brokerAdapter.InsertQuery(First_TextBox.Text, Second_TextBox.Text, Third_TextBox.Text,s, Five_TextBox.Text, Six_TextBox.Text, Seven_ComboBox.SelectedIndex + 1, Eight_ComboBox.SelectedIndex+1,Nine_ComboBox.SelectedIndex+1);
                    }
                    else
                    {
                        MessageBox.Show("Введите числовое значение");
                    }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Fourth_TextBox.Text == null || Five_TextBox.Text == null || Six_TextBox.Text == null
                       || Seven_ComboBox.SelectedItem == null || Eight_ComboBox.SelectedItem == null || Nine_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Int32.TryParse(Six_TextBox.Text, out int f) & Double.TryParse(Fourth_TextBox.Text, out double s))
                        {
                            brokerAdapter.UpdateQuery(First_TextBox.Text, Second_TextBox.Text, Third_TextBox.Text, s, Five_TextBox.Text, Six_TextBox.Text, Seven_ComboBox.SelectedIndex + 1, Eight_ComboBox.SelectedIndex + 1, Nine_ComboBox.SelectedIndex + 1, idRow);
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение");
                        }
                    
                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            brokerAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = brokerAdapter.GetData();
            }
            else if (table == "diploma")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            diplomaAdapter.InsertQuery(First_TextBox.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            diplomaAdapter.UpdateQuery(First_TextBox.Text, idRow);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            diplomaAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = diplomaAdapter.GetData();
            }
            else if (table == "brokOff")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            brokOffAdapter.InsertQuery(First_TextBox.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            brokOffAdapter.UpdateQuery(First_TextBox.Text, idRow);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            brokOffAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = brokOffAdapter.GetData();
            }
            else if (table == "clients")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Five_TextBox.Text == null || Six_TextBox.Text == null
                            || Seven_ComboBox.SelectedItem == null || Eight_ComboBox.SelectedItem == null || Nine_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Int32.TryParse(Six_TextBox.Text, out int f))
                        {
                            clientsAdapter.InsertClient(First_TextBox.Text, Second_TextBox.Text, Third_TextBox.Text, Five_TextBox.Text, Six_TextBox.Text, Seven_ComboBox.SelectedIndex + 1, Nine_ComboBox.SelectedIndex + 1);
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Five_TextBox.Text == null || Six_TextBox.Text == null
                            || Seven_ComboBox.SelectedItem == null || Eight_ComboBox.SelectedItem == null || Nine_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Int32.TryParse(Six_TextBox.Text, out int f))
                        {
                            clientsAdapter.UpdateQuery(First_TextBox.Text, Second_TextBox.Text, Third_TextBox.Text, Five_TextBox.Text, Six_TextBox.Text, Seven_ComboBox.SelectedIndex + 1, Nine_ComboBox.SelectedIndex + 1, idRow);
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            clientsAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = clientsAdapter.GetData();
            }
            else if (table == "banks")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            banksAdapter.InsertQuery(First_TextBox.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            banksAdapter.UpdateQuery(First_TextBox.Text, idRow);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            banksAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = banksAdapter.GetData();
            }
            else if (table == "method")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            methodAdapter.InsertQuery(First_TextBox.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            methodAdapter.UpdateQuery(First_TextBox.Text, idRow);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            methodAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = methodAdapter.GetData();
            }
            else if (table == "sec")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Seven_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Int32.TryParse(Six_TextBox.Text, out int f))
                        {
                            secAdapter.InsertQuery(f, Eight_ComboBox.SelectedIndex+1, Seven_ComboBox.SelectedIndex+1);
                        }
                        else
                        {
                            MessageBox.Show("Введите название");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Seven_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Int32.TryParse(Six_TextBox.Text, out int f))
                        {
                            secAdapter.UpdateQuery(f, Eight_ComboBox.SelectedIndex + 1, Seven_ComboBox.SelectedIndex + 1, idRow);
                        }
                        else
                        {
                            MessageBox.Show("Введите название");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            secAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = secAdapter.GetData();
            }
            else if (table == "info")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Seven_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if(double.TryParse(Second_TextBox.Text, out double f))
                        {
                            infoAdapter.InsertQuery(First_TextBox.Text, f, Seven_ComboBox.SelectedIndex + 1);
                        }
                        else 
                        {
                            MessageBox.Show("Введите название");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Seven_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (double.TryParse(Second_TextBox.Text, out double f))
                        {
                            infoAdapter.UpdateQuery(First_TextBox.Text, f, Seven_ComboBox.SelectedIndex + 1, idRow);
                        }
                        else
                        {
                            MessageBox.Show("Введите название");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            infoAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = infoAdapter.GetData();
            }
            else if (table == "owner")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Five_TextBox.Text == null || Six_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Int32.TryParse(Six_TextBox.Text, out int f))
                        {
                            ownerAdapter.InsertQuery(First_TextBox.Text, Second_TextBox.Text, Third_TextBox.Text, Five_TextBox.Text, Six_TextBox.Text);
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Five_TextBox.Text == null || Six_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Int32.TryParse(Six_TextBox.Text, out int f))
                        {
                            ownerAdapter.UpdateQuery(First_TextBox.Text, Second_TextBox.Text, Third_TextBox.Text, Five_TextBox.Text, Six_TextBox.Text, idRow);
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            ownerAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = ownerAdapter.GetData();
            }
            else if (table == "secType")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            secTypeAdapter.InsertQuery(First_TextBox.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            secTypeAdapter.UpdateQuery(First_TextBox.Text, idRow);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            secTypeAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = secTypeAdapter.GetData();
            }
            else if (table == "status")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            statusAdapter.InsertQuery(First_TextBox.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            statusAdapter.UpdateQuery(First_TextBox.Text, idRow);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            statusAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = statusAdapter.GetData();
            }
            else if (table == "user")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Seven_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            userAdapter.InsertUser(First_TextBox.Text, Second_TextBox.Text, Seven_ComboBox.SelectedIndex + 1);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Seven_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            userAdapter.UpdateQuery(First_TextBox.Text, Second_TextBox.Text, Seven_ComboBox.SelectedIndex + 1, idRow);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            userAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = userAdapter.GetData();
            }
            else if (table == "role")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            roleAdapter.InsertQuery(First_TextBox.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите правильыне значения");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (First_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else
                        {
                            roleAdapter.UpdateQuery(First_TextBox.Text, idRow);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Выберит строку пожалуйста");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Удалить")
                {
                    try
                    {
                        if (Main_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Main_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Main_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            roleAdapter.DeleteQuery(idRow);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
                }
                Main_DataGrid.ItemsSource = null;
                Main_DataGrid.ItemsSource = roleAdapter.GetData();
            }
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            registerWindow.Show();
        }

        private void Menu_Backup_Click(object sender, RoutedEventArgs e)
        {
            querry.Stock_Exchange();
            MessageBox.Show("Бэкап сделан");
        }
    }
}
