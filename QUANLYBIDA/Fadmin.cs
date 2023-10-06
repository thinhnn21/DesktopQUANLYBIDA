using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBIDA
{
    public partial class Fadmin : Form
    {
        public Fadmin()
        {
            InitializeComponent();
            Loadinaccout();


        }
        void Loadinaccout()
        {
            String connectionstr = "Data Source=DESKTOP-BQ1G3FJ\\SQLEXPRESS01;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True"
            SqlConnection connect = new SqlConnection(connectionstr);
            String query = " SELECT * FROM dbo.Account";
            connect.Open();
            SqlCommand cmd = new SqlCommand(query, connect);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            connect.Close();
            da

        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
