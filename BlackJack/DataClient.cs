﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class DataClient : Form
    {
        public DataClient()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;database=Client;Integrated Security=True");

        private void DataClient_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter dapt = new SqlDataAdapter("delete from client", conn);
            var table = new DataTable();
            dapt.Fill(table);
            this.MaximizeBox = false;

            var dap = new SqlDataAdapter("SELECT * FROM CLIENT", conn);
            var tablet = new DataTable();
            dap.Fill(tablet);
            datatClient.DataSource = tablet;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM CLIENT", conn);
            var table = new DataTable();
            dap.Fill(table);
            datatClient.DataSource = table;
        }

        private void datatClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
