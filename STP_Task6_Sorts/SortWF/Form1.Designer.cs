namespace SortWF
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GetDataFromFileBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.IntQuickSortBtn = new System.Windows.Forms.Button();
            this.QuickSortDelegatedBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(213, 694);
            this.dataGridView1.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GetDataFromFileBtn
            // 
            this.GetDataFromFileBtn.BackColor = System.Drawing.SystemColors.Info;
            this.GetDataFromFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetDataFromFileBtn.Location = new System.Drawing.Point(272, 14);
            this.GetDataFromFileBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetDataFromFileBtn.Name = "GetDataFromFileBtn";
            this.GetDataFromFileBtn.Size = new System.Drawing.Size(209, 77);
            this.GetDataFromFileBtn.TabIndex = 1;
            this.GetDataFromFileBtn.Text = "Заполнить массив из документа";
            this.GetDataFromFileBtn.UseVisualStyleBackColor = false;
            this.GetDataFromFileBtn.Click += new System.EventHandler(this.GetDataFromFileBtn_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.BackColor = System.Drawing.SystemColors.Info;
            this.SaveFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveFileBtn.Location = new System.Drawing.Point(575, 14);
            this.SaveFileBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(126, 77);
            this.SaveFileBtn.TabIndex = 2;
            this.SaveFileBtn.Text = "Сохранить";
            this.SaveFileBtn.UseVisualStyleBackColor = false;
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // IntQuickSortBtn
            // 
            this.IntQuickSortBtn.BackColor = System.Drawing.SystemColors.Info;
            this.IntQuickSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IntQuickSortBtn.Location = new System.Drawing.Point(272, 223);
            this.IntQuickSortBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IntQuickSortBtn.Name = "IntQuickSortBtn";
            this.IntQuickSortBtn.Size = new System.Drawing.Size(209, 69);
            this.IntQuickSortBtn.TabIndex = 5;
            this.IntQuickSortBtn.Text = "Отсортировать числа int";
            this.IntQuickSortBtn.UseVisualStyleBackColor = false;
            this.IntQuickSortBtn.Click += new System.EventHandler(this.IntQuickSortBtn_Click);
            // 
            // QuickSortDelegatedBtn
            // 
            this.QuickSortDelegatedBtn.BackColor = System.Drawing.SystemColors.Info;
            this.QuickSortDelegatedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuickSortDelegatedBtn.Location = new System.Drawing.Point(272, 139);
            this.QuickSortDelegatedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuickSortDelegatedBtn.Name = "QuickSortDelegatedBtn";
            this.QuickSortDelegatedBtn.Size = new System.Drawing.Size(209, 67);
            this.QuickSortDelegatedBtn.TabIndex = 6;
            this.QuickSortDelegatedBtn.Text = "Отсортировать строки";
            this.QuickSortDelegatedBtn.UseVisualStyleBackColor = false;
            this.QuickSortDelegatedBtn.Click += new System.EventHandler(this.QuickSortDelegatedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.QuickSortDelegatedBtn);
            this.Controls.Add(this.IntQuickSortBtn);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.GetDataFromFileBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button GetDataFromFileBtn;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.Button IntQuickSortBtn;
        private System.Windows.Forms.Button QuickSortDelegatedBtn;
    }
}

