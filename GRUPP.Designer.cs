namespace SDAM
{
    partial class GRUPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRUPP));
            this.labelgod = new System.Windows.Forms.Label();
            this.labelsem = new System.Windows.Forms.Label();
            this.labelpregod = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.textBoxGOD = new System.Windows.Forms.TextBox();
            this.textBoxSPE = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ListViewG = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelgod
            // 
            this.labelgod.AutoSize = true;
            this.labelgod.BackColor = System.Drawing.Color.White;
            this.labelgod.Location = new System.Drawing.Point(-70, 182);
            this.labelgod.Name = "labelgod";
            this.labelgod.Size = new System.Drawing.Size(24, 13);
            this.labelgod.TabIndex = 41;
            this.labelgod.Text = "год";
            // 
            // labelsem
            // 
            this.labelsem.AutoSize = true;
            this.labelsem.BackColor = System.Drawing.Color.White;
            this.labelsem.Location = new System.Drawing.Point(21, 129);
            this.labelsem.Name = "labelsem";
            this.labelsem.Size = new System.Drawing.Size(24, 13);
            this.labelsem.TabIndex = 40;
            this.labelsem.Text = "год";
            // 
            // labelpregod
            // 
            this.labelpregod.AutoSize = true;
            this.labelpregod.BackColor = System.Drawing.Color.White;
            this.labelpregod.Location = new System.Drawing.Point(21, 74);
            this.labelpregod.Name = "labelpregod";
            this.labelpregod.Size = new System.Drawing.Size(84, 13);
            this.labelpregod.TabIndex = 39;
            this.labelpregod.Text = "специальность";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.White;
            this.labelname.Location = new System.Drawing.Point(-67, 19);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(29, 13);
            this.labelname.TabIndex = 38;
            this.labelname.Text = "Имя";
            // 
            // textBoxGOD
            // 
            this.textBoxGOD.Location = new System.Drawing.Point(21, 145);
            this.textBoxGOD.Name = "textBoxGOD";
            this.textBoxGOD.Size = new System.Drawing.Size(100, 20);
            this.textBoxGOD.TabIndex = 36;
            // 
            // textBoxSPE
            // 
            this.textBoxSPE.Location = new System.Drawing.Point(21, 90);
            this.textBoxSPE.Name = "textBoxSPE";
            this.textBoxSPE.Size = new System.Drawing.Size(100, 20);
            this.textBoxSPE.TabIndex = 35;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(21, 34);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(100, 20);
            this.textBoxNAME.TabIndex = 34;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(396, 196);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 33;
            this.buttonDel.Text = "УДАЛИТЬ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(302, 196);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 23);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "ОБНОВИТЬ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(221, 196);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "СОЗДАТЬ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ListViewG
            // 
            this.ListViewG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewG.FullRowSelect = true;
            this.ListViewG.GridLines = true;
            this.ListViewG.HideSelection = false;
            this.ListViewG.Location = new System.Drawing.Point(159, 12);
            this.ListViewG.MultiSelect = false;
            this.ListViewG.Name = "ListViewG";
            this.ListViewG.Size = new System.Drawing.Size(365, 178);
            this.ListViewG.TabIndex = 30;
            this.ListViewG.UseCompatibleStateImageBehavior = false;
            this.ListViewG.View = System.Windows.Forms.View.Details;
            this.ListViewG.SelectedIndexChanged += new System.EventHandler(this.ListViewG_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "название";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "специальность";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "название";
            // 
            // GRUPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(566, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelgod);
            this.Controls.Add(this.labelsem);
            this.Controls.Add(this.labelpregod);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.textBoxGOD);
            this.Controls.Add(this.textBoxSPE);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ListViewG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GRUPP";
            this.Text = "GRUPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelgod;
        private System.Windows.Forms.Label labelsem;
        private System.Windows.Forms.Label labelpregod;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBoxGOD;
        private System.Windows.Forms.TextBox textBoxSPE;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView ListViewG;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
    }
}