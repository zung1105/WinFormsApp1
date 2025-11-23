namespace WinFormsApp1.Forms
{
    partial class FormCreateCategory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_tenDanhMuc = new Label();
            label_loaiDanhMuc = new Label();
            label_MieuTa = new Label();
            input_tenDanhMuc = new TextBox();
            input_MieuTa = new TextBox();
            radioButton_ThuNhap = new RadioButton();
            radioButton_ChiTieu = new RadioButton();
            button_confirm = new Button();
            SuspendLayout();
            // 
            // label_tenDanhMuc
            // 
            label_tenDanhMuc.AutoSize = true;
            label_tenDanhMuc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tenDanhMuc.Location = new Point(12, 22);
            label_tenDanhMuc.Name = "label_tenDanhMuc";
            label_tenDanhMuc.Size = new Size(112, 20);
            label_tenDanhMuc.TabIndex = 0;
            label_tenDanhMuc.Text = "Tên Danh Mục:";
            // 
            // label_loaiDanhMuc
            // 
            label_loaiDanhMuc.AutoSize = true;
            label_loaiDanhMuc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_loaiDanhMuc.Location = new Point(12, 59);
            label_loaiDanhMuc.Name = "label_loaiDanhMuc";
            label_loaiDanhMuc.Size = new Size(116, 20);
            label_loaiDanhMuc.TabIndex = 1;
            label_loaiDanhMuc.Text = "Loại Danh Mục:";
            // 
            // label_MieuTa
            // 
            label_MieuTa.AutoSize = true;
            label_MieuTa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_MieuTa.Location = new Point(52, 99);
            label_MieuTa.Name = "label_MieuTa";
            label_MieuTa.Size = new Size(72, 20);
            label_MieuTa.TabIndex = 2;
            label_MieuTa.Text = " Miêu Tả:";
            // 
            // input_tenDanhMuc
            // 
            input_tenDanhMuc.Location = new Point(139, 19);
            input_tenDanhMuc.Name = "input_tenDanhMuc";
            input_tenDanhMuc.Size = new Size(382, 27);
            input_tenDanhMuc.TabIndex = 3;
            // 
            // input_MieuTa
            // 
            input_MieuTa.Location = new Point(139, 99);
            input_MieuTa.Multiline = true;
            input_MieuTa.Name = "input_MieuTa";
            input_MieuTa.Size = new Size(382, 237);
            input_MieuTa.TabIndex = 4;
            // 
            // radioButton_ThuNhap
            // 
            radioButton_ThuNhap.AutoSize = true;
            radioButton_ThuNhap.Location = new Point(139, 57);
            radioButton_ThuNhap.Name = "radioButton_ThuNhap";
            radioButton_ThuNhap.Size = new Size(94, 24);
            radioButton_ThuNhap.TabIndex = 5;
            radioButton_ThuNhap.TabStop = true;
            radioButton_ThuNhap.Text = "Thu Nhập";
            radioButton_ThuNhap.UseVisualStyleBackColor = true;
            // 
            // radioButton_ChiTieu
            // 
            radioButton_ChiTieu.AutoSize = true;
            radioButton_ChiTieu.Location = new Point(254, 57);
            radioButton_ChiTieu.Name = "radioButton_ChiTieu";
            radioButton_ChiTieu.Size = new Size(83, 24);
            radioButton_ChiTieu.TabIndex = 6;
            radioButton_ChiTieu.TabStop = true;
            radioButton_ChiTieu.Text = "Chi Tiêu";
            radioButton_ChiTieu.UseVisualStyleBackColor = true;
            // 
            // button_confirm
            // 
            button_confirm.BackColor = Color.FromArgb(192, 255, 192);
            button_confirm.ForeColor = Color.Green;
            button_confirm.Location = new Point(229, 354);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(94, 29);
            button_confirm.TabIndex = 7;
            button_confirm.Text = "Xác Nhận";
            button_confirm.UseVisualStyleBackColor = false;
            button_confirm.Click += button_confirm_Click;
            // 
            // FormCreateCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 404);
            Controls.Add(button_confirm);
            Controls.Add(radioButton_ChiTieu);
            Controls.Add(radioButton_ThuNhap);
            Controls.Add(input_MieuTa);
            Controls.Add(input_tenDanhMuc);
            Controls.Add(label_MieuTa);
            Controls.Add(label_loaiDanhMuc);
            Controls.Add(label_tenDanhMuc);
            Name = "FormCreateCategory";
            Text = "FormCreateCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_tenDanhMuc;
        private Label label_loaiDanhMuc;
        private Label label_MieuTa;
        private TextBox input_tenDanhMuc;
        private TextBox input_MieuTa;
        private RadioButton radioButton_ThuNhap;
        private RadioButton radioButton_ChiTieu;
        private Button button_confirm;
    }
}