namespace WinFormsApp1.Screen
{
    partial class ScreenCategoriesManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton_ThuNhap = new RadioButton();
            radioButton_ChiTieu = new RadioButton();
            button_TaoMoiDanhMuc = new Button();
            CategoriesGridView = new DataGridView();
            linkLable_Xoa = new LinkLabel();
            button_chinhSua = new Button();
            label_chonVi = new Label();
            WalletSelector = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)CategoriesGridView).BeginInit();
            SuspendLayout();
            // 
            // radioButton_ThuNhap
            // 
            radioButton_ThuNhap.AutoSize = true;
            radioButton_ThuNhap.Location = new Point(326, 106);
            radioButton_ThuNhap.Name = "radioButton_ThuNhap";
            radioButton_ThuNhap.Size = new Size(94, 24);
            radioButton_ThuNhap.TabIndex = 0;
            radioButton_ThuNhap.TabStop = true;
            radioButton_ThuNhap.Text = "Thu Nhập";
            radioButton_ThuNhap.UseVisualStyleBackColor = true;
            radioButton_ThuNhap.CheckedChanged += radioButton_ThuNhap_CheckedChanged;
            // 
            // radioButton_ChiTieu
            // 
            radioButton_ChiTieu.AutoSize = true;
            radioButton_ChiTieu.Location = new Point(479, 106);
            radioButton_ChiTieu.Name = "radioButton_ChiTieu";
            radioButton_ChiTieu.Size = new Size(83, 24);
            radioButton_ChiTieu.TabIndex = 1;
            radioButton_ChiTieu.TabStop = true;
            radioButton_ChiTieu.Text = "Chi Tiêu";
            radioButton_ChiTieu.UseVisualStyleBackColor = true;
            radioButton_ChiTieu.CheckedChanged += radioButton_ChiTieu_CheckedChanged;
            // 
            // button_TaoMoiDanhMuc
            // 
            button_TaoMoiDanhMuc.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_TaoMoiDanhMuc.Location = new Point(288, 25);
            button_TaoMoiDanhMuc.Name = "button_TaoMoiDanhMuc";
            button_TaoMoiDanhMuc.Size = new Size(132, 71);
            button_TaoMoiDanhMuc.TabIndex = 2;
            button_TaoMoiDanhMuc.Text = "Tạo Danh Mục Mới";
            button_TaoMoiDanhMuc.UseVisualStyleBackColor = true;
            button_TaoMoiDanhMuc.Click += button_TaoMoi_Click;
            // 
            // CategoriesGridView
            // 
            CategoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriesGridView.Dock = DockStyle.Bottom;
            CategoriesGridView.Location = new Point(0, 151);
            CategoriesGridView.MultiSelect = false;
            CategoriesGridView.Name = "CategoriesGridView";
            CategoriesGridView.RowHeadersWidth = 51;
            CategoriesGridView.Size = new Size(916, 407);
            CategoriesGridView.TabIndex = 3;
            // 
            // linkLable_Xoa
            // 
            linkLable_Xoa.AutoSize = true;
            linkLable_Xoa.LinkColor = Color.Red;
            linkLable_Xoa.Location = new Point(753, 106);
            linkLable_Xoa.Name = "linkLable_Xoa";
            linkLable_Xoa.Size = new Size(35, 20);
            linkLable_Xoa.TabIndex = 4;
            linkLable_Xoa.TabStop = true;
            linkLable_Xoa.Text = "Xóa";
            linkLable_Xoa.VisitedLinkColor = Color.Silver;
            linkLable_Xoa.LinkClicked += linkLable_Xoa_LinkClicked;
            // 
            // button_chinhSua
            // 
            button_chinhSua.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_chinhSua.Location = new Point(463, 25);
            button_chinhSua.Name = "button_chinhSua";
            button_chinhSua.Size = new Size(132, 71);
            button_chinhSua.TabIndex = 5;
            button_chinhSua.Text = "Chỉnh Sửa Danh Mục";
            button_chinhSua.UseVisualStyleBackColor = true;
            button_chinhSua.Click += button_chinhSua_Click;
            // 
            // label_chonVi
            // 
            label_chonVi.AutoSize = true;
            label_chonVi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_chonVi.Location = new Point(84, 25);
            label_chonVi.Name = "label_chonVi";
            label_chonVi.Size = new Size(78, 25);
            label_chonVi.TabIndex = 6;
            label_chonVi.Text = "Chọn Ví";
            // 
            // WalletSelector
            // 
            WalletSelector.FormattingEnabled = true;
            WalletSelector.Location = new Point(45, 68);
            WalletSelector.Name = "WalletSelector";
            WalletSelector.Size = new Size(151, 28);
            WalletSelector.TabIndex = 7;
            WalletSelector.SelectedIndexChanged += WalletSelector_SelectedIndexChanged;
            // 
            // UserControlQuanLyDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WalletSelector);
            Controls.Add(label_chonVi);
            Controls.Add(button_chinhSua);
            Controls.Add(linkLable_Xoa);
            Controls.Add(CategoriesGridView);
            Controls.Add(button_TaoMoiDanhMuc);
            Controls.Add(radioButton_ChiTieu);
            Controls.Add(radioButton_ThuNhap);
            Name = "UserControlQuanLyDanhMuc";
            Size = new Size(916, 558);
            ((System.ComponentModel.ISupportInitialize)CategoriesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton_ThuNhap;
        private RadioButton radioButton_ChiTieu;
        private Button button_TaoMoiDanhMuc;
        private DataGridView CategoriesGridView;
        private LinkLabel linkLable_Xoa;
        private Button button_chinhSua;
        private Label label_chonVi;
        private ComboBox WalletSelector;
    }
}
