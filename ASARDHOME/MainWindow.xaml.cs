using System;
using System.Collections.Generic;
using System.IO.Ports;
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

namespace ASARDHOME
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort sp = new SerialPort();





        public void ComboSelectPort(object sender, RoutedEventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();


        }
        private void on_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                sp.Write("1");
            }
            catch (Exception)
            {
                MessageBox.Show("Proszę pierw włączyc ");
            }

        }

        private void Of_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sp.Write("0");
            }
            catch (Exception)
            {
                MessageBox.Show("Proszę pierw włączyc ");
            }
        }

        public void Connect_Click(object sender, RoutedEventArgs e)
        {
            Button asn = sender as Button;
            asn.Background = Brushes.Green;
            Rozłączony.Background = Brushes.Silver;
            status.Background = Brushes.Green;
            try
            {
                String portName = comport.Text;
                sp.PortName = portName;
                sp.BaudRate = 9600;
                sp.Open();
                status.Text = "Połączony";

            }
            catch (Exception)
            {

                MessageBox.Show("Prosze wybrac prawidłowy nr portu");
            }
        }

        public void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = Brushes.Red;
            Włączony.Background = Brushes.Silver;
            status.Background = Brushes.Red;
            try
            {
                sp.Write("0");
                sp.Close();
                status.Text = "Rozłączony";


            }
            catch (Exception)
            {

                MessageBox.Show("Pierw Połącz nastepnie Rozłącz");
            }
        }

        public void AddRange(object[] items)
        {

        }

    }
}
