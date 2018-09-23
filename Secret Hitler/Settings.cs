using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secret_Hitler
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

        }

        TextBox[] textBoxes = new TextBox[5];
        

        private void Settings_Load(object sender, EventArgs e)
        {
            //Loading names from settings
            TXTBOX_Player1Name.Text = Properties.Settings.Default.Player1Name;
            TXTBOX_Player2Name.Text = Properties.Settings.Default.Player2Name;
            TXTBOX_Player3Name.Text = Properties.Settings.Default.Player3Name;
            TXTBOX_Player4Name.Text = Properties.Settings.Default.Player4Name;
            TXTBOX_Player5Name.Text = Properties.Settings.Default.Player5Name;
            TXTBOX_Player6Name.Text = Properties.Settings.Default.Player6Name;
            TXTBOX_Player7Name.Text = Properties.Settings.Default.Player7Name;
            TXTBOX_Player8Name.Text = Properties.Settings.Default.Player8Name;
            TXTBOX_Player9Name.Text = Properties.Settings.Default.Player9Name;

            textBoxes[0] = TXTBOX_Player5Name;
            textBoxes[1] = TXTBOX_Player6Name;
            textBoxes[2] = TXTBOX_Player7Name;
            textBoxes[3] = TXTBOX_Player8Name;
            textBoxes[4] = TXTBOX_Player9Name;

            //Loading number of players from settings
            NUM_PlayerCount.Value = Properties.Settings.Default.Number_Of_Players;

            if (Properties.Settings.Default.AI_Difficulty == 0)
            {
                RADBTN_AIRandom.Select();
            }
            else if (Properties.Settings.Default.AI_Difficulty == 1)
            {
                RADBTN_AISimple.Select();
            }
            else RADBTN_AIAdvanced.Select();
            
            //Enabling text boxes depending on number of AI players
            TextBoxEnabler();
        }

        

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            //Checking that all AI players have names
            if (TXTBOX_Player1Name.Text == "" || TXTBOX_Player2Name.Text == "" || TXTBOX_Player3Name.Text == "" || TXTBOX_Player4Name.Text == ""
                || TXTBOX_Player5Name.Text == "" || TXTBOX_Player6Name.Text == "" || TXTBOX_Player7Name.Text == "" 
                || TXTBOX_Player8Name.Text == "" || TXTBOX_Player9Name.Text == "")
            {
                MessageBox.Show("Please enter names for all characters!");
                return;
            }

            //Saving names in settings before the form closes
            Properties.Settings.Default.Player1Name = TXTBOX_Player1Name.Text;
            Properties.Settings.Default.Player2Name = TXTBOX_Player2Name.Text;
            Properties.Settings.Default.Player3Name = TXTBOX_Player3Name.Text;
            Properties.Settings.Default.Player4Name = TXTBOX_Player4Name.Text;
            Properties.Settings.Default.Player5Name = TXTBOX_Player5Name.Text;
            Properties.Settings.Default.Player6Name = TXTBOX_Player6Name.Text;
            Properties.Settings.Default.Player7Name = TXTBOX_Player7Name.Text;
            Properties.Settings.Default.Player8Name = TXTBOX_Player8Name.Text;
            Properties.Settings.Default.Player9Name = TXTBOX_Player9Name.Text;

            Properties.Settings.Default.Number_Of_Players = Convert.ToInt32(NUM_PlayerCount.Value);

            if (RADBTN_AIRandom.Checked==true)
            {
                Properties.Settings.Default.AI_Difficulty = 0;
            }
            else if (RADBTN_AISimple.Checked == true)
            {
                Properties.Settings.Default.AI_Difficulty = 1;
            }
            else Properties.Settings.Default.AI_Difficulty = 2;

            Close();
        }

        private void NUM_PlayerCount_ValueChanged(object sender, EventArgs e)
        {
            if (NUM_PlayerCount.Value<4)
            {
                MessageBox.Show("Minumum number of computer players is 4!");
                NUM_PlayerCount.Value = 4;
            }
            else if (NUM_PlayerCount.Value>9)
            {
                MessageBox.Show("Maximum number of computer players is 9!");
                NUM_PlayerCount.Value = 9;    
            }
            else TextBoxEnabler();
        }

        private void TextBoxEnabler()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i >= NUM_PlayerCount.Value - 4)
                {
                    textBoxes[i].Enabled = false;
                }
                else textBoxes[i].Enabled = true;
            }

        }

        private void RADBTN_AISimple_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(RADBTN_AISimple, "Computer players will play simple and to win");
        }

        private void RADBTN_AIAdvanced_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(RADBTN_AIAdvanced, "Computer players will play more strategically to avoid detection");
        }

        private void RADBTN_AIRandom_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(RADBTN_AIRandom, "Computer players will do every action randomly");
        }
    }
}
