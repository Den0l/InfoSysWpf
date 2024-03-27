using Stock_Exchange_WPF.Stock_ExchangeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
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
using static Stock_Exchange_WPF.Stock_ExchangeDataSet;

namespace Stock_Exchange_WPF
{
    /// <summary>
    /// Логика взаимодействия для BrokerWindow.xaml
    /// </summary>
    public partial class BrokerWindow : Window
    {
        public int ID_UserReg { get; }
        RegisterWindow registerWindow = new RegisterWindow();
        AddReceiptWindow addWindow = new AddReceiptWindow();
        ClientsTableAdapter clientsAdapter = new ClientsTableAdapter();
        Securities_TransactionTableAdapter transAdapter = new Securities_TransactionTableAdapter();
        SecuritiesTableAdapter securitiesAdapter = new SecuritiesTableAdapter();
        Transaction_Status_TableTableAdapter statusAdapter = new Transaction_Status_TableTableAdapter();
        Information_About_SecuritiesTableAdapter infoAdapter = new Information_About_SecuritiesTableAdapter();
        Method_of_PaymentTableAdapter methodAdapter = new Method_of_PaymentTableAdapter();
        Owner_of_SecuritiesTableAdapter ownerAdapter = new Owner_of_SecuritiesTableAdapter();
        Receipt_of_PaymentTableAdapter receiptAdapter = new Receipt_of_PaymentTableAdapter();
        Broker_Stock_ExchangeTableAdapter brokerAdapter = new Broker_Stock_ExchangeTableAdapter();
        private string DateComplUser;
        private string DateCreatUser;
        public BrokerWindow(int UserReg)
        {
            InitializeComponent();
            ID_UserReg = UserReg;
            Broker_DataGrid.ItemsSource = transAdapter.GetTransID();
            Fourth_ComboBox.DisplayMemberPath = "Securities_Name";
            Fourth_ComboBox.ItemsSource = infoAdapter.GetData();
            Five_ComboBox.DisplayMemberPath = "Last_Name_Client";
            Five_ComboBox.ItemsSource = clientsAdapter.GetData();
            Six_ComboBox.DisplayMemberPath = "Method_of_Payment";
            Six_ComboBox.ItemsSource = methodAdapter.GetData();
            Seven_ComboBox.DisplayMemberPath = "Transaction_Status";
            Seven_ComboBox.ItemsSource = statusAdapter.GetData();
            First_TextBox.MaxLength = 29;
            Second_TextBox.MaxLength = 29;
            Third_TextBox.MaxLength = 29;

            
            
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
            Broker_DataGrid.ItemsSource = null;
            Broker_DataGrid.ItemsSource = transAdapter.GetTransID();
            Create_Button.IsEnabled = true;
            Update_Button.IsEnabled = true;
            Delete_Button.IsEnabled = true;
            First_TextBlock.Text = "Дата созд:";
            Second_TextBlock.Text = "Дата заве:";
            Third_TextBlock.Text = "Кол-во:";
            Fourth_TextBlock.Visibility = Visibility.Visible;
            Fourth_ComboBox.Visibility = Visibility.Visible;
            Five_ComboBox.Visibility = Visibility.Visible;
            Six_ComboBox.Visibility = Visibility.Visible;
            Seven_ComboBox.Visibility = Visibility.Visible;
            Five_TextBlock.Visibility = Visibility.Visible;
            Six_TextBlock.Visibility = Visibility.Visible;
            Seven_TextBlock.Visibility = Visibility.Visible;
            Fourth_TextBlock.Text = "Ценная Бумага:";
            Fourth_ComboBox.DisplayMemberPath = "Securities_Name";
            Fourth_ComboBox.ItemsSource = infoAdapter.GetData();
            Five_ComboBox.DisplayMemberPath = "Last_Name_Client";
            Five_ComboBox.ItemsSource = clientsAdapter.GetData();
            Six_ComboBox.DisplayMemberPath = "Method_of_Payment";
            Six_ComboBox.ItemsSource = methodAdapter.GetData();
            Seven_ComboBox.DisplayMemberPath = "Transaction_Status";
            Seven_ComboBox.ItemsSource = statusAdapter.GetData();

            Broker_DataGrid.Columns[4].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[5].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[6].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[7].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[8].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[9].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[10].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[12].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[14].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[16].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[18].Visibility = Visibility.Collapsed;
        }   
        private void Menu_Receipt_Click(object sender, RoutedEventArgs e)
        {
            Broker_DataGrid.ItemsSource = null;
            Broker_DataGrid.ItemsSource = receiptAdapter.GetData();
            Create_Button.IsEnabled = true;
            Update_Button.IsEnabled = true;
            Delete_Button.IsEnabled = true;
            Five_ComboBox.Visibility = Visibility.Collapsed;
            Six_ComboBox.Visibility = Visibility.Collapsed;
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Visibility = Visibility.Collapsed;
            Six_TextBlock.Visibility = Visibility.Collapsed;
            Seven_TextBlock.Visibility = Visibility.Collapsed;
            First_TextBlock.Text = "Итоговая:";
            Second_TextBlock.Text = "Внесенная:";
            Third_TextBlock.Text = "Сдача:";
            Fourth_TextBlock.Visibility = Visibility.Collapsed;
            Fourth_ComboBox.Visibility = Visibility.Collapsed;

            

        }
        private void Menu_Clients_Click(object sender, RoutedEventArgs e)
        {
            Broker_DataGrid.ItemsSource = null;
            Broker_DataGrid.ItemsSource = clientsAdapter.GetClientBank();
            Create_Button.IsEnabled = false;
            Update_Button.IsEnabled = false;
            Delete_Button.IsEnabled = false;

            Broker_DataGrid.Columns[0].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[6].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[7].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[8].Visibility = Visibility.Collapsed;
        }

