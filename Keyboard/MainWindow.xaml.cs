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



namespace Keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public delegate void SetLetter(object sender);

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        //Testing the github
        //Testing github again with GitGui
        //Testing git hub gui

        
        
        private static string LetterManipulator(object sender)
        {
            Button send = sender as Button;

            return send.Content.ToString().ToLower();
        }
        

        private void txtBoxCursor_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
            System.Windows.Clipboard.SetText(txtBoxCursor.Text);
        }

        #region Letters of keyboard events

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             

            txtBoxCursor.AppendText(LetterManipulator(sender));
            
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender)); ;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));

        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            txtBoxCursor.AppendText(LetterManipulator(sender));
        } 
        #endregion
        
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

       

        private void Grid_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

        }

        

    }
}
