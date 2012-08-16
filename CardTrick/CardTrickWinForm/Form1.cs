using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace CardTrickWinForm
{
    public partial class Form1 : Form
    {
        List<int> deck = new List<int>();
        List<int> pool1 = new List<int>();
        List<int> pool2 = new List<int>();
        List<int> pool3 = new List<int>();
        int turn = 1;


        public Form1()
        {
            InitializeComponent();
        }

        private void showresult()
        {
            MessageBox.Show(deck[Convert.ToInt32(ConfigurationManager.AppSettings["pointer"].ToString())].ToString());
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            turn = 1;
            Initializedeck();
            dissemimate();
            print();
        }

        private void print()
        {
            lbxpool1.DataSource = pool1;
            lbxpool2.DataSource = pool2;
            lbxpool3.DataSource = pool3;
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
            int count = Convert.ToInt32(ConfigurationManager.AppSettings["total"].ToString());
            count++;

            deck = new List<int>();
            for (int i = 1; i < count; i++)
            {
                deck.Add(i);
            }
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
