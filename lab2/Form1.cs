namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //весь код ниже будет выполняется только после нажатия кнопки
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog(); //создание экземпляра класса OpenFileDialog1
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt"; //установка фильтра

            //написанный ниже код выполнится только после того, как будет выбран файл
            // и будет нажата кнопка выбора 'ОК'
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                //создание массива строк из файла, размер поределится автоматически
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                    int l_num = lines.Length; //узнали общее число строк

                    //вывод исходного файла в том же порядке
                    //foreach (string str in lines) listBox1.Items.Add(str);
                    string buf;
                    for (int i = 1; i < l_num; i++) //сортировка, считанных из файла строк
                        for (int j = i; j > 0; j--)
                            if (lines[j].Length < lines[j - 1].Length)
                            //if(String.Compare(lines[j], lines[j-1]) < 0)
                            {
                                buf = lines[j];
                                lines[j] = lines[j - 1];
                                lines[j - 1] = buf;
                            }

                    /*
                    в Си# есть 4 вида циклов, известные нам for, while, do while и foreach
                    foreach (date_type item in collection)
                    { / code / } 
                    если тип данных элементов коллекции не известен, то можно использовать слово 'var'
                    */
                    //добавление в listbox каждой строки из отсортированного массива 
                    foreach (string line in lines)
                        listBox1.Items.Add(line);
                }
                catch
                {
                    MessageBox.Show("Неизвестная ошибка при открытии файла " + openFileDialog1.FileName);
                }
            }

        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }   
    }
}