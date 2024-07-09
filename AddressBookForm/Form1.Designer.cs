namespace AddressBookForm
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
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(181, 124);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(274, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(181, 170);
            textBoxEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(274, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(181, 216);
            textBoxPhone.Margin = new Padding(4, 3, 4, 3);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(274, 23);
            textBoxPhone.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(181, 274);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(79, 27);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 98);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 152);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Email";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 198);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Phone Number";
            label3.Click += label1_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(354, 278);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(101, 23);
            btnDisplay.TabIndex = 5;
            btnDisplay.Text = "Show saved";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(622, 461);
            Controls.Add(btnDisplay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
            private System.Windows.Forms.TextBox textBoxEmail;
            private System.Windows.Forms.TextBox textBoxPhone;
            private System.Windows.Forms.Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDisplay;
    }
    

}