        private void Menu_Securities_Click(object sender, RoutedEventArgs e)
        {
            Broker_DataGrid.ItemsSource = null;
            Broker_DataGrid.ItemsSource = securitiesAdapter.GetSec();
            Create_Button.IsEnabled = false;
            Update_Button.IsEnabled = false;
            Delete_Button.IsEnabled = false;

            Broker_DataGrid.Columns[0].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[2].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[3].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[4].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[7].Visibility = Visibility.Collapsed;
        }

        private void Menu_Owner_Click(object sender, RoutedEventArgs e)
        {
            Broker_DataGrid.ItemsSource = null;
            Broker_DataGrid.ItemsSource = ownerAdapter.GetData();
            Create_Button.IsEnabled = false;
            Update_Button.IsEnabled = false;
            Delete_Button.IsEnabled = false;

            Broker_DataGrid.Columns[0].Visibility = Visibility.Collapsed;
        }

        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            CUD_Button.Content = "Создать";
            DisableButton(Update_Button, Delete_Button);
            if (First_TextBlock.Text == "Итоговая:")
            {
                First_TextBlock.Visibility = Visibility.Visible;
                First_TextBox.Visibility = Visibility.Visible;
                Second_TextBlock.Visibility = Visibility.Visible;
                Second_TextBox.Visibility = Visibility.Visible;
                Third_TextBlock.Visibility = Visibility.Visible;
                Third_TextBox.Visibility = Visibility.Visible;
                Fourth_ComboBox.Visibility = Visibility.Visible;
                Fourth_TextBlock.Visibility = Visibility.Visible;
            }
            else
            {

                First_TextBlock.Visibility = Visibility.Visible;
                First_TextBox.Visibility = Visibility.Visible;
                Second_TextBlock.Visibility = Visibility.Visible;
                Second_TextBox.Visibility = Visibility.Visible;
                Third_TextBlock.Visibility = Visibility.Visible;
                Third_TextBox.Visibility = Visibility.Visible;
                Fourth_ComboBox.Visibility = Visibility.Visible;
                Fourth_TextBlock.Visibility = Visibility.Visible;
                Five_ComboBox.Visibility = Visibility.Visible;
                Five_TextBlock.Visibility = Visibility.Visible;
                Six_ComboBox.Visibility = Visibility.Visible;
                Six_TextBlock.Visibility = Visibility.Visible;
                Seven_ComboBox.Visibility = Visibility.Visible;
                Seven_TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            CUD_Button.Content = "Изменить";
            DisableButton(Create_Button, Delete_Button);
            if (First_TextBlock.Text == "Итоговая:")
            {
                First_TextBlock.Visibility = Visibility.Visible;
                First_TextBox.Visibility = Visibility.Visible;
                Second_TextBlock.Visibility = Visibility.Visible;
                Second_TextBox.Visibility = Visibility.Visible;
                Third_TextBlock.Visibility = Visibility.Visible;
                Third_TextBox.Visibility = Visibility.Visible;
                Fourth_ComboBox.Visibility = Visibility.Visible;
                Fourth_TextBlock.Visibility = Visibility.Visible;
            }
            else
            {

                First_TextBlock.Visibility = Visibility.Visible;
                First_TextBox.Visibility = Visibility.Visible;
                Second_TextBlock.Visibility = Visibility.Visible;
                Second_TextBox.Visibility = Visibility.Visible;
                Third_TextBlock.Visibility = Visibility.Visible;
                Third_TextBox.Visibility = Visibility.Visible;
                Fourth_ComboBox.Visibility = Visibility.Visible;
                Fourth_TextBlock.Visibility = Visibility.Visible;
                Five_ComboBox.Visibility = Visibility.Visible;
                Five_TextBlock.Visibility = Visibility.Visible;
                Six_ComboBox.Visibility = Visibility.Visible;
                Six_TextBlock.Visibility = Visibility.Visible;
                Seven_ComboBox.Visibility = Visibility.Visible;
                Seven_TextBlock.Visibility = Visibility.Visible;
            }
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            CUD_Button.Content = "Удалить";
            DisableButton(Create_Button, Update_Button);
            First_TextBlock.Visibility = Visibility.Collapsed;
            First_TextBox.Visibility = Visibility.Collapsed;
            Second_TextBlock.Visibility = Visibility.Collapsed;
            Second_TextBox.Visibility = Visibility.Collapsed;
            Third_TextBlock.Visibility = Visibility.Collapsed;
            Third_TextBox.Visibility = Visibility.Collapsed;
            Fourth_ComboBox.Visibility = Visibility.Collapsed;
            Fourth_TextBlock.Visibility = Visibility.Collapsed;
            Five_ComboBox.Visibility = Visibility.Collapsed;
            Five_TextBlock.Visibility = Visibility.Collapsed;
            Six_ComboBox.Visibility = Visibility.Collapsed;
            Six_TextBlock.Visibility = Visibility.Collapsed;
            Seven_ComboBox.Visibility = Visibility.Collapsed;
            Seven_TextBlock.Visibility = Visibility.Collapsed;
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            registerWindow.Show();
        }

