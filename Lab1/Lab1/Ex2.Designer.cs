namespace Lab1
{
    partial class Ex2
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
            label4 = new Label();
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            textBoxNum3 = new TextBox();
            btn_Find = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(284, 29);
            label1.TabIndex = 0;
            label1.Text = "Tìm min max trong 3 số";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(26, 63);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Số Thứ Nhất";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(26, 93);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập Số Thứ Hai";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(26, 123);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhập Số Thứ Ba";
            label4.Click += label4_Click;
            // 
            // textBoxNum1
            // 
            textBoxNum1.BackColor = SystemColors.Window;
            textBoxNum1.Location = new Point(189, 62);
            textBoxNum1.Margin = new Padding(3, 2, 3, 2);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(300, 23);
            textBoxNum1.TabIndex = 4;
            textBoxNum1.TextChanged += textBoxNum1_TextChanged;
            // 
            // textBoxNum2
            // 
            textBoxNum2.BackColor = SystemColors.Window;
            textBoxNum2.Location = new Point(189, 92);
            textBoxNum2.Margin = new Padding(3, 2, 3, 2);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(300, 23);
            textBoxNum2.TabIndex = 5;
            textBoxNum2.TextChanged += textBox2_TextChanged;
            // 
            // textBoxNum3
            // 
            textBoxNum3.BackColor = SystemColors.Window;
            textBoxNum3.Location = new Point(189, 122);
            textBoxNum3.Margin = new Padding(3, 2, 3, 2);
            textBoxNum3.Name = "textBoxNum3";
            textBoxNum3.Size = new Size(300, 23);
            textBoxNum3.TabIndex = 6;
            textBoxNum3.TextChanged += textBoxNum3_TextChanged;
            // 
            // btn_Find
            // 
            btn_Find.Cursor = Cursors.Hand;
            btn_Find.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Find.Location = new Point(539, 53);
            btn_Find.Margin = new Padding(3, 2, 3, 2);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(100, 40);
            btn_Find.TabIndex = 8;
            btn_Find.Text = "Tính";
            btn_Find.UseVisualStyleBackColor = true;
            btn_Find.Click += btn_Find_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Cursor = Cursors.Hand;
            btn_Exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Exit.Location = new Point(539, 185);
            btn_Exit.Margin = new Padding(3, 2, 3, 2);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(100, 40);
            btn_Exit.TabIndex = 9;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Cursor = Cursors.Hand;
            btn_Restore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Restore.Location = new Point(539, 119);
            btn_Restore.Margin = new Padding(3, 2, 3, 2);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(100, 40);
            btn_Restore.TabIndex = 10;
            btn_Restore.Text = "Xóa";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // textBoxMax
            // 
            textBoxMax.BackColor = SystemColors.Window;
            textBoxMax.Location = new Point(189, 163);
            textBoxMax.Margin = new Padding(3, 2, 3, 2);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.ReadOnly = true;
            textBoxMax.Size = new Size(300, 23);
            textBoxMax.TabIndex = 11;
            textBoxMax.TextChanged += textBoxMax_TextChanged;
            // 
            // textBoxMin
            // 
            textBoxMin.BackColor = SystemColors.Window;
            textBoxMin.Location = new Point(189, 194);
            textBoxMin.Margin = new Padding(3, 2, 3, 2);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.ReadOnly = true;
            textBoxMin.Size = new Size(300, 23);
            textBoxMin.TabIndex = 12;
            textBoxMin.TextChanged += textBoxMin_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(26, 164);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 13;
            label5.Text = "Max";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(26, 195);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 14;
            label6.Text = "Min";
            label6.Click += label6_Click;
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBoxNum3);
            Controls.Add(label2);
            Controls.Add(textBoxNum2);
            Controls.Add(label3);
            Controls.Add(textBoxNum1);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxMin);
            Controls.Add(textBoxMax);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Find);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ex2";
            Text = "Bài2";
            FormClosed += Ex2_FormClosed;
            Load += Ex2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private TextBox textBoxNum3;
        private Button btn_Find;
        private Button btn_Exit;
        private Button btn_Restore;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private Label label5;
        private Label label6;
    }
}