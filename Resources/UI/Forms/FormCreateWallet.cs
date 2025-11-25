using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1.Forms
{
    public partial class FormCreateWallet : Form
    {
        public FormCreateWallet()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=LAPTOP-E2S67ERL\\SQLEXPRESS;Initial Catalog=budgeting_DB;Integrated Security=True;TrustServerCertificate=True");

        //private void Load_db(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        con.Open();
        //        MessageBox.Show("Kết nối thành công");
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Kết nối thất bại");
        //    }
        //}
        private void button_confirmCreate_Click(object sender, EventArgs e)
        {
            string walletName = input_walletName.Text.Trim();
            string mieuTaWallet=input_mieuTa.Text.Trim();
            string soDuBanDau=input_soDuBanDau.Text.Trim();

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-E2S67ERL\\SQLEXPRESS;Initial Catalog=budgeting_DB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string checkSql = "select COUNT(*) from Wallet where Name=@Name";
                    SqlCommand checkCmd = new SqlCommand(checkSql, con);
                    checkCmd.Parameters.AddWithValue("@Name", walletName);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Ví đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string sql = "INSERT into Wallet (Name, Balance, Description) values (@walletName, @soDuBanDau, @mieuTaWallet)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@walletName", walletName);
                        cmd.Parameters.AddWithValue("@soDuBanDau", soDuBanDau);
                        cmd.Parameters.AddWithValue("@mieuTaWallet", mieuTaWallet);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Thêm ví thành công", "Thành công", MessageBoxButtons.OK);
                            input_walletName.Text = "";
                            input_soDuBanDau.Text = "";
                            input_mieuTa.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Thêm ví thất bại", "Thất bại", MessageBoxButtons.OK);
                        }
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: "+ ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }


        private void input_walletName_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_mieuTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_soDuBanDau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
