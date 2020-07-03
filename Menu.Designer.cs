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
            this.buttonSUDENT = new System.Windows.Forms.Button();
            this.buttonDIS = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSUDENT
            // 
            this.buttonSUDENT.Location = new System.Drawing.Point(52, 58);
            this.buttonSUDENT.Name = "buttonSUDENT";
            this.buttonSUDENT.Size = new System.Drawing.Size(75, 23);
            this.buttonSUDENT.TabIndex = 0;
            this.buttonSUDENT.Text = "Студент";
            this.buttonSUDENT.UseVisualStyleBackColor = true;
            this.buttonSUDENT.Click += new System.EventHandler(this.buttonSUDENT_Click);
            // 
            // buttonDIS
            // 
            this.buttonDIS.Location = new System.Drawing.Point(52, 87);
            this.buttonDIS.Name = "buttonDIS";
            this.buttonDIS.Size = new System.Drawing.Size(75, 23);
            this.buttonDIS.TabIndex = 1;
            this.buttonDIS.Text = "дисциплина";
            this.buttonDIS.UseVisualStyleBackColor = true;
            this.buttonDIS.Click += new System.EventHandler(this.buttonDIS_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 265);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDIS);
            this.Controls.Add(this.buttonSUDENT);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSUDENT;
        private System.Windows.Forms.Button buttonDIS;
        private System.Windows.Forms.Button button3;
    }
}