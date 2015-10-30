namespace Messing_with_types.Forms.main
{
    partial class Main
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
            this.NameBox = new System.Windows.Forms.Label();
            this.LevelBox = new System.Windows.Forms.Label();
            this.Gain10Points = new System.Windows.Forms.Button();
            this.Gain1Points = new System.Windows.Forms.Button();
            this.Gain100Points = new System.Windows.Forms.Button();
            this.Gain10000Points = new System.Windows.Forms.Button();
            this.Gain1000Points = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(321, 33);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(76, 31);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "User";
            // 
            // LevelBox
            // 
            this.LevelBox.AutoSize = true;
            this.LevelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelBox.Location = new System.Drawing.Point(322, 73);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(71, 25);
            this.LevelBox.TabIndex = 1;
            this.LevelBox.Text = "Level:\r";
            // 
            // Gain10Points
            // 
            this.Gain10Points.Location = new System.Drawing.Point(121, 170);
            this.Gain10Points.Name = "Gain10Points";
            this.Gain10Points.Size = new System.Drawing.Size(75, 23);
            this.Gain10Points.TabIndex = 5;
            this.Gain10Points.Text = "+10 Points";
            this.Gain10Points.UseVisualStyleBackColor = true;
            this.Gain10Points.Click += new System.EventHandler(this.Gain10Points_Click);
            // 
            // Gain1Points
            // 
            this.Gain1Points.Location = new System.Drawing.Point(40, 170);
            this.Gain1Points.Name = "Gain1Points";
            this.Gain1Points.Size = new System.Drawing.Size(75, 23);
            this.Gain1Points.TabIndex = 4;
            this.Gain1Points.Text = "+1 Points";
            this.Gain1Points.UseVisualStyleBackColor = true;
            this.Gain1Points.Click += new System.EventHandler(this.Gain1Points_Click);
            // 
            // Gain100Points
            // 
            this.Gain100Points.Location = new System.Drawing.Point(202, 170);
            this.Gain100Points.Name = "Gain100Points";
            this.Gain100Points.Size = new System.Drawing.Size(75, 23);
            this.Gain100Points.TabIndex = 6;
            this.Gain100Points.Text = "+100 Points";
            this.Gain100Points.UseVisualStyleBackColor = true;
            this.Gain100Points.Click += new System.EventHandler(this.Gain100Points_Click);
            // 
            // Gain10000Points
            // 
            this.Gain10000Points.Location = new System.Drawing.Point(364, 170);
            this.Gain10000Points.Name = "Gain10000Points";
            this.Gain10000Points.Size = new System.Drawing.Size(75, 23);
            this.Gain10000Points.TabIndex = 8;
            this.Gain10000Points.Text = "+10000 Points";
            this.Gain10000Points.UseVisualStyleBackColor = true;
            this.Gain10000Points.Click += new System.EventHandler(this.Gain10000Points_Click);
            // 
            // Gain1000Points
            // 
            this.Gain1000Points.Location = new System.Drawing.Point(283, 170);
            this.Gain1000Points.Name = "Gain1000Points";
            this.Gain1000Points.Size = new System.Drawing.Size(75, 23);
            this.Gain1000Points.TabIndex = 7;
            this.Gain1000Points.Text = "+1000 Points";
            this.Gain1000Points.UseVisualStyleBackColor = true;
            this.Gain1000Points.Click += new System.EventHandler(this.Gain1000Points_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gain10000Points);
            this.Controls.Add(this.Gain1000Points);
            this.Controls.Add(this.Gain100Points);
            this.Controls.Add(this.Gain10Points);
            this.Controls.Add(this.Gain1Points);
            this.Controls.Add(this.LevelBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Label LevelBox;
        private System.Windows.Forms.Button Gain10Points;
        private System.Windows.Forms.Button Gain1Points;
        private System.Windows.Forms.Button Gain100Points;
        private System.Windows.Forms.Button Gain10000Points;
        private System.Windows.Forms.Button Gain1000Points;
    }
}