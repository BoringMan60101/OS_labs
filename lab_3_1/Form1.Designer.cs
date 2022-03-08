namespace lab_3_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_invert_text = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.but_delete_words = new System.Windows.Forms.Button();
            this.but_check_number = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_invert_text
            // 
            this.but_invert_text.Location = new System.Drawing.Point(12, 332);
            this.but_invert_text.Name = "but_invert_text";
            this.but_invert_text.Size = new System.Drawing.Size(247, 106);
            this.but_invert_text.TabIndex = 0;
            this.but_invert_text.Text = "Вывести текст в обратном порядке";
            this.but_invert_text.UseVisualStyleBackColor = true;
            this.but_invert_text.Click += new System.EventHandler(this.but_invert_text_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(776, 314);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // but_delete_words
            // 
            this.but_delete_words.Location = new System.Drawing.Point(265, 332);
            this.but_delete_words.Name = "but_delete_words";
            this.but_delete_words.Size = new System.Drawing.Size(270, 106);
            this.but_delete_words.TabIndex = 2;
            this.but_delete_words.Text = "Удалить слова, начинающиеся с букв \"А\", \"Я\"";
            this.but_delete_words.UseVisualStyleBackColor = true;
            this.but_delete_words.Click += new System.EventHandler(this.but_delete_words_Click);
            // 
            // but_check_number
            // 
            this.but_check_number.Location = new System.Drawing.Point(541, 332);
            this.but_check_number.Name = "but_check_number";
            this.but_check_number.Size = new System.Drawing.Size(247, 106);
            this.but_check_number.TabIndex = 3;
            this.but_check_number.Text = "Проверить, является ли число простым";
            this.but_check_number.UseVisualStyleBackColor = true;
            this.but_check_number.Click += new System.EventHandler(this.but_check_number_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_check_number);
            this.Controls.Add(this.but_delete_words);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.but_invert_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button but_invert_text;
        private TextBox textBox;
        private Button but_delete_words;
        private Button but_check_number;
    }
}