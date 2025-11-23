using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Screen
{
    public partial class ScreenStatistic : UserControl
    {
        public ScreenStatistic()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_From_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_Income_Click(object sender, EventArgs e)
        {

        }

        private void picker_searchTransByCustom_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_From.Enabled = dateTimePicker_To.Enabled = picker_searchTransByCustom.Checked;
        }

        private void button_chinhSua_Click(object sender, EventArgs e)
        {

        }
    }
}
