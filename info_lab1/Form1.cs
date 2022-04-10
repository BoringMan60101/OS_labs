using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show_info_lab_1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var_name = get_txt_box.Text;
            string var_val = Environment.GetEnvironmentVariable(var_name);
            if (var_val != null)
            {
                output_txt_box.Text = var_val;
                var_list.Items.Add(get_txt_box.Text);
            }
            else
            {
                MessageBox.Show("Error! Unknown variable name.");
            }

        }

        private void var_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
