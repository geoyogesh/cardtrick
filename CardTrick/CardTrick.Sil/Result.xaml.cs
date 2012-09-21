using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CardTrick.Sil
{
    public partial class Result : ChildWindow
    {
        public Result(int Result)
        {
            InitializeComponent();
            //resulttext.Text = "The Card you have in your mind is " + Result;
            string url = "Images/" + Result + ".png";
            imgresult.Source = new BitmapImage(new Uri(url, UriKind.RelativeOrAbsolute));
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}

