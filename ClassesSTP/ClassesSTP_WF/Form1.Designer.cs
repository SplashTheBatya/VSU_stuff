namespace ClassesSTP_WF
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
            this.MarksBox = new System.Windows.Forms.TextBox();
            this.MinAvgResultShowBox = new System.Windows.Forms.TextBox();
            this.MaxAvgResultShowBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.ShowMostEffStud = new System.Windows.Forms.Button();
            this.ShowLessEffStud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MarksBox
            // 
            this.MarksBox.Location = new System.Drawing.Point(46, 113);
            this.MarksBox.Name = "MarksBox";
            this.MarksBox.Size = new System.Drawing.Size(252, 20);
            this.MarksBox.TabIndex = 0;
            // 
            // MinAvgResultShowBox
            // 
            this.MinAvgResultShowBox.Location = new System.Drawing.Point(479, 329);
            this.MinAvgResultShowBox.Name = "MinAvgResultShowBox";
            this.MinAvgResultShowBox.Size = new System.Drawing.Size(252, 20);
            this.MinAvgResultShowBox.TabIndex = 1;
            // 
            // MaxAvgResultShowBox
            // 
            this.MaxAvgResultShowBox.Location = new System.Drawing.Point(479, 241);
            this.MaxAvgResultShowBox.Name = "MaxAvgResultShowBox";
            this.MaxAvgResultShowBox.Size = new System.Drawing.Size(252, 20);
            this.MaxAvgResultShowBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(46, 54);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(252, 20);
            this.NameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Оценки студента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Студент с самым высоким средним балом";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Студент с самым низким средним балом";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(46, 164);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(75, 23);
            this.AddStudentButton.TabIndex = 8;
            this.AddStudentButton.Text = "Добавить";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // ShowMostEffStud
            // 
            this.ShowMostEffStud.Location = new System.Drawing.Point(363, 241);
            this.ShowMostEffStud.Name = "ShowMostEffStud";
            this.ShowMostEffStud.Size = new System.Drawing.Size(75, 23);
            this.ShowMostEffStud.TabIndex = 9;
            this.ShowMostEffStud.Text = "Показать";
            this.ShowMostEffStud.UseVisualStyleBackColor = true;
            this.ShowMostEffStud.Click += new System.EventHandler(this.ShowMostEffStud_Click);
            // 
            // ShowLessEffStud
            // 
            this.ShowLessEffStud.Location = new System.Drawing.Point(363, 329);
            this.ShowLessEffStud.Name = "ShowLessEffStud";
            this.ShowLessEffStud.Size = new System.Drawing.Size(75, 23);
            this.ShowLessEffStud.TabIndex = 10;
            this.ShowLessEffStud.Text = "Показать";
            this.ShowLessEffStud.UseVisualStyleBackColor = true;
            this.ShowLessEffStud.Click += new System.EventHandler(this.ShowLessEffStud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowLessEffStud);
            this.Controls.Add(this.ShowMostEffStud);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.MaxAvgResultShowBox);
            this.Controls.Add(this.MinAvgResultShowBox);
            this.Controls.Add(this.MarksBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MarksBox;
        private System.Windows.Forms.TextBox MinAvgResultShowBox;
        private System.Windows.Forms.TextBox MaxAvgResultShowBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button ShowMostEffStud;
        private System.Windows.Forms.Button ShowLessEffStud;
    }
}

