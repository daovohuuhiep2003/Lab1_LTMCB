namespace Lab1_Bai5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(53, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách môn học và điểm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 35);
            label1.TabIndex = 1;
            label1.Text = "Phần mềm quản lí điểm";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 65);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Danh sách điểm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(694, 102);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 326);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 5;
            label3.Text = "Điểm trung bình: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 362);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 6;
            label4.Text = "Môn có điểm cao nhất: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 399);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 7;
            label5.Text = "Số môn đậu: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 326);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 8;
            label6.Text = "Học lực: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(409, 362);
            label7.Name = "label7";
            label7.Size = new Size(171, 20);
            label7.TabIndex = 9;
            label7.Text = "Môn có điểm thấp nhất: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 399);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 10;
            label8.Text = "Số môn không đậu: ";
            // 
            // button2
            // 
            button2.Location = new Point(694, 154);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Xử lí mảng & tổng hợp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
    }
}