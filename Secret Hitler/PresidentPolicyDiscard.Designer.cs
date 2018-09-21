namespace Secret_Hitler
{
    partial class PresidentPolicyDiscard
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
            this.LBL_IntroText = new System.Windows.Forms.Label();
            this.RADBTN_Policy1 = new System.Windows.Forms.RadioButton();
            this.RADBTN_Policy2 = new System.Windows.Forms.RadioButton();
            this.RADBTN_Policy3 = new System.Windows.Forms.RadioButton();
            this.BTN_Discard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_IntroText
            // 
            this.LBL_IntroText.AutoSize = true;
            this.LBL_IntroText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_IntroText.Location = new System.Drawing.Point(13, 13);
            this.LBL_IntroText.Name = "LBL_IntroText";
            this.LBL_IntroText.Size = new System.Drawing.Size(197, 18);
            this.LBL_IntroText.TabIndex = 0;
            this.LBL_IntroText.Text = "Intro text, should not be seen";
            // 
            // RADBTN_Policy1
            // 
            this.RADBTN_Policy1.AutoSize = true;
            this.RADBTN_Policy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_Policy1.Location = new System.Drawing.Point(16, 72);
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
            this.RADBTN_Policy2.Location = new System.Drawing.Point(16, 114);
            this.RADBTN_Policy2.Name = "RADBTN_Policy2";
            this.RADBTN_Policy2.Size = new System.Drawing.Size(78, 22);
            this.RADBTN_Policy2.TabIndex = 2;
            this.RADBTN_Policy2.TabStop = true;
            this.RADBTN_Policy2.Text = "Policy 2";
            this.RADBTN_Policy2.UseVisualStyleBackColor = true;
            // 
            // RADBTN_Policy3
            // 
            this.RADBTN_Policy3.AutoSize = true;
            this.RADBTN_Policy3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_Policy3.Location = new System.Drawing.Point(16, 159);
            this.RADBTN_Policy3.Name = "RADBTN_Policy3";
            this.RADBTN_Policy3.Size = new System.Drawing.Size(78, 22);
            this.RADBTN_Policy3.TabIndex = 3;
            this.RADBTN_Policy3.TabStop = true;
            this.RADBTN_Policy3.Text = "Policy 3";
            this.RADBTN_Policy3.UseVisualStyleBackColor = true;
            // 
            // BTN_Discard
            // 
            this.BTN_Discard.Location = new System.Drawing.Point(400, 203);
            this.BTN_Discard.Name = "BTN_Discard";
            this.BTN_Discard.Size = new System.Drawing.Size(75, 23);
            this.BTN_Discard.TabIndex = 4;
            this.BTN_Discard.Text = "Discard";
            this.BTN_Discard.UseVisualStyleBackColor = true;
            this.BTN_Discard.Click += new System.EventHandler(this.BTN_Discard_Click);
            // 
            // PresidentPolicyDiscard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 238);
            this.Controls.Add(this.BTN_Discard);
            this.Controls.Add(this.RADBTN_Policy3);
            this.Controls.Add(this.RADBTN_Policy2);
            this.Controls.Add(this.RADBTN_Policy1);
            this.Controls.Add(this.LBL_IntroText);
            this.Name = "PresidentPolicyDiscard";
            this.Text = "PresidentPolicyDiscard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PresidentPolicyDiscard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_IntroText;
        private System.Windows.Forms.RadioButton RADBTN_Policy1;
        private System.Windows.Forms.RadioButton RADBTN_Policy2;
        private System.Windows.Forms.RadioButton RADBTN_Policy3;
        private System.Windows.Forms.Button BTN_Discard;
    }
}