namespace viewer_lab_1
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
            this.image_box = new System.Windows.Forms.PictureBox();
            this.open_img_but = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.image_box)).BeginInit();
            this.SuspendLayout();
            // 
            // image_box
            // 
            this.image_box.Location = new System.Drawing.Point(12, 12);
            this.image_box.Name = "image_box";
            this.image_box.Size = new System.Drawing.Size(805, 493);
            this.image_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_box.TabIndex = 0;
            this.image_box.TabStop = false;
            this.image_box.Click += new System.EventHandler(this.image_box_Click);
            // 
            // open_img_but
            // 
            this.open_img_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.open_img_but.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_img_but.Location = new System.Drawing.Point(12, 511);
            this.open_img_but.Name = "open_img_but";
            this.open_img_but.Size = new System.Drawing.Size(805, 50);
            this.open_img_but.TabIndex = 1;
            this.open_img_but.Text = "выбрать изображение";
            this.open_img_but.UseVisualStyleBackColor = true;
            this.open_img_but.Click += new System.EventHandler(this.open_img_but_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 573);
            this.Controls.Add(this.open_img_but);
            this.Controls.Add(this.image_box);
            this.Name = "Form1";
            this.Text = "Просмотр изображений";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image_box;
        private System.Windows.Forms.Button open_img_but;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

