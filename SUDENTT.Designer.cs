namespace SDAM
{
    partial class SUDENTT
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
            this.ListViewSUDENT = new System.Windows.Forms.ListView();
            this.textBoxLASTNAME = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelLASTNAME = new System.Windows.Forms.Label();
            this.labelNAME = new System.Windows.Forms.Label();
            this.labelGRUP = new System.Windows.Forms.Label();
            this.comboBoxGRUP = new System.Windows.Forms.ComboBox();
            this.textBoxGRUP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListViewSUDENT
            // 
            this.ListViewSUDENT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewSUDENT.FullRowSelect = true;
            this.ListViewSUDENT.GridLines = true;
            this.ListViewSUDENT.HideSelection = false;
            this.ListViewSUDENT.Location = new System.Drawing.Point(174, 12);
            this.ListViewSUDENT.MultiSelect = false;
            this.ListViewSUDENT.Name = "ListViewSUDENT";
            this.ListViewSUDENT.Size = new System.Drawing.Size(254, 153);
            this.ListViewSUDENT.TabIndex = 11;
            this.ListViewSUDENT.UseCompatibleStateImageBehavior = false;
            this.ListViewSUDENT.View = System.Windows.Forms.View.Details;
            this.ListViewSUDENT.SelectedIndexChanged += new System.EventHandler(this.ListViewSUDENT_SelectedIndexChanged);
            // 
            // textBoxLASTNAME
            // 
            this.textBoxLASTNAME.Location = new System.Drawing.Point(11, 38);
            this.textBoxLASTNAME.Name = "textBoxLASTNAME";
            this.textBoxLASTNAME.Size = new System.Drawing.Size(100, 20);
            this.textBoxLASTNAME.TabIndex = 12;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(11, 86);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(100, 20);
            this.textBoxNAME.TabIndex = 13;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФАМИЛИЯ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ИМЯ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IDGRUP";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(353, 182);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "УДАЛИТЬ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(259, 182);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 23);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "ИЗМЕНИТЬ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(178, 182);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "СОЗДАТЬ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelLASTNAME
            // 
            this.labelLASTNAME.AutoSize = true;
            this.labelLASTNAME.Location = new System.Drawing.Point(11, 12);
            this.labelLASTNAME.Name = "labelLASTNAME";
            this.labelLASTNAME.Size = new System.Drawing.Size(66, 13);
            this.labelLASTNAME.TabIndex = 18;
            this.labelLASTNAME.Text = "ФАМИЛИЯ";
            // 
            // labelNAME
            // 
            this.labelNAME.AutoSize = true;
            this.labelNAME.Location = new System.Drawing.Point(12, 61);
            this.labelNAME.Name = "labelNAME";
            this.labelNAME.Size = new System.Drawing.Size(32, 13);
            this.labelNAME.TabIndex = 19;
            this.labelNAME.Text = "ИМЯ";
            // 
            // labelGRUP
            // 
            this.labelGRUP.AutoSize = true;
            this.labelGRUP.Location = new System.Drawing.Point(12, 109);
            this.labelGRUP.Name = "labelGRUP";
            this.labelGRUP.Size = new System.Drawing.Size(51, 13);
            this.labelGRUP.TabIndex = 20;
            this.labelGRUP.Text = "ГРУППА";
            // 
            // comboBoxGRUP
            // 
            this.comboBoxGRUP.FormattingEnabled = true;
            this.comboBoxGRUP.Location = new System.Drawing.Point(11, 157);
            this.comboBoxGRUP.Name = "comboBoxGRUP";
            this.comboBoxGRUP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGRUP.TabIndex = 21;
            // 
            // textBoxGRUP
            // 
            this.textBoxGRUP.Location = new System.Drawing.Point(11, 131);
            this.textBoxGRUP.Name = "textBoxGRUP";
            this.textBoxGRUP.Size = new System.Drawing.Size(100, 20);
            this.textBoxGRUP.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 226);
            this.Controls.Add(this.textBoxGRUP);
            this.Controls.Add(this.comboBoxGRUP);
            this.Controls.Add(this.labelGRUP);
            this.Controls.Add(this.labelNAME);
            this.Controls.Add(this.labelLASTNAME);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.textBoxLASTNAME);
            this.Controls.Add(this.ListViewSUDENT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewSUDENT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxLASTNAME;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelLASTNAME;
        private System.Windows.Forms.Label labelNAME;
        private System.Windows.Forms.Label labelGRUP;
        private System.Windows.Forms.ComboBox comboBoxGRUP;
        private System.Windows.Forms.TextBox textBoxGRUP;
    }
}

