using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanThueNha.DAO;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QL_BanThueNha
{
    public partial class fQL : Form
    {
        public fQL()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            // tải danh sách các Loại nha
            string query1 = @"SELECT Type_Name FROM TypeOfApartment";

            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);

            List<string> typeApart = new List<string>();

            foreach (DataRow item in data1.Rows)
            {
                typeApart.Add(item[0].ToString());
            }

            typeApart_kh.DataSource = typeApart;

            // tải danh sách 
            type_Cus.Items.Add("Người Mua");
            type_Cus.Items.Add("Người Thuê");
            type_Cus.SelectedIndex = 0;


            //data Branch
            string query2 = @"SELECT Br_ID FROM Branch";
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);

            List<string> branch = new List<string>();
    
            foreach (DataRow item in data2.Rows)
            {
                branch.Add(item[0].ToString());
            }

            Branch_Cus.DataSource = branch;
            cb_Branch.DataSource = branch;

            //load id

            string query3 = @"SELECT Cus_ID FROM Customer";
            DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);
            List<string> list_id = new List<string>();
            list_id.Add("<None>");
            foreach (DataRow item in data3.Rows)
            {
                list_id.Add(item[0].ToString());
            }

            input_ID.DataSource = list_id;
            input_ID.SelectedIndex = 0;
            

            //load data name
            string query4 = @"SELECT Cus_Name FROM Customer";
            DataTable data4 = DataProvider.Instance.ExecuteQuery(query4);
            List<string> list_name = new List<string>();
            list_name.Add("<None>");
            foreach (DataRow item in data4.Rows)
            {
                list_name.Add(item[0].ToString());
            }
            input_name.DataSource = list_name;
            input_name.SelectedIndex = 0;
            ////load data adress
            string query5 = @"SELECT Cus_Address FROM Customer";
            DataTable data5 = DataProvider.Instance.ExecuteQuery(query5);
            List<string> list_adr = new List<string>();
            list_adr.Add("<None>");
            foreach (DataRow item in data5.Rows)
            {
                list_adr.Add(item[0].ToString());
            }
            cus_adress.DataSource = list_adr;
            cus_adress.SelectedIndex = 0;

            //ds nhân viên
            string query6 = @"SELECT Em_ID FROM Employee";

            DataTable data6 = DataProvider.Instance.ExecuteQuery(query6);

            List<string> list_em = new List<string>();

            foreach (DataRow item in data6.Rows)
            {
                list_em.Add(item[0].ToString());
            }
            input_em.DataSource = list_em;
            //ds chủ hộ
            string query7 = @"SELECT Lan_Name FROM LandLord";

            DataTable data7 = DataProvider.Instance.ExecuteQuery(query7);

            List<string> list_lan = new List<string>();

            foreach (DataRow item in data7.Rows)
            {
                list_lan.Add(item[0].ToString());
            }
            comboBox1.DataSource = list_lan;

        }
        bool Add_Customer(int id, string name, string dc, string phone, string yc, int loainha,string loaikh,int branch)
        {
            string query = string.Format("exec Add_Customer {0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}", id, name, dc, phone,yc,loainha,loaikh,branch);
            int sucess = DataProvider.Instance.ExecuteNonQuery(query);

            return sucess > 0;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_kh.Text);
            string ten = name_kh.Text;
            string dc = adress_kh.Text;
            string sdt = phoneNum_kh.Text;
            string yc = cri.Text;
            int loainha = typeApart_kh.SelectedIndex+1;
            string loaikh;
            if (type_Cus.SelectedIndex == 0)
            {
                loaikh = "B";
            }
            else
            {
                loaikh = "R";
            }
            int branch = int.Parse(Branch_Cus.Text);

            try
            {
                if (Add_Customer(id, ten, dc, sdt,yc,loainha,loaikh,branch))
                {
                    MessageBox.Show("Đã thêm nhân viên " + id, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi!!",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string id,name,adress;

          
            
            if (input_ID.Text == "<None>")
               id = "0";
            else
            {
                id = input_ID.Text;
            }

            if (input_name.Text == "<None>")
                name = "null";
            else
            {
                name = input_name.Text;
            }

            if (cus_adress.Text == "<None>")
                adress = "null";
            else
            {
                adress = cus_adress.Text;
            }
            string query = string.Format("exec Find_Customer {0}, N'{1}', N'{2}'", id, name, adress);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            Find_Result.DataSource = data;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      

        private void id_kh_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_kh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = @"select* from Customer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            Cus_list.DataSource = data;
            button2.Hide();
        }

        private void input_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tt_Em_Click(object sender, EventArgs e)
        {

        }

        private void input_em_SelectedValueChanged(object sender, EventArgs e)
        {

            string query = "exec Infor_Employee " + input_em.Text;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            data_em.DataSource = data;

            string query1 = "exec Branch_Employee " + input_em.Text;
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            data_br.DataSource = data1;

            string query2 = "exec Apar_Em " + input_em.Text;
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            dataGridView1.DataSource = data2;

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cb_Branch_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "exec Employee_Branch " + cb_Branch.Text;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            em_br.DataSource = data;

            string query1 = "exec Apr_Branch " + cb_Branch.Text;
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            data_apr.DataSource = data1;

            string query2 = "exec Aps_Branch " + cb_Branch.Text;
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            data_aps.DataSource = data2;


        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "exec TT_LandLord N'" + comboBox1.Text + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dataGridView2.DataSource = data;

            string query1 = "exec apr_LandLord N'" + comboBox1.Text + "'";
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            dataGridView3.DataSource = data1;

            string query2 = "exec aps_LandLord N'" + comboBox1.Text + "'";
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            dataGridView4.DataSource = data2;
        }
    }
}
