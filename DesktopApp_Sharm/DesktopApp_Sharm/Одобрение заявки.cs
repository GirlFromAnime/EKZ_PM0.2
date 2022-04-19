using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp_Sharm
{
    public partial class Одобрение_заявки : Form
    {
        public Одобрение_заявки()
        {
            InitializeComponent();
            bOk.BackColor = Color.FromArgb(210, 220, 230);
            bBack.BackColor = Color.FromArgb(210, 220, 230);
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
