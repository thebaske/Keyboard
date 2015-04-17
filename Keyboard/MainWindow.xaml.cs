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
using System.Windows;

namespace Keyboard
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
        
        //Testing the github

        private void txtBoxCursor_TextChanged(object sender, TextChangedEventArgs e)
        {
            System.Windows.Clipboard.SetText(txtBoxCursor.Text);
        }

        #region Letters of keyboard events
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("q");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("w");
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("e");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("r");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("t");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("y");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("u");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("i");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("o");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("p");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("a");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("s");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("d");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("f");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("g");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("h");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("j");

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("k");

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("l");

        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("z");
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("x");
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("c");
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("v");
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("b");
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("n");
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText("m");
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(" ");
        } 
        #endregion
        //TODO: Make all keyboard letters as one method

        //Delete character
        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            
            if (txtBoxCursor.Text.Length != 0)
            {
                char[] deleted = new char[txtBoxCursor.Text.Length - 1];
                int i = 0;
                foreach (var item in txtBoxCursor.Text)
                {

                    if (i <= txtBoxCursor.Text.Length - 2)
                    {
                        deleted[i] = item;
                    }
                    i++;
                }
                txtBoxCursor.Clear();
                foreach (var item in deleted)
                {
                    txtBoxCursor.AppendText(item.ToString());
                } 
            }
            
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.Clear();
        }

        

    }
}
