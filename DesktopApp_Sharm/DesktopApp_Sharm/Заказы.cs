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
    public partial class Заказы : Form
    {

        SqlConnection conect;

        public Заказы()
        {
            InitializeComponent();
            bZayav.BackColor = Color.FromArgb(210, 220, 230);
            bSee.BackColor = Color.FromArgb(210, 220, 230);

            conect = new SqlConnection(@"Data source = DESKTOP-626G5DV\SQLEXPRESS; initial catalog = Sharm; integrated security = SSPI");
            conect.Open();
            SqlCommand com = new SqlCommand("SELECT [Employee].[LastName]+' '+[Employee].[MiddleName]+' '+[Employee].[FirstName] as [ФИО],[Name]  as [Должность],count(Client.LastName" +
                "+ ' ' + Client.MiddleName + ' ' + Client.FirstName) as [Кол-во заказов] FROM[dbo].[Employee] " +
                "left join Position on PositionId = Position.ID " +
                "left join [Order] on [Order].EmployeeID = Employee.ID " +
                "left join Client on Client.ID = [Order].ClientID " +
                "group by [Employee].[LastName]+' '+[Employee].[MiddleName]+' '+[Employee].[FirstName],[Name]", conect);
            DataTable table = new DataTable();
            SqlDataReader r = com.ExecuteReader();
            table.Load(r);
            dataGridView1.DataSource = table;
            conect.Close();
        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            
        }

        private void bSee_Click(object sender, EventArgs e)
        {
            Записи_клиентов записи = new Записи_клиентов();
            записи.ShowDialog();
        }

        private void bZayav_Click(object sender, EventArgs e)
        {
            Заявки заявки = new Заявки();
            заявки.ShowDialog();
        }
    }
}
