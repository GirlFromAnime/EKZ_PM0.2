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
    public partial class Записи_клиентов : Form
    {

        SqlConnection conect;

        public Записи_клиентов()
        {
            InitializeComponent();
            conect = new SqlConnection(@"Data source = DESKTOP-626G5DV\SQLEXPRESS; initial catalog = Sharm; integrated security = SSPI");
            conect.Open();
            SqlCommand com = new SqlCommand("SELECT LastName+' '+ MiddleName+' '+FirstName as [ФИО],[Name] as [Должность], Price,[Date]" +
                " from [Order] Left join Client on Client.ID = [Order].ClientID " +
                "left join OrderService on OrderService.OrderID = [Order].ID " +
                "left join[Service] on[Service].ID = OrderService.ServiceID", conect);
            DataTable table = new DataTable();
            SqlDataReader r = com.ExecuteReader();
            table.Load(r);
            dataGridView1.DataSource = table;
            conect.Close();
        }

        private void Записи_клиентов_Load(object sender, EventArgs e)
        {

        }
    }
}
