namespace SDAM
{
    partial class DIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIS));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ListViewDIS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.textBoxPREPODOVATEL = new System.Windows.Forms.TextBox();
            this.textBoxSEMESTOR = new System.Windows.Forms.TextBox();
            this.textBoxGOD = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelpregod = new System.Windows.Forms.Label();
            this.labelsem = new System.Windows.Forms.Label();
            this.labelgod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(387, 196);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 21;
            this.buttonDel.Text = "УДАЛИТЬ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(293, 196);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 23);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "ОБНОВИТЬ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(212, 196);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "СОЗДАТЬ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ListViewDIS
            // 
            this.ListViewDIS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewDIS.FullRowSelect = true;
            this.ListViewDIS.GridLines = true;
            this.ListViewDIS.HideSelection = false;
            this.ListViewDIS.Location = new System.Drawing.Point(150, 12);
            this.ListViewDIS.MultiSelect = false;
            this.ListViewDIS.Name = "ListViewDIS";
            this.ListViewDIS.Size = new System.Drawing.Size(365, 178);
            this.ListViewDIS.TabIndex = 18;
            this.ListViewDIS.UseCompatibleStateImageBehavior = false;
            this.ListViewDIS.View = System.Windows.Forms.View.Details;
            this.ListViewDIS.SelectedIndexChanged += new System.EventHandler(this.ListViewDIS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Преподователь";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Семестр";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "год";
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(12, 34);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(100, 20);
            this.textBoxNAME.TabIndex = 22;
            // 
            // textBoxPREPODOVATEL
            // 
            this.textBoxPREPODOVATEL.Location = new System.Drawing.Point(12, 90);
            this.textBoxPREPODOVATEL.Name = "textBoxPREPODOVATEL";
            this.textBoxPREPODOVATEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPREPODOVATEL.TabIndex = 23;
            // 
            // textBoxSEMESTOR
            // 
            this.textBoxSEMESTOR.Location = new System.Drawing.Point(12, 145);
            this.textBoxSEMESTOR.Name = "textBoxSEMESTOR";
            this.textBoxSEMESTOR.Size = new System.Drawing.Size(100, 20);
            this.textBoxSEMESTOR.TabIndex = 24;
            // 
            // textBoxGOD
            // 
            this.textBoxGOD.Location = new System.Drawing.Point(12, 198);
            this.textBoxGOD.Name = "textBoxGOD";
            this.textBoxGOD.Size = new System.Drawing.Size(100, 20);
            this.textBoxGOD.TabIndex = 25;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.White;
            this.labelname.Location = new System.Drawing.Point(12, 18);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(29, 13);
            this.labelname.TabIndex = 26;
            this.labelname.Text = "Имя";
            // 
            // labelpregod
            // 
            this.labelpregod.AutoSize = true;
            this.labelpregod.BackColor = System.Drawing.Color.White;
            this.labelpregod.Location = new System.Drawing.Point(12, 74);
            this.labelpregod.Name = "labelpregod";
            this.labelpregod.Size = new System.Drawing.Size(84, 13);
            this.labelpregod.TabIndex = 27;
            this.labelpregod.Text = "преподаватель";
            // 
            // labelsem
            // 
            this.labelsem.AutoSize = true;
            this.labelsem.BackColor = System.Drawing.Color.White;
            this.labelsem.Location = new System.Drawing.Point(12, 129);
            this.labelsem.Name = "labelsem";
            this.labelsem.Size = new System.Drawing.Size(50, 13);
            this.labelsem.TabIndex = 28;
            this.labelsem.Text = "семестр";
            // 
            // labelgod
            // 
            this.labelgod.AutoSize = true;
            this.labelgod.BackColor = System.Drawing.Color.White;
            this.labelgod.Location = new System.Drawing.Point(9, 181);
            this.labelgod.Name = "labelgod";
            this.labelgod.Size = new System.Drawing.Size(24, 13);
            this.labelgod.TabIndex = 29;
            this.labelgod.Text = "год";
            // 
            // DIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 299);
            this.Controls.Add(this.labelgod);
            this.Controls.Add(this.labelsem);
            this.Controls.Add(this.labelpregod);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.textBoxGOD);
            this.Controls.Add(this.textBoxSEMESTOR);
            this.Controls.Add(this.textBoxPREPODOVATEL);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ListViewDIS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DIS";
            this.Text = "DIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView ListViewDIS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.TextBox textBoxPREPODOVATEL;
        private System.Windows.Forms.TextBox textBoxSEMESTOR;
        private System.Windows.Forms.TextBox textBoxGOD;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelpregod;
        private System.Windows.Forms.Label labelsem;
        private System.Windows.Forms.Label labelgod;
    }
}