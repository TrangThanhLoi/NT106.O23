namespace Lab1
{
    partial class Ex1
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
            lb_EnterNum2 = new Label();
            lb_enterNum1 = new Label();
            textBoxNum2 = new TextBox();
            textBoxNum1 = new TextBox();
            btn_Cal = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            label4 = new Label();
            textBoxSum = new TextBox();
            lb_res = new Label();
            SuspendLayout();
            // 
            // lb_EnterNum2
            // 
            lb_EnterNum2.AutoSize = true;
            lb_EnterNum2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lb_EnterNum2.Location = new Point(39, 124);
            lb_EnterNum2.Name = "lb_EnterNum2";
            lb_EnterNum2.Size = new Size(95, 20);
            lb_EnterNum2.TabIndex = 3;
            lb_EnterNum2.Text = "Nhập Số B";
            lb_EnterNum2.Click += lb_EnterNum2_Click;
            // 
            // lb_enterNum1
            // 
            lb_enterNum1.AutoSize = true;
            lb_enterNum1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lb_enterNum1.Location = new Point(39, 83);
            lb_enterNum1.Name = "lb_enterNum1";
            lb_enterNum1.Size = new Size(95, 20);
            lb_enterNum1.TabIndex = 2;
            lb_enterNum1.Text = "Nhập Số A";
            lb_enterNum1.Click += lb_enterNum1_Click;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNum2.Location = new Point(206, 120);
            textBoxNum2.Margin = new Padding(3, 2, 3, 2);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(300, 28);
            textBoxNum2.TabIndex = 1;
            textBoxNum2.TextChanged += textBoxNum2_TextChanged;
            // 
            // textBoxNum1
            // 
            textBoxNum1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNum1.Location = new Point(206, 79);
            textBoxNum1.Margin = new Padding(3, 2, 3, 2);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(300, 28);
            textBoxNum1.TabIndex = 0;
            textBoxNum1.TextChanged += textBox1Num_TextChanged;
            // 
            // btn_Cal
            // 
            btn_Cal.Cursor = Cursors.Hand;
            btn_Cal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Cal.Location = new Point(515, 73);
            btn_Cal.Margin = new Padding(3, 2, 3, 2);
            btn_Cal.Name = "btn_Cal";
            btn_Cal.Size = new Size(100, 40);
            btn_Cal.TabIndex = 1;
            btn_Cal.Text = "Tính";
            btn_Cal.UseVisualStyleBackColor = true;
            btn_Cal.Click += btn_Cal_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Cursor = Cursors.Hand;
            btn_Exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Exit.Location = new Point(515, 155);
            btn_Exit.Margin = new Padding(3, 2, 3, 2);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(100, 40);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Cursor = Cursors.Hand;
            btn_Restore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Restore.Location = new Point(515, 114);
            btn_Restore.Margin = new Padding(3, 2, 3, 2);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(100, 40);
            btn_Restore.TabIndex = 3;
            btn_Restore.Text = "Xóa";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 14);
            label4.Name = "label4";
            label4.Size = new Size(218, 29);
            label4.TabIndex = 5;
            label4.Text = "Tính Tổng Hai Số";
            label4.Click += label4_Click;
            // 
            // textBoxSum
            // 
            textBoxSum.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSum.Location = new Point(206, 161);
            textBoxSum.Margin = new Padding(3, 2, 3, 2);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.ReadOnly = true;
            textBoxSum.Size = new Size(300, 28);
            textBoxSum.TabIndex = 6;
            textBoxSum.TextChanged += textBoxRes_TextChanged;
            // 
            // lb_res
            // 
            lb_res.AutoSize = true;
            lb_res.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lb_res.Location = new Point(39, 165);
            lb_res.Name = "lb_res";
            lb_res.Size = new Size(74, 20);
            lb_res.TabIndex = 7;
            lb_res.Text = "Kết Quả";
            lb_res.Click += lb_res_Click;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lb_EnterNum2);
            Controls.Add(lb_enterNum1);
            Controls.Add(lb_res);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxSum);
            Controls.Add(textBoxNum1);
            Controls.Add(label4);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Cal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ex1";
            Text = "Bài1";
            FormClosed += Ex1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_EnterNum2;
        private Label lb_enterNum1;
        private TextBox textBoxNum2;
        private TextBox textBoxNum1;
        private Button btn_Cal;
        private Button btn_Exit;
        private Button btn_Restore;
        private Label label4;
        private TextBox textBoxSum;
        private Label lb_res;
    }
}