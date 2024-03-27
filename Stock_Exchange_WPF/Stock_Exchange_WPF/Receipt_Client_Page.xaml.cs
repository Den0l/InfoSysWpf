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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Data;

namespace Stock_Exchange_WPF
{
    /// <summary>
    /// Логика взаимодействия для Receipt_Client_Page.xaml
    /// </summary>
    public partial class Receipt_Client_Page : Page
    {
        public int ID_UserReg { get; }
        private int clientID;
        Receipt_of_PaymentTableAdapter receiptAdapter = new Receipt_of_PaymentTableAdapter();
        ClientsTableAdapter clientsAdapter = new ClientsTableAdapter();
        public Receipt_Client_Page(int UserReg)
        {
            InitializeComponent();
            ID_UserReg = UserReg;

            foreach (var item in clientsAdapter.GetData())
            {
                if (item.User_Stock_Exchange_ID == ID_UserReg)
                {
                    clientID = item.ID_Clients;
                }
            }
            Receipt_DataGrid.ItemsSource = receiptAdapter.GetReceiptClient(clientID);  
        }

        private void SaveTxt_Button_Click(object sender, RoutedEventArgs e)
        {
            string path = "\\Квитанция";
            if (Receipt_DataGrid.SelectedItem == null )
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {
                DataRowView rowView = (DataRowView)Receipt_DataGrid.SelectedItem;
                int firstColumnValue = Convert.ToInt32(rowView.Row.ItemArray[0]);
                int eightColumnValue = Convert.ToInt32(rowView.Row.ItemArray[8]);
                string SixColumnValue = Convert.ToString(rowView.Row.ItemArray[6]);
                string SevenColumnValue = Convert.ToString(rowView.Row.ItemArray[7]);
                string thirdColumnValue = Convert.ToString(rowView.Row.ItemArray[13]);
                double fourColumnValue = Convert.ToDouble(rowView.Row.ItemArray[14]);
                int id = firstColumnValue;
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string file = "Квитанция №" + receiptAdapter.GetData().FindByID_Receipt_of_Payment(id).ID_Receipt_of_Payment + "\n" 
                + "Дата создания:" + SixColumnValue + "\n"
                + "Дата завершения:" + SevenColumnValue + "\n"
                + "Кол-во:" + eightColumnValue + "\n"
                + "Название:" + thirdColumnValue + "\n"
                + "Цена:" + fourColumnValue + "\n"
                + "Итоговая сумма:" + receiptAdapter.GetData().FindByID_Receipt_of_Payment(id).Total_Amount + "\n"
                + "Внесенная сумма:" + receiptAdapter.GetData().FindByID_Receipt_of_Payment(id).Contributed_Amount + "\n"
                + "Сдача:" + receiptAdapter.GetData().FindByID_Receipt_of_Payment(id).Surrender;
                for (int i = 1; i <= 100; i++)
                {
                    if (!File.Exists(desktopPath + path + i.ToString() + ".txt"))
                    {
                        path = path + i.ToString() + ".txt";
                        break;
                    }
                }

                File.WriteAllText(desktopPath+path, file);
                MessageBox.Show("Квитанция на рабочем столе");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Receipt_DataGrid.Columns[0].Visibility = Visibility.Collapsed;
            Receipt_DataGrid.Columns[4].Visibility = Visibility.Collapsed;
            Receipt_DataGrid.Columns[5].Visibility = Visibility.Collapsed;
            Receipt_DataGrid.Columns[9].Visibility = Visibility.Collapsed;
            Receipt_DataGrid.Columns[10].Visibility = Visibility.Collapsed;
            Receipt_DataGrid.Columns[11].Visibility = Visibility.Collapsed;
            Receipt_DataGrid.Columns[12].Visibility = Visibility.Collapsed;
            Receipt_DataGrid.Columns[15].Visibility = Visibility.Collapsed;

        }

    }
}
