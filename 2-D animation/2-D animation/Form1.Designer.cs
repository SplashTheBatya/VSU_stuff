namespace _2_D_animation
{
    partial class animation
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
            this.components = new System.ComponentModel.Container();
            this.timer_a = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_sunrise = new System.Windows.Forms.PictureBox();
            this.pictureBox_earth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sunrise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_earth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_sunrise
            // 
            this.pictureBox_sunrise.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_sunrise.Name = "pictureBox_sunrise";
            this.pictureBox_sunrise.Size = new System.Drawing.Size(770, 446);
            this.pictureBox_sunrise.TabIndex = 0;
            this.pictureBox_sunrise.TabStop = false;
            // 
            // pictureBox_earth
            // 
            this.pictureBox_earth.Location = new System.Drawing.Point(12, 457);
            this.pictureBox_earth.Name = "pictureBox_earth";
            this.pictureBox_earth.Size = new System.Drawing.Size(770, 122);
            this.pictureBox_earth.TabIndex = 1;
            this.pictureBox_earth.TabStop = false;
            // 
            // animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 607);
            this.Controls.Add(this.pictureBox_earth);
            this.Controls.Add(this.pictureBox_sunrise);
            this.Name = "animation";
            this.Text = "2D_animation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.animation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sunrise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_earth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_a;
        private System.Windows.Forms.PictureBox pictureBox_sunrise;
        private System.Windows.Forms.PictureBox pictureBox_earth;
    }
}

