namespace SDAM
{
    partial class BALLL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BALLL));
            this.comboBoxSUDENT = new System.Windows.Forms.ComboBox();
            this.comboBoxDIS = new System.Windows.Forms.ComboBox();
            this.textBoxBALL = new System.Windows.Forms.TextBox();
            this.ListViewBALL = new System.Windows.Forms.ListView();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSUDENT = new System.Windows.Forms.Label();
            this.labelDIS = new System.Windows.Forms.Label();
            this.labelBALL = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBoxSUDENT
            // 
            this.comboBoxSUDENT.FormattingEnabled = true;
            this.comboBoxSUDENT.Location = new System.Drawing.Point(12, 33);
            this.comboBoxSUDENT.Name = "comboBoxSUDENT";
            this.comboBoxSUDENT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSUDENT.TabIndex = 0;
            // 
            // comboBoxDIS
            // 
            this.comboBoxDIS.FormattingEnabled = true;
            this.comboBoxDIS.Location = new System.Drawing.Point(12, 80);
            this.comboBoxDIS.Name = "comboBoxDIS";
            this.comboBoxDIS.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDIS.TabIndex = 1;
            // 
            // textBoxBALL
            // 
            this.textBoxBALL.Location = new System.Drawing.Point(12, 130);
            this.textBoxBALL.Name = "textBoxBALL";
            this.textBoxBALL.Size = new System.Drawing.Size(100, 20);
            this.textBoxBALL.TabIndex = 2;
            // 
            // ListViewBALL
            // 
            this.ListViewBALL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ListViewBALL.FullRowSelect = true;
            this.ListViewBALL.GridLines = true;
            this.ListViewBALL.HideSelection = false;
            this.ListViewBALL.Location = new System.Drawing.Point(139, 12);
            this.ListViewBALL.MultiSelect = false;
            this.ListViewBALL.Name = "ListViewBALL";
            this.ListViewBALL.Size = new System.Drawing.Size(291, 157);
            this.ListViewBALL.TabIndex = 19;
            this.ListViewBALL.UseCompatibleStateImageBehavior = false;
            this.ListViewBALL.View = System.Windows.Forms.View.Details;
            this.ListViewBALL.SelectedIndexChanged += new System.EventHandler(this.ListViewBALL_SelectedIndexChanged);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(335, 175);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 24;
            this.buttonDel.Text = "УДАЛИТЬ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(241, 175);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 23);
            this.buttonEdit.TabIndex = 23;
            this.buttonEdit.Text = "ОБНОВИТЬ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(160, 175);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "СОЗДАТЬ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSUDENT
            // 
            this.labelSUDENT.AutoSize = true;
            this.labelSUDENT.BackColor = System.Drawing.Color.White;
            this.labelSUDENT.Location = new System.Drawing.Point(13, 14);
            this.labelSUDENT.Name = "labelSUDENT";
            this.labelSUDENT.Size = new System.Drawing.Size(47, 13);
            this.labelSUDENT.TabIndex = 25;
            this.labelSUDENT.Text = "Студент";
            // 
            // labelDIS
            // 
            this.labelDIS.AutoSize = true;
            this.labelDIS.BackColor = System.Drawing.Color.White;
            this.labelDIS.Location = new System.Drawing.Point(13, 57);
            this.labelDIS.Name = "labelDIS";
            this.labelDIS.Size = new System.Drawing.Size(70, 13);
            this.labelDIS.TabIndex = 26;
            this.labelDIS.Text = "Дисциплина";
            // 
            // labelBALL
            // 
            this.labelBALL.AutoSize = true;
            this.labelBALL.BackColor = System.Drawing.Color.White;
            this.labelBALL.Location = new System.Drawing.Point(13, 114);
            this.labelBALL.Name = "labelBALL";
            this.labelBALL.Size = new System.Drawing.Size(40, 13);
            this.labelBALL.TabIndex = 27;
            this.labelBALL.Text = "Баллы";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "фамилия";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "имя";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "группа";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "дисциплина";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "семестр";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "год";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "баллы";
            // 
            // BALLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(453, 247);
            this.Controls.Add(this.labelBALL);
            this.Controls.Add(this.labelDIS);
            this.Controls.Add(this.labelSUDENT);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ListViewBALL);
            this.Controls.Add(this.textBoxBALL);
            this.Controls.Add(this.comboBoxDIS);
            this.Controls.Add(this.comboBoxSUDENT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BALLL";
            this.Text = "BALLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSUDENT;
        private System.Windows.Forms.ComboBox comboBoxDIS;
        private System.Windows.Forms.TextBox textBoxBALL;
        private System.Windows.Forms.ListView ListViewBALL;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSUDENT;
        private System.Windows.Forms.Label labelDIS;
        private System.Windows.Forms.Label labelBALL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}