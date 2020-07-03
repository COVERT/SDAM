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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonSUDENT_Click(object sender, EventArgs e)
        {
            Form formSUDENT = new SUDENTT();
            formSUDENT.Show();

        }

        private void buttonDIS_Click(object sender, EventArgs e)
        {
            Form formDIS = new DIS();
            formDIS.Show();
        }

        private void buttonBALL_Click(object sender, EventArgs e)
        {
            Form formBALLL = new BALLL();
            formBALLL.Show();
        }
    }
}
