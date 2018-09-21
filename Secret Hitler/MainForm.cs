using System;
using System.Collections.Generic;
using System.Windows.Forms;
//TODO: Set all arrays to lists. Check all forms for compatibility, for loops and new game button
namespace Secret_Hitler
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        //Creating four arrays for players, labels and policy cards
        List<string> Policies = new List<string>();
        List<Players> PlayersArray = new List<Players>();
        Label[] LabelNames = new Label[Properties.Settings.Default.Number_Of_Players+1];
        Label[] LabelRoles = new Label[Properties.Settings.Default.Number_Of_Players+1];

        //List for discarded policies and policy count 
        int LiberalPolicies;
        int FascistPolicies;
        List<string> DiscardedPolicies = new List<string>();

        private int EventStage = 0;

        //Create new random object for all needs
        Random Rand = new Random();

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

            PlayersAndLabelsSetUp();

            //Disabling the buttons
            BTN_NewGame.Enabled = false;
            BTN_Settings.Enabled = false;
            BTN_Continuation.Enabled = true;

            //Setting policy number, works also as resetting them and setting the label
            LiberalPolicies = 5;
            FascistPolicies = 5;
            LBL_FacistLaws.Text = "Fascist Laws - 0";
            LBL_LiberalLaws.Text = "Liberal Laws - 0";

            //Filling the policies array with 6 liberal and 11 fascist cards
            for (int i = 0; i < 17; i++)
            {
                if (i <= 5) Policies.Add("Liberal");
                else Policies.Add("Fascist");

            }
            Policies.Shuffle();
            GiveRoles();
            PB_Image.SendToBack();
            StartGame();
        }

        private void PlayersAndLabelsSetUp()
        {/*
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
            LabelRoles[0] = LBL_PlayerHumanRole;
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
            LBL_FacistLaws.Visible = true;*/

            //Creating objects of minimum 5 players
            Players PlayerHuman = new Players(TXTBOX_PlayerHumanName.Text);
            Players Player1 = new Players(Properties.Settings.Default.Player1Name);
            Players Player2 = new Players(Properties.Settings.Default.Player2Name);
            Players Player3 = new Players(Properties.Settings.Default.Player3Name);
            Players Player4 = new Players(Properties.Settings.Default.Player4Name);

            //Placing human player and index 0 at all arrays
            LabelRoles[0] = LBL_PlayerHumanRole;
            PlayersArray[0] = PlayerHuman;
            LabelNames[0] = LBL_PlayerHuman;


            //Enabling label visibility for human player and laws
            LBL_PlayerHuman.Visible = true;
            LBL_LiberalLaws.Visible = true;
            LBL_FacistLaws.Visible = true;

            if (Properties.Settings.Default.Number_Of_Players==4)
            {
                //Filling the player array
                PlayersArray[1] = Player1;
                PlayersArray[2] = Player2;
                PlayersArray[3] = Player3;
                PlayersArray[4] = Player4;

                //Putting label names in label name array
                LabelNames[1] = LBL_Player2;
                LabelNames[2] = LBL_Player3;
                LabelNames[3] = LBL_Player7;
                LabelNames[4] = LBL_Player8;

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Length; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role array with labels
                LabelRoles[1] = LBL_Player2Role;
                LabelRoles[2] = LBL_Player3Role;
                LabelRoles[3] = LBL_Player7Role;
                LabelRoles[4] = LBL_Player8Role;

                //Enabling label visibility for AI
                LBL_Player2.Visible = true;
                LBL_Player3.Visible = true;
                LBL_Player7.Visible = true;
                LBL_Player8.Visible = true;
            }

            else if (Properties.Settings.Default.Number_Of_Players == 5)
            {
                Players Player5 = new Players(Properties.Settings.Default.Player5Name);

                //Filling the player array
                PlayersArray[1] = Player1;
                PlayersArray[2] = Player2;
                PlayersArray[3] = Player3;
                PlayersArray[4] = Player4;
                PlayersArray[5] = Player5;

                //Putting label names in label name array
                LabelNames[1] = LBL_Player2;
                LabelNames[2] = LBL_Player3;
                LabelNames[3] = LBL_Player5;
                LabelNames[4] = LBL_Player7;
                LabelNames[5] = LBL_Player8;

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Length; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role array with labels
                LabelRoles[1] = LBL_Player2Role;
                LabelRoles[2] = LBL_Player3Role;
                LabelRoles[3] = LBL_Player5Role;
                LabelRoles[4] = LBL_Player7Role;
                LabelRoles[5] = LBL_Player8Role;

                //Enabling label visibility for AI
                LBL_Player2.Visible = true;
                LBL_Player3.Visible = true;
                LBL_Player5.Visible = true;
                LBL_Player7.Visible = true;
                LBL_Player8.Visible = true;
            }

            else if (Properties.Settings.Default.Number_Of_Players == 6)
            {
                Players Player5 = new Players(Properties.Settings.Default.Player5Name);
                Players Player6 = new Players(Properties.Settings.Default.Player6Name);

                //Filling the player array
                PlayersArray[1] = Player1;
                PlayersArray[2] = Player2;
                PlayersArray[3] = Player3;
                PlayersArray[4] = Player4;
                PlayersArray[5] = Player5;
                PlayersArray[6] = Player6;

                //Putting label names in label name array
                LabelNames[1] = LBL_Player1;
                LabelNames[2] = LBL_Player2;
                LabelNames[3] = LBL_Player3;
                LabelNames[4] = LBL_Player7;
                LabelNames[5] = LBL_Player8;
                LabelNames[6] = LBL_Player9;

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Length; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role array with labels
                LabelRoles[1] = LBL_Player1Role;
                LabelRoles[2] = LBL_Player2Role;
                LabelRoles[3] = LBL_Player3Role;
                LabelRoles[4] = LBL_Player7Role;
                LabelRoles[5] = LBL_Player8Role;
                LabelRoles[6] = LBL_Player9Role;

                //Enabling label visibility for AI
                LBL_Player1.Visible = true;
                LBL_Player2.Visible = true;
                LBL_Player3.Visible = true;
                LBL_Player7.Visible = true;
                LBL_Player8.Visible = true;
                LBL_Player9.Visible = true;
            }
            else if (Properties.Settings.Default.Number_Of_Players == 7)
            {
                Players Player5 = new Players(Properties.Settings.Default.Player5Name);
                Players Player6 = new Players(Properties.Settings.Default.Player6Name);
                Players Player7 = new Players(Properties.Settings.Default.Player7Name);

                //Filling the player array
                PlayersArray[1] = Player1;
                PlayersArray[2] = Player2;
                PlayersArray[3] = Player3;
                PlayersArray[4] = Player4;
                PlayersArray[5] = Player5;
                PlayersArray[6] = Player6;
                PlayersArray[7] = Player7;

                //Putting label names in label name array
                LabelNames[1] = LBL_Player1;
                LabelNames[2] = LBL_Player2;
                LabelNames[3] = LBL_Player3;
                LabelNames[4] = LBL_Player5;
                LabelNames[5] = LBL_Player7;
                LabelNames[6] = LBL_Player8;
                LabelNames[7] = LBL_Player9;

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Length; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role array with labels
                LabelRoles[1] = LBL_Player1Role;
                LabelRoles[2] = LBL_Player2Role;
                LabelRoles[3] = LBL_Player3Role;
                LabelRoles[4] = LBL_Player5Role;
                LabelRoles[5] = LBL_Player7Role;
                LabelRoles[6] = LBL_Player8Role;
                LabelRoles[7] = LBL_Player9Role;

                //Enabling label visibility for AI
                LBL_Player1.Visible = true;
                LBL_Player2.Visible = true;
                LBL_Player3.Visible = true;
                LBL_Player5.Visible = true;
                LBL_Player7.Visible = true;
                LBL_Player8.Visible = true;
                LBL_Player9.Visible = true;
            }

            else if (Properties.Settings.Default.Number_Of_Players == 8)
            {
                Players Player5 = new Players(Properties.Settings.Default.Player5Name);
                Players Player6 = new Players(Properties.Settings.Default.Player6Name);
                Players Player7 = new Players(Properties.Settings.Default.Player7Name);
                Players Player8 = new Players(Properties.Settings.Default.Player8Name);

                //Filling the player array
                PlayersArray[1] = Player1;
                PlayersArray[2] = Player2;
                PlayersArray[3] = Player3;
                PlayersArray[4] = Player4;
                PlayersArray[5] = Player5;
                PlayersArray[6] = Player6;
                PlayersArray[7] = Player7;
                PlayersArray[8] = Player8;

                //Putting label names in label name array
                LabelNames[1] = LBL_Player1;
                LabelNames[2] = LBL_Player2;
                LabelNames[3] = LBL_Player3;
                LabelNames[4] = LBL_Player4;
                LabelNames[5] = LBL_Player6;
                LabelNames[6] = LBL_Player7;
                LabelNames[7] = LBL_Player8;
                LabelNames[8] = LBL_Player9;

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Length; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role array with labels
                LabelRoles[1] = LBL_Player1Role;
                LabelRoles[2] = LBL_Player2Role;
                LabelRoles[3] = LBL_Player3Role;
                LabelRoles[4] = LBL_Player4Role;
                LabelRoles[5] = LBL_Player6Role;
                LabelRoles[6] = LBL_Player7Role;
                LabelRoles[7] = LBL_Player8Role;
                LabelRoles[8] = LBL_Player9Role;

                //Enabling label visibility for AI
                LBL_Player1.Visible = true;
                LBL_Player2.Visible = true;
                LBL_Player3.Visible = true;
                LBL_Player4.Visible = true;
                LBL_Player6.Visible = true;
                LBL_Player7.Visible = true;
                LBL_Player8.Visible = true;
                LBL_Player9.Visible = true;
            }
            else if (Properties.Settings.Default.Number_Of_Players == 9)
            {
                Players Player5 = new Players(Properties.Settings.Default.Player5Name);
                Players Player6 = new Players(Properties.Settings.Default.Player6Name);
                Players Player7 = new Players(Properties.Settings.Default.Player7Name);
                Players Player8 = new Players(Properties.Settings.Default.Player8Name);
                Players Player9 = new Players(Properties.Settings.Default.Player9Name);

                //Filling the player array
                PlayersArray[1] = Player1;
                PlayersArray[2] = Player2;
                PlayersArray[3] = Player3;
                PlayersArray[4] = Player4;
                PlayersArray[5] = Player5;
                PlayersArray[6] = Player6;
                PlayersArray[7] = Player7;
                PlayersArray[8] = Player8;
                PlayersArray[9] = Player9;

                //Putting label names in label name array
                LabelNames[1] = LBL_Player1;
                LabelNames[2] = LBL_Player2;
                LabelNames[3] = LBL_Player3;
                LabelNames[4] = LBL_Player4;
                LabelNames[5] = LBL_Player5;
                LabelNames[6] = LBL_Player6;
                LabelNames[7] = LBL_Player7;
                LabelNames[8] = LBL_Player8;
                LabelNames[9] = LBL_Player9;

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Length; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role array with labels
                LabelRoles[1] = LBL_Player1Role;
                LabelRoles[2] = LBL_Player2Role;
                LabelRoles[3] = LBL_Player3Role;
                LabelRoles[4] = LBL_Player4Role;
                LabelRoles[5] = LBL_Player5Role;
                LabelRoles[6] = LBL_Player6Role;
                LabelRoles[7] = LBL_Player7Role;
                LabelRoles[8] = LBL_Player8Role;
                LabelRoles[9] = LBL_Player9Role;

                //Enabling label visibility for AI
                LBL_Player1.Visible = true;
                LBL_Player2.Visible = true;
                LBL_Player3.Visible = true;
                LBL_Player4.Visible = true;
                LBL_Player5.Visible = true;
                LBL_Player6.Visible = true;
                LBL_Player7.Visible = true;
                LBL_Player8.Visible = true;
                LBL_Player9.Visible = true;
            }

            return;


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
            int rand;
            for (int i = 0; i < 4; i++)
            {
                //Random has been set from max value 1 to 2 because too many times, 0 would be drawn
                rand=Rand.Next(0, 2);
                if (rand==0)
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
                BTN_Continuation.Text = "President Discard";
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
                REDO:
                int choice = Rand.Next(0, 5);
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
            for (int i = 0; i < PlayersArray.Length; i++)
            {
                
                RAND:
                int r = Rand.Next(0,3);
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
                LBL_PlayerHuman.Text += " - Liberal";
            }
            else if (PlayersArray[0].IsFascist == true)
            {
                MessageBox.Show("You are fascist!");
                LBL_PlayerHuman.Text += " - Fascist";
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
                    LabelNames[i].Text += " - Fascist";
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
            settings.ShowDialog();
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
            //Show chancellor discard form if player is the chancellor
            if (PlayersArray[0].IsChancellor==true)
            {
                ChancellorPolicyDiscard chancellor = new ChancellorPolicyDiscard(PlayersArray[0], Policies[0], Policies[1]);
                chancellor.ShowDialog();
                string temp = Policies[chancellor.Choice];
                Policies.RemoveAt(chancellor.Choice);
                DiscardedPolicies.Add(temp);
            }
            //Randomly pick one if the play is not a chancellor
            else
            {
                int Discard = Rand.Next(0, 2);
                string temp = Policies[Discard];
                Policies.RemoveAt(Discard);
                DiscardedPolicies.Add(temp);
                MessageBox.Show("Chancellor has discarded a card");
            }
            //Set stage to the beginning
            EventStage = 0;

            
            //Increase number of the inacted policies depending which policy it is, remove the first policy from the game
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
            //If there are less than three policies in policy card pile, add the discarded policies in, shuffle them and empty the discarded policy list
            if (Policies.Count < 3)
            {
                Policies.AddRange(DiscardedPolicies);
                Policies.Shuffle();
                DiscardedPolicies.RemoveRange(0, DiscardedPolicies.Count);
            }

            StartGame();


        }

        private void GameOver()
        {
            BTN_NewGame.Enabled = true;
            BTN_Settings.Enabled = true;
            BTN_Continuation.Enabled = false;
            BTN_Continuation.Visible = false;

            for (int i = 1; i < PlayersArray.Length; i++)
            {
                LabelNames[i].Text = PlayersArray[i].Name + " - ";
                if (PlayersArray[i].IsLiberal == true)
                {
                    LabelNames[i].Text += "Liberal";
                }
                else if (PlayersArray[i].IsFascist == true)
                {
                    LabelNames[i].Text += "Fascist";
                }
                else LabelNames[i].Text += "Hitler";
            }
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
                
                //New integer that will be save the index of the discarded policy
                int RandomPolicy = Rand.Next(0, 3);
                //Same as above
                string temp = Policies[RandomPolicy];
                Policies.RemoveAt(RandomPolicy);
                DiscardedPolicies.Add(temp);
                MessageBox.Show("President has discarded a card");
            }

            //Move event Stage to next stage
            EventStage = 3;
            BTN_Continuation.Text = "Chancellor Discard";
        }
    }

    static class Extention
    {
        //Extention to list for random shuffle
        public  static Random rng = new Random();

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
