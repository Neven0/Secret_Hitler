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
    public partial class ChancellorPolicyDiscard : Form
    {
        public int Choice { get; set; }

        public ChancellorPolicyDiscard(Players HumanPlayer, string Policy1, string Policy2)
        {
            //Write text on label and text on radio buttons
            InitializeComponent();
            LBL_InfoText.Text = "Chancellor " + HumanPlayer.Name + ", pick which policy would you like to discard." + Environment.NewLine +
                "Other policy will be implemented.";
            RADBTN_Policy1.Text = Policy1;
            RADBTN_Policy2.Text = Policy2;
            //Select first button so even if the form in closed, a choice is made
            RADBTN_Policy1.Select();
        }

        private void BTN_Discard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChancellorPolicyDiscard_FormClosing(object sender, FormClosingEventArgs e)
        {   //Give value that will serve as index to discard a policy
            if (RADBTN_Policy1.Checked == true)
            {
                Choice = 0;
            }
            else Choice = 1;
        }
    }
}
