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
    public partial class GRUPP : Form
    {
        public GRUPP()
        {
            InitializeComponent();
            showvis();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GRUP grup = new GRUP();

            grup.NAZVANIE = textBoxNAME.Text;
            grup.SPECIALNOST = textBoxSPE.Text;
            grup.GOD = Convert.ToInt32(textBoxGOD.Text);
            Program.BD.GRUP.Add(grup);
            Program.BD.SaveChanges();
            showvis();
        }
        void showvis()
        {
            ListViewG.Items.Clear();
            foreach (GRUP grup in Program.BD.GRUP)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                       grup.NAZVANIE,
                grup.SPECIALNOST,
                Convert.ToString(grup.GOD)
            });
                item.Tag = grup;
                ListViewG.Items.Add(item);
            }
            ListViewG.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ListViewG.SelectedItems.Count == 1)
            {
                GRUP grup = ListViewG.SelectedItems[0].Tag as GRUP;

                grup.NAZVANIE = textBoxNAME.Text;
                grup.SPECIALNOST = textBoxSPE.Text;
                grup.GOD = Convert.ToInt32(textBoxGOD.Text);
                Program.BD.SaveChanges();
                showvis();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {


                if (ListViewG.SelectedItems.Count == 1)
                {
                    SUDENT sUDENT = ListViewG.SelectedItems[0].Tag as SUDENT;
                    Program.BD.SUDENT.Remove(sUDENT);
                    Program.BD.SaveChanges();
                    showvis();
                }
                textBoxNAME.Text = "";
                textBoxSPE.Text = "";
                textBoxGOD.Text = "";
            }
            catch
            {
                MessageBox.Show("не возможно удалить эту запись, эта запись используется!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ListViewG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewG.SelectedItems.Count == 1)
            {
               GRUP grup= ListViewG.SelectedItems[0].Tag as GRUP;
                textBoxNAME.Text = grup.NAZVANIE;
                textBoxSPE.Text = grup.SPECIALNOST;
                textBoxGOD.Text = Convert.ToString(grup.GOD);
                


            }
            else
            {
                textBoxNAME.Text = "";
                textBoxSPE.Text = "";
                textBoxGOD.Text = "";
            }
        }
    }
}
