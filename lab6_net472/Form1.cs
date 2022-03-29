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

namespace lab6_net472
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mutex mutex = new Mutex();
        bool flag = true;
        void writer(object mut)
        {
            Mutex mutex = mut as Mutex;
            mutex.WaitOne();
            Random rnd = new Random();
            try
            {
                if (flag == true)
                {
                    int rnd_int = rnd.Next() % 100;
                    File.AppendAllText("C:/Users/alex2/Desktop/test.txt", rnd_int.ToString() + " \n");
                }
                flag = false;
            }
            catch(Exception)
            {
                Thread.Sleep(500);
            }
            Thread.Sleep(500);
            mutex.ReleaseMutex();
        }

        void reader(object mut)
        {
            Mutex mutex = mut as Mutex;
            mutex.WaitOne();
            textBox1.Text = String.Empty;
            try
            {
                if (flag == false)
                {
                    string[] f_data = File.ReadAllLines("C:/Users/alex2/Desktop/test.txt");
                    textBox1.Text = " ";
                    textBox1.Text = String.Empty;
                    textBox1.Clear();

                    textBox1.Text = File.ReadAllText("C:/Users/alex2/Desktop/test.txt");
                    flag = true;
                    Thread.Sleep(500);
                }
            }
            catch(Exception)
            {
                Thread.Sleep(500);
            }
            mutex.ReleaseMutex();
        }

        void func()
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread write = new Thread(writer);
            Thread read = new Thread(reader);
            while (read.ThreadState == ThreadState.Running)
                Thread.Sleep(500);
            write.Start(mutex);
            while (write.ThreadState == ThreadState.Running)
                Thread.Sleep(500);
            read.Start(mutex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                CheckForIllegalCrossThreadCalls = false;
                Thread write = new Thread(writer);
                Thread read = new Thread(reader);
                write.Start(mutex);
                read.Start(mutex);
        }

        void f_clean(object mut)
        {
            Mutex mutex = mut as Mutex;
            mutex.WaitOne();
            File.Delete("C:/Users/alex2/Desktop/test.txt");
            textBox1.Text = String.Empty;
            File.WriteAllText("C:/Users/alex2/Desktop/test.txt", String.Empty);
            Thread.Sleep(500);
            mutex.ReleaseMutex();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread f_cleaning = new Thread(f_clean);
            f_cleaning.Start(mutex);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thread_handler = new Thread(func);
            thread_handler.Start();
        }
    }
}
