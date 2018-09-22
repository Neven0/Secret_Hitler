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
    public partial class ChooseChancellor : Form
    {
        public int Selected { get; set; }

        RadioButton[] radioButtons = new RadioButton[5];
        

        public ChooseChancellor(List<Players> playersArray)
        {
            InitializeComponent();

            //Setting names of players
            RADBTN_Player1.Text = playersArray[1].Name;
            RADBTN_Player2.Text = playersArray[2].Name;
            RADBTN_Player3.Text = playersArray[3].Name;
            RADBTN_Player4.Text = playersArray[4].Name;
            RADBTN_Player1.Select();

            radioButtons[0] = RADBTN_Player5;
            radioButtons[1] = RADBTN_Player6;
            radioButtons[2] = RADBTN_Player7;
            radioButtons[3] = RADBTN_Player8;
            radioButtons[4] = RADBTN_Player9;

            if (playersArray.Count>=6)
            {
                for (int i = 5; i < playersArray.Count; i++)
                {
                    radioButtons[i-5].Text = playersArray[i].Name;
                    radioButtons[i-5].Visible = true;
                }
            }
            
        }

        private void BTN_Nominate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChooseChancellor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Giving value to value for selected member
            if (RADBTN_Player1.Checked == true)
            {
                Selected = 1;
            }
            else if (RADBTN_Player2.Checked == true)
            {
                Selected = 2;
            }
            else if (RADBTN_Player3.Checked == true)
            {
                Selected = 3;
            }
            else if (RADBTN_Player4.Checked==true)
            {
                Selected = 4;
            }
            else
            {
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (radioButtons[i].Checked==true)
                    {
                        Selected = 5 + i;
                    }
                }
            }
        }
    }
}
