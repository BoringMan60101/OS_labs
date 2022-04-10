using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
   
namespace lab5
{ 
    //КЛИКАТЬ 1 РАЗ (при выборе следующей директории из списка в listbox устанавливается 1-я выбранная)
    public partial class Form1 : Form
    {
        string prev = Environment.GetEnvironmentVariable("HOMEDRIVE") + "/"; 
        string next = Environment.GetEnvironmentVariable("HOMEDRIVE") + "/";
        string lbl1_text = "Содержимое директории ";
        string lbl2_text = "Выбранная директория ";
        int offset = 0;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }
        void func()
        {
            
            string[] tmp = prev.Split('\\');
            prev = "";
            for (int i = 0; i < tmp.Length - offset; i++)
                prev += tmp[i] + "\\";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            offset += 1;
            func();
            if(prev == "")
                prev = Environment.GetEnvironmentVariable("HOMEDRIVE") + "/";
            label1.Text = lbl1_text + prev;
            label2.Text = lbl2_text;
            string[] dir_ent = Directory.GetDirectories(prev);
            foreach (string dir in dir_ent)
                listBox1.Items.Add(dir);
            flag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {   string[] dir_ent = Directory.GetDirectories(next);
                foreach (string dir in dir_ent)
                    listBox1.Items.Add(dir);
                flag = false;
                label1.Text = lbl1_text + prev;
                label2.Text = lbl2_text;
            }
            catch 
            { MessageBox.Show("Ошибка при просмотре содержимого директории"); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag) return; //чтобы не было ошибок
            label1.Text = lbl1_text + prev;
            next = listBox1.SelectedItem.ToString();
            prev = next;
            label2.Text = lbl2_text + next;
            flag = true;
            offset = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dir_ent = Directory.GetDirectories(prev);
            foreach (string dir in dir_ent)
                listBox1.Items.Add(dir);
            label1.Text = lbl1_text + prev;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
