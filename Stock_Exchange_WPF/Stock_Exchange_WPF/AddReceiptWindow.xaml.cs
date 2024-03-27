using Stock_Exchange_WPF.Stock_ExchangeDataSetTableAdapters;
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
    /// Логика взаимодействия для AddReceiptWindow.xaml
    /// </summary>
    public partial class AddReceiptWindow : Window
    {
        Securities_TransactionTableAdapter transAdapter = new Securities_TransactionTableAdapter();
        Receipt_of_PaymentTableAdapter receiptAdapter = new Receipt_of_PaymentTableAdapter();
        public AddReceiptWindow()
        {
            InitializeComponent();
        }

        private void AddRecep_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            if (Double.TryParse(AddRecep_Amount.Text, out double f) && (double.TryParse(AddRecep_User.Text, out double s) 
                && (double.TryParse(AddRecep_Surren.Text, out double t))))
            {
                receiptAdapter.InsertReceipt(f,s,t, transAdapter.GetData().Last().ID_Securities_Transaction);
                Close();
            }
            else if(AddRecep_Amount.Text == null || AddRecep_User.Text == null || AddRecep_Surren.Text == null)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                MessageBox.Show("Введите коректные числа (вместо запятой поставьте точку)");
            }
            }
            catch
            {
                MessageBox.Show("Некоректные данные");
            }

            
        }
    }
}
