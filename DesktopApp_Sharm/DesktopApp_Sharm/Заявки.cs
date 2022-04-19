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
    public partial class Заявки : Form
    {

        SqlConnection conect;

        public Заявки()
        {
            InitializeComponent();
            bAccept.BackColor = Color.FromArgb(210, 220, 230);
            bCancel.BackColor = Color.FromArgb(210, 220, 230);

            conect = new SqlConnection(@"Data source = DESKTOP-626G5DV\SQLEXPRESS; initial catalog = Sharm; integrated security = SSPI");
            conect.Open();
            SqlCommand com = new SqlCommand("SELECT LastName+' '+ MiddleName+' '+FirstName,[Name], Price,[Date],[Accepted]" +
                " from [Order] Left join Client on Client.ID = [Order].ClientID " +
                "left join OrderService on OrderService.OrderID = [Order].ID " +
                "left join[Service] on[Service].ID = OrderService.ServiceID", conect);
            DataTable table = new DataTable();
            SqlDataReader r = com.ExecuteReader();
            table.Load(r);
            dataGridView1.DataSource = table;
            conect.Close();
        }

        string date1;
        string date2;
        string date3;
        string date4;

        private void Заявки_Load(object sender, EventArgs e)
        {

        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            conect = new SqlConnection(@"Data source = DESKTOP-626G5DV\SQLEXPRESS; initial catalog = Sharm; integrated security = SSPI");
            conect.Open();
            SqlCommand com = new SqlCommand("SELECT [Order].ID, LastName+' '+ MiddleName+' '+FirstName,[Name], Price,[Date]" +
                " from [Order] Left join Client on Client.ID = [Order].ClientID " +
                "left join OrderService on OrderService.OrderID = [Order].ID " +
                "left join[Service] on[Service].ID = OrderService.ServiceID Where LastName+' '+ MiddleName+' '+FirstName = " +
                "'" + date1 + "' and [Name] = '" + date2 + "'", conect);
            DataTable table = new DataTable();
            SqlDataReader r = com.ExecuteReader();
            table.Load(r);
            dataGridView2.DataSource = table;
            int id = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString());

            SqlCommand com1 = new SqlCommand("Update [Order] set [Accepted] = 'True' Where ID= " + id + "", conect);
            com1.ExecuteNonQuery();
            conect.Close();

            conect = new SqlConnection(@"Data source = DESKTOP-626G5DV\SQLEXPRESS; initial catalog = Sharm; integrated security = SSPI");
            conect.Open();
            SqlCommand com5 = new SqlCommand("SELECT LastName+' '+ MiddleName+' '+FirstName,[Name], Price,[Date],[Accepted]" +
                " from [Order] Left join Client on Client.ID = [Order].ClientID " +
                "left join OrderService on OrderService.OrderID = [Order].ID " +
                "left join[Service] on[Service].ID = OrderService.ServiceID", conect);
            DataTable table5 = new DataTable();
            SqlDataReader r5 = com5.ExecuteReader();
            table5.Load(r5);
            dataGridView1.DataSource = table5;
            conect.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            date1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            date2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            date3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            date4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            conect = new SqlConnection(@"Data source = DESKTOP-626G5DV\SQLEXPRESS; initial catalog = Sharm; integrated security = SSPI");
            conect.Open();
            SqlCommand com = new SqlCommand("SELECT [Order].ID, LastName+' '+ MiddleName+' '+FirstName,[Name], Price,[Date]" +
                " from [Order] Left join Client on Client.ID = [Order].ClientID " +
                "left join OrderService on OrderService.OrderID = [Order].ID " +
                "left join[Service] on[Service].ID = OrderService.ServiceID Where LastName+' '+ MiddleName+' '+FirstName = " +
                "'" + date1 + "' and [Name] = '" + date2 + "'", conect);
            DataTable table = new DataTable();
            SqlDataReader r = com.ExecuteReader();
            table.Load(r);
            dataGridView2.DataSource = table;
            int id = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString());


            SqlCommand com1 = new SqlCommand("Update [Order] set [Accepted] = 'False' Where ID= " + id + "", conect);
            com1.ExecuteNonQuery();
            conect.Close();

            conect = new SqlConnection(@"Data source = DESKTOP-626G5DV\SQLEXPRESS; initial catalog = Sharm; integrated security = SSPI");
            conect.Open();
            SqlCommand com5 = new SqlCommand("SELECT LastName+' '+ MiddleName+' '+FirstName,[Name], Price,[Date],[Accepted]" +
                " from [Order] Left join Client on Client.ID = [Order].ClientID " +
                "left join OrderService on OrderService.OrderID = [Order].ID " +
                "left join[Service] on[Service].ID = OrderService.ServiceID", conect);
            DataTable table5 = new DataTable();
            SqlDataReader r5 = com5.ExecuteReader();
            table5.Load(r5);
            dataGridView1.DataSource = table5;
            conect.Close();
        }
    }
}
