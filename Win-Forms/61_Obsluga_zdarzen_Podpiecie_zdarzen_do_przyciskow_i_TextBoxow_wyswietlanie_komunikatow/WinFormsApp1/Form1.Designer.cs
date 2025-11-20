namespace WinFormsApp1
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
            textBoxLogin = new TextBox();
            textBoxPass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 27);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(439, 27);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(12, 82);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(439, 27);
            textBoxPass.TabIndex = 1;
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 145);
            button1.Name = "button1";
            button1.Size = new Size(439, 29);
            button1.TabIndex = 2;
            button1.Text = "Logowanie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 205);
            Controls.Add(button1);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPass;
        private Button button1;
    }
}
