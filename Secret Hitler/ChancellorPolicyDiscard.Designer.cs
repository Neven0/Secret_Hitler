namespace Secret_Hitler
{
    partial class ChancellorPolicyDiscard
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
            this.LBL_InfoText = new System.Windows.Forms.Label();
            this.RADBTN_Policy1 = new System.Windows.Forms.RadioButton();
            this.RADBTN_Policy2 = new System.Windows.Forms.RadioButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.BTN_Discard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_InfoText
            // 
            this.LBL_InfoText.AutoSize = true;
            this.LBL_InfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_InfoText.Location = new System.Drawing.Point(12, 9);
            this.LBL_InfoText.Name = "LBL_InfoText";
            this.LBL_InfoText.Size = new System.Drawing.Size(192, 18);
            this.LBL_InfoText.TabIndex = 0;
            this.LBL_InfoText.Text = "Info text, should not be seen";
            // 
            // RADBTN_Policy1
            // 
            this.RADBTN_Policy1.AutoSize = true;
            this.RADBTN_Policy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_Policy1.Location = new System.Drawing.Point(15, 78);
            this.RADBTN_Policy1.Name = "RADBTN_Policy1";
            this.RADBTN_Policy1.Size = new System.Drawing.Size(78, 22);
            this.RADBTN_Policy1.TabIndex = 1;
            this.RADBTN_Policy1.TabStop = true;
            this.RADBTN_Policy1.Text = "Policy 1";
            this.RADBTN_Policy1.UseVisualStyleBackColor = true;
            // 
            // RADBTN_Policy2
            // 
            this.RADBTN_Policy2.AutoSize = true;
            this.RADBTN_Policy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_Policy2.Location = new System.Drawing.Point(15, 135);
            this.RADBTN_Policy2.Name = "RADBTN_Policy2";
            this.RADBTN_Policy2.Size = new System.Drawing.Size(78, 22);
            this.RADBTN_Policy2.TabIndex = 2;
            this.RADBTN_Policy2.TabStop = true;
            this.RADBTN_Policy2.Text = "Policy 2";
            this.RADBTN_Policy2.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // BTN_Discard
            // 
            this.BTN_Discard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_Discard.Location = new System.Drawing.Point(336, 195);
            this.BTN_Discard.Name = "BTN_Discard";
            this.BTN_Discard.Size = new System.Drawing.Size(75, 23);
            this.BTN_Discard.TabIndex = 3;
            this.BTN_Discard.Text = "Discard";
            this.BTN_Discard.UseVisualStyleBackColor = true;
            this.BTN_Discard.Click += new System.EventHandler(this.BTN_Discard_Click);
            // 
            // ChancellorPolicyDiscard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 230);
            this.Controls.Add(this.BTN_Discard);
            this.Controls.Add(this.RADBTN_Policy2);
            this.Controls.Add(this.RADBTN_Policy1);
            this.Controls.Add(this.LBL_InfoText);
            this.Name = "ChancellorPolicyDiscard";
            this.Text = "ChancellorPolicyDiscard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChancellorPolicyDiscard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_InfoText;
        private System.Windows.Forms.RadioButton RADBTN_Policy1;
        private System.Windows.Forms.RadioButton RADBTN_Policy2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button BTN_Discard;
    }
}