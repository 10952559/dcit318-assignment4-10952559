namespace LoginApp
{
    partial class LoginPage
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
            button1 = new Button();
            UsernameField = new TextBox();
            PasswordField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(403, 82);
            button1.Name = "button1";
            button1.Size = new Size(59, 67);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UsernameField
            // 
            UsernameField.BackColor = Color.Yellow;
            UsernameField.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameField.Location = new Point(107, 49);
            UsernameField.Name = "UsernameField";
            UsernameField.Size = new Size(204, 30);
            UsernameField.TabIndex = 1;
            UsernameField.TextChanged += Username_TextChanged;
            // 
            // PasswordField
            // 
            PasswordField.BackColor = Color.Yellow;
            PasswordField.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordField.Location = new Point(107, 151);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.Size = new Size(204, 30);
            PasswordField.TabIndex = 2;
            PasswordField.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 202);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter password";
            label2.Click += label2_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 311);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordField);
            Controls.Add(UsernameField);
            Controls.Add(button1);
            Name = "LoginPage";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private Label label1;
        private Label label2;
    }
}
