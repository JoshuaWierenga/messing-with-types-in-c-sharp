namespace level
{
    partial class Signup
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
            this.Signupbutton = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.Signuptext = new System.Windows.Forms.Label();
            this.Gotosignin = new System.Windows.Forms.LinkLabel();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Signupbutton
            // 
            this.Signupbutton.Location = new System.Drawing.Point(232, 71);
            this.Signupbutton.Name = "Signupbutton";
            this.Signupbutton.Size = new System.Drawing.Size(75, 23);
            this.Signupbutton.TabIndex = 0;
            this.Signupbutton.Text = "Sign up";
            this.Signupbutton.UseVisualStyleBackColor = true;
            this.Signupbutton.Click += new System.EventHandler(this.Signupbutton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(80, 47);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameBox.TabIndex = 1;
            // 
            // Signuptext
            // 
            this.Signuptext.AutoSize = true;
            this.Signuptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Signuptext.Location = new System.Drawing.Point(135, 10);
            this.Signuptext.Name = "Signuptext";
            this.Signuptext.Size = new System.Drawing.Size(70, 20);
            this.Signuptext.TabIndex = 4;
            this.Signuptext.Text = "Sign up";
            // 
            // Gotosignin
            // 
            this.Gotosignin.AutoSize = true;
            this.Gotosignin.Location = new System.Drawing.Point(114, 142);
            this.Gotosignin.Name = "Gotosignin";
            this.Gotosignin.Size = new System.Drawing.Size(132, 13);
            this.Gotosignin.TabIndex = 5;
            this.Gotosignin.TabStop = true;
            this.Gotosignin.Text = "Already have an account?";
            this.Gotosignin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Gotosignin_LinkClicked);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(80, 93);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 6;
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameText.Location = new System.Drawing.Point(20, 50);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(58, 13);
            this.UsernameText.TabIndex = 7;
            this.UsernameText.Text = "Username:";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordText.Location = new System.Drawing.Point(22, 96);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(56, 13);
            this.PasswordText.TabIndex = 8;
            this.PasswordText.Text = "Password:";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Gotosignin);
            this.Controls.Add(this.Signuptext);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.Signupbutton);
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(360, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Signupbutton;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label Signuptext;
        private System.Windows.Forms.LinkLabel Gotosignin;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label UsernameText;
        private System.Windows.Forms.Label PasswordText;
    }
}

