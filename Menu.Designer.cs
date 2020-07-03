namespace SDAM
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonSUDENT = new System.Windows.Forms.Button();
            this.buttonDIS = new System.Windows.Forms.Button();
            this.buttonBALL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSUDENT
            // 
            this.buttonSUDENT.Location = new System.Drawing.Point(55, 117);
            this.buttonSUDENT.Name = "buttonSUDENT";
            this.buttonSUDENT.Size = new System.Drawing.Size(75, 23);
            this.buttonSUDENT.TabIndex = 0;
            this.buttonSUDENT.Text = "Студент";
            this.buttonSUDENT.UseVisualStyleBackColor = true;
            this.buttonSUDENT.Click += new System.EventHandler(this.buttonSUDENT_Click);
            // 
            // buttonDIS
            // 
            this.buttonDIS.Location = new System.Drawing.Point(55, 156);
            this.buttonDIS.Name = "buttonDIS";
            this.buttonDIS.Size = new System.Drawing.Size(75, 23);
            this.buttonDIS.TabIndex = 1;
            this.buttonDIS.Text = "дисциплина";
            this.buttonDIS.UseVisualStyleBackColor = true;
            this.buttonDIS.Click += new System.EventHandler(this.buttonDIS_Click);
            // 
            // buttonBALL
            // 
            this.buttonBALL.Location = new System.Drawing.Point(55, 196);
            this.buttonBALL.Name = "buttonBALL";
            this.buttonBALL.Size = new System.Drawing.Size(75, 23);
            this.buttonBALL.TabIndex = 2;
            this.buttonBALL.Text = "Баллы";
            this.buttonBALL.UseVisualStyleBackColor = true;
            this.buttonBALL.Click += new System.EventHandler(this.buttonBALL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SDAM.Properties.Resources.LOGOTIP;
            this.pictureBox1.Location = new System.Drawing.Point(45, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttong
            // 
            this.buttong.Location = new System.Drawing.Point(54, 230);
            this.buttong.Name = "buttong";
            this.buttong.Size = new System.Drawing.Size(75, 23);
            this.buttong.TabIndex = 4;
            this.buttong.Text = "ggg";
            this.buttong.UseVisualStyleBackColor = true;
            this.buttong.Click += new System.EventHandler(this.buttong_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(196, 265);
            this.Controls.Add(this.buttong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBALL);
            this.Controls.Add(this.buttonDIS);
            this.Controls.Add(this.buttonSUDENT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSUDENT;
        private System.Windows.Forms.Button buttonDIS;
        private System.Windows.Forms.Button buttonBALL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttong;
    }
}