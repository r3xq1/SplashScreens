namespace SplashEx
{
    partial class ViewSplash
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
            this.SplashScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.SplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.SplashScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplashScreen.Image = global::SplashEx.Properties.Resources.SplashPicture;
            this.SplashScreen.Location = new System.Drawing.Point(0, 0);
            this.SplashScreen.Name = "SplashScreen";
            this.SplashScreen.Size = new System.Drawing.Size(508, 315);
            this.SplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SplashScreen.TabIndex = 0;
            this.SplashScreen.TabStop = false;
            // 
            // ViewSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(508, 315);
            this.Controls.Add(this.SplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashEx";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashScreen;
    }
}

