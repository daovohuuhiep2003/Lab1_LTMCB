namespace Lab1_Bai4
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(116, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dec", "Bin", "Hex" });
            comboBox1.Location = new Point(168, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 43);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Dec", "Bin", "Hex" });
            comboBox2.Location = new Point(436, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 43);
            comboBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(168, 236);
            button1.Name = "button1";
            button1.Size = new Size(370, 43);
            button1.TabIndex = 7;
            button1.Text = "Thực hiện";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 41);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 145);
            label3.Name = "label3";
            label3.Size = new Size(70, 35);
            label3.TabIndex = 3;
            label3.Text = "Sang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(129, 35);
            label1.TabIndex = 1;
            label1.Text = "Nhập 1 số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 148);
            label2.Name = "label2";
            label2.Size = new Size(73, 35);
            label2.TabIndex = 2;
            label2.Text = "Chọn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(116, 359);
            label4.Name = "label4";
            label4.Size = new Size(100, 35);
            label4.TabIndex = 4;
            label4.Text = "Kết quả";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 367);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(496, 27);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(-3, 37);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(-3, 87);
            button3.Name = "button3";
            button3.Size = new Size(94, 35);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Đổi hệ cơ số";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}