/*
 * Name: Riley de Gans
 * Date: May 27th, 2019
 * Description: Converts integers into binary
 */
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

namespace _184863BinaryNumbers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblOutput.Content = "";
            for (int i = 0; i < 20; i++)
            {
                lblOutput.Content += (i + 1) + "\t" + toBinary(i + 1) + "\n";
            }
        }
        public int toBinary (int input)
        {
            int maxNum = 0;
            int counter = 0;
            while (maxNum <= input)
            {
                counter++;
                maxNum = (int)(Math.Pow(2, counter));
            }
            string finalNum = "";
            maxNum = 0;
            for (int i = counter; i > -1; i--)
            {
                if (maxNum + Math.Pow(2, i) <= input)
                {
                    maxNum += (int)(Math.Pow(2, i));
                    finalNum += "1";
                }
                else
                {
                    finalNum += "0";
                }
            }
            int output;
            int.TryParse(finalNum, out output);
            return output;
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int input;
            int.TryParse(txtInput.Text, out input);
            lblOutput.Content = input + "\t" + toBinary(input);
            txtInput.Text = "";
        }
    }
}
