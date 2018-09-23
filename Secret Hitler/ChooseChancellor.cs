﻿using System;
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

        RadioButton[] radioButtons = new RadioButton[9];
        

        public ChooseChancellor(List<Players> playersArray)
        {
            InitializeComponent();
            //Filling array of radio buttons
            radioButtons[0] = RADBTN_Player1;
            radioButtons[1] = RADBTN_Player2;
            radioButtons[2] = RADBTN_Player3;
            radioButtons[3] = RADBTN_Player4;
            radioButtons[4] = RADBTN_Player5;
            radioButtons[5] = RADBTN_Player6;
            radioButtons[6] = RADBTN_Player7;
            radioButtons[7] = RADBTN_Player8;
            radioButtons[8] = RADBTN_Player9;

        for (int i = 1; i < playersArray.Count; i++)
         {
            radioButtons[i-1].Text = playersArray[i].Name;
            radioButtons[i-1].Visible = true;
           
            if (playersArray[i].WasInOffice==true)
            {
                    radioButtons[i-1].Text += " (player has been in office last turn)";
                    radioButtons[i-1].Enabled = false;
            }
            else if (playersArray[i].IsAssassinated==true)
            {
                    radioButtons[i - 1].Text += " (player is assassinated)";
                    radioButtons[i - 1].Enabled = false;
            }

         }
            if (radioButtons[0].Enabled == true)
            {
                radioButtons[0].Select();
            }
            else if (radioButtons[1].Enabled == true)
            {
                radioButtons[1].Select();
            }
            else radioButtons[2].Select();

            
        }

        private void BTN_Nominate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChooseChancellor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Giving value to value for selected member

            for (int i = 0; i < radioButtons.Length; i++)
             {
                 if (radioButtons[i].Checked==true)
                 {
                        Selected = i+1;
                 }
             }
        }
    }
}
