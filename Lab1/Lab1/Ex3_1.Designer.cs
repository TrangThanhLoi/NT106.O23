namespace Lab1
{
    partial class Ex3_1
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
            button_Read = new Button();
            button2 = new Button();
            btn_Restore = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(317, 29);
            label1.TabIndex = 0;
            label1.Text = "Chuyển số thành chữ ver.2";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(35, 93);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Số Dưới 12 Chữ Số";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(35, 181);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết Quả";
            label3.Click += label3_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(35, 211);
            textBoxResult.Margin = new Padding(3, 2, 3, 2);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(492, 67);
            textBoxResult.TabIndex = 4;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = SystemColors.Window;
            textBoxInput.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(250, 90);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(252, 26);
            textBoxInput.TabIndex = 3;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // button_Read
            // 
            button_Read.Cursor = Cursors.Hand;
            button_Read.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button_Read.Location = new Point(540, 83);
            button_Read.Margin = new Padding(3, 2, 3, 2);
            button_Read.Name = "button_Read";
            button_Read.Size = new Size(100, 40);
            button_Read.TabIndex = 4;
            button_Read.Text = "Tính";
            button_Read.UseVisualStyleBackColor = true;
            button_Read.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button2.Location = new Point(540, 171);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 5;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Cursor = Cursors.Hand;
            btn_Restore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Restore.Location = new Point(540, 127);
            btn_Restore.Margin = new Padding(3, 2, 3, 2);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(100, 40);
            btn_Restore.TabIndex = 6;
            btn_Restore.Text = "Xóa";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // Ex3_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBoxResult);
            Controls.Add(btn_Restore);
            Controls.Add(textBoxInput);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_Read);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ex3_1";
            Text = "Bài 3.1";
            FormClosed += Ex3_1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxResult;
        private TextBox textBoxInput;
        private Button button_Read;
        private Button button2;
        private Button btn_Restore;
    }
}