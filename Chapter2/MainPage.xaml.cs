using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Chapter2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            myLable.Text = "name is " + name + "\nx is " + x + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 10;
            if(x == 10)
            {
                myLable.Text = "x must be 10";
            }
            else
            {
                myLable.Text = "x isn't 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "hello";
            if ((someValue == 3) && (name == "joe"))
            {
                myLable.Text = "x is 3 and name is Joe";
            }
            myLable.Text = "this line runs no matter what";

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while(count < 10)
            {
                count++;
            }
            for(int i = 0; i<5; i++)
            {
                count--;
            }
            myLable.Text = "The answer is " + count;
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox1.IsChecked == true)
            {
                if (labelToChange.Text == "Right") {
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Left;
                    labelToChange.Text = "Left";
                }
                else {
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Right;
                    labelToChange.Text = "Right";
                }
            }
            else
            {
                labelToChange.Text = "Text changing is disabled";
            }
        }
    }
}