        private void CUD_Button_Click(object sender, RoutedEventArgs e)
        {
            int idRow = 0;
            bool bo=true;
            int brokerID = 0;
            int quantity = 0;
            DateTime enteredDate;
            foreach (var item in brokerAdapter.GetData())
            {
                if (item.User_Stock_Exchange_ID == ID_UserReg)
                {
                    brokerID = item.ID_Broker_Stock_Exchange;
                }
            }
            
            if (First_TextBlock.Text == "Дата созд:")
            {
                if (CUD_Button.Content == null)
                {
                    MessageBox.Show("Нажмите на кнопку для действия");
                }
                else if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        if ((First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Fourth_ComboBox.SelectedItem == null
                         || Five_ComboBox.SelectedItem == null || Six_ComboBox.SelectedItem == null || Seven_ComboBox.SelectedItem == null) && bo)
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
                        else if(bo)
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
                        else if(bo)
                        {
                            MessageBox.Show("Некорректный формат даты");
                            bo = false;
                        }
                        if (bo)
                        {
                            transAdapter.InsertTrans(DateCreatUser, DateComplUser, quantity,
                            Fourth_ComboBox.SelectedIndex+1, Five_ComboBox.SelectedIndex+1, Six_ComboBox.SelectedIndex+1, Seven_ComboBox.SelectedIndex+1, brokerID);
                            First_TextBox.Text = null; Second_TextBox.Text = null;  Third_TextBox.Text = null;

                        }
                        addWindow.Show();
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
                        if (Broker_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                            bo = false;
                        }
                        if ((First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Fourth_ComboBox.SelectedItem == null
                         || Five_ComboBox.SelectedItem == null || Six_ComboBox.SelectedItem == null || Seven_ComboBox.SelectedItem == null) && bo)
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
                            Fourth_ComboBox.SelectedIndex + 1, Five_ComboBox.SelectedIndex + 1, Six_ComboBox.SelectedIndex + 1, Seven_ComboBox.SelectedIndex + 1, brokerID, idRow);
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
                        if (Broker_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Broker_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                            transAdapter.DeleteTrans(idRow);
                        }
                        else if (Broker_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Это строка ссылается на другую таблицу");
                    }
            }
                Broker_DataGrid.ItemsSource = null;
                Broker_DataGrid.ItemsSource = transAdapter.GetData();
            }
            else if (First_TextBlock.Text == "Итоговая:")
            {

                if (CUD_Button.Content.ToString() == "Создать")
                {
                    try
                    {
                        
                        if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Double.TryParse(First_TextBox.Text, out double f) & Double.TryParse(Second_TextBox.Text, out double s) & Double.TryParse(Third_TextBox.Text, out double t))
                        {
                            receiptAdapter.InsertReceipt(f, s, t, transAdapter.GetData().Last().ID_Securities_Transaction);
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение (либо поменяйте точку на запятую)");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Квитанция может быть только у одной сделки");
                    }
                }
                else if (CUD_Button.Content.ToString() == "Изменить")
                {
                    try
                    {


                        if (Broker_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Broker_DataGrid.SelectedItem as DataRowView;

                            if (dataRowView != null)
                            {
                                idRow = Convert.ToInt32(dataRowView.Row[0]);
                            }
                        }
                        if (Broker_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (First_TextBox.Text == null || Second_TextBox.Text == null || Third_TextBox.Text == null || Fourth_ComboBox.SelectedItem == null)
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                        else if (Double.TryParse(First_TextBox.Text, out double f) & Double.TryParse(Second_TextBox.Text, out double s) & Double.TryParse(Third_TextBox.Text, out double t))
                        {
                            receiptAdapter.UpdateReceipt(f, s, t, Fourth_ComboBox.SelectedIndex + 1, idRow);
                        }
                        else
                        {
                            MessageBox.Show("Введите числовое значение (либо поменяйте точку на запятую)");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Квитанция может быть только у одной сделки");
                    }
                }
                else if(CUD_Button.Content.ToString() == "Удалить" )
                {
                    try {
                        if (Broker_DataGrid.SelectedItem == null)
                        {
                            MessageBox.Show("Выберите строку");
                        }
                        else if (Broker_DataGrid.SelectedItem != null)
                        {
                            DataRowView dataRowView = Broker_DataGrid.SelectedItem as DataRowView;

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
                Broker_DataGrid.ItemsSource = null;
                Broker_DataGrid.ItemsSource = receiptAdapter.GetData();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Broker_DataGrid.Columns[4].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[5].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[6].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[7].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[8].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[9].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[10].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[12].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[14].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[16].Visibility = Visibility.Collapsed;
            Broker_DataGrid.Columns[18].Visibility = Visibility.Collapsed;
        }

    }
}
