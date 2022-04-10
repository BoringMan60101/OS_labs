namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog(); 
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                    int l_num = lines.Length;
                    string buf;
                    for (int i = 1; i < l_num; i++) 
                        for (int j = i; j > 0; j--)
                            if (lines[j].Length < lines[j - 1].Length)
                            {
                                buf = lines[j];
                                lines[j] = lines[j - 1];
                                lines[j - 1] = buf;
                            }

    
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