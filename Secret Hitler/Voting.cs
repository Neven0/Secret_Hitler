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
    public partial class Voting : Form
    {
        public bool Choice { get; set; }

        public Voting(List<Players> playersList)
        {
            InitializeComponent();
            //Writing the label regarding who the current president is
            for (int i = 0; i < playersList.Count; i++)
            {
                
                if (playersList[0].IsNominated==true)
                {
                    label1.Text = "You have been nominated for chancellor. How do you vote?";
                }
                else if (playersList[i].IsNominated==true)
                {
                    label1.Text = playersList[i].Name + " has been nominated for chancellor. How do you vote?";
                    break;
                }

                
            }
            RADBTN_VoteYes.Select();
        }

        private void BTN_GiveVote_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Voting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RADBTN_VoteYes.Checked == true)
            {
                Choice = true;
            }
            else Choice = false;

        }
    }
}
