namespace Secret_Hitler
{
    partial class ChooseChancellor
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
            this.label2 = new System.Windows.Forms.Label();
            this.RADBTN_Player1 = new System.Windows.Forms.RadioButton();
            this.RADBTN_Player2 = new System.Windows.Forms.RadioButton();
            this.RADBTN_Player3 = new System.Windows.Forms.RadioButton();
            this.RADBTN_Player4 = new System.Windows.Forms.RadioButton();
            this.BTN_Nominate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are the President. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Who do you choose to nominate as chancellor?";
            // 
            // RADBTN_Player1
            // 
            this.RADBTN_Player1.AutoSize = true;
            this.RADBTN_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_Player1.Location = new System.Drawing.Point(12, 83);
            this.RADBTN_Player1.Name = "RADBTN_Player1";
            this.RADBTN_Player1.Size = new System.Drawing.Size(112, 20);
            this.RADBTN_Player1.TabIndex = 2;
            this.RADBTN_Player1.TabStop = true;
            this.RADBTN_Player1.Text = "Player1 Name";
            this.RADBTN_Player1.UseVisualStyleBackColor = true;
            // 
            // RADBTN_Player2
            // 
            this.RADBTN_Player2.AutoSize = true;
            this.RADBTN_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_Player2.Location = new System.Drawing.Point(12, 109);
            this.RADBTN_Player2.Name = "RADBTN_Player2";
            this.RADBTN_Player2.Size = new System.Drawing.Size(112, 20);
            this.RADBTN_Player2.TabIndex = 3;
            this.RADBTN_Player2.TabStop = true;
            this.RADBTN_Player2.Text = "Player2 Name";
            this.RADBTN_Player2.UseVisualStyleBackColor = true;
            // 
            // RADBTN_Player3
            // 
            this.RADBTN_Player3.AutoSize = true;
            this.RADBTN_Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_Player3.Location = new System.Drawing.Point(12, 135);
            this.RADBTN_Player3.Name = "RADBTN_Player3";
            this.RADBTN_Player3.Size = new System.Drawing.Size(112, 20);
            this.RADBTN_Player3.TabIndex = 4;
            this.RADBTN_Player3.TabStop = true;
            this.RADBTN_Player3.Text = "Player3 Name";
            this.RADBTN_Player3.UseVisualStyleBackColor = true;
            // 
            // RADBTN_Player4
            // 
            this.RADBTN_Player4.AutoSize = true;
            this.RADBTN_Player4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RADBTN_Player4.Location = new System.Drawing.Point(12, 159);
            this.RADBTN_Player4.Name = "RADBTN_Player4";
            this.RADBTN_Player4.Size = new System.Drawing.Size(112, 20);
            this.RADBTN_Player4.TabIndex = 5;
            this.RADBTN_Player4.TabStop = true;
            this.RADBTN_Player4.Text = "Player4 Name";
            this.RADBTN_Player4.UseVisualStyleBackColor = true;
            // 
            // BTN_Nominate
            // 
            this.BTN_Nominate.Location = new System.Drawing.Point(274, 159);
            this.BTN_Nominate.Name = "BTN_Nominate";
            this.BTN_Nominate.Size = new System.Drawing.Size(75, 23);
            this.BTN_Nominate.TabIndex = 6;
            this.BTN_Nominate.Text = "Nominate";
            this.BTN_Nominate.UseVisualStyleBackColor = true;
            this.BTN_Nominate.Click += new System.EventHandler(this.BTN_Nominate_Click);
            // 
            // ChooseChancellor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 200);
            this.Controls.Add(this.BTN_Nominate);
            this.Controls.Add(this.RADBTN_Player4);
            this.Controls.Add(this.RADBTN_Player3);
            this.Controls.Add(this.RADBTN_Player2);
            this.Controls.Add(this.RADBTN_Player1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChooseChancellor";
            this.Text = "Nominate a chancellor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseChancellor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RADBTN_Player1;
        private System.Windows.Forms.RadioButton RADBTN_Player2;
        private System.Windows.Forms.RadioButton RADBTN_Player3;
        private System.Windows.Forms.RadioButton RADBTN_Player4;
        private System.Windows.Forms.Button BTN_Nominate;
    }
}