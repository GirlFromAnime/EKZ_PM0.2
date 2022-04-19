using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesktopApp_Sharm
{
    public partial class Авторизация : Form
    {

        SqlConnection conect;

        public Авторизация()
        {
            InitializeComponent();
            bEnter.BackColor = Color.FromArgb(210, 220, 230);            
            tbPassword.UseSystemPasswordChar = true;
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {

        }
                                                                           //Авторизация пользователя в систему//
        private void bEnter_Click(object sender, EventArgs e)
        {
            conect = new SqlConnection(@"Data source = DESKTOP-626G5DV\SQLEXPRESS; initial catalog = Sharm; integrated security = SSPI");
            conect.Open();
            SqlCommand com = new SqlCommand("Select * from [User] Where Логин = '" + tbLogin.Text + "' and Пароль = '" + tbPassword.Text + "'", conect);
            DataTable table = new DataTable();
            SqlDataReader r = com.ExecuteReader();
            table.Load(r);
            dataGridView1.DataSource = table;
            conect.Close();
            if (dataGridView1.Rows[0].Cells[2].Value != null)
            {
                Заказы заказы = new Заказы();
                заказы.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
