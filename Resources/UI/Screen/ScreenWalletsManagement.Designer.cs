namespace WinFormsApp1.Screen
{
    partial class ScreenWalletsManagement
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
            components = new System.ComponentModel.Container();
            label_tenvi = new Label();
            lable_soDu = new Label();
            label_createDate = new Label();
            label_description = new Label();
            comboBox_WalletSelect = new ComboBox();
            label_walletChoose = new Label();
            text_TenVi = new TextBox();
            text_SoDu = new TextBox();
            text_MieuTa = new TextBox();
            button_confirmEdit = new Button();
            linkLabel_Xoa = new LinkLabel();
            button_CreateWallet = new Button();
            CreatedDate = new DateTimePicker();
            isEditing = new CheckBox();
            walletBindingSource = new BindingSource(components);
            walletBindingSource1 = new BindingSource(components);
            btn_Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)walletBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)walletBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label_tenvi
            // 
            label_tenvi.AutoSize = true;
            label_tenvi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tenvi.Location = new Point(154, 182);
            label_tenvi.Margin = new Padding(4, 0, 4, 0);
            label_tenvi.Name = "label_tenvi";
            label_tenvi.Size = new Size(91, 32);
            label_tenvi.TabIndex = 0;
            label_tenvi.Text = "Tên Ví:";
            // 
            // lable_soDu
            // 
            lable_soDu.AutoSize = true;
            lable_soDu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable_soDu.Location = new Point(155, 250);
            lable_soDu.Margin = new Padding(4, 0, 4, 0);
            lable_soDu.Name = "lable_soDu";
            lable_soDu.Size = new Size(90, 32);
            lable_soDu.TabIndex = 1;
            lable_soDu.Text = "Số Dư:";
            // 
            // label_createDate
            // 
            label_createDate.AutoSize = true;
            label_createDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_createDate.Location = new Point(51, 321);
            label_createDate.Margin = new Padding(4, 0, 4, 0);
            label_createDate.Name = "label_createDate";
            label_createDate.Size = new Size(187, 32);
            label_createDate.TabIndex = 2;
            label_createDate.Text = "Thời Điểm Tạo:";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_description.Location = new Point(130, 401);
            label_description.Margin = new Padding(4, 0, 4, 0);
            label_description.Name = "label_description";
            label_description.Size = new Size(113, 32);
            label_description.TabIndex = 3;
            label_description.Text = "Miêu Tả:";
            // 
            // comboBox_WalletSelect
            // 
            comboBox_WalletSelect.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_WalletSelect.FormattingEnabled = true;
            comboBox_WalletSelect.Location = new Point(441, 71);
            comboBox_WalletSelect.Margin = new Padding(4);
            comboBox_WalletSelect.Name = "comboBox_WalletSelect";
            comboBox_WalletSelect.Size = new Size(310, 38);
            comboBox_WalletSelect.TabIndex = 4;
            comboBox_WalletSelect.SelectedIndexChanged += comboBox_WalletSelect_SelectedIndexChanged;
            // 
            // label_walletChoose
            // 
            label_walletChoose.AutoSize = true;
            label_walletChoose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_walletChoose.Location = new Point(530, 32);
            label_walletChoose.Margin = new Padding(4, 0, 4, 0);
            label_walletChoose.Name = "label_walletChoose";
            label_walletChoose.Size = new Size(103, 32);
            label_walletChoose.TabIndex = 5;
            label_walletChoose.Text = "Chọn Ví";
            // 
            // text_TenVi
            // 
            text_TenVi.Enabled = false;
            text_TenVi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_TenVi.Location = new Point(272, 182);
            text_TenVi.Margin = new Padding(4);
            text_TenVi.Name = "text_TenVi";
            text_TenVi.Size = new Size(856, 36);
            text_TenVi.TabIndex = 6;
            text_TenVi.TextChanged += text_TenVi_TextChanged;
            // 
            // text_SoDu
            // 
            text_SoDu.Enabled = false;
            text_SoDu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_SoDu.Location = new Point(272, 250);
            text_SoDu.Margin = new Padding(4);
            text_SoDu.Name = "text_SoDu";
            text_SoDu.Size = new Size(856, 36);
            text_SoDu.TabIndex = 7;
            // 
            // text_MieuTa
            // 
            text_MieuTa.Enabled = false;
            text_MieuTa.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_MieuTa.Location = new Point(272, 401);
            text_MieuTa.Margin = new Padding(4);
            text_MieuTa.Multiline = true;
            text_MieuTa.Name = "text_MieuTa";
            text_MieuTa.Size = new Size(856, 172);
            text_MieuTa.TabIndex = 9;
            text_MieuTa.TextChanged += text_MieuTa_TextChanged;
            // 
            // button_confirmEdit
            // 
            button_confirmEdit.BackColor = Color.FromArgb(192, 255, 192);
            button_confirmEdit.Enabled = false;
            button_confirmEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_confirmEdit.ForeColor = Color.Green;
            button_confirmEdit.Location = new Point(490, 592);
            button_confirmEdit.Margin = new Padding(4);
            button_confirmEdit.Name = "button_confirmEdit";
            button_confirmEdit.Size = new Size(218, 48);
            button_confirmEdit.TabIndex = 10;
            button_confirmEdit.Text = "Xác Nhận";
            button_confirmEdit.UseVisualStyleBackColor = false;
            button_confirmEdit.Click += button_confirmEdit_Click;
            // 
            // linkLabel_Xoa
            // 
            linkLabel_Xoa.ActiveLinkColor = Color.Maroon;
            linkLabel_Xoa.AutoSize = true;
            linkLabel_Xoa.LinkColor = Color.Red;
            linkLabel_Xoa.Location = new Point(1059, 38);
            linkLabel_Xoa.Margin = new Padding(4, 0, 4, 0);
            linkLabel_Xoa.Name = "linkLabel_Xoa";
            linkLabel_Xoa.Size = new Size(43, 25);
            linkLabel_Xoa.TabIndex = 12;
            linkLabel_Xoa.TabStop = true;
            linkLabel_Xoa.Text = "Xóa";
            linkLabel_Xoa.LinkClicked += linkLabel_Xoa_LinkClicked;
            // 
            // button_CreateWallet
            // 
            button_CreateWallet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CreateWallet.Location = new Point(775, 71);
            button_CreateWallet.Margin = new Padding(4);
            button_CreateWallet.Name = "button_CreateWallet";
            button_CreateWallet.Size = new Size(154, 41);
            button_CreateWallet.TabIndex = 13;
            button_CreateWallet.Text = "Tạo Ví Mới";
            button_CreateWallet.UseVisualStyleBackColor = true;
            button_CreateWallet.Click += button_CreateWallet_Click;
            // 
            // CreatedDate
            // 
            CreatedDate.Enabled = false;
            CreatedDate.Location = new Point(272, 324);
            CreatedDate.Margin = new Padding(4);
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Size = new Size(312, 31);
            CreatedDate.TabIndex = 14;
            CreatedDate.ValueChanged += comboBox_WalletSelect_SelectedIndexChanged;
            // 
            // isEditing
            // 
            isEditing.AutoSize = true;
            isEditing.ForeColor = Color.Blue;
            isEditing.Location = new Point(940, 134);
            isEditing.Margin = new Padding(4);
            isEditing.Name = "isEditing";
            isEditing.Size = new Size(118, 29);
            isEditing.TabIndex = 15;
            isEditing.Text = "Chỉnh Sửa";
            isEditing.UseVisualStyleBackColor = true;
            isEditing.CheckedChanged += isEditing_CheckedChanged;
            // 
            // walletBindingSource
            // 
            walletBindingSource.DataSource = typeof(Models.Wallet);
            // 
            // walletBindingSource1
            // 
            walletBindingSource1.DataSource = typeof(Models.Wallet);
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(1101, 129);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(112, 34);
            btn_Xoa.TabIndex = 16;
            btn_Xoa.Text = "Xóa ví";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // ScreenWalletsManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Xoa);
            Controls.Add(isEditing);
            Controls.Add(CreatedDate);
            Controls.Add(button_CreateWallet);
            Controls.Add(linkLabel_Xoa);
            Controls.Add(button_confirmEdit);
            Controls.Add(text_MieuTa);
            Controls.Add(text_SoDu);
            Controls.Add(text_TenVi);
            Controls.Add(label_walletChoose);
            Controls.Add(comboBox_WalletSelect);
            Controls.Add(label_description);
            Controls.Add(label_createDate);
            Controls.Add(lable_soDu);
            Controls.Add(label_tenvi);
            Margin = new Padding(4);
            Name = "ScreenWalletsManagement";
            Size = new Size(1216, 666);
            ((System.ComponentModel.ISupportInitialize)walletBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)walletBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_tenvi;
        private Label lable_soDu;
        private Label label_createDate;
        private Label label_description;
        private ComboBox comboBox_WalletSelect;
        private Label label_walletChoose;
        private TextBox text_TenVi;
        private TextBox text_SoDu;
        private TextBox text_MieuTa;
        private Button button_confirmEdit;
        private LinkLabel linkLabel_Xoa;
        private Button button_CreateWallet;
        private DateTimePicker CreatedDate;
        private CheckBox isEditing;
        private BindingSource walletBindingSource;
        private BindingSource walletBindingSource1;
        private Button btn_Xoa;
    }
}
