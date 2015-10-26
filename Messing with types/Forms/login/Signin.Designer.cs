namespace Messing_with_types.Forms.login
{
    partial class Signin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Signintext = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Signinbutton = new System.Windows.Forms.Button();
            this.Gotosignup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Signintext
            // 
            this.Signintext.AutoSize = true;
            this.Signintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Signintext.Location = new System.Drawing.Point(135, 10);
            this.Signintext.Name = "Signintext";
            this.Signintext.Size = new System.Drawing.Size(64, 20);
            this.Signintext.TabIndex = 5;
            this.Signintext.Text = "Sign in";
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameText.Location = new System.Drawing.Point(20, 50);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(58, 13);
            this.UsernameText.TabIndex = 8;
            this.UsernameText.Text = "Username:";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordText.Location = new System.Drawing.Point(22, 96);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(56, 13);
            this.PasswordText.TabIndex = 9;
            this.PasswordText.Text = "Password:";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(80, 47);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameBox.TabIndex = 10;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(80, 93);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 11;
            // 
            // Signinbutton
            // 
            this.Signinbutton.Location = new System.Drawing.Point(232, 71);
            this.Signinbutton.Name = "Signinbutton";
            this.Signinbutton.Size = new System.Drawing.Size(75, 23);
            this.Signinbutton.TabIndex = 12;
            this.Signinbutton.Text = "Sign in";
            this.Signinbutton.UseVisualStyleBackColor = true;
            this.Signinbutton.Click += new System.EventHandler(this.Signinbutton_Click);
            // 
            // Gotosignup
            // 
            this.Gotosignup.AutoSize = true;
            this.Gotosignup.Location = new System.Drawing.Point(110, 142);
            this.Gotosignup.Name = "Gotosignup";
            this.Gotosignup.Size = new System.Drawing.Size(140, 13);
            this.Gotosignup.TabIndex = 13;
            this.Gotosignup.TabStop = true;
            this.Gotosignup.Text = "Don`t have an account yet?";
            this.Gotosignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Gotosignup_LinkClicked);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gotosignup);
            this.Controls.Add(this.Signinbutton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.Signintext);
            this.Name = "Signin";
            this.Size = new System.Drawing.Size(360, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Signintext;
        private System.Windows.Forms.Label UsernameText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Signinbutton;
        private System.Windows.Forms.LinkLabel Gotosignup;
    }
}
