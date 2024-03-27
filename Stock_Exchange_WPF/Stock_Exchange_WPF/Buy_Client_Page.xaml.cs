using Stock_Exchange_WPF.Stock_ExchangeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Data;
using System.Net;

namespace Stock_Exchange_WPF
{
    /// <summary>
    /// Логика взаимодействия для Buy_Client_Page.xaml
    /// </summary>
    public partial class Buy_Client_Page : Page
    {
        RegisterWindow regWindow;
        
        
        SecuritiesTableAdapter securitiesAdapter = new SecuritiesTableAdapter();
        Information_About_SecuritiesTableAdapter infoAdapter = new Information_About_SecuritiesTableAdapter();
        Method_of_PaymentTableAdapter methodAdapter = new Method_of_PaymentTableAdapter();
        Securities_TransactionTableAdapter transAdapter = new Securities_TransactionTableAdapter();
        ClientsTableAdapter clientsAdapter = new ClientsTableAdapter();
        Receipt_of_PaymentTableAdapter receiptAdapter = new Receipt_of_PaymentTableAdapter();
        Broker_Stock_ExchangeTableAdapter brokerAdapter = new Broker_Stock_ExchangeTableAdapter();
        private Random rnd = new Random();
        private int MaxQuantity = 0;
        private int UserQuantity = 0;
        private double priceSec = 0; 
        private double amountUser = 0;
        private int UserMethodPay;
        private string DateComplUser;
        private int status = 0;
        public int ID_UserReg { get; }
        public Buy_Client_Page(int UserReg)
        {
            InitializeComponent();
            Securities_ComboBox.DisplayMemberPath = "Securities_Name";
            Securities_ComboBox.ItemsSource = infoAdapter.GetData();
            MethodPay_ComboBox.DisplayMemberPath = "Method_of_Payment";
            MethodPay_ComboBox.ItemsSource = methodAdapter.GetData();
            ID_UserReg = UserReg;
            Quantity_TextBox.MaxLength = 29;
            DateComplit_TextBox.MaxLength = 29;
            AmountContr_TextBox.MaxLength = 29;
        }

        public bool ErrorInsertComboBox(ComboBox combo, ComboBox combo1)
        {

            if(combo.SelectedItem == null)
            {
                MessageBox.Show("Введите все значения");
                return false;
            }
            else if(combo1.SelectedItem == null)
            {
                MessageBox.Show("Введите все значения");
                return false;
            }
            return true;
        }

        public bool ErrorInsertTextBox(TextBox box, TextBox box1, TextBox box2)
        {

            if (box.Text == null)
            {
                MessageBox.Show("Введите все значения");
                return false;
            }
            else if(box1.Text == null)
            {
                MessageBox.Show("Введите все значения");
                return false;
            }
            else if (box2.Text == null)
            {
                MessageBox.Show("Введите все значения");
                return false;
            }
            return true;

        }


        private void Securities_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MaxQuantity = securitiesAdapter.GetData().ElementAt(Securities_ComboBox.SelectedIndex).Quantity_of_Securities_of_Owner;
            priceSec = infoAdapter.GetData().ElementAt(Securities_ComboBox.SelectedIndex).Price_of_Securities;
            QuantityMax_TextBlock.Text = "Макс:" + MaxQuantity.ToString();
        }

        private void Quantity_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            QuantityError_TextBlock.Text = null;
            if (Quantity_TextBox.Text == null)
            {
                QuantityError_TextBlock.Text = "Введите значение";
            }
            if(Int32.TryParse(Quantity_TextBox.Text, out int result))
            {
                if(result > MaxQuantity)
                {
                    QuantityError_TextBlock.Text = "Вы превысили лимит";
                }
                else
                {
                    UserQuantity = result;
                    AmountMax_TextBlock.Text = "Итоговая сумма:" +  (result*priceSec).ToString();
                }
            }
            else
            {
                QuantityError_TextBlock.Text = "Введите целое число";
            }
        }

        private void MethodPay_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserMethodPay = methodAdapter.GetData().ElementAt(MethodPay_ComboBox.SelectedIndex).ID_Method_of_Payment;
        }

        private void DateComplit_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            DateComplitError_TextBlock.Text = null;
            DateTime enteredDate;
            if (DateComplit_TextBox.Text == null)
            {
                DateComplitError_TextBlock.Text = "Введите значение";
            }
            if (DateTime.TryParseExact(DateComplit_TextBox.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out enteredDate))
            {
                if (enteredDate < DateTime.Today)
                {
                    DateComplitError_TextBlock.Text = "Этот день уже прошел";
                }
                else
                {
                    if (enteredDate == DateTime.Today)
                    {
                        status = 2;
                    }
                    else if(enteredDate > DateTime.Today)
                    {
                        status = 1;
                    }
                    DateComplUser = DateComplit_TextBox.Text;
                }
            }
            else
            {
                DateComplitError_TextBlock.Text = "Некорректный формат даты";
            }

        }

        private void AmountContr_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            AmountError_TextBlock.Text = null;
            if (AmountContr_TextBox.Text == null)
            {
                AmountError_TextBlock.Text = "Введите значение";
            }
            if (Double.TryParse(AmountContr_TextBox.Text, out double result))
            {
                if (result < (UserQuantity*priceSec))
                {
                    AmountError_TextBlock.Text = "Недостаточно средств";
                }
                else
                {
                    amountUser = result;
                }
            }
            
        }

        private void Buy_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int clientID = 0;
                string todayDate = DateTime.Today.ToString("yyyy-MM-dd");
                int secID = securitiesAdapter.GetData().ElementAt(Securities_ComboBox.SelectedIndex).ID_Securities;
                foreach (var item in clientsAdapter.GetData())
                {
                    if (item.User_Stock_Exchange_ID == ID_UserReg)
                    {
                        clientID = item.ID_Clients;
                    }
                }
                if (ErrorInsertTextBox(Quantity_TextBox, AmountContr_TextBox, DateComplit_TextBox) && ErrorInsertComboBox(Securities_ComboBox, MethodPay_ComboBox))
                {
                    transAdapter.InsertTrans(todayDate, DateComplUser, UserQuantity, secID, clientID, UserMethodPay, status, rnd.Next(0, brokerAdapter.GetData().Rows.Count - 1));
                    receiptAdapter.InsertReceipt((UserQuantity * priceSec), amountUser, Math.Round((amountUser - (UserQuantity * priceSec)), 2), transAdapter.GetData().Last().ID_Securities_Transaction);
                }
            }
            catch
            {
                MessageBox.Show("Введите все значения");
            }
            
        }
    }
}
