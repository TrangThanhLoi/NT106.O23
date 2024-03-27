namespace Lab1
{
    partial class Ex3
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
            textBoxInput = new TextBox();
            btn_Read = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(253, 29);
            label1.TabIndex = 0;
            label1.Text = "Chuyển số thành chữ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(41, 111);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập vào số từ 0 - 9";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(41, 202);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết Quả";
            label3.Click += label3_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(332, 199);
            textBoxResult.Margin = new Padding(3, 2, 3, 2);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(200, 26);
            textBoxResult.TabIndex = 8;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = SystemColors.Window;
            textBoxInput.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(332, 108);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(200, 26);
            textBoxInput.TabIndex = 7;
            textBoxInput.TextChanged += textBox1_TextChanged;
            // 
            // btn_Read
            // 
            btn_Read.Cursor = Cursors.Hand;
            btn_Read.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Read.Location = new Point(538, 101);
            btn_Read.Margin = new Padding(3, 2, 3, 2);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(100, 40);
            btn_Read.TabIndex = 4;
            btn_Read.Text = "Tính";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Cursor = Cursors.Hand;
            btn_Exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Exit.Location = new Point(538, 191);
            btn_Exit.Margin = new Padding(3, 2, 3, 2);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(100, 40);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += button2_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Cursor = Cursors.Hand;
            btn_Restore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Restore.Location = new Point(538, 146);
            btn_Restore.Margin = new Padding(3, 2, 3, 2);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(100, 40);
            btn_Restore.TabIndex = 6;
            btn_Restore.Text = "Xóa";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 350);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxResult);
            Controls.Add(btn_Restore);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Read);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ex3";
            Text = "Bài3";
            FormClosed += Ex3_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxResult;
        private TextBox textBoxInput;
        private Button btn_Read;
        private Button btn_Exit;
        private Button btn_Restore;
    }
}