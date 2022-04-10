using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        int code = 0;
        void pisatel1(object mut)
        {
            Mutex mutex = mut as Mutex; 
            mutex.WaitOne();
            Random rand = new Random();
            int kol, i, j;
            string[] frukti = { "яблоко", "апельсин", "ананас", "банан", "груша", "авокадо", "лимон"};
            string vivod = "";
            kol = 1 + rand.Next() % 6;
            for (i = 0; i < kol; i++)
            {
                j = rand.Next() % 7;
                vivod = vivod + frukti[j] + " ";
            }
            textBox5.Text = vivod;
            code = 1;
            textBox1.Text = vivod;
            textBox2.Text = "";
            Thread.Sleep(2000);
            mutex.ReleaseMutex();
        }

        void pisatel2(object mut)
        {
            Mutex mutex = mut as Mutex;
            while (code != 2)
                Thread.Sleep(1000);
            mutex.WaitOne();
            Random rand = new Random();
            int kol, i, j;
            string[] mebel = { "стол", "стул", "шкаф", "кровать", "табуретка", "кресло", "комод"};
            string vivod = "";
            kol = 1 + rand.Next() % 6;
            for (i = 0; i < kol; i++)
            {
                j = rand.Next() % 7;
                vivod = vivod + mebel[j] + " ";
            }
            textBox5.Text = vivod;
            textBox2.Text = "";
            code = 3;
            textBox2.Text = vivod;
            Thread.Sleep(2000);
            mutex.ReleaseMutex();
        }

        void chitatel1(object mut)
        {
            while(code != 1)
                Thread.Sleep(1000);
            Mutex mutex = mut as Mutex;
            mutex.WaitOne();
            string[] slova = textBox5.Text.Split(); 
            int kol_sl_s_A = 0;
            for (int i = 0; i < slova.Length-1; i++)
            {
                if(slova[i][0] == 'а')
                    kol_sl_s_A++;
            }
            textBox5.Text = "";
            textBox3.Text = "Kolichestvo slov nachinayushixsya s bukvi A v obshem pole ravno = " + kol_sl_s_A.ToString();
            code = 2;
            Thread.Sleep(2000);
            mutex.ReleaseMutex();
        }

        void chitatel2(object mut)
        {
            Mutex mutex = mut as Mutex;
            while(code != 3)
                Thread.Sleep(1000);
            mutex.WaitOne();
            string[] slova = textBox5.Text.Split();
            int kol_slov = slova.Length-1;
            textBox5.Text = "";
            textBox4.Text = "Kolichestvo slov v obshem pole ravno = " + kol_slov.ToString();
            code = 4;
            Thread.Sleep(2000);
            mutex.ReleaseMutex();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Mutex mutex = new Mutex();
            Thread pis1 = new Thread(pisatel1);
            Thread pis2 = new Thread(pisatel2);
            Thread chit1 = new Thread(chitatel1);
            Thread chit2 = new Thread(chitatel2);
            pis1.Start(mutex);
            chit1.Start(mutex);
            pis2.Start(mutex);
            chit2.Start(mutex);
        }
    }
}
