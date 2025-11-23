
using WinFormsApp1.Screen;
namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {

        }
        private void button_statistic_Click(object sender, EventArgs e)
        {
        }
        private void button_WalletManagement_Click(object sender, EventArgs e)
        {
            ShowMainContent(new ScreenWalletsManagement());
        }
        private void button_noti_Click(object sender, EventArgs e)
        {
        }
        private void button_QuanLyDanhMuc_Click(object sender, EventArgs e)
        {
        }
        public void ShowMainContent(UserControl mainContent)
        {
            panel_content.Controls.Clear();
            mainContent.Dock = DockStyle.Fill;
            panel_content.Controls.Add(mainContent);
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void panel_navigator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
