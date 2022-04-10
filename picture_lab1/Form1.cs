using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer_lab_1
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

        private void open_img_but_Click(object sender, EventArgs e)
        {
            //фильтр = "описаниефильтра|маскa1;маска2;....маскаN;|описание2.....";
            openFileDialog1.Filter = "Только изображения (*.BMP;*.JPG;*.GIF)|*.BMP;*JPG;*.GIF|Все файлы (*.*)|(*.*)";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image_box.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбранный файл не является изображением. Выберите другой файл.");
                }
            }
            else
                MessageBox.Show("Окно было закрыто");

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void image_box_Click(object sender, EventArgs e)
        {

        }
    }
}
