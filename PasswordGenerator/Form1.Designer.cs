namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.lblYourPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordLength.Location = new System.Drawing.Point(258, 22);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(245, 39);
            this.lblPasswordLength.TabIndex = 0;
            this.lblPasswordLength.Text = "Password Length";
            this.lblPasswordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPasswordLength.Location = new System.Drawing.Point(244, 64);
            this.txtPasswordLength.Multiline = true;
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(303, 37);
            this.txtPasswordLength.TabIndex = 1;
            // 
            // lblYourPassword
            // 
            this.lblYourPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYourPassword.Location = new System.Drawing.Point(253, 198);
            this.lblYourPassword.Name = "lblYourPassword";
            this.lblYourPassword.Size = new System.Drawing.Size(294, 74);
            this.lblYourPassword.TabIndex = 2;
            this.lblYourPassword.Text = "Your Password: ";
            this.lblYourPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(12, 258);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(776, 40);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopyPassword.Location = new System.Drawing.Point(284, 313);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(219, 70);
            this.btnCopyPassword.TabIndex = 4;
            this.btnCopyPassword.Text = "Copy Password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeneratePassword.Location = new System.Drawing.Point(244, 125);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(303, 70);
            this.btnGeneratePassword.TabIndex = 5;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblYourPassword);
            this.Controls.Add(this.txtPasswordLength);
            this.Controls.Add(this.lblPasswordLength);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.Label lblYourPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCopyPassword;
        private System.Windows.Forms.Button btnGeneratePassword;
    }
}

