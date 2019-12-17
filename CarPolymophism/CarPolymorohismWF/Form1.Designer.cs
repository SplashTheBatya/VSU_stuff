namespace CarPolymorohismWF
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
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.AddCarsBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ShowInfoBtn = new System.Windows.Forms.Button();
            this.NumberTxtBox = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miliage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.Number,
            this.FuelCapacity,
            this.FuelConsumption,
            this.Miliage,
            this.Capacity});
            this.dataGridViewCars.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewCars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(976, 231);
            this.dataGridViewCars.TabIndex = 0;
            // 
            // AddCarsBtn
            // 
            this.AddCarsBtn.Location = new System.Drawing.Point(82, 277);
            this.AddCarsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCarsBtn.Name = "AddCarsBtn";
            this.AddCarsBtn.Size = new System.Drawing.Size(170, 57);
            this.AddCarsBtn.TabIndex = 1;
            this.AddCarsBtn.Text = "Добавить машины";
            this.AddCarsBtn.UseVisualStyleBackColor = true;
            this.AddCarsBtn.Click += new System.EventHandler(this.AddCarsBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(618, 277);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(522, 379);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // ShowInfoBtn
            // 
            this.ShowInfoBtn.Location = new System.Drawing.Point(424, 568);
            this.ShowInfoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowInfoBtn.Name = "ShowInfoBtn";
            this.ShowInfoBtn.Size = new System.Drawing.Size(170, 91);
            this.ShowInfoBtn.TabIndex = 3;
            this.ShowInfoBtn.Text = "Показать информацию по номеру";
            this.ShowInfoBtn.UseVisualStyleBackColor = true;
            this.ShowInfoBtn.Click += new System.EventHandler(this.ShowInfoBtn_Click);
            // 
            // NumberTxtBox
            // 
            this.NumberTxtBox.Location = new System.Drawing.Point(354, 512);
            this.NumberTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumberTxtBox.Name = "NumberTxtBox";
            this.NumberTxtBox.Size = new System.Drawing.Size(238, 26);
            this.NumberTxtBox.TabIndex = 4;
            // 
            // Model
            // 
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            // 
            // FuelCapacity
            // 
            this.FuelCapacity.HeaderText = "Ёмкость бензобака";
            this.FuelCapacity.Name = "FuelCapacity";
            // 
            // FuelConsumption
            // 
            this.FuelConsumption.HeaderText = "Расход бензина";
            this.FuelConsumption.Name = "FuelConsumption";
            // 
            // Miliage
            // 
            this.Miliage.HeaderText = "Пробег";
            this.Miliage.Name = "Miliage";
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Кол-во мест или грузоподъёмность";
            this.Capacity.Name = "Capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.NumberTxtBox);
            this.Controls.Add(this.ShowInfoBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AddCarsBtn);
            this.Controls.Add(this.dataGridViewCars);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.Button AddCarsBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ShowInfoBtn;
        private System.Windows.Forms.TextBox NumberTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelConsumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miliage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
    }
}

