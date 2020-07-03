using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM
{
    public partial class SUDENTT : Form
    {
        public SUDENTT()
        {
            InitializeComponent();
            showvis();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SUDENT sUDENT = new SUDENT();
            
            sUDENT.LASTNAME = textBoxLASTNAME.Text;
            sUDENT.NAME = textBoxNAME.Text;
            sUDENT.IDGRUP = Convert.ToInt32(textBoxGRUP.Text);
            Program.BD.SUDENT.Add(sUDENT);
            Program.BD.SaveChanges();
            showvis();
        }
        void showvis ()
        {
            ListViewSUDENT.Items.Clear();
            foreach (SUDENT sUDENT in Program.BD.SUDENT)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                       sUDENT.IDSTUDENT.ToString(),
                       sUDENT.LASTNAME,
                       sUDENT.NAME,
                       sUDENT.IDGRUP.ToString()
                }) ;
                item.Tag = sUDENT;
                ListViewSUDENT.Items.Add(item);
            }
            ListViewSUDENT.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ListViewSUDENT.SelectedItems.Count == 1)
            {
                SUDENT sUDENT = ListViewSUDENT.SelectedItems[0].Tag as SUDENT;
               
                sUDENT.LASTNAME = textBoxLASTNAME.Text;
                sUDENT.NAME = textBoxNAME.Text;
                sUDENT.IDGRUP = Convert.ToInt32(textBoxGRUP.Text);
                Program.BD.SaveChanges();
                showvis();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {


                if (ListViewSUDENT.SelectedItems.Count == 1)
                {
                    SUDENT sUDENT = ListViewSUDENT.SelectedItems[0].Tag as SUDENT;
                    Program.BD.SUDENT.Remove(sUDENT);
                    Program.BD.SaveChanges();
                    showvis();
                }
                textBoxLASTNAME.Text = "";
                textBoxNAME.Text = "";
                textBoxGRUP.Text = "";
            }
            catch
            {
                MessageBox.Show("не возможно удалить эту запись, эта запись используется!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ListViewSUDENT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewSUDENT.SelectedItems.Count == 1)
            {
                SUDENT sUDENT = ListViewSUDENT.SelectedItems[0].Tag as SUDENT;
                textBoxLASTNAME.Text = sUDENT.LASTNAME;
                textBoxNAME.Text = sUDENT.NAME;
                textBoxGRUP.Text = Convert.ToString( sUDENT.IDGRUP);
                

            }
            else
            {
                textBoxLASTNAME.Text = "";
                textBoxNAME.Text = "";
                textBoxGRUP.Text = "";
            }
        }
    }
}
