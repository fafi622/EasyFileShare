namespace FileShareClient
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
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.IPlabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.AlertLable = new System.Windows.Forms.Label();
            this.FirstPanle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(84, 57);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(100, 20);
            this.IPtextbox.TabIndex = 0;
            this.IPtextbox.Text = "192.168.0.3";
            // 
            // IPlabel
            // 
            this.IPlabel.AutoSize = true;
            this.IPlabel.Location = new System.Drawing.Point(61, 60);
            this.IPlabel.Name = "IPlabel";
            this.IPlabel.Size = new System.Drawing.Size(17, 13);
            this.IPlabel.TabIndex = 1;
            this.IPlabel.Text = "IP";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(94, 83);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // AlertLable
            // 
            this.AlertLable.AutoSize = true;
            this.AlertLable.Location = new System.Drawing.Point(114, 145);
            this.AlertLable.Name = "AlertLable";
            this.AlertLable.Size = new System.Drawing.Size(0, 13);
            this.AlertLable.TabIndex = 3;
            // 
            // FirstPanle
            // 
            this.FirstPanle.Location = new System.Drawing.Point(3, 0);
            this.FirstPanle.Name = "FirstPanle";
            this.FirstPanle.Size = new System.Drawing.Size(282, 261);
            this.FirstPanle.TabIndex = 4;
            this.FirstPanle.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FirstPanle);
            this.Controls.Add(this.AlertLable);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.IPlabel);
            this.Controls.Add(this.IPtextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPtextbox;
        private System.Windows.Forms.Label IPlabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label AlertLable;
        private System.Windows.Forms.Panel FirstPanle;
    }
}

