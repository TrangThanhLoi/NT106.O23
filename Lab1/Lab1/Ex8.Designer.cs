namespace Lab1
{
    partial class Ex8
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
            label2 = new Label();
            btn_find = new Button();
            btn_del = new Button();
            btn_exit = new Button();
            textBoxResult = new TextBox();
            btn_add = new Button();
            label1 = new Label();
            textBoxInput = new TextBox();
            listBoxFood = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(136, 274);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 1;
            label2.Text = "Món Ăn Hôm Nay Là";
            label2.Click += label2_Click;
            // 
            // btn_find
            // 
            btn_find.Cursor = Cursors.Hand;
            btn_find.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_find.Location = new Point(414, 21);
            btn_find.Margin = new Padding(3, 2, 3, 2);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(150, 40);
            btn_find.TabIndex = 3;
            btn_find.Text = "Tìm Món Ăn";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += button2_Click;
            // 
            // btn_del
            // 
            btn_del.Cursor = Cursors.Hand;
            btn_del.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_del.Location = new Point(414, 139);
            btn_del.Margin = new Padding(3, 2, 3, 2);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(100, 40);
            btn_del.TabIndex = 4;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_restore_Click;
            // 
            // btn_exit
            // 
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_exit.Location = new Point(414, 198);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(100, 40);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ButtonHighlight;
            textBoxResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.ImeMode = ImeMode.NoControl;
            textBoxResult.Location = new Point(314, 271);
            textBoxResult.Margin = new Padding(3, 2, 3, 2);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(200, 26);
            textBoxResult.TabIndex = 7;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // btn_add
            // 
            btn_add.Cursor = Cursors.Hand;
            btn_add.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_add.Location = new Point(414, 80);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 40);
            btn_add.TabIndex = 2;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập Món Ăn";
            label1.Click += label1_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(159, 29);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(200, 24);
            textBoxInput.TabIndex = 6;
            textBoxInput.TextChanged += textBoxInput_TextChanged_1;
            // 
            // listBoxFood
            // 
            listBoxFood.FormattingEnabled = true;
            listBoxFood.ItemHeight = 15;
            listBoxFood.Location = new Point(75, 71);
            listBoxFood.Margin = new Padding(3, 2, 3, 2);
            listBoxFood.Name = "listBoxFood";
            listBoxFood.Size = new Size(284, 169);
            listBoxFood.TabIndex = 7;
            listBoxFood.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Ex8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 377);
            Controls.Add(listBoxFood);
            Controls.Add(btn_add);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxResult);
            Controls.Add(label1);
            Controls.Add(btn_del);
            Controls.Add(label2);
            Controls.Add(btn_find);
            Controls.Add(btn_exit);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ex8";
            Text = "Bài 8";
            FormClosed += Ex8_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btn_find;
        private Button btn_del;
        private Button btn_exit;
        private TextBox textBoxResult;
        private Button btn_add;
        private Label label1;
        private TextBox textBoxInput;
        private ListBox listBoxFood;
    }
}