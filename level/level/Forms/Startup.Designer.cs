namespace level
{
    partial class Startup
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
            this.UserInfo = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserInfo
            // 
            this.UserInfo.AutoSize = true;
            this.UserInfo.Location = new System.Drawing.Point(117, 9);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(0, 13);
            this.UserInfo.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(42, 42);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Signup
            // 
            this.Signup.Location = new System.Drawing.Point(167, 42);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(75, 23);
            this.Signup.TabIndex = 6;
            this.Signup.Text = "Sign up";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.UserInfo);
            this.Name = "Startup";
            this.Text = "Startup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserInfo;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Signup;
    }
}

