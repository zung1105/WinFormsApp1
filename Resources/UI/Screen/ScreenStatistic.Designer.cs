namespace WinFormsApp1.Screen
{
    partial class ScreenStatistic
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
            panel1 = new Panel();
            label1 = new Label();
            button_Create = new Button();
            button_Xoa = new Button();
            button_chinhSua = new Button();
            label_to = new Label();
            label_ChiTieu = new Label();
            label_Income = new Label();
            dateTimePicker_To = new DateTimePicker();
            dateTimePicker_From = new DateTimePicker();
            picker_searchTransByCustom = new RadioButton();
            picker_searchTransInYear = new RadioButton();
            button_FindTransactions = new Button();
            picker_searchTransInMonth = new RadioButton();
            picker_searchTransInWeek = new RadioButton();
            picker_searchTransInDay = new RadioButton();
            searchByTransactionType = new CheckedListBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_Create);
            panel1.Controls.Add(button_Xoa);
            panel1.Controls.Add(button_chinhSua);
            panel1.Controls.Add(label_to);
            panel1.Controls.Add(label_ChiTieu);
            panel1.Controls.Add(label_Income);
            panel1.Controls.Add(dateTimePicker_To);
            panel1.Controls.Add(dateTimePicker_From);
            panel1.Controls.Add(picker_searchTransByCustom);
            panel1.Controls.Add(picker_searchTransInYear);
            panel1.Controls.Add(button_FindTransactions);
            panel1.Controls.Add(picker_searchTransInMonth);
            panel1.Controls.Add(picker_searchTransInWeek);
            panel1.Controls.Add(picker_searchTransInDay);
            panel1.Controls.Add(searchByTransactionType);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 237);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(461, 126);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 15;
            label1.Text = "Tùy chọn tìm kiếm:";
            // 
            // button_Create
            // 
            button_Create.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Create.Location = new Point(461, 55);
            button_Create.Name = "button_Create";
            button_Create.Size = new Size(123, 44);
            button_Create.TabIndex = 14;
            button_Create.Text = "Tạo Mới";
            button_Create.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            button_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Xoa.Location = new Point(332, 55);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(123, 44);
            button_Xoa.TabIndex = 13;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_chinhSua
            // 
            button_chinhSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_chinhSua.Location = new Point(203, 55);
            button_chinhSua.Name = "button_chinhSua";
            button_chinhSua.Size = new Size(123, 44);
            button_chinhSua.TabIndex = 12;
            button_chinhSua.Text = "Chỉnh Sửa";
            button_chinhSua.UseVisualStyleBackColor = true;
            button_chinhSua.Click += button_chinhSua_Click;
            // 
            // label_to
            // 
            label_to.AutoSize = true;
            label_to.Location = new Point(860, 187);
            label_to.Name = "label_to";
            label_to.Size = new Size(25, 20);
            label_to.TabIndex = 11;
            label_to.Text = "To";
            label_to.Click += label1_Click;
            // 
            // label_ChiTieu
            // 
            label_ChiTieu.AutoSize = true;
            label_ChiTieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ChiTieu.ForeColor = Color.FromArgb(192, 0, 0);
            label_ChiTieu.Location = new Point(895, 55);
            label_ChiTieu.Name = "label_ChiTieu";
            label_ChiTieu.Size = new Size(94, 28);
            label_ChiTieu.TabIndex = 10;
            label_ChiTieu.Text = "Chi Tiêu:";
            // 
            // label_Income
            // 
            label_Income.AutoSize = true;
            label_Income.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Income.ForeColor = Color.FromArgb(0, 192, 0);
            label_Income.Location = new Point(607, 55);
            label_Income.Name = "label_Income";
            label_Income.Size = new Size(110, 28);
            label_Income.TabIndex = 9;
            label_Income.Text = "Thu Nhập:";
            label_Income.Click += label_Income_Click;
            // 
            // dateTimePicker_To
            // 
            dateTimePicker_To.Enabled = false;
            dateTimePicker_To.Location = new Point(891, 185);
            dateTimePicker_To.Name = "dateTimePicker_To";
            dateTimePicker_To.Size = new Size(250, 27);
            dateTimePicker_To.TabIndex = 8;
            // 
            // dateTimePicker_From
            // 
            dateTimePicker_From.Enabled = false;
            dateTimePicker_From.Location = new Point(603, 185);
            dateTimePicker_From.Name = "dateTimePicker_From";
            dateTimePicker_From.Size = new Size(250, 27);
            dateTimePicker_From.TabIndex = 7;
            dateTimePicker_From.ValueChanged += dateTimePicker_From_ValueChanged;
            // 
            // picker_searchTransByCustom
            // 
            picker_searchTransByCustom.AutoSize = true;
            picker_searchTransByCustom.Location = new Point(514, 185);
            picker_searchTransByCustom.Name = "picker_searchTransByCustom";
            picker_searchTransByCustom.Size = new Size(83, 24);
            picker_searchTransByCustom.TabIndex = 6;
            picker_searchTransByCustom.TabStop = true;
            picker_searchTransByCustom.Text = "Custom:";
            picker_searchTransByCustom.UseVisualStyleBackColor = true;
            picker_searchTransByCustom.CheckedChanged += picker_searchTransByCustom_CheckedChanged;
            // 
            // picker_searchTransInYear
            // 
            picker_searchTransInYear.AutoSize = true;
            picker_searchTransInYear.Location = new Point(362, 203);
            picker_searchTransInYear.Name = "picker_searchTransInYear";
            picker_searchTransInYear.Size = new Size(105, 24);
            picker_searchTransInYear.TabIndex = 5;
            picker_searchTransInYear.TabStop = true;
            picker_searchTransInYear.Text = "Trong năm ";
            picker_searchTransInYear.UseVisualStyleBackColor = true;
            // 
            // button_FindTransactions
            // 
            button_FindTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_FindTransactions.Location = new Point(74, 55);
            button_FindTransactions.Name = "button_FindTransactions";
            button_FindTransactions.Size = new Size(123, 44);
            button_FindTransactions.TabIndex = 4;
            button_FindTransactions.Text = "Tìm Kiếm";
            button_FindTransactions.UseVisualStyleBackColor = true;
            button_FindTransactions.Click += button1_Click;
            // 
            // picker_searchTransInMonth
            // 
            picker_searchTransInMonth.AutoSize = true;
            picker_searchTransInMonth.Location = new Point(362, 157);
            picker_searchTransInMonth.Name = "picker_searchTransInMonth";
            picker_searchTransInMonth.Size = new Size(114, 24);
            picker_searchTransInMonth.TabIndex = 3;
            picker_searchTransInMonth.TabStop = true;
            picker_searchTransInMonth.Text = "Trong tháng ";
            picker_searchTransInMonth.UseVisualStyleBackColor = true;
            picker_searchTransInMonth.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // picker_searchTransInWeek
            // 
            picker_searchTransInWeek.AutoSize = true;
            picker_searchTransInWeek.Location = new Point(227, 203);
            picker_searchTransInWeek.Name = "picker_searchTransInWeek";
            picker_searchTransInWeek.Size = new Size(101, 24);
            picker_searchTransInWeek.TabIndex = 2;
            picker_searchTransInWeek.TabStop = true;
            picker_searchTransInWeek.Text = "Trong tuần";
            picker_searchTransInWeek.UseVisualStyleBackColor = true;
            // 
            // picker_searchTransInDay
            // 
            picker_searchTransInDay.AutoSize = true;
            picker_searchTransInDay.Location = new Point(227, 157);
            picker_searchTransInDay.Name = "picker_searchTransInDay";
            picker_searchTransInDay.Size = new Size(104, 24);
            picker_searchTransInDay.TabIndex = 1;
            picker_searchTransInDay.TabStop = true;
            picker_searchTransInDay.Text = "Trong ngày";
            picker_searchTransInDay.UseVisualStyleBackColor = true;
            // 
            // searchByTransactionType
            // 
            searchByTransactionType.FormattingEnabled = true;
            searchByTransactionType.Items.AddRange(new object[] { "Chi Tiêu", "Thu Nhập" });
            searchByTransactionType.Location = new Point(74, 157);
            searchByTransactionType.Name = "searchByTransactionType";
            searchByTransactionType.Size = new Size(129, 70);
            searchByTransactionType.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 237);
            panel2.Name = "panel2";
            panel2.Size = new Size(1189, 590);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1189, 590);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UserControlAnalytic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlAnalytic";
            Size = new Size(1189, 827);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckedListBox searchByTransactionType;
        private Panel panel2;
        private DataGridView dataGridView1;
        private RadioButton picker_searchTransInMonth;
        private RadioButton picker_searchTransInWeek;
        private RadioButton picker_searchTransInDay;
        private Button button_FindTransactions;
        private RadioButton picker_searchTransInYear;
        private DateTimePicker dateTimePicker_To;
        private DateTimePicker dateTimePicker_From;
        private RadioButton picker_searchTransByCustom;
        private Label label_ChiTieu;
        private Label label_Income;
        private Label label_to;
        private Button button_Xoa;
        private Button button_chinhSua;
        private Button button_Create;
        private Label label1;
    }
}
