using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumbersToWords.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            //creating the object of WCF service client     
            ServiceReference1.ConversionServiceClient service = new ServiceReference1.ConversionServiceClient();


            //assigning the output value from service Response     
            ServiceReference1.Response response = service.Convert(textBox1.Text);

            //assigning the output value to the lable to show user     
            label2.Text += response.error != null ? response.error : response.result;
        }
    }
}
