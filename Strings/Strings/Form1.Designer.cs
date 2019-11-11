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
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(313, 452);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(454, 48);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(75, 23);
            this.ReadFile.TabIndex = 1;
            this.ReadFile.Text = "Show";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // ButtonForCount
            // 
            this.ButtonForCount.Location = new System.Drawing.Point(454, 117);
            this.ButtonForCount.Name = "ButtonForCount";
            this.ButtonForCount.Size = new System.Drawing.Size(75, 23);
            this.ButtonForCount.TabIndex = 3;
            this.ButtonForCount.Text = "Count";
            this.ButtonForCount.UseVisualStyleBackColor = true;
            this.ButtonForCount.Click += new System.EventHandler(this.ButtonForCount_Click);
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(628, 117);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(126, 20);
            this.TextBoxResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.ButtonForCount);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.richTextBox);
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
    }
}

