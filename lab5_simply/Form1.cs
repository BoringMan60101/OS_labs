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
    public partial class Form1 : Form
    {

        string put = "C:/"; //сначала отображаем содержимое корневого каталога

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //обработка кнопки "назад"
        {
            //По нажатию кнопки "назад" отображается содержимое каталога (папки) предыдущей (на уровень выше)
            listBox1.Items.Clear(); //освобождение поля от предыдущей записи
            DirectoryInfo pred_dir = Directory.GetParent(put); //получение объекта - родительского каталога
            if (pred_dir == null) //проверка, если родителя уже нет (самый высокий уровень)
            {
                put = "C:/"; //мы фактически и так в этом каталоге, но запишем его ещё раз
                MessageBox.Show("достигнут корневой каталог (выше некуда)"); //вывод соответсвующего сообщения
            }
            else
                put = pred_dir.FullName; //если есть родительский каталог (на уровень выше)

            string[] papki = Directory.GetDirectories(put); //получение папок в данном каталоге
            foreach (string dir in papki) //вывод папок
                listBox1.Items.Add(dir);
            string[] files = Directory.GetFiles(put); //получение файлов (их имён)
            foreach (string dir in files) //вывод
                listBox1.Items.Add(dir);
        }

        private void button2_Click(object sender, EventArgs e) //обработка кнопки "отобразить"
        {
            //Отображает содержимое введённо вручную каталога (из TextBox)
            put = textBox1.Text; //получили введёный вручную путь
            //if {} else - обработка ошибочного и существующего пути
            if(Directory.Exists(put) == false)
            {
                MessageBox.Show("введён неправильный путь к папке");
                return;
            }
            try
            {
                listBox1.Items.Clear(); //освобождение поля от предыдущей записи
                //ниже вывод сначала папок, потом каталогов выбранного каталога
                string[] papki = Directory.GetDirectories(put); 
                foreach (string dir in papki)
                    listBox1.Items.Add(dir);
                string[] files = Directory.GetFiles(put);
                foreach (string dir in files)
                    listBox1.Items.Add(dir);
            }
            catch 
            { MessageBox.Show("ошибка при открытии папки"); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //этот код запустится сразу после запуска программы
        {
            //при запуске программы сразу выводится содержимое корневого каталога (диск С)
            string[] papki = Directory.GetDirectories(put);
            foreach (string dir in papki)
                listBox1.Items.Add(dir);
            string[] files = Directory.GetFiles(put);
            foreach (string dir in files)
                listBox1.Items.Add(dir);
        }
    }
}
