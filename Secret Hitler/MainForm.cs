using System;
using System.Collections.Generic;
using System.Windows.Forms;
//TO DO: Enable button continuation after new game starts, when game ends, show who is who. 
namespace Secret_Hitler
{
    public partial class MainForm : Form
    {
        //To see if git works
        public MainForm()
        {
            InitializeComponent();
        }
        //Creating four arrays for players, labels and policy cards
        List<string> Policies = new List<string>();
        Players[] PlayersArray = new Players[5];
        Label[] LabelNames = new Label[5];
        Label[] LabelRoles = new Label[5];

        //List for discarded policies and policy count 
        int LiberalPolicies = 5;
        int FascistPolicies = 5;
        List<string> DiscardedPolicies = new List<string>();

        private int EventStage = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_NewGame_Click(object sender, EventArgs e)
        {
            //Show message in case name textbox is empty and quit the event
            if (TXTBOX_PlayerHumanName.Text=="")
            {
                MessageBox.Show("Please write your name!");
                return;
            }

            //Creating classes for all players
            Players Player1 = new Players(Properties.Settings.Default.Player1Name);
            Players Player2 = new Players(Properties.Settings.Default.Player2Name);
            Players Player3 = new Players(Properties.Settings.Default.Player3Name);
            Players Player4 = new Players(Properties.Settings.Default.Player4Name);
            Players PlayerHuman = new Players(TXTBOX_PlayerHumanName.Text);

            //Filling the player array
            PlayersArray[0] = PlayerHuman;
            PlayersArray[1] = Player1;
            PlayersArray[2] = Player2;
            PlayersArray[3] = Player3;
            PlayersArray[4] = Player4;

            //Putting label names in label name array
            LabelNames[0] = LBL_PlayerHuman;
            LabelNames[1] = LBL_Player1;
            LabelNames[2] = LBL_Player2;
            LabelNames[3] = LBL_Player3;
            LabelNames[4] = LBL_Player4;

            //Writing names of players on labels
            for (int i = 0; i < LabelNames.Length; i++)
            {
                LabelNames[i].Text = PlayersArray[i].Name;
            }

            //Filling label role array with labels
            LabelRoles[0] = LBL_HumanPlayerRole;
            LabelRoles[1] = LBL_Player1Role;
            LabelRoles[2] = LBL_Player2Role;
            LabelRoles[3] = LBL_Player3Role;
            LabelRoles[4] = LBL_Player4Role;

            //Enabling label visibility
            LBL_Player1.Visible = true;
            LBL_Player2.Visible = true;
            LBL_Player3.Visible = true;
            LBL_Player4.Visible = true;
            LBL_PlayerHuman.Visible = true;
            LBL_LiberalLaws.Visible = true;
            LBL_FacistLaws.Visible = true;

            //Disabling the buttons
            BTN_NewGame.Enabled = false;
            BTN_Settings.Enabled = false;

            //Filling the policies array with 6 liberal and 11 fascist cards
            for (int i = 0; i < 17; i++)
            {
                if (i <= 5) Policies.Add("Liberal");
                else Policies.Add("Fascist");

            }
            Policies.Shuffle();
            GiveRoles();
            StartGame();
        }

        private void StartGame()
        {
            //give president
            GivePresident();
            BTN_Continuation.Text = "Choose chancellor";
            BTN_Continuation.Visible = true;
        }


        private void VoteChancellor()
        {
            
            //Initializing counters for votes
            int VoteYes = 0;
            int VoteNo = 0;

            //Starting voting form
            Voting voting = new Voting(PlayersArray);
            voting.ShowDialog();
            //Giving vote depending how player voted
            if (voting.Choice == true)
            {
                VoteYes++;
            }
            else
            {
                VoteNo++;
            }
            //Random votes for AI players
            Random rand = new Random();
            int Rand;
            for (int i = 0; i < 4; i++)
            {
                //Random has been set from max value 1 to 2 because too many times, 0 would be drawn
                Rand=rand.Next(0, 2);
                if (Rand==0)
                {
                    VoteNo++;
                }
                else
                {
                    VoteYes++;
                }
            }
            //Message to player when voting ends
            if (VoteNo>VoteYes)
            {   //Restart the cycle if majority vote is no
                MessageBox.Show("Vote no won by " + VoteNo.ToString() + " to " + VoteYes.ToString() + ". President to be moved to next player.");
                StartGame();
            }
            else
            {
                MessageBox.Show("Vote yes won by " + VoteYes.ToString() + " to " + VoteNo.ToString());
                EventStage = 2;
            }
            //If vote passed, nominated player is the chancellor
            for (int i = 0; i < PlayersArray.Length; i++)
            {
                if (PlayersArray[i].IsNominated==true)
                {
                    PlayersArray[i].IsNominated = false;
                    PlayersArray[i].IsChancellor = true;
                }
            }
        }

