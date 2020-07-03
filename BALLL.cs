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
    public partial class BALLL : Form
    {
        public BALLL()
        {
            InitializeComponent();
            sudent();
            diss();
            vis();
        }
        void sudent()
        {
            comboBoxSUDENT.Items.Clear();
            foreach (SUDENT sUDENT in Program.BD.SUDENT)
            {
                string[] item =
                {
                    sUDENT.LASTNAME,
                    sUDENT.NAME,
                    Convert.ToString(sUDENT.IDGRUP)

                };
                comboBoxSUDENT.Items.Add(string.Join(" ", item));
            }
        }
        void diss()
        {
            comboBoxDIS.Items.Clear();
            foreach (DISS dis in Program.BD.DISS)
            {
                string[] item =
               {
                    
                    dis.PREPOD,
                    dis.SEMESTOR,
                    Convert.ToString(dis.GOD)

                };
                comboBoxDIS.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxDIS.SelectedItem != null && comboBoxSUDENT.SelectedItem != null)
            {
                
                BALL ball = new BALL();
                
                ball.IDSUDENT = Convert.ToInt32(comboBoxSUDENT.SelectedIndex.ToString().Split()[0]);
                ball.IDDISS = Convert.ToInt32(comboBoxDIS.SelectedIndex.ToString().Split()[0]);
                ball.BALL1 = Convert.ToInt32(textBoxBALL.Text);
                Program.BD.BALL.Add(ball);
                Program.BD.SaveChanges();
                vis();


            }
            else
            {
                MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListViewBALL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewBALL.SelectedItems.Count == 1)
            {
                BALL ball = ListViewBALL.SelectedItems[0].Tag as BALL;
                comboBoxSUDENT.Text = ball.SUDENT.LASTNAME;
                comboBoxSUDENT.Text = ball.SUDENT.NAME;
                comboBoxSUDENT.Text = Convert.ToString(ball.SUDENT.IDGRUP);
                comboBoxDIS.Text = ball.DISS.PREPOD;
                comboBoxDIS.Text = ball.DISS.SEMESTOR;
                comboBoxDIS.Text = Convert.ToString(ball.DISS.GOD);
                textBoxBALL.Text = Convert.ToString(ball.BALL1);




            }
            else
            {

                comboBoxSUDENT.Text = "";
                comboBoxSUDENT.Text = "";
                comboBoxSUDENT.Text = "";
                comboBoxDIS.Text = "";
                comboBoxDIS.Text = "";
                comboBoxDIS.Text = "";
                textBoxBALL.Text = "";



            }
        }
        void vis()
        {
            ListViewBALL.Items.Clear();
            foreach (BALL ball in Program.BD.BALL)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    ball.SUDENT.LASTNAME,
                    ball.SUDENT.NAME,
                    Convert.ToString(ball.SUDENT.IDGRUP),
                    ball.DISS.PREPOD,
                    ball.DISS.SEMESTOR,
                    Convert.ToString(ball.DISS.GOD),
                    Convert.ToString(ball.BALL1),



                });
                item.Tag = ball;
                ListViewBALL.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ListViewBALL.SelectedItems.Count == 1)
            {
                BALL ball = ListViewBALL.SelectedItems[0].Tag as BALL;
                ball.IDSUDENT = Convert.ToInt32(comboBoxSUDENT.SelectedIndex.ToString().Split()[0]);
                ball.IDDISS = Convert.ToInt32(comboBoxDIS.SelectedIndex.ToString().Split()[0]);
                ball.BALL1 = Convert.ToInt32(textBoxBALL.Text);
                Program.BD.SaveChanges();
                vis();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }
    }
}
