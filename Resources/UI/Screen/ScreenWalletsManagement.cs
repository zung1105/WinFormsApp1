using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Services.WalletServices;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1.Screen
{
    public partial class ScreenWalletsManagement : UserControl
    {


        public ScreenWalletsManagement()
        {
            InitializeComponent();
            LoadWalletComboBox();


        }

        private void button_CreateWallet_Click(object sender, EventArgs e)
        {
            FormCreateWallet from = new FormCreateWallet();
            from.ShowDialog();
            LoadWalletComboBox();
        }
        private void button_confirmEdit_Click(object sender, EventArgs e)
        {
            string OldName = comboBox_WalletSelect.Text;
            string TenVi = text_TenVi.Text.Trim();
            string MieuTa = text_MieuTa.Text.Trim();
            string SoDu = text_SoDu.Text.Trim();
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-E2S67ERL\\SQLEXPRESS;Initial Catalog=budgeting_DB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string sql = "UPDATE Wallet SET Name=@TenVi, Description=@MieuTa, Balance=@SoDu WHERE Name=@OldName";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@TenVi", TenVi);
                    cmd.Parameters.AddWithValue("@MieuTa", MieuTa);
                    cmd.Parameters.AddWithValue("@SoDu", SoDu);
                    cmd.Parameters.AddWithValue("@OldName", OldName);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Cập nhật ví thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadWalletComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật ví thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel_Xoa_LinkClicked(object sender, EventArgs e)
        {

        }

        private void comboBox_WalletSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView row = (DataRowView)comboBox_WalletSelect.SelectedItem;
            text_TenVi.Text = row["Name"].ToString();
            text_SoDu.Text = row["Balance"].ToString();
            text_MieuTa.Text = row["Description"].ToString();
            CreatedDate.Value = Convert.ToDateTime(row["CreatedAt"]);

        }
        private void LoadWalletComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-E2S67ERL\\SQLEXPRESS;Initial Catalog=budgeting_DB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string sql = "select Name, Balance, Description, CreatedAt  from Wallet";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox_WalletSelect.DataSource = dt;
                    comboBox_WalletSelect.DisplayMember = "Name";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void isEditing_CheckedChanged(object sender, EventArgs e)
        {
            text_TenVi.Enabled = text_MieuTa.Enabled = CreatedDate.Enabled = text_SoDu.Enabled = button_confirmEdit.Enabled = isEditing.Checked;

        }

        private void text_TenVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_MieuTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string OldName = text_TenVi.Text;
            try 
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-E2S67ERL\\SQLEXPRESS;Initial Catalog=budgeting_DB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string sql = "delete from Wallet where Name=@OldName";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@OldName",OldName);
                    int row= cmd.ExecuteNonQuery();
                    if(row >0)
                    {
                        MessageBox.Show("Xóa ví thành công ");
                        LoadWalletComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Xoa vi thất bại ");
                    }    

                }    

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database");
            }
        }
    }
}
