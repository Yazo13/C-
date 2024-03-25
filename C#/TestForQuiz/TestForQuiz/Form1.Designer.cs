namespace TestForQuiz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(248, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Your Role";
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.User.Location = new System.Drawing.Point(132, 222);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(155, 56);
            this.User.TabIndex = 1;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Admin.Location = new System.Drawing.Point(447, 222);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(144, 56);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Button Admin;
    }
}

