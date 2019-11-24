namespace CG_Task4_
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.CanvasLabel = new System.Windows.Forms.Label();
            this.DrawLineButton = new System.Windows.Forms.Button();
            this.ReDrawButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.labelMouseY = new System.Windows.Forms.Label();
            this.labelMouseX = new System.Windows.Forms.Label();
            this.mousePosYLabel = new System.Windows.Forms.Label();
            this.mousePosXLabel = new System.Windows.Forms.Label();
            this.FirstLineTable = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondLineTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstLineTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondLineTable)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(13, 13);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(448, 425);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // CanvasLabel
            // 
            this.CanvasLabel.AutoSize = true;
            this.CanvasLabel.Location = new System.Drawing.Point(21, 22);
            this.CanvasLabel.Name = "CanvasLabel";
            this.CanvasLabel.Size = new System.Drawing.Size(43, 13);
            this.CanvasLabel.TabIndex = 2;
            this.CanvasLabel.Text = "Canvas";
            // 
            // DrawLineButton
            // 
            this.DrawLineButton.Location = new System.Drawing.Point(467, 126);
            this.DrawLineButton.Name = "DrawLineButton";
            this.DrawLineButton.Size = new System.Drawing.Size(75, 23);
            this.DrawLineButton.TabIndex = 3;
            this.DrawLineButton.Text = "Draw Line";
            this.DrawLineButton.UseVisualStyleBackColor = true;
            this.DrawLineButton.Click += new System.EventHandler(this.DrawLineButton_Click);
            // 
            // ReDrawButton
            // 
            this.ReDrawButton.Location = new System.Drawing.Point(470, 386);
            this.ReDrawButton.Name = "ReDrawButton";
            this.ReDrawButton.Size = new System.Drawing.Size(75, 23);
            this.ReDrawButton.TabIndex = 4;
            this.ReDrawButton.Text = "ReDraw";
            this.ReDrawButton.UseVisualStyleBackColor = true;
            this.ReDrawButton.Click += new System.EventHandler(this.ReDrawButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(470, 415);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // labelMouseY
            // 
            this.labelMouseY.AutoSize = true;
            this.labelMouseY.Location = new System.Drawing.Point(467, 32);
            this.labelMouseY.Name = "labelMouseY";
            this.labelMouseY.Size = new System.Drawing.Size(49, 13);
            this.labelMouseY.TabIndex = 6;
            this.labelMouseY.Text = "MouseY:";
            // 
            // labelMouseX
            // 
            this.labelMouseX.AutoSize = true;
            this.labelMouseX.Location = new System.Drawing.Point(467, 9);
            this.labelMouseX.Name = "labelMouseX";
            this.labelMouseX.Size = new System.Drawing.Size(49, 13);
            this.labelMouseX.TabIndex = 7;
            this.labelMouseX.Text = "MouseX:";
            // 
            // mousePosYLabel
            // 
            this.mousePosYLabel.AutoSize = true;
            this.mousePosYLabel.Location = new System.Drawing.Point(522, 32);
            this.mousePosYLabel.Name = "mousePosYLabel";
            this.mousePosYLabel.Size = new System.Drawing.Size(19, 13);
            this.mousePosYLabel.TabIndex = 8;
            this.mousePosYLabel.Text = "....";
            // 
            // mousePosXLabel
            // 
            this.mousePosXLabel.AutoSize = true;
            this.mousePosXLabel.Location = new System.Drawing.Point(522, 9);
            this.mousePosXLabel.Name = "mousePosXLabel";
            this.mousePosXLabel.Size = new System.Drawing.Size(19, 13);
            this.mousePosXLabel.TabIndex = 9;
            this.mousePosXLabel.Text = "....";
            // 
            // FirstLineTable
            // 
            this.FirstLineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstLineTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.Y1});
            this.FirstLineTable.Location = new System.Drawing.Point(548, 32);
            this.FirstLineTable.Name = "FirstLineTable";
            this.FirstLineTable.Size = new System.Drawing.Size(250, 150);
            this.FirstLineTable.TabIndex = 10;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            // 
            // Y1
            // 
            this.Y1.HeaderText = "Y1";
            this.Y1.Name = "Y1";
            // 
            // SecondLineTable
            // 
            this.SecondLineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondLineTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.SecondLineTable.Location = new System.Drawing.Point(548, 288);
            this.SecondLineTable.Name = "SecondLineTable";
            this.SecondLineTable.Size = new System.Drawing.Size(250, 150);
            this.SecondLineTable.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X2";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Y2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecondLineTable);
            this.Controls.Add(this.FirstLineTable);
            this.Controls.Add(this.mousePosXLabel);
            this.Controls.Add(this.mousePosYLabel);
            this.Controls.Add(this.labelMouseX);
            this.Controls.Add(this.labelMouseY);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ReDrawButton);
            this.Controls.Add(this.DrawLineButton);
            this.Controls.Add(this.CanvasLabel);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstLineTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondLineTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label CanvasLabel;
        private System.Windows.Forms.Button DrawLineButton;
        private System.Windows.Forms.Button ReDrawButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label labelMouseY;
        private System.Windows.Forms.Label labelMouseX;
        private System.Windows.Forms.Label mousePosYLabel;
        private System.Windows.Forms.Label mousePosXLabel;
        private System.Windows.Forms.DataGridView FirstLineTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y1;
        private System.Windows.Forms.DataGridView SecondLineTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

