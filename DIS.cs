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
    public partial class DIS : Form
    {
        public DIS()
        {
            InitializeComponent();
            showviss();
        }
        void showviss()
        {
            ListViewDIS.Items.Clear();
            foreach (DISS dis in Program.BD.DISS)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                      Convert.ToString(dis.IDDISS),
                      dis.NAME,
                      dis.PREPOD,
                      dis.SEMESTOR,
                      Convert.ToString(dis.GOD)
                });
                item.Tag = dis;
                ListViewDIS.Items.Add(item);
            }
            ListViewDIS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DISS dis = new DISS();

            dis.NAME = textBoxNAME.Text;
            dis.PREPOD = textBoxPREPODOVATEL.Text;
            dis.SEMESTOR = textBoxSEMESTOR.Text;
            dis.GOD = Convert.ToInt32(textBoxGOD.Text);
            Program.BD.DISS.Add(dis);
            Program.BD.SaveChanges();
            showviss();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ListViewDIS.SelectedItems.Count == 1)
            {
                DISS dis = ListViewDIS.SelectedItems[0].Tag as DISS;
                dis.NAME = textBoxNAME.Text;
                dis.PREPOD = textBoxPREPODOVATEL.Text;
                dis.SEMESTOR = textBoxSEMESTOR.Text;
                dis.GOD = Convert.ToInt32(textBoxGOD.Text);
                Program.BD.SaveChanges();
                showviss();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {


                if (ListViewDIS.SelectedItems.Count == 1)
                {
                    DISS dis = ListViewDIS.SelectedItems[0].Tag as DISS;
                    Program.BD.DISS.Remove(dis);
                    Program.BD.SaveChanges();
                    showviss();
                }
                textBoxNAME.Text = "";
                textBoxPREPODOVATEL.Text = "";
                textBoxSEMESTOR.Text = "";

                textBoxGOD.Text = "";

            }
            catch
            {
                MessageBox.Show("не возможно удалить эту запись, эта запись используется!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ListViewDIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewDIS.SelectedItems.Count == 1)
            {
                DISS dis = ListViewDIS.SelectedItems[0].Tag as DISS;
                textBoxNAME.Text = dis.NAME;
                textBoxPREPODOVATEL.Text = dis.PREPOD;
                textBoxSEMESTOR.Text = dis.SEMESTOR;
                textBoxGOD.Text = Convert.ToString( dis.GOD);


            }
            else
            {
                textBoxNAME.Text = "";
                textBoxPREPODOVATEL.Text = "";
                textBoxSEMESTOR.Text = ""; 
                textBoxGOD.Text = "";
            }
        }
    }
}
