namespace Pizza_Order_Project
{
    partial class AboutUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.btnClosePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClosePage
            // 
            this.btnClosePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClosePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePage.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePage.ForeColor = System.Drawing.Color.Black;
            this.btnClosePage.Location = new System.Drawing.Point(621, 392);
            this.btnClosePage.Name = "btnClosePage";
            this.btnClosePage.Size = new System.Drawing.Size(153, 46);
            this.btnClosePage.TabIndex = 0;
            this.btnClosePage.Text = "Back";
            this.btnClosePage.UseVisualStyleBackColor = false;
            this.btnClosePage.Click += new System.EventHandler(this.btnClosePage_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClosePage);
            this.DoubleBuffered = true;
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClosePage;
    }
}