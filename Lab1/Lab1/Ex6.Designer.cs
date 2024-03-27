namespace Lab1
{
    partial class Ex6
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
            textBoxResult = new TextBox();
            textBoxDay = new TextBox();
            textBoxMonth = new TextBox();
            label4 = new Label();
            btn_Find = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 42);
            label1.Name = "label1";
            label1.Size = new Size(218, 29);
            label1.TabIndex = 0;
            label1.Text = "Cung Hoàng Đạo ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(55, 94);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Ngày Sinh";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(55, 202);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 2;
            label3.Text = "Cung Của Bạn Là ";
            label3.Click += label3_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(213, 199);
            textBoxResult.Margin = new Padding(3, 2, 3, 2);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(200, 26);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBoxDay
            // 
            textBoxDay.BackColor = SystemColors.Window;
            textBoxDay.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDay.Location = new Point(213, 92);
            textBoxDay.Margin = new Padding(3, 2, 3, 2);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(200, 24);
            textBoxDay.TabIndex = 4;
            textBoxDay.TextChanged += textBoxDay_TextChanged;
            // 
            // textBoxMonth
            // 
            textBoxMonth.BackColor = SystemColors.Window;
            textBoxMonth.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMonth.Location = new Point(213, 146);
            textBoxMonth.Margin = new Padding(3, 2, 3, 2);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(200, 24);
            textBoxMonth.TabIndex = 6;
            textBoxMonth.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(55, 148);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 5;
            label4.Text = "Nhập Tháng Sinh";
            label4.Click += label4_Click;
            // 
            // btn_Find
            // 
            btn_Find.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Find.Location = new Point(445, 84);
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
            btn_Exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Exit.Location = new Point(445, 192);
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
            btn_Restore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Restore.Location = new Point(445, 138);
            btn_Restore.Margin = new Padding(3, 2, 3, 2);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(100, 40);
            btn_Restore.TabIndex = 10;
            btn_Restore.Text = "Xóa";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += button3_Click;
            // 
            // Ex6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBoxMonth);
            Controls.Add(btn_Restore);
            Controls.Add(textBoxDay);
            Controls.Add(label2);
            Controls.Add(btn_Exit);
            Controls.Add(label4);
            Controls.Add(btn_Find);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ex6";
            Text = "Bài 6";
            FormClosed += Ex6_FormClosed;
            Load += Ex6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxResult;
        private TextBox textBoxDay;
        private TextBox textBoxMonth;
        private Label label4;
        private Button btn_Find;
        private Button btn_Exit;
        private Button btn_Restore;
    }
}