        private void ChooseChancellor()
        {
            EventStage = 1;
            //Open the chancellor form to nominate the chancellor
            if (PlayersArray[0].IsPresident==true)
            {
                ChooseChancellor chancellor = new ChooseChancellor(PlayersArray);
                chancellor.ShowDialog();
                PlayersArray[chancellor.Selected].IsNominated = true;
            }
            else //If AI is president, nominate a random chancellor
            {
                Random rand = new Random();
                REDO:
                int choice = rand.Next(0, 5);
                if (PlayersArray[choice].IsPresident==true)
                {
                    goto REDO;
                }
                PlayersArray[choice].IsNominated = true;
                MessageBox.Show(PlayersArray[choice].Name + " has been nominated!");
            }
        }

        private void GivePresident()
        {
            EventStage = 0;
            //check if president already exists
            bool PresidentExists= CheckPresident();
            if (PresidentExists==false)
            {
                //If president doesn't exist, give it to first player
                PlayersArray[0].IsPresident = true;
                LabelRoles[0].Text = "President";
                LabelRoles[0].Visible = true;
                return;
            }
            for (int i = 0; i < PlayersArray.Length; i++)
            {
                //change president to next person and edite role labels
                if (i < 4 && PlayersArray[i].IsPresident == true)
                {
                    PlayersArray[i].IsPresident = false;
                    PlayersArray[i + 1].IsPresident = true;
                    LabelRoles[i].Text = "";
                    LabelRoles[i].Visible = false;
                    LabelRoles[i + 1].Text = "President";
                    LabelRoles[i + 1].Visible = true;
                    break;
                }
                //If president is last player, give it to the first and edit role labels
                else if (PlayersArray[4].IsPresident == true)
                {
                    PlayersArray[4].IsPresident = false;
                    PlayersArray[0].IsPresident = true;
                    LabelRoles[4].Text = "";
                    LabelRoles[4].Visible = false;
                    LabelRoles[0].Text = "President";
                    LabelRoles[0].Visible = true;
                    break;
                }
            }

        }

        private bool CheckPresident()
        {
            for (int i = 0; i < PlayersArray.Length; i++)
            {
                if (PlayersArray[i].IsPresident==true)
                {
                    return true;
                }
            }
            return false;
        }

        private void GiveRoles()
        {   //Counters for number of Liberals, Fascists and Hitler
            int Lib = 0;
            int Fasc = 0;
            int Hitl = 0;

            //Creates a random class object to give random role to people
            Random rand = new Random();
            for (int i = 0; i < PlayersArray.Length; i++)
            {
                
                RAND:
                int r = rand.Next(3);
                //Checks random number r and amount of that people that there are. If number of either is at the limit, generates the new random number
                if (r == 0 && Lib < 3)
                {
                    PlayersArray[i].IsLiberal = true;
                    Lib++;
                }
                else if (r == 1 && Fasc < 2)
                {
                    PlayersArray[i].IsFascist = true;
                    Fasc++;
                }
                else if (r == 2 && Hitl < 1)
                {
                    PlayersArray[i].IsHitler = true;
                    Hitl++;
                }
                else goto RAND;  
            }

            //Showing player role
            if (PlayersArray[0].IsLiberal == true)
            {
                MessageBox.Show("You are liberal!");
                LBL_PlayerHuman.Text += " - Lib";
            }
            else if (PlayersArray[0].IsFascist == true)
            {
                MessageBox.Show("You are fascist!");
                LBL_PlayerHuman.Text += " - Fasc";
                ShowFascists();
            }
            else
            {
                MessageBox.Show("You are Hitler!");
                LBL_PlayerHuman.Text += " - Hitler";
                ShowFascists();
            }


        }

