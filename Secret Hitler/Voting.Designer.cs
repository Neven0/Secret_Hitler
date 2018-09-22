namespace Secret_Hitler
{
    partial class Voting
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
            this.RADBTN_VoteYes = new System.Windows.Forms.RadioButton();
            this.RADBTN_VoteNo = new System.Windows.Forms.RadioButton();
            this.BTN_GiveVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text label";
            // 
            // RADBTN_VoteYes
            // 
            this.RADBTN_VoteYes.AutoSize = true;
            this.RADBTN_VoteYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_VoteYes.Location = new System.Drawing.Point(15, 62);
            this.RADBTN_VoteYes.Name = "RADBTN_VoteYes";
            this.RADBTN_VoteYes.Size = new System.Drawing.Size(51, 22);
            this.RADBTN_VoteYes.TabIndex = 1;
            this.RADBTN_VoteYes.TabStop = true;
            this.RADBTN_VoteYes.Text = "Yes";
            this.RADBTN_VoteYes.UseVisualStyleBackColor = true;
            // 
            // RADBTN_VoteNo
            // 
            this.RADBTN_VoteNo.AutoSize = true;
            this.RADBTN_VoteNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_VoteNo.Location = new System.Drawing.Point(15, 86);
            this.RADBTN_VoteNo.Name = "RADBTN_VoteNo";
            this.RADBTN_VoteNo.Size = new System.Drawing.Size(46, 22);
            this.RADBTN_VoteNo.TabIndex = 2;
            this.RADBTN_VoteNo.TabStop = true;
            this.RADBTN_VoteNo.Text = "No";
            this.RADBTN_VoteNo.UseVisualStyleBackColor = true;
            // 
            // BTN_GiveVote
            // 
            this.BTN_GiveVote.Location = new System.Drawing.Point(409, 94);
            this.BTN_GiveVote.Name = "BTN_GiveVote";
            this.BTN_GiveVote.Size = new System.Drawing.Size(75, 23);
            this.BTN_GiveVote.TabIndex = 3;
            this.BTN_GiveVote.Text = "Vote";
            this.BTN_GiveVote.UseVisualStyleBackColor = true;
            this.BTN_GiveVote.Click += new System.EventHandler(this.BTN_GiveVote_Click);
            // 
            // Voting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 129);
            this.Controls.Add(this.BTN_GiveVote);
            this.Controls.Add(this.RADBTN_VoteNo);
            this.Controls.Add(this.RADBTN_VoteYes);
            this.Controls.Add(this.label1);
            this.Name = "Voting";
            this.Text = "Voting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Voting_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RADBTN_VoteYes;
        private System.Windows.Forms.RadioButton RADBTN_VoteNo;
        private System.Windows.Forms.Button BTN_GiveVote;
    }
}