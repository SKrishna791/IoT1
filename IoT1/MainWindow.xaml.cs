using System;
using System.Collections.ObjectModel;
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
using GrpcClient;

namespace IoT1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Client client;
        public MainWindow()
        {
           //Client _client = new Client(""); 
           // string result= _client.GetServerId();
            

           // _client.GetListOfDevices();

                InitializeComponent();
            
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            client= new Client(""); //Add address
            string result = client.GetServerId();
            Test1.Text = result;
        }
    }
}
