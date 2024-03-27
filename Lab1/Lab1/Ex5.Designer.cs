namespace Lab1
{
    partial class Ex5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Cal = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            textBoxResult = new TextBox();
            textBoxInput1 = new TextBox();
            textBoxInput2 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(425, 29);
            label1.TabIndex = 0;
            label1.Text = "Bảng cửu chương và tính toán giá trị";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 76);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập A";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(46, 127);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập B";
            label3.Click += label3_Click;
            // 
            // btn_Cal
            // 
            btn_Cal.Cursor = Cursors.Hand;
            btn_Cal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Cal.Location = new Point(539, 66);
            btn_Cal.Margin = new Padding(3, 2, 3, 2);
            btn_Cal.Name = "btn_Cal";
            btn_Cal.Size = new Size(100, 40);
            btn_Cal.TabIndex = 3;
            btn_Cal.Text = "Tính";
            btn_Cal.UseVisualStyleBackColor = true;
            btn_Cal.Click += btn_Cal_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Cursor = Cursors.Hand;
            btn_Exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Exit.Location = new Point(539, 168);
            btn_Exit.Margin = new Padding(3, 2, 3, 2);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(100, 40);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Cursor = Cursors.Hand;
            btn_Restore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Restore.Location = new Point(539, 117);
            btn_Restore.Margin = new Padding(3, 2, 3, 2);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(100, 40);
            btn_Restore.TabIndex = 5;
            btn_Restore.Text = "Xóa";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(140, 232);
            textBoxResult.Margin = new Padding(3, 2, 3, 2);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(499, 80);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBoxInput1
            // 
            textBoxInput1.Location = new Point(140, 75);
            textBoxInput1.Margin = new Padding(3, 2, 3, 2);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(110, 23);
            textBoxInput1.TabIndex = 8;
            textBoxInput1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxInput2
            // 
            textBoxInput2.Location = new Point(140, 126);
            textBoxInput2.Margin = new Padding(3, 2, 3, 2);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(110, 23);
            textBoxInput2.TabIndex = 9;
            textBoxInput2.TextChanged += textBoxInput2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng Cửu Chương ( B - A )", "Tính Toán Giá Trị" });
            comboBox1.Location = new Point(140, 174);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 29);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(46, 178);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 12;
            label4.Text = "Lựa Chọn";
            label4.Click += label4_Click;
            // 
            // Ex5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxInput2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxInput1);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Cal);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ex5";
            Text = "Bài 5";
            FormClosed += Ex5_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Cal;
        private Button btn_Exit;
        private Button btn_Restore;
        private TextBox textBoxInput1;
        private TextBox textBoxInput2;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBoxResult;
    }
}