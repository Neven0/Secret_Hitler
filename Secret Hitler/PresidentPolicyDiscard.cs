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
    public partial class PresidentPolicyDiscard : Form
    {
        //Integer that will serve as index number for policy that needs to be removed
        public int Discard { get; set; }

        public PresidentPolicyDiscard(Players HumanPlayer, List<string> Policies)
        {
            InitializeComponent();
            //Label will be written depending on player name
            LBL_IntroText.Text = "President " + HumanPlayer.Name + ", choose which policy would you like to discard." + Environment.NewLine + " Other two policies will be" +
                " given to the chancellor.";
            //Radio button text depends on which first 3 policies are
            RADBTN_Policy1.Text = Policies[0];
            RADBTN_Policy2.Text = Policies[1];
            RADBTN_Policy3.Text = Policies[2];

            RADBTN_Policy1.Select();
        }

        private void BTN_Discard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PresidentPolicyDiscard_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Give the Discard index of which policy will be discarded
            if (RADBTN_Policy1.Checked == true)
            {
                Discard = 0;
            }
            else if (RADBTN_Policy2.Checked == true)
            {
                Discard = 1;
            }
            else Discard = 2;
        }
    }
}
