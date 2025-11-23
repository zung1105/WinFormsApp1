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

namespace WinFormsApp1.Screen
{
    public partial class ScreenWalletsManagement : UserControl
    {


        public ScreenWalletsManagement()
        {
            InitializeComponent();
        }

        private void button_CreateWallet_Click(object sender, EventArgs e)
        {
            FormCreateWallet from = new FormCreateWallet();
            from.ShowDialog();
        }
        private void button_confirmEdit_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel_Xoa_LinkClicked(object sender, EventArgs e)
        {

        }
        private void comboBox_WalletSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void isEditing_CheckedChanged(object sender, EventArgs e)
        {
            text_TenVi.Enabled = text_MieuTa.Enabled = CreatedDate.Enabled = button_confirmEdit.Enabled = isEditing.Checked;
        }

        private void text_TenVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_MieuTa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
