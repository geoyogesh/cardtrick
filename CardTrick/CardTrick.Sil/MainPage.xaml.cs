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
    public partial class MainPage : UserControl
    {
        List<int> deck = new List<int>();
        List<int> pool1 = new List<int>();
        List<int> pool2 = new List<int>();
        List<int> pool3 = new List<int>();
        int turn = 1;


        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            turn = 1;
            Initializedeck();
            dissemimate();
            print();
            txtTip.Text = "Start:- Choose any card and press the 'Set' button based on the card in your mind";
        }

        private void showresult()
        {
            Result result = new Result(deck[10]);
            result.Show();
            //MessageBox.Show(deck[10].ToString());
            MainPage_Loaded(null, null);
        }


        private void print()
        {
            sppool1.Children.Clear();
            sppool2.Children.Clear();
            sppool3.Children.Clear();

            foreach (var item in pool1)
            {
                Image img = new Image();
                string url = "Images/" + item + ".png";
                img.Source = new BitmapImage(new Uri(url, UriKind.RelativeOrAbsolute));
                img.Height = 96;
                img.Width = 72;
                img.VerticalAlignment = VerticalAlignment.Top;
                img.Margin = new Thickness(10);
                sppool1.Children.Add(img);
            }

            foreach (var item in pool2)
            {
                Image img = new Image();
                string url = "Images/" + item + ".png";
                img.Source = new BitmapImage(new Uri(url, UriKind.RelativeOrAbsolute));
                img.Height = 96;
                img.Width = 72;
                img.VerticalAlignment = VerticalAlignment.Top;
                img.Margin = new Thickness(10);
                sppool2.Children.Add(img);
            }
            foreach (var item in pool3)
            {
                Image img = new Image();
                string url = "Images/" + item + ".png";
                img.Source = new BitmapImage(new Uri(url, UriKind.RelativeOrAbsolute));
                img.Height = 96;
                img.Width = 72;
                img.VerticalAlignment = VerticalAlignment.Top;
                img.Margin = new Thickness(10);
                sppool3.Children.Add(img);
            }
            
            //lbxpool1.ItemsSource = pool1;
            //lbxpool2.ItemsSource = pool2;
            //lbxpool3.ItemsSource = pool3;
        }

        private void dissemimate()
        {
            pool1 = new List<int>();
            pool2 = new List<int>();
            pool3 = new List<int>();
            for (int i = 0; i < deck.Count; i++)
            {
                pool1.Add(deck[i]);
                pool2.Add(deck[i + 1]);
                pool3.Add(deck[i + 2]);
                i += 2;
            }
        }

        private void Initializedeck()
        {
            deck = new List<int>();
            for (int i = 1; i < 22; i++)
            {
                deck.Add(i);
            }
            deck.Shuffle();
        }

        private void btnpool1_Click(object sender, EventArgs e)
        {
            deck = new List<int>();
            deck.AddRange(pool2);
            deck.AddRange(pool1);
            deck.AddRange(pool3);

            iteration();
        }

        private void iteration()
        {
            deck.Reverse();
            if (turn != 3)
            {
                txtTip.Text = "Turn: " + turn + " cards are shuffled.... press the 'Set' button based on the card in your mind. In 3rd Turn we will show the card";
                dissemimate();
                print();
                turn++;
            }
            else
            {
                showresult();
            }
        }

        private void btnpool2_Click(object sender, EventArgs e)
        {
            deck = new List<int>();
            deck.AddRange(pool1);
            deck.AddRange(pool2);
            deck.AddRange(pool3);

            iteration();
        }

        private void btnpool3_Click(object sender, EventArgs e)
        {
            deck = new List<int>();
            deck.AddRange(pool1);
            deck.AddRange(pool3);
            deck.AddRange(pool2);

            iteration();
        }




    }
}
