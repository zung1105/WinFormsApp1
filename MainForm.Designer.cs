namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel_navigator = new Panel();
            button_QuanLyDanhMuc = new Button();
            button_save = new Button();
            button_noti = new Button();
            button_WalletManagement = new Button();
            button_statistic = new Button();
            button_dashboard = new Button();
            panel_content = new Panel();
            panel_navigator.SuspendLayout();
            SuspendLayout();
            // 
            // panel_navigator
            // 
            panel_navigator.BackColor = Color.White;
            panel_navigator.Controls.Add(button_QuanLyDanhMuc);
            panel_navigator.Controls.Add(button_save);
            panel_navigator.Controls.Add(button_noti);
            panel_navigator.Controls.Add(button_WalletManagement);
            panel_navigator.Controls.Add(button_statistic);
            panel_navigator.Controls.Add(button_dashboard);
            panel_navigator.Dock = DockStyle.Left;
            panel_navigator.Location = new Point(0, 0);
            panel_navigator.Margin = new Padding(3, 5, 3, 5);
            panel_navigator.Name = "panel_navigator";
            panel_navigator.Size = new Size(238, 558);
            panel_navigator.TabIndex = 1;
            panel_navigator.Paint += panel_navigator_Paint;
            // 
            // button_QuanLyDanhMuc
            // 
            button_QuanLyDanhMuc.BackColor = Color.Transparent;
            button_QuanLyDanhMuc.BackgroundImageLayout = ImageLayout.None;
            button_QuanLyDanhMuc.FlatAppearance.BorderSize = 0;
            button_QuanLyDanhMuc.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button_QuanLyDanhMuc.ImageAlign = ContentAlignment.MiddleLeft;
            button_QuanLyDanhMuc.Location = new Point(12, 309);
            button_QuanLyDanhMuc.Margin = new Padding(3, 5, 3, 5);
            button_QuanLyDanhMuc.Name = "button_QuanLyDanhMuc";
            button_QuanLyDanhMuc.Size = new Size(203, 40);
            button_QuanLyDanhMuc.TabIndex = 6;
            button_QuanLyDanhMuc.Text = "Quản Lý Danh Mục";
            button_QuanLyDanhMuc.UseVisualStyleBackColor = false;
            button_QuanLyDanhMuc.Click += button_QuanLyDanhMuc_Click;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Transparent;
            button_save.BackgroundImageLayout = ImageLayout.None;
            button_save.FlatAppearance.BorderSize = 0;
            button_save.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(12, 504);
            button_save.Margin = new Padding(3, 5, 3, 5);
            button_save.Name = "button_save";
            button_save.Size = new Size(203, 40);
            button_save.TabIndex = 5;
            button_save.Text = "Sao lưu";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_noti
            // 
            button_noti.BackColor = Color.Transparent;
            button_noti.BackgroundImageLayout = ImageLayout.None;
            button_noti.FlatAppearance.BorderSize = 0;
            button_noti.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button_noti.ImageAlign = ContentAlignment.MiddleLeft;
            button_noti.Location = new Point(12, 407);
            button_noti.Margin = new Padding(3, 5, 3, 5);
            button_noti.Name = "button_noti";
            button_noti.Size = new Size(203, 40);
            button_noti.TabIndex = 3;
            button_noti.Text = "Thông Báo";
            button_noti.UseVisualStyleBackColor = false;
            button_noti.Click += button_noti_Click;
            // 
            // button_WalletManagement
            // 
            button_WalletManagement.BackColor = Color.Transparent;
            button_WalletManagement.BackgroundImageLayout = ImageLayout.None;
            button_WalletManagement.FlatAppearance.BorderSize = 0;
            button_WalletManagement.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button_WalletManagement.ImageAlign = ContentAlignment.MiddleLeft;
            button_WalletManagement.Location = new Point(14, 205);
            button_WalletManagement.Margin = new Padding(3, 5, 3, 5);
            button_WalletManagement.Name = "button_WalletManagement";
            button_WalletManagement.Size = new Size(203, 40);
            button_WalletManagement.TabIndex = 2;
            button_WalletManagement.Text = "Quản Lý Ví";
            button_WalletManagement.UseVisualStyleBackColor = false;
            button_WalletManagement.Click += button_WalletManagement_Click;
            // 
            // button_statistic
            // 
            button_statistic.BackColor = Color.Transparent;
            button_statistic.BackgroundImageLayout = ImageLayout.None;
            button_statistic.FlatAppearance.BorderSize = 0;
            button_statistic.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button_statistic.ImageAlign = ContentAlignment.MiddleLeft;
            button_statistic.Location = new Point(12, 106);
            button_statistic.Margin = new Padding(3, 5, 3, 5);
            button_statistic.Name = "button_statistic";
            button_statistic.Size = new Size(203, 40);
            button_statistic.TabIndex = 1;
            button_statistic.Text = "Thống Kê";
            button_statistic.UseVisualStyleBackColor = false;
            button_statistic.Click += button_statistic_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.BackColor = Color.Transparent;
            button_dashboard.BackgroundImageLayout = ImageLayout.None;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            button_dashboard.Location = new Point(14, 9);
            button_dashboard.Margin = new Padding(3, 5, 3, 5);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(203, 40);
            button_dashboard.TabIndex = 0;
            button_dashboard.Text = "Dashboard";
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // panel_content
            // 
            panel_content.Dock = DockStyle.Fill;
            panel_content.Location = new Point(238, 0);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(916, 558);
            panel_content.TabIndex = 2;
            panel_content.Paint += panel_content_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1154, 558);
            Controls.Add(panel_content);
            Controls.Add(panel_navigator);
            Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel_navigator.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel_navigator;
        private Button button_dashboard;
        private Button button_noti;
        private Button button_WalletManagement;
        private Button button_statistic;
        private Button button_save;
        private Panel panel_content;
        private Button button_QuanLyDanhMuc;
    }
}
