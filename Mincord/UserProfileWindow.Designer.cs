
namespace Mincord
{
    partial class UserProfileWindow
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
            this.userLabel = new System.Windows.Forms.Label();
            this.globalLabel = new System.Windows.Forms.Label();
            this.avatarPicture = new System.Windows.Forms.WebBrowser();
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLabel.Location = new System.Drawing.Point(144, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(83, 20);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username";
            // 
            // globalLabel
            // 
            this.globalLabel.AutoSize = true;
            this.globalLabel.Location = new System.Drawing.Point(144, 44);
            this.globalLabel.Name = "globalLabel";
            this.globalLabel.Size = new System.Drawing.Size(66, 13);
            this.globalLabel.TabIndex = 2;
            this.globalLabel.Text = "Global name";
            // 
            // avatarPicture
            // 
            this.avatarPicture.AllowNavigation = false;
            this.avatarPicture.IsWebBrowserContextMenuEnabled = false;
            this.avatarPicture.Location = new System.Drawing.Point(12, 13);
            this.avatarPicture.MinimumSize = new System.Drawing.Size(20, 20);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.ScrollBarsEnabled = false;
            this.avatarPicture.Size = new System.Drawing.Size(126, 102);
            this.avatarPicture.TabIndex = 3;
            this.avatarPicture.TabStop = false;
            this.avatarPicture.WebBrowserShortcutsEnabled = false;
            // 
            // bioTextBox
            // 
            this.bioTextBox.Enabled = false;
            this.bioTextBox.Location = new System.Drawing.Point(145, 72);
            this.bioTextBox.Multiline = true;
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.Size = new System.Drawing.Size(142, 110);
            this.bioTextBox.TabIndex = 4;
            // 
            // UserProfileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(299, 194);
            this.Controls.Add(this.bioTextBox);
            this.Controls.Add(this.avatarPicture);
            this.Controls.Add(this.globalLabel);
            this.Controls.Add(this.userLabel);
            this.MaximizeBox = false;
            this.Name = "UserProfileWindow";
            this.ShowIcon = false;
            this.Text = "Profile of";
            this.Load += new System.EventHandler(this.UserProfileWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label globalLabel;
        private System.Windows.Forms.WebBrowser avatarPicture;
        private System.Windows.Forms.TextBox bioTextBox;
    }
}