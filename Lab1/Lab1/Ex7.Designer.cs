namespace Lab1
{
	partial class Ex7
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
            textBoxInputScores = new TextBox();
            labelInputScores = new Label();
            listViewScores = new ListView();
            columnSubject = new ColumnHeader();
            columnGrades = new ColumnHeader();
            labelAvg = new Label();
            labelMax = new Label();
            labelMin = new Label();
            labelGrade = new Label();
            labelPassed = new Label();
            labelFailed = new Label();
            textBoxAvg = new TextBox();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            textBoxGrades = new TextBox();
            textBoxPass = new TextBox();
            textBoxFail = new TextBox();
            labelTitle = new Label();
            buttonCalc = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            label1 = new Label();
            textBoxStudentName = new TextBox();
            SuspendLayout();
            // 
            // textBoxInputScores
            // 
            textBoxInputScores.BackColor = SystemColors.Window;
            textBoxInputScores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxInputScores.Location = new Point(237, 44);
            textBoxInputScores.Margin = new Padding(2);
            textBoxInputScores.Name = "textBoxInputScores";
            textBoxInputScores.Size = new Size(200, 26);
            textBoxInputScores.TabIndex = 0;
            textBoxInputScores.TextChanged += textBoxInputScores_TextChanged;
            // 
            // labelInputScores
            // 
            labelInputScores.AutoSize = true;
            labelInputScores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelInputScores.Location = new Point(46, 47);
            labelInputScores.Margin = new Padding(2, 0, 2, 0);
            labelInputScores.Name = "labelInputScores";
            labelInputScores.Size = new Size(187, 20);
            labelInputScores.TabIndex = 1;
            labelInputScores.Text = "Nhập Họ Tên Và Điểm";
            labelInputScores.Click += labelInputScores_Click;
            // 
            // listViewScores
            // 
            listViewScores.Columns.AddRange(new ColumnHeader[] { columnSubject, columnGrades });
            listViewScores.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            listViewScores.FullRowSelect = true;
            listViewScores.GridLines = true;
            listViewScores.Location = new Point(495, 145);
            listViewScores.Margin = new Padding(2);
            listViewScores.Name = "listViewScores";
            listViewScores.Size = new Size(163, 195);
            listViewScores.TabIndex = 2;
            listViewScores.UseCompatibleStateImageBehavior = false;
            listViewScores.View = View.Details;
            listViewScores.SelectedIndexChanged += listViewScores_SelectedIndexChanged;
            // 
            // columnSubject
            // 
            columnSubject.Text = "Môn";
            columnSubject.Width = 110;
            // 
            // columnGrades
            // 
            columnGrades.Text = "Điểm";
            columnGrades.Width = 100;
            // 
            // labelAvg
            // 
            labelAvg.AutoSize = true;
            labelAvg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelAvg.Location = new Point(46, 109);
            labelAvg.Margin = new Padding(2, 0, 2, 0);
            labelAvg.Name = "labelAvg";
            labelAvg.Size = new Size(142, 20);
            labelAvg.TabIndex = 3;
            labelAvg.Text = "Điểm Trung Bình";
            labelAvg.Click += labelAvg_Click;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelMax.Location = new Point(46, 140);
            labelMax.Margin = new Padding(2, 0, 2, 0);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(130, 20);
            labelMax.TabIndex = 4;
            labelMax.Text = "Điểm Cao Nhất";
            labelMax.Click += labelMax_Click;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelMin.Location = new Point(46, 171);
            labelMin.Margin = new Padding(2, 0, 2, 0);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(138, 20);
            labelMin.TabIndex = 5;
            labelMin.Text = "Điểm Thấp Nhất";
            labelMin.Click += labelMin_Click;
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelGrade.Location = new Point(46, 202);
            labelGrade.Margin = new Padding(2, 0, 2, 0);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(80, 20);
            labelGrade.TabIndex = 6;
            labelGrade.Text = "Xếp Loại";
            labelGrade.Click += labelGrade_Click;
            // 
            // labelPassed
            // 
            labelPassed.AutoSize = true;
            labelPassed.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelPassed.Location = new Point(46, 233);
            labelPassed.Margin = new Padding(2, 0, 2, 0);
            labelPassed.Name = "labelPassed";
            labelPassed.Size = new Size(108, 20);
            labelPassed.TabIndex = 7;
            labelPassed.Text = "Số Môn Đậu";
            labelPassed.Click += labelPassed_Click;
            // 
            // labelFailed
            // 
            labelFailed.AutoSize = true;
            labelFailed.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelFailed.Location = new Point(46, 264);
            labelFailed.Margin = new Padding(2, 0, 2, 0);
            labelFailed.Name = "labelFailed";
            labelFailed.Size = new Size(104, 20);
            labelFailed.TabIndex = 8;
            labelFailed.Text = "Số Môn Rớt";
            labelFailed.Click += labelFailed_Click;
            // 
            // textBoxAvg
            // 
            textBoxAvg.BackColor = SystemColors.Window;
            textBoxAvg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxAvg.Location = new Point(237, 106);
            textBoxAvg.Margin = new Padding(2);
            textBoxAvg.Name = "textBoxAvg";
            textBoxAvg.ReadOnly = true;
            textBoxAvg.Size = new Size(200, 26);
            textBoxAvg.TabIndex = 9;
            textBoxAvg.TextChanged += textBoxAvg_TextChanged;
            // 
            // textBoxMax
            // 
            textBoxMax.BackColor = SystemColors.Window;
            textBoxMax.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxMax.Location = new Point(237, 137);
            textBoxMax.Margin = new Padding(2);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.ReadOnly = true;
            textBoxMax.Size = new Size(200, 26);
            textBoxMax.TabIndex = 10;
            textBoxMax.TextChanged += textBoxMax_TextChanged;
            // 
            // textBoxMin
            // 
            textBoxMin.BackColor = SystemColors.Window;
            textBoxMin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxMin.Location = new Point(237, 168);
            textBoxMin.Margin = new Padding(2);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.ReadOnly = true;
            textBoxMin.Size = new Size(200, 26);
            textBoxMin.TabIndex = 11;
            textBoxMin.TextChanged += textBoxMin_TextChanged;
            // 
            // textBoxGrades
            // 
            textBoxGrades.BackColor = SystemColors.Window;
            textBoxGrades.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxGrades.Location = new Point(237, 199);
            textBoxGrades.Margin = new Padding(2);
            textBoxGrades.Name = "textBoxGrades";
            textBoxGrades.ReadOnly = true;
            textBoxGrades.Size = new Size(200, 26);
            textBoxGrades.TabIndex = 12;
            textBoxGrades.TextChanged += textBoxGrades_TextChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = SystemColors.Window;
            textBoxPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxPass.Location = new Point(237, 230);
            textBoxPass.Margin = new Padding(2);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.ReadOnly = true;
            textBoxPass.Size = new Size(200, 26);
            textBoxPass.TabIndex = 13;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // textBoxFail
            // 
            textBoxFail.BackColor = SystemColors.Window;
            textBoxFail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxFail.Location = new Point(237, 261);
            textBoxFail.Margin = new Padding(2);
            textBoxFail.Name = "textBoxFail";
            textBoxFail.ReadOnly = true;
            textBoxFail.Size = new Size(200, 26);
            textBoxFail.TabIndex = 14;
            textBoxFail.TextChanged += textBoxFail_TextChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(11, 11);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(472, 31);
            labelTitle.TabIndex = 15;
            labelTitle.Text = "Tính điểm sinh viên theo danh sách";
            labelTitle.Click += labelTitle_Click;
            // 
            // buttonCalc
            // 
            buttonCalc.Cursor = Cursors.Hand;
            buttonCalc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonCalc.Location = new Point(558, 11);
            buttonCalc.Margin = new Padding(2);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(100, 40);
            buttonCalc.TabIndex = 16;
            buttonCalc.Text = "Tính";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // buttonReset
            // 
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonReset.Location = new Point(558, 56);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(100, 40);
            buttonReset.TabIndex = 17;
            buttonReset.Text = "Xóa";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonExit.Location = new Point(558, 101);
            buttonExit.Margin = new Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(100, 40);
            buttonExit.TabIndex = 18;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(46, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 19;
            label1.Text = "Tên Sinh Viên";
            label1.Click += label1_Click;
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.BackColor = SystemColors.Window;
            textBoxStudentName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxStudentName.Location = new Point(237, 75);
            textBoxStudentName.Margin = new Padding(2);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.ReadOnly = true;
            textBoxStudentName.Size = new Size(200, 26);
            textBoxStudentName.TabIndex = 20;
            textBoxStudentName.TextChanged += textBoxStudentName_TextChanged;
            // 
            // Ex7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 351);
            Controls.Add(textBoxStudentName);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonCalc);
            Controls.Add(labelTitle);
            Controls.Add(textBoxFail);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxGrades);
            Controls.Add(textBoxMin);
            Controls.Add(textBoxMax);
            Controls.Add(textBoxAvg);
            Controls.Add(labelFailed);
            Controls.Add(labelPassed);
            Controls.Add(labelGrade);
            Controls.Add(labelMin);
            Controls.Add(labelMax);
            Controls.Add(labelAvg);
            Controls.Add(listViewScores);
            Controls.Add(labelInputScores);
            Controls.Add(textBoxInputScores);
            Margin = new Padding(2);
            Name = "Ex7";
            Text = "Bài 7";
            FormClosed += Ex7_FormClosed;
            Load += Ex7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputScores;
		private Label labelInputScores;
		private ListView listViewScores;
		private Label labelAvg;
		private Label labelMax;
		private Label labelMin;
		private Label labelGrade;
		private Label labelPassed;
		private Label labelFailed;
		private TextBox textBoxAvg;
		private TextBox textBoxMax;
		private TextBox textBoxMin;
		private TextBox textBoxGrades;
		private TextBox textBoxPass;
		private TextBox textBoxFail;
		private Label labelTitle;
		private Button buttonCalc;
		private Button buttonReset;
		private Button buttonExit;
		private ColumnHeader columnSubject;
		private ColumnHeader columnGrades;
        private Label label1;
        private TextBox textBoxStudentName;
    }
}