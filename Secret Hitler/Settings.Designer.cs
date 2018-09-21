namespace Secret_Hitler
{
    partial class Settings
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
            this.TXTBOX_Player1Name = new System.Windows.Forms.TextBox();
            this.TXTBOX_Player2Name = new System.Windows.Forms.TextBox();
            this.TXTBOX_Player3Name = new System.Windows.Forms.TextBox();
            this.TXTBOX_Player4Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTBOX_Player1Name
            // 
            this.TXTBOX_Player1Name.Location = new System.Drawing.Point(44, 42);
            this.TXTBOX_Player1Name.Name = "TXTBOX_Player1Name";
            this.TXTBOX_Player1Name.Size = new System.Drawing.Size(263, 20);
            this.TXTBOX_Player1Name.TabIndex = 0;
            // 
            // TXTBOX_Player2Name
            // 
            this.TXTBOX_Player2Name.Location = new System.Drawing.Point(44, 93);
            this.TXTBOX_Player2Name.Name = "TXTBOX_Player2Name";
            this.TXTBOX_Player2Name.Size = new System.Drawing.Size(263, 20);
            this.TXTBOX_Player2Name.TabIndex = 1;
            // 
            // TXTBOX_Player3Name
            // 
            this.TXTBOX_Player3Name.Location = new System.Drawing.Point(45, 141);
            this.TXTBOX_Player3Name.Name = "TXTBOX_Player3Name";
            this.TXTBOX_Player3Name.Size = new System.Drawing.Size(262, 20);
            this.TXTBOX_Player3Name.TabIndex = 2;
            // 
            // TXTBOX_Player4Name
            // 
            this.TXTBOX_Player4Name.Location = new System.Drawing.Point(44, 194);
            this.TXTBOX_Player4Name.Name = "TXTBOX_Player4Name";
            this.TXTBOX_Player4Name.Size = new System.Drawing.Size(263, 20);
            this.TXTBOX_Player4Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Computer player names";
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(380, 251);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 5;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 286);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTBOX_Player4Name);
            this.Controls.Add(this.TXTBOX_Player3Name);
            this.Controls.Add(this.TXTBOX_Player2Name);
            this.Controls.Add(this.TXTBOX_Player1Name);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBOX_Player1Name;
        private System.Windows.Forms.TextBox TXTBOX_Player2Name;
        private System.Windows.Forms.TextBox TXTBOX_Player3Name;
        private System.Windows.Forms.TextBox TXTBOX_Player4Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_OK;
    }
}