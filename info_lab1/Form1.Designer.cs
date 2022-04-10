namespace show_info_lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.get_txt_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.output_txt_box = new System.Windows.Forms.TextBox();
            this.var_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // get_txt_box
            // 
            this.get_txt_box.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_txt_box.Location = new System.Drawing.Point(12, 32);
            this.get_txt_box.Name = "get_txt_box";
            this.get_txt_box.Size = new System.Drawing.Size(325, 27);
            this.get_txt_box.TabIndex = 0;
            this.get_txt_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.Location = new System.Drawing.Point(57, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show variable value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output_txt_box
            // 
            this.output_txt_box.Location = new System.Drawing.Point(12, 114);
            this.output_txt_box.Multiline = true;
            this.output_txt_box.Name = "output_txt_box";
            this.output_txt_box.Size = new System.Drawing.Size(650, 324);
            this.output_txt_box.TabIndex = 2;
            // 
            // var_list
            // 
            this.var_list.FormattingEnabled = true;
            this.var_list.Location = new System.Drawing.Point(696, 57);
            this.var_list.Name = "var_list";
            this.var_list.Size = new System.Drawing.Size(120, 381);
            this.var_list.TabIndex = 3;
            this.var_list.SelectedIndexChanged += new System.EventHandler(this.var_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter variable name ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(662, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Showed variables list";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.var_list);
            this.Controls.Add(this.output_txt_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.get_txt_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox get_txt_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox output_txt_box;
        private System.Windows.Forms.ListBox var_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

