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

        private void Settings_Load(object sender, EventArgs e)
        {
            //Loading names from settings
            TXTBOX_Player1Name.Text = Properties.Settings.Default.Player1Name;
            TXTBOX_Player2Name.Text = Properties.Settings.Default.Player2Name;
            TXTBOX_Player3Name.Text = Properties.Settings.Default.Player3Name;
            TXTBOX_Player4Name.Text = Properties.Settings.Default.Player4Name;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            //Checking that all AI players have names
            if (TXTBOX_Player1Name.Text == "" || TXTBOX_Player2Name.Text == "" || TXTBOX_Player3Name.Text == "" || TXTBOX_Player4Name.Text == "")
            {
                MessageBox.Show("Please enter names for all characters!");
                return;
            }

            //Saving names in settings before the form closes
            Properties.Settings.Default.Player1Name = TXTBOX_Player1Name.Text;
            Properties.Settings.Default.Player2Name = TXTBOX_Player2Name.Text;
            Properties.Settings.Default.Player3Name = TXTBOX_Player3Name.Text;
            Properties.Settings.Default.Player4Name = TXTBOX_Player4Name.Text;

            Close();
        }
    }
}
