namespace Test_Send_Email
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
            SEND_EMAIL = new Button();
            SuspendLayout();
            // 
            // SEND_EMAIL
            // 
            SEND_EMAIL.Location = new Point(311, 285);
            SEND_EMAIL.Name = "SEND_EMAIL";
            SEND_EMAIL.Size = new Size(94, 29);
            SEND_EMAIL.TabIndex = 0;
            SEND_EMAIL.Text = "Send";
            SEND_EMAIL.UseVisualStyleBackColor = true;
            SEND_EMAIL.Click += SEND_EMAIL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SEND_EMAIL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button SEND_EMAIL;
    }
}