        private void ShowFascists()
        {
            //Shows which player is fascist

            for (int i = 1; i < PlayersArray.Length; i++)
            {
                if (PlayersArray[i].IsFascist==true)
                {
                    LabelNames[i].Text += " - Fasc";
                }
                else if (PlayersArray[i].IsHitler==true)
                {
                    LabelNames[i].Text += " - Hitler";
                }
            }
        }

        private void BTN_Settings_Click(object sender, EventArgs e)
        {
            //Opening settings form
            Settings settings = new Settings();
            settings.Show();
        }

        private void BTN_Continuation_Click(object sender, EventArgs e)
        {
            //Depending on event stage, call in functions. This way, there are pauses in between events
            if (EventStage==0)
            {
                ChooseChancellor();
                BTN_Continuation.Text = "Vote on Chancellor";
            }
            else if(EventStage==1)
            {
                VoteChancellor();
            }
            else if (EventStage==2)
            {
                PresidentPolicyCheck();
            }
            else if (EventStage==3)
            {
                ChancellorPolicyCheck();
            }
        }

        private void ChancellorPolicyCheck()
        {
            if (PlayersArray[0].IsChancellor==true)
            {
                ChancellorPolicyDiscard chancellor = new ChancellorPolicyDiscard(PlayersArray[0], Policies[0], Policies[1]);
                chancellor.ShowDialog();
                string temp = Policies[chancellor.Choice];
                Policies.RemoveAt(chancellor.Choice);
                DiscardedPolicies.Add(temp);
            }

            else
            {
                Random rand = new Random();
                int Discard = rand.Next(0, 2);
                string temp = Policies[Discard];
                Policies.RemoveAt(Discard);
                DiscardedPolicies.Add(temp);
                MessageBox.Show("Chancellor has discarded a card");
            }

            EventStage = 0;

            if (Policies.Count<3)
            {
                Policies.AddRange(DiscardedPolicies);
                DiscardedPolicies.RemoveRange(0, DiscardedPolicies.Count);
            }

            if (Policies[0] == "Liberal")
            {
                LiberalPolicies++;
                LBL_LiberalLaws.Text = "Liberal Laws - " + LiberalPolicies.ToString();
                MessageBox.Show("Liberal law has been added");
                if (LiberalPolicies == 6)
                {
                    GameOver();
                }
            }
            else if (Policies[0] == "Fascist")
            {
                FascistPolicies++;
                LBL_FacistLaws.Text = "Fascist Laws - " + FascistPolicies.ToString();
                MessageBox.Show("Fascist law has been added");
                if (FascistPolicies == 6)
                {
                    GameOver();
                }
            }
            StartGame();


        }

        private void GameOver()
        {
            BTN_NewGame.Enabled = true;
            BTN_Settings.Enabled = true;
            BTN_Continuation.Enabled = false;
        }

        private void PresidentPolicyCheck()
        {
            if (PlayersArray[0].IsPresident==true)
            {
                //Create and open president policy discard form
                PresidentPolicyDiscard PresidentForm = new PresidentPolicyDiscard(PlayersArray[0], Policies);
                PresidentForm.ShowDialog();
                //Temporary place selected policy for discarding in an string variable, delete the discarded policy and place it in list for discarded policies
                string temp = Policies[PresidentForm.Discard];
                Policies.RemoveAt(PresidentForm.Discard);
                DiscardedPolicies.Add(temp);
                
            }
            else
            {
                //Create new random object
                Random rand = new Random();
                //New integer that will be save the index of the discarded policy
                int RandomPolicy = rand.Next(0, 3);
                //Same as above
                string temp = Policies[RandomPolicy];
                Policies.RemoveAt(RandomPolicy);
                DiscardedPolicies.Add(temp);
                MessageBox.Show("President has discarded a card");
            }

            //Move event Stage to next stage
            EventStage = 3;
        }
    }

    static class Extention
    {
        //Extention to list for random shuffle
        public static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;

            }
        }
    }
}
