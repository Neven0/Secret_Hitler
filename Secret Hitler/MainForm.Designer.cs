namespace Secret_Hitler
{
    partial class MainForm
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
            this.BTN_NewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_Player1 = new System.Windows.Forms.Label();
            this.LBL_Player2 = new System.Windows.Forms.Label();
            this.LBL_Player3 = new System.Windows.Forms.Label();
            this.LBL_Player4 = new System.Windows.Forms.Label();
            this.LBL_PlayerHuman = new System.Windows.Forms.Label();
            this.TXTBOX_PlayerHumanName = new System.Windows.Forms.TextBox();
            this.LBL_PlayerHumanTXTBOX = new System.Windows.Forms.Label();
            this.BTN_Settings = new System.Windows.Forms.Button();
            this.LBL_LiberalLaws = new System.Windows.Forms.Label();
            this.LBL_FacistLaws = new System.Windows.Forms.Label();
            this.LBL_Player1Role = new System.Windows.Forms.Label();
            this.LBL_Player2Role = new System.Windows.Forms.Label();
            this.LBL_Player4Role = new System.Windows.Forms.Label();
            this.LBL_Player3Role = new System.Windows.Forms.Label();
            this.LBL_HumanPlayerRole = new System.Windows.Forms.Label();
            this.BTN_Continuation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_NewGame
            // 
            this.BTN_NewGame.Location = new System.Drawing.Point(676, 77);
            this.BTN_NewGame.Name = "BTN_NewGame";
            this.BTN_NewGame.Size = new System.Drawing.Size(75, 23);
            this.BTN_NewGame.TabIndex = 0;
            this.BTN_NewGame.Text = "New Game";
            this.BTN_NewGame.UseVisualStyleBackColor = true;
            this.BTN_NewGame.Click += new System.EventHandler(this.BTN_NewGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(57, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 391);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_Player1
            // 
            this.LBL_Player1.AutoSize = true;
            this.LBL_Player1.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Player1.Location = new System.Drawing.Point(116, 147);
            this.LBL_Player1.Name = "LBL_Player1";
            this.LBL_Player1.Size = new System.Drawing.Size(107, 20);
            this.LBL_Player1.TabIndex = 2;
            this.LBL_Player1.Text = "Player1 Name";
            this.LBL_Player1.Visible = false;
            // 
            // LBL_Player2
            // 
            this.LBL_Player2.AutoSize = true;
            this.LBL_Player2.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Player2.Location = new System.Drawing.Point(116, 270);
            this.LBL_Player2.Name = "LBL_Player2";
            this.LBL_Player2.Size = new System.Drawing.Size(107, 20);
            this.LBL_Player2.TabIndex = 3;
            this.LBL_Player2.Text = "Player2 Name";
            this.LBL_Player2.Visible = false;
            // 
            // LBL_Player3
            // 
            this.LBL_Player3.AutoSize = true;
            this.LBL_Player3.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Player3.Location = new System.Drawing.Point(485, 147);
            this.LBL_Player3.Name = "LBL_Player3";
            this.LBL_Player3.Size = new System.Drawing.Size(107, 20);
            this.LBL_Player3.TabIndex = 4;
            this.LBL_Player3.Text = "Player3 Name";
            this.LBL_Player3.Visible = false;
            // 
            // LBL_Player4
            // 
            this.LBL_Player4.AutoSize = true;
            this.LBL_Player4.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Player4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Player4.Location = new System.Drawing.Point(485, 270);
            this.LBL_Player4.Name = "LBL_Player4";
            this.LBL_Player4.Size = new System.Drawing.Size(107, 20);
            this.LBL_Player4.TabIndex = 5;
            this.LBL_Player4.Text = "Player4 Name";
            this.LBL_Player4.Visible = false;
            // 
            // LBL_PlayerHuman
            // 
            this.LBL_PlayerHuman.AutoSize = true;
            this.LBL_PlayerHuman.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_PlayerHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_PlayerHuman.Location = new System.Drawing.Point(271, 80);
            this.LBL_PlayerHuman.Name = "LBL_PlayerHuman";
            this.LBL_PlayerHuman.Size = new System.Drawing.Size(153, 20);
            this.LBL_PlayerHuman.TabIndex = 6;
            this.LBL_PlayerHuman.Text = "Human player Name";
            this.LBL_PlayerHuman.Visible = false;
            // 
            // TXTBOX_PlayerHumanName
            // 
            this.TXTBOX_PlayerHumanName.Location = new System.Drawing.Point(651, 37);
            this.TXTBOX_PlayerHumanName.Name = "TXTBOX_PlayerHumanName";
            this.TXTBOX_PlayerHumanName.Size = new System.Drawing.Size(126, 20);
            this.TXTBOX_PlayerHumanName.TabIndex = 7;
            // 
            // LBL_PlayerHumanTXTBOX
            // 
            this.LBL_PlayerHumanTXTBOX.AutoSize = true;
            this.LBL_PlayerHumanTXTBOX.Location = new System.Drawing.Point(648, 9);
            this.LBL_PlayerHumanTXTBOX.Name = "LBL_PlayerHumanTXTBOX";
            this.LBL_PlayerHumanTXTBOX.Size = new System.Drawing.Size(140, 13);
            this.LBL_PlayerHumanTXTBOX.TabIndex = 8;
            this.LBL_PlayerHumanTXTBOX.Text = "Please write your name here";
            // 
            // BTN_Settings
            // 
            this.BTN_Settings.Location = new System.Drawing.Point(676, 121);
            this.BTN_Settings.Name = "BTN_Settings";
            this.BTN_Settings.Size = new System.Drawing.Size(75, 23);
            this.BTN_Settings.TabIndex = 9;
            this.BTN_Settings.Text = "Settings";
            this.BTN_Settings.UseVisualStyleBackColor = true;
            this.BTN_Settings.Click += new System.EventHandler(this.BTN_Settings_Click);
            // 
            // LBL_LiberalLaws
            // 
            this.LBL_LiberalLaws.AutoSize = true;
            this.LBL_LiberalLaws.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_LiberalLaws.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_LiberalLaws.Location = new System.Drawing.Point(275, 167);
            this.LBL_LiberalLaws.Name = "LBL_LiberalLaws";
            this.LBL_LiberalLaws.Size = new System.Drawing.Size(97, 20);
            this.LBL_LiberalLaws.TabIndex = 10;
            this.LBL_LiberalLaws.Text = "Liberal Laws";
            this.LBL_LiberalLaws.Visible = false;
            // 
            // LBL_FacistLaws
            // 
            this.LBL_FacistLaws.AutoSize = true;
            this.LBL_FacistLaws.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_FacistLaws.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_FacistLaws.Location = new System.Drawing.Point(275, 240);
            this.LBL_FacistLaws.Name = "LBL_FacistLaws";
            this.LBL_FacistLaws.Size = new System.Drawing.Size(93, 20);
            this.LBL_FacistLaws.TabIndex = 11;
            this.LBL_FacistLaws.Text = "Facist Laws";
            this.LBL_FacistLaws.Visible = false;
            // 
            // LBL_Player1Role
            // 
            this.LBL_Player1Role.AutoSize = true;
            this.LBL_Player1Role.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Player1Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Player1Role.Location = new System.Drawing.Point(116, 167);
            this.LBL_Player1Role.Name = "LBL_Player1Role";
            this.LBL_Player1Role.Size = new System.Drawing.Size(98, 20);
            this.LBL_Player1Role.TabIndex = 12;
            this.LBL_Player1Role.Text = "Player1 Role";
            this.LBL_Player1Role.Visible = false;
            // 
            // LBL_Player2Role
            // 
            this.LBL_Player2Role.AutoSize = true;
            this.LBL_Player2Role.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Player2Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Player2Role.Location = new System.Drawing.Point(116, 290);
            this.LBL_Player2Role.Name = "LBL_Player2Role";
            this.LBL_Player2Role.Size = new System.Drawing.Size(98, 20);
            this.LBL_Player2Role.TabIndex = 13;
            this.LBL_Player2Role.Text = "Player2 Role";
            this.LBL_Player2Role.Visible = false;
            // 
            // LBL_Player4Role
            // 
            this.LBL_Player4Role.AutoSize = true;
            this.LBL_Player4Role.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Player4Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Player4Role.Location = new System.Drawing.Point(485, 290);
            this.LBL_Player4Role.Name = "LBL_Player4Role";
            this.LBL_Player4Role.Size = new System.Drawing.Size(98, 20);
            this.LBL_Player4Role.TabIndex = 14;
            this.LBL_Player4Role.Text = "Player4 Role";
            this.LBL_Player4Role.Visible = false;
            // 
            // LBL_Player3Role
            // 
            this.LBL_Player3Role.AutoSize = true;
            this.LBL_Player3Role.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_Player3Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Player3Role.Location = new System.Drawing.Point(485, 167);
            this.LBL_Player3Role.Name = "LBL_Player3Role";
            this.LBL_Player3Role.Size = new System.Drawing.Size(98, 20);
            this.LBL_Player3Role.TabIndex = 15;
            this.LBL_Player3Role.Text = "Player3 Role";
            this.LBL_Player3Role.Visible = false;
            // 
            // LBL_HumanPlayerRole
            // 
            this.LBL_HumanPlayerRole.AutoSize = true;
            this.LBL_HumanPlayerRole.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_HumanPlayerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_HumanPlayerRole.Location = new System.Drawing.Point(271, 100);
            this.LBL_HumanPlayerRole.Name = "LBL_HumanPlayerRole";
            this.LBL_HumanPlayerRole.Size = new System.Drawing.Size(141, 20);
            this.LBL_HumanPlayerRole.TabIndex = 16;
            this.LBL_HumanPlayerRole.Text = "HumanPlayer Role";
            this.LBL_HumanPlayerRole.Visible = false;
            // 
            // BTN_Continuation
            // 
            this.BTN_Continuation.Location = new System.Drawing.Point(478, 361);
            this.BTN_Continuation.Name = "BTN_Continuation";
            this.BTN_Continuation.Size = new System.Drawing.Size(114, 23);
            this.BTN_Continuation.TabIndex = 17;
            this.BTN_Continuation.Text = "Should not be seen";
            this.BTN_Continuation.UseVisualStyleBackColor = true;
            this.BTN_Continuation.Visible = false;
            this.BTN_Continuation.Click += new System.EventHandler(this.BTN_Continuation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Continuation);
            this.Controls.Add(this.LBL_HumanPlayerRole);
            this.Controls.Add(this.LBL_Player3Role);
            this.Controls.Add(this.LBL_Player4Role);
            this.Controls.Add(this.LBL_Player2Role);
            this.Controls.Add(this.LBL_Player1Role);
            this.Controls.Add(this.LBL_FacistLaws);
            this.Controls.Add(this.LBL_LiberalLaws);
            this.Controls.Add(this.BTN_Settings);
            this.Controls.Add(this.LBL_PlayerHumanTXTBOX);
            this.Controls.Add(this.TXTBOX_PlayerHumanName);
            this.Controls.Add(this.LBL_PlayerHuman);
            this.Controls.Add(this.LBL_Player4);
            this.Controls.Add(this.LBL_Player3);
            this.Controls.Add(this.LBL_Player2);
            this.Controls.Add(this.LBL_Player1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_NewGame);
            this.Name = "MainForm";
            this.Text = "Secret Hitler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_NewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_Player1;
        private System.Windows.Forms.Label LBL_Player2;
        private System.Windows.Forms.Label LBL_Player3;
        private System.Windows.Forms.Label LBL_Player4;
        private System.Windows.Forms.Label LBL_PlayerHuman;
        private System.Windows.Forms.TextBox TXTBOX_PlayerHumanName;
        private System.Windows.Forms.Label LBL_PlayerHumanTXTBOX;
        private System.Windows.Forms.Button BTN_Settings;
        private System.Windows.Forms.Label LBL_LiberalLaws;
        private System.Windows.Forms.Label LBL_FacistLaws;
        private System.Windows.Forms.Label LBL_Player1Role;
        private System.Windows.Forms.Label LBL_Player2Role;
        private System.Windows.Forms.Label LBL_Player4Role;
        private System.Windows.Forms.Label LBL_Player3Role;
        private System.Windows.Forms.Label LBL_HumanPlayerRole;
        private System.Windows.Forms.Button BTN_Continuation;
    }
}

