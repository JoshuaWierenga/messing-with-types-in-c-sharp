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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}