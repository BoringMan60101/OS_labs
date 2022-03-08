namespace lab_3_1
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

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
        void invert_text()
        {
            char[] text = textBox.Text.ToCharArray();
            char buf;
            int len = text.Length - 1;
            //if(len % 2 != 0)
                
            for (int i = 0; i <= len / 2; i++)
            {
                buf = text[i];
                text[i] = text[len - i];
                text[len - i] = buf;
            }
            string output = new string(text);
            //textBox.Text = text.ToString();
            textBox.Text = output;
        }
        private void but_invert_text_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread invert_text_stream = new Thread(invert_text);
            invert_text_stream.Start();
        }

        void delete_words()
        {
            string str = textBox.Text.ToString();
            string[] raw_words = str.Split(' ');
            string[] out_words = new string[raw_words.Length];
            int i = 0;
            foreach (string word in raw_words)
                if (word[0] != 'А' && word[0] != 'Я' && word[0] != 'а' && word[0] != 'я')
                { out_words[i] = word; i++; }

            str = "";
            for(i = 0; i < out_words.Length; i++)
                str += out_words[i] + " ";
            textBox.Text = str;
        }
        private void but_delete_words_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread words_handler_stream = new Thread(delete_words);
            words_handler_stream.Start();
        }

        void check_number()
        {
            string data = textBox.Text.ToString();
            try
            {
                int num = Convert.ToInt32(data);
                if (num < 0)
                    num = -num;
                Boolean flag = true; //1 простое
                for (int i = 3; i < num; i++)
                    if (num % i == 0)
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                    textBox.Text = "Число " + data + " простое.";
                else
                    textBox.Text = "Число " + data + " не является простым.";
            }
            catch (FormatException)
            {
                string err_msg = "Ошибка с преобразованием к числу ввода '" + data + "'";
                MessageBox.Show(err_msg);
            }

        }
        private void but_check_number_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread check_num_stream = new Thread(check_number);
            check_num_stream.Start();
        }

        
    }
}