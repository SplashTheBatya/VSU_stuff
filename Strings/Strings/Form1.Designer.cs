namespace Strings
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.ReadFile = new System.Windows.Forms.Button();
            this.ButtonForCount = new System.Windows.Forms.Button();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxForSpecialWords = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(468, 693);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(681, 74);
            this.ReadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(112, 35);
            this.ReadFile.TabIndex = 1;
            this.ReadFile.Text = "ShowText";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // ButtonForCount
            // 
            this.ButtonForCount.Location = new System.Drawing.Point(681, 171);
            this.ButtonForCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonForCount.Name = "ButtonForCount";
            this.ButtonForCount.Size = new System.Drawing.Size(112, 35);
            this.ButtonForCount.TabIndex = 3;
            this.ButtonForCount.Text = "Count";
            this.ButtonForCount.UseVisualStyleBackColor = true;
            this.ButtonForCount.Click += new System.EventHandler(this.ButtonForCount_Click);
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(942, 180);
            this.TextBoxResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(187, 26);
            this.TextBoxResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Посчитать кол-во слов которые начинаются и заканчиваются одинаковыми символами\r\n";
            // 
            // TextBoxForSpecialWords
            // 
            this.TextBoxForSpecialWords.Location = new System.Drawing.Point(665, 361);
            this.TextBoxForSpecialWords.Name = "TextBoxForSpecialWords";
            this.TextBoxForSpecialWords.ReadOnly = true;
            this.TextBoxForSpecialWords.Size = new System.Drawing.Size(399, 96);
            this.TextBoxForSpecialWords.TabIndex = 6;
            this.TextBoxForSpecialWords.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Слова подходящие по условию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Колличество слов, удовлетворяющих условию\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxForSpecialWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.ButtonForCount);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.richTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Button ButtonForCount;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextBoxForSpecialWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

