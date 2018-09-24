using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

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
        List<Label> LabelNames = new List<Label>();
        List<Label> LabelRoles = new List<Label>();

        //List for discarded policies and policy count 
        int LiberalPolicies;
        int FascistPolicies;
        List<string> DiscardedPolicies = new List<string>();

        //Event stage to go through events vial button click
        int EventStage = 0;

        //Round counter to... count rounds of course
        int RoundCounter;

        bool FirstAssassinationGiven;
        bool SecondAssassinationGiven;

        //Create new random object for all random needs
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
            LiberalPolicies = 0;
            FascistPolicies = 0;
            LBL_FacistLaws.Text = "Fascist Laws - 0";
            LBL_LiberalLaws.Text = "Liberal Laws - 0";

            FirstAssassinationGiven = false;
            SecondAssassinationGiven = false;
            //Filling the policies array with 6 liberal and 11 fascist cards
            for (int i = 0; i < 17; i++)
            {
                if (i <= 5) Policies.Add("Liberal");
                else Policies.Add("Fascist");

            }

            //Shuffle the policy list
            Policies.Shuffle();
            //Give roles to players
            GiveRoles();
            //Setting the counter to 1, updating the label
            RoundCounter = 1;
            LBL_RoundCounter.Text = "Round: " + RoundCounter.ToString();
            //Send the "Secret Hitler" image to the back, so it's not visible
            PB_Image.SendToBack();
            //Making round counter label visible after image is sent to back
            LBL_RoundCounter.Visible = true;
            //Enable to continueation button
            BTN_Continuation.Visible = true;
            //Start the game
            StartGame();
        }

        private void PlayersAndLabelsSetUp()
        {

            //Creating objects of minimum 5 players
            Players PlayerHuman = new Players(TXTBOX_PlayerHumanName.Text);
            Players Player1 = new Players(Properties.Settings.Default.Player1Name);
            Players Player2 = new Players(Properties.Settings.Default.Player2Name);
            Players Player3 = new Players(Properties.Settings.Default.Player3Name);
            Players Player4 = new Players(Properties.Settings.Default.Player4Name);

            //Placing human player and index 0 at all lists
            LabelRoles.Add(LBL_PlayerHumanRole);
            PlayersArray.Add(PlayerHuman);
            LabelNames.Add(LBL_PlayerHuman);

            //Enabling label visibility for human player and laws
            LBL_PlayerHuman.Visible = true;
            LBL_LiberalLaws.Visible = true;
            LBL_FacistLaws.Visible = true;

            //Filling the player list with minimum players
            PlayersArray.Add(Player1);
            PlayersArray.Add(Player2);
            PlayersArray.Add(Player3);
            PlayersArray.Add(Player4);

            if (Properties.Settings.Default.Number_Of_Players==4)
            {
                //Putting label names in label name list
                LabelNames.Add(LBL_Player2);
                LabelNames.Add(LBL_Player3);
                LabelNames.Add(LBL_Player7);
                LabelNames.Add(LBL_Player8);

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Count; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role list with labels
                LabelRoles.Add(LBL_Player2Role);
                LabelRoles.Add(LBL_Player3Role);
                LabelRoles.Add(LBL_Player7Role);
                LabelRoles.Add(LBL_Player8Role);

                //Enabling label visibility for AI
                LBL_Player2.Visible = true;
                LBL_Player3.Visible = true;
                LBL_Player7.Visible = true;
                LBL_Player8.Visible = true;
            }

            else if (Properties.Settings.Default.Number_Of_Players == 5)
            {
                Players Player5 = new Players(Properties.Settings.Default.Player5Name);

                //Filling the player list
                PlayersArray.Add(Player5);

                //Putting label names in label name list
                LabelNames.Add(LBL_Player2);
                LabelNames.Add(LBL_Player3);
                LabelNames.Add(LBL_Player5);
                LabelNames.Add(LBL_Player7);
                LabelNames.Add(LBL_Player8);

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Count; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role list with labels
                LabelRoles.Add(LBL_Player2Role);
                LabelRoles.Add(LBL_Player3Role);
                LabelRoles.Add(LBL_Player5Role);
                LabelRoles.Add(LBL_Player7Role);
                LabelRoles.Add(LBL_Player8Role);

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

                //Filling the player list
                PlayersArray.Add(Player5);
                PlayersArray.Add(Player6);

                //Putting label names in label name list
                LabelNames.Add(LBL_Player1);
                LabelNames.Add(LBL_Player2);
                LabelNames.Add(LBL_Player3);
                LabelNames.Add(LBL_Player7);
                LabelNames.Add(LBL_Player8);
                LabelNames.Add(LBL_Player9);

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Count; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role list with labels
                LabelRoles.Add(LBL_Player1Role);
                LabelRoles.Add(LBL_Player2Role);
                LabelRoles.Add(LBL_Player3Role);
                LabelRoles.Add(LBL_Player7Role);
                LabelRoles.Add(LBL_Player8Role);
                LabelRoles.Add(LBL_Player9Role);

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

                //Filling the player list
                PlayersArray.Add(Player5);
                PlayersArray.Add(Player6);
                PlayersArray.Add(Player7);

                //Putting label names in label name list
                LabelNames.Add(LBL_Player1);
                LabelNames.Add(LBL_Player2);
                LabelNames.Add(LBL_Player3);
                LabelNames.Add(LBL_Player5);
                LabelNames.Add(LBL_Player7);
                LabelNames.Add(LBL_Player8);
                LabelNames.Add(LBL_Player9);

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Count; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role list with labels
                LabelRoles.Add(LBL_Player1Role);
                LabelRoles.Add(LBL_Player2Role);
                LabelRoles.Add(LBL_Player3Role);
                LabelRoles.Add(LBL_Player5Role);
                LabelRoles.Add(LBL_Player7Role);
                LabelRoles.Add(LBL_Player8Role);
                LabelRoles.Add(LBL_Player9Role);

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

                //Filling the player list
                PlayersArray.Add(Player5);
                PlayersArray.Add(Player6);
                PlayersArray.Add(Player7);
                PlayersArray.Add(Player8);

                //Putting label names in label name list
                LabelNames.Add(LBL_Player1);
                LabelNames.Add(LBL_Player2);
                LabelNames.Add(LBL_Player3);
                LabelNames.Add(LBL_Player4);
                LabelNames.Add(LBL_Player6);
                LabelNames.Add(LBL_Player7);
                LabelNames.Add(LBL_Player8);
                LabelNames.Add(LBL_Player9);

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Count; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role list with labels
                LabelRoles.Add(LBL_Player1Role);
                LabelRoles.Add(LBL_Player2Role);
                LabelRoles.Add(LBL_Player3Role);
                LabelRoles.Add(LBL_Player4Role);
                LabelRoles.Add(LBL_Player6Role);
                LabelRoles.Add(LBL_Player7Role);
                LabelRoles.Add(LBL_Player8Role);
                LabelRoles.Add(LBL_Player9Role);

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

                //Filling the player list
                PlayersArray.Add(Player5);
                PlayersArray.Add(Player6);
                PlayersArray.Add(Player7);
                PlayersArray.Add(Player8);
                PlayersArray.Add(Player9);

                //Putting label names in label name list
                LabelNames.Add(LBL_Player1);
                LabelNames.Add(LBL_Player2);
                LabelNames.Add(LBL_Player3);
                LabelNames.Add(LBL_Player4);
                LabelNames.Add(LBL_Player5);
                LabelNames.Add(LBL_Player6);
                LabelNames.Add(LBL_Player7);
                LabelNames.Add(LBL_Player8);
                LabelNames.Add(LBL_Player9);

                //Writing names of players on labels
                for (int i = 0; i < LabelNames.Count; i++)
                {
                    LabelNames[i].Text = PlayersArray[i].Name;
                }

                //Filling label role list with labels
                LabelRoles.Add(LBL_Player1Role);
                LabelRoles.Add(LBL_Player2Role);
                LabelRoles.Add(LBL_Player3Role);
                LabelRoles.Add(LBL_Player4Role);
                LabelRoles.Add(LBL_Player5Role);
                LabelRoles.Add(LBL_Player6Role);
                LabelRoles.Add(LBL_Player7Role);
                LabelRoles.Add(LBL_Player8Role);
                LabelRoles.Add(LBL_Player9Role);

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
            //Updating the round counter label
            LBL_RoundCounter.Text = "Round: " + RoundCounter.ToString();
            //Writing round number after roles are given
            RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "ROUND " + RoundCounter.ToString());
            GivePresident();
            BTN_Continuation.Text = "Choose chancellor";
        }


        private void VoteChancellor()
        {

            //Initializing counters for votes
            int VoteYes = 0;
            int VoteNo = 0;

            if (PlayersArray[0].IsAssassinated == false)
            {
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

            }
            //Random votes for AI players
            int rand;
            int alive = 0;
            for (int i = 1; i < PlayersArray.Count; i++)
            {
                if (PlayersArray[i].IsAssassinated==false)
                {
                    alive++;
                }
            }
            for (int i = 0; i < alive; i++)
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
            if (VoteNo > VoteYes)
            {   //Restart the cycle if majority vote is no
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"Vote no won by " + VoteNo.ToString() + " to " + VoteYes.ToString() + 
                    ". President to be moved to next player.", Color.Red);
                //StartGame();
                EventStage = 5;
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "END OF ROUND " + RoundCounter.ToString());
                RoundCounter++;
                BTN_Continuation.Text = "Next Round";
            }
            else if (VoteNo == VoteYes)
            {
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"Vote ended in a tie. Presidency is moved to next player.",Color.Red);
                //StartGame();
                EventStage = 5;
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "END OF ROUND " + RoundCounter.ToString());
                RoundCounter++;
                BTN_Continuation.Text = "Next Round";
            }
            else
            {
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"Vote yes won by " + VoteYes.ToString() + " to " + 
                    VoteNo.ToString(), Color.Green);
                EventStage = 2;
                BTN_Continuation.Text = "President Discard";

                //If vote passed, nominated player is the chancellor
                for (int i = 0; i < PlayersArray.Count; i++)
                {
                    if (PlayersArray[i].IsNominated&&PlayersArray[i].IsHitler&&FascistPolicies>=3)
                    {
                        if (PlayersArray[0].IsLiberal)
                        {
                            RTXTBOX_InfoLog.AppendText("Hitler has been elected as chancellor after3 fascist policies have been enacted! We lost.", Color.Red);
                        }
                        else if (PlayersArray[0].IsFascist)
                        {
                            RTXTBOX_InfoLog.AppendText("Hitler has been elected as chancellor after3 fascist policies have been enacted! We won.", Color.Green);
                        }
                        else RTXTBOX_InfoLog.AppendText("You, as Hitler, have been elected as chancellor after3 fascist policies have been enacted! Fascists won.", Color.Green);
                        GameOver();
                    }
                    else if (PlayersArray[i].IsNominated == true)
                    {
                        PlayersArray[i].IsNominated = false;
                        PlayersArray[i].IsChancellor = true;
                        LabelRoles[i].Text = "Chancellor";
                        LabelRoles[i].Visible = true;
                        break;
                    }
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
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"You have nominated " +PlayersArray[chancellor.Selected].Name, Color.Green);
            }
            else //If AI is president, nominate a random chancellor
            {
                REDO:
                int choice = Rand.Next(0, PlayersArray.Count);
                if (PlayersArray[choice].IsPresident==true||PlayersArray[choice].WasInOffice==true||PlayersArray[choice].IsAssassinated==true)
                {
                    goto REDO;
                }
                PlayersArray[choice].IsNominated = true;
                //MessageBox.Show(PlayersArray[choice].Name + " has been nominated!");
                if (PlayersArray[0].IsNominated==true)
                {
                    RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"You have been nominated!",Color.Green);
                }
                else RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+PlayersArray[choice].Name + " has been nominated!");
            }
        }

        private void GivePresident()
        {
            EventStage = 0;

            //Reset role labels, chancellor and nomination values for all players
            for (int i = 0; i < PlayersArray.Count; i++)
            {
                if (PlayersArray[i].IsAssassinated==true)
                {
                    continue;
                }
                PlayersArray[i].IsNominated = false;

                if (PlayersArray[i].IsChancellor == true)
                {
                    PlayersArray[i].IsChancellor = false;
                    PlayersArray[i].WasInOffice = true;
                }
                else PlayersArray[i].WasInOffice = false;
                LabelRoles[i].Text = "";
                LabelRoles[i].Visible = false;
            }
            //check if president already exists
            bool PresidentExists = CheckPresident();
            if (PresidentExists == false)
            {
                //If president doesn't exist, give it to first player
                PlayersArray[0].IsPresident = true;
                LabelRoles[0].Text = "President";
                LabelRoles[0].Visible = true;
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + " You are the president.");
                return;
            }

            //If president is last player, give it to the first and edit role labels
            if (PlayersArray[PlayersArray.Count - 1].IsPresident == true && PlayersArray[0].IsAssassinated == false)
            {
                PlayersArray[PlayersArray.Count - 1].IsPresident = false;
                PlayersArray[PlayersArray.Count - 1].WasInOffice = true;
                PlayersArray[0].IsPresident = true;
                LabelRoles[0].Text = "President";
                LabelRoles[0].Visible = true;
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "You are the president.");
            }
            else if (PlayersArray[PlayersArray.Count - 1].IsPresident == true && PlayersArray[1].IsAssassinated == false)
            {
                PlayersArray[PlayersArray.Count - 1].IsPresident = false;
                PlayersArray[PlayersArray.Count - 1].WasInOffice = true;
                PlayersArray[1].IsPresident = true;
                LabelRoles[1].Text = "President";
                LabelRoles[1].Visible = true;
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + PlayersArray[1].Name + " is the president.");
            }
            else if (PlayersArray[PlayersArray.Count - 1].IsPresident == true && PlayersArray[2].IsAssassinated == false)
            {
                PlayersArray[PlayersArray.Count - 1].IsPresident = false;
                PlayersArray[PlayersArray.Count - 1].WasInOffice = true;
                PlayersArray[2].IsPresident = true;
                LabelRoles[2].Text = "President";
                LabelRoles[2].Visible = true;
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + PlayersArray[2].Name + " is the president.");
            }
            else if (PlayersArray[PlayersArray.Count - 2].IsPresident == true && PlayersArray[PlayersArray.Count - 1].IsAssassinated == false)
            {
                PlayersArray[PlayersArray.Count - 2].IsPresident = false;
                PlayersArray[PlayersArray.Count - 2].WasInOffice = true;
                PlayersArray[PlayersArray.Count - 1].IsPresident = true;
                LabelRoles[PlayersArray.Count - 1].Text = "President";
                LabelRoles[PlayersArray.Count - 1].Visible = true;
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + PlayersArray[PlayersArray.Count - 1].Name + " is the president.");
            }
            else if (PlayersArray[PlayersArray.Count - 2].IsPresident == true && PlayersArray[0].IsAssassinated == false)
            {
                PlayersArray[PlayersArray.Count - 2].IsPresident = false;
                PlayersArray[PlayersArray.Count - 2].WasInOffice = true;
                PlayersArray[1].IsPresident = true;
                LabelRoles[1].Text = "President";
                LabelRoles[1].Visible = true;
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + PlayersArray[1].Name + " is the president.");
            }

            else
            {
                for (int i = 0; i < PlayersArray.Count-1; i++)
                {

                    //change president to next person and edite role labels
                    if (PlayersArray[i].IsPresident == true)
                    {
                        if (PlayersArray[i+1].IsAssassinated==false)
                        {
                            PlayersArray[i].IsPresident = false;
                            PlayersArray[i].WasInOffice = true;
                            PlayersArray[i + 1].IsPresident = true;
                            LabelRoles[i].Text = "";
                            LabelRoles[i].Visible = false;
                            LabelRoles[i + 1].Text = "President";
                            LabelRoles[i + 1].Visible = true;
                            RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + PlayersArray[i + 1].Name + " is the president.");
                            break;
                        }
                        else if (PlayersArray[i + 2].IsAssassinated == false)
                        {
                            PlayersArray[i].IsPresident = false;
                            PlayersArray[i].WasInOffice = true;
                            PlayersArray[i + 2].IsPresident = true;
                            LabelRoles[i].Text = "";
                            LabelRoles[i].Visible = false;
                            LabelRoles[i + 2].Text = "President";
                            LabelRoles[i + 2].Visible = true;
                            RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + PlayersArray[i + 2].Name + " is the president.");
                            break;
                        }
                        else
                        {
                            PlayersArray[i].IsPresident = false;
                            PlayersArray[i].WasInOffice = true;
                            PlayersArray[i + 3].IsPresident = true;
                            LabelRoles[i].Text = "";
                            LabelRoles[i].Visible = false;
                            LabelRoles[i + 3].Text = "President";
                            LabelRoles[i + 3].Visible = true;
                            RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + PlayersArray[i + 3].Name + " is the president.");
                            break;
                        }
                    }
                }
            }

        }

        private bool CheckPresident()
        {
            //If any of the players is the president, return true
            for (int i = 0; i < PlayersArray.Count; i++)
            {
                if (PlayersArray[i].IsPresident==true)
                {
                    return true;
                }
            }
            return false;
        }

        private void GiveRoles()
        {
            //Initializing minimum number of liberal and fascist players. Hitler is included as a fascist
            int MaxLib=3;
            int MaxFasc=2;

            //Increase the number of liberal and fascist players depending how many players there are
            for (int i = MaxLib+MaxFasc; i < Properties.Settings.Default.Number_Of_Players+1; i++)
            {
                if (MaxLib == MaxFasc + 1)
                {
                    MaxLib++;
                }
                else MaxFasc++;
            }
            //Counters for number of Liberals, Fascists and Hitler
            int Lib = 0;
            int Fasc = 0;
            int Hitl = 0;
            for (int i = 0; i < PlayersArray.Count; i++)
            {
                
                RAND:
                int rand = Rand.Next(0,3);
                //Checks random number rand and amount of that people that there are. If number of either is at the limit, generates the new random number
                if (rand == 0 && Lib < MaxLib)
                {
                    PlayersArray[i].IsLiberal = true;
                    Lib++;
                }
                else if (rand == 1 && Fasc < MaxFasc-1)
                {
                    PlayersArray[i].IsFascist = true;
                    Fasc++;
                }
                else if (rand == 2 && Hitl < 1)
                {
                    PlayersArray[i].IsHitler = true;
                    Hitl++;
                }
                else goto RAND;  
            }

            //Showing player role
            if (PlayersArray[0].IsLiberal == true)
            {
                MessageBox.Show("You are liberal!"+Environment.NewLine+"Enact 5 liberal policies or assassinate Hitler to win.");
                RTXTBOX_InfoLog.AppendText("You are Liberal!");
                LBL_PlayerHuman.Text += " - Liberal";
            }
            else if (PlayersArray[0].IsFascist == true)
            {
                MessageBox.Show("You are fascist!" + Environment.NewLine + "Enact 6 fascist policies or elect Hitler as chancellor after third fascist policy to win.");
                RTXTBOX_InfoLog.AppendText("You are Fascist!");
                LBL_PlayerHuman.Text += " - Fascist";
                ShowFascists();
            }
            else
            {
                MessageBox.Show("You are Hitler!" + Environment.NewLine + "Enact 6 fascist policies or be elected as chancellor after third fascist policy to win.");
                RTXTBOX_InfoLog.AppendText("You are Hitler!");
                LBL_PlayerHuman.Text += " - Hitler";
                //Hitler only knows who the other Fascists are if there are less than 7 players playing
                if (Properties.Settings.Default.Number_Of_Players<=5)
                {
                    ShowFascists();
                }
            }


        }

        private void ShowFascists()
        {
            //Shows which player is fascist

            for (int i = 1; i < PlayersArray.Count; i++)
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
            else if (EventStage==4)
            {
                Reset();
            }
            else if (EventStage==5)
            {
                StartGame();
            }
        }

        private void Reset()
        {
            //Enable "New game" and "Settings" buttons, disable continuation button
            BTN_NewGame.Enabled = true;
            BTN_Settings.Enabled = true;
            BTN_Continuation.Enabled = false;
            BTN_Continuation.Visible = false;
            LBL_RoundCounter.Visible = false;

            //Reset Labels to nothing for next game
            for (int i = 0; i < LabelNames.Count; i++)
            {
                LabelNames[i].Text = "";
                LabelNames[i].ForeColor = Color.Black;
            }

            for (int i = 0; i < LabelRoles.Count; i++)
            {
                LabelRoles[i].Text = "";
                LabelRoles[i].ForeColor = Color.Black;
            }

            //Delete lists of players, cards and labels. Players and labels have to be refilled depending on amount of players for next game
            //Cards have to be reset to the beginning
            PlayersArray.RemoveRange(0, PlayersArray.Count);
            LabelNames.RemoveRange(0, LabelNames.Count);
            LabelRoles.RemoveRange(0, LabelRoles.Count);
            DiscardedPolicies.RemoveRange(0, DiscardedPolicies.Count);
            Policies.RemoveRange(0, Policies.Count);

            RTXTBOX_InfoLog.Text= RTXTBOX_InfoLog.Text.Remove(0);

            //Bring logo to the front
            PB_Image.BringToFront();
        }

        private void ChancellorPolicyCheck()
        {
            //Show chancellor discard form if player is the chancellor
            if (PlayersArray[0].IsChancellor==true&&PlayersArray[0].IsAssassinated==false)
            {
                ChancellorPolicyDiscard chancellor = new ChancellorPolicyDiscard(PlayersArray[0], Policies[0], Policies[1]);
                chancellor.ShowDialog();
                string temp = Policies[chancellor.Choice];
                Policies.RemoveAt(chancellor.Choice);
                DiscardedPolicies.Add(temp);
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"You have discarded a card.");
            }
            //Randomly pick one if the play is not a chancellor
            else
            {
                if (Properties.Settings.Default.AI_Difficulty == 0)
                {
                    int Discard = Rand.Next(0, 2);
                    string temp = Policies[Discard];
                    Policies.RemoveAt(Discard);
                    DiscardedPolicies.Add(temp);
                    //RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "Chancellor has discarded a card.");
                }
                else if (Properties.Settings.Default.AI_Difficulty == 1)
                {
                    for (int i = 1; i < PlayersArray.Count; i++)
                    {
                        if (PlayersArray[i].IsChancellor == true)
                        {
                            if (PlayersArray[i].IsLiberal == true)
                            {
                                if (Policies[0] == "Fascist")
                                {
                                    string temp = Policies[0];
                                    Policies.RemoveAt(0);
                                    DiscardedPolicies.Add(temp);
                                }
                                else
                                {
                                    string temp = Policies[1];
                                    Policies.RemoveAt(1);
                                    DiscardedPolicies.Add(temp);
                                }
                            }
                            else
                            {
                                if (Policies[0] == "Liberal")
                                {
                                    string temp = Policies[0];
                                    Policies.RemoveAt(0);
                                    DiscardedPolicies.Add(temp);
                                }
                                else
                                {
                                    string temp = Policies[1];
                                    Policies.RemoveAt(1);
                                    DiscardedPolicies.Add(temp);
                                }
                            }
                        }
                        else continue;
                    }
                }
                else
                {
                    for (int i = 1; i < PlayersArray.Count; i++)
                    {
                        if (PlayersArray[i].IsChancellor == true)
                        {
                            if (PlayersArray[i].IsLiberal == true || ((PlayersArray[i].IsFascist || PlayersArray[i].IsHitler == true) && LiberalPolicies <= 3))
                            {
                                if (Policies[0] == "Fascist")
                                {
                                    string temp = Policies[0];
                                    Policies.RemoveAt(0);
                                    DiscardedPolicies.Add(temp);
                                }
                                else
                                {
                                    string temp = Policies[1];
                                    Policies.RemoveAt(1);
                                    DiscardedPolicies.Add(temp);
                                }
                            }
                            else
                            {
                                if (Policies[0] == "Liberal")
                                {
                                    string temp = Policies[0];
                                    Policies.RemoveAt(0);
                                    DiscardedPolicies.Add(temp);
                                }
                                else
                                {
                                    string temp = Policies[1];
                                    Policies.RemoveAt(1);
                                    DiscardedPolicies.Add(temp);
                                }
                            } 
                        }
                    }
                }
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "Chancellor has discarded a card.");

            }
            
            //Increase number of the inacted policies depending which policy it is, remove the first policy from the game
            if (Policies[0] == "Liberal")
            {
                LiberalPolicies++;
                LBL_LiberalLaws.Text = "Liberal Laws - " + LiberalPolicies.ToString();
                //MessageBox.Show("Liberal law has been added");
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"Liberal law has been added.");
            }
            else if (Policies[0] == "Fascist")
            {
                FascistPolicies++;
                LBL_FacistLaws.Text = "Fascist Laws - " + FascistPolicies.ToString();
                //MessageBox.Show("Fascist law has been added");
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"Fascist law has been added.");

            }

            if (Properties.Settings.Default.AI_Using_Assassinations==true)
            {
                if (FascistPolicies == 4 && FirstAssassinationGiven == false)
                {
                    FirstAssassinationGiven = true;
                    if (PlayersArray[0].IsPresident == true)
                    {
                        AssassinationForm form = new AssassinationForm(PlayersArray);
                        form.ShowDialog();
                        PlayersArray[form.Selected].IsAssassinated = true;
                        PlayersArray[form.Selected].IsChancellor = false;
                        PlayersArray[form.Selected].IsNominated = false;
                        PlayersArray[form.Selected].WasInOffice = false;
                        LabelNames[form.Selected].ForeColor = Color.Gray;
                        LabelRoles[form.Selected].Text = "Dead";
                        LabelRoles[form.Selected].ForeColor = Color.Gray;
                        LabelRoles[form.Selected].Visible = true;
                    }
                    else if(Properties.Settings.Default.AI_Difficulty==0)
                    {
                        int rand;
                        LOOP:
                        rand = Rand.Next(0, PlayersArray.Count);
                        if (PlayersArray[rand].IsPresident == true || PlayersArray[rand].IsAssassinated == true)
                        {
                            goto LOOP;
                        }
                        PlayersArray[rand].IsAssassinated = true;
                        PlayersArray[rand].IsChancellor = false;
                        PlayersArray[rand].IsNominated = false;
                        PlayersArray[rand].WasInOffice = false;
                        LabelNames[rand].ForeColor = Color.Gray;
                        LabelRoles[rand].Text = "Dead";
                        LabelRoles[rand].ForeColor = Color.Gray;
                        LabelRoles[rand].Visible = true;
                    }
                    else
                    {
                        for (int i = 1; i < PlayersArray.Count; i++)
                        {
                            if (PlayersArray[i].IsPresident==true)
                            {
                                if (PlayersArray[i].IsLiberal==true || (PlayersArray[i].IsHitler && PlayersArray.Count > 6))
                                {
                                    int rand;
                                    LOOP:
                                    rand = Rand.Next(0, PlayersArray.Count);
                                    if (PlayersArray[rand].IsPresident == true || PlayersArray[rand].IsAssassinated == true)
                                    {
                                        goto LOOP;
                                    }
                                    PlayersArray[rand].IsAssassinated = true;
                                    PlayersArray[rand].IsChancellor = false;
                                    PlayersArray[rand].IsNominated = false;
                                    PlayersArray[rand].WasInOffice = false;
                                    LabelNames[rand].ForeColor = Color.Gray;
                                    LabelRoles[rand].Text = "Dead";
                                    LabelRoles[rand].ForeColor = Color.Gray;
                                    LabelRoles[rand].Visible = true;
                                }
                                else if (PlayersArray[i].IsFascist||(PlayersArray[i].IsHitler&&PlayersArray.Count<=6))
                                {
                                    int rand;
                                    LOOP:
                                    rand = Rand.Next(0, PlayersArray.Count);
                                    if (PlayersArray[rand].IsPresident == true || PlayersArray[rand].IsAssassinated == true|| PlayersArray[rand].IsFascist == true|| PlayersArray[rand].IsHitler == true)
                                    {
                                        goto LOOP;
                                    }
                                    PlayersArray[rand].IsAssassinated = true;
                                    PlayersArray[rand].IsChancellor = false;
                                    PlayersArray[rand].IsNominated = false;
                                    PlayersArray[rand].WasInOffice = false;
                                    LabelNames[rand].ForeColor = Color.Gray;
                                    LabelRoles[rand].Text = "Dead";
                                    LabelRoles[rand].ForeColor = Color.Gray;
                                    LabelRoles[rand].Visible = true;
                                }
                            }
                        }
                    }
                }
                else if (FascistPolicies == 5 && SecondAssassinationGiven == false)
                {
                    SecondAssassinationGiven = true;
                    if (PlayersArray[0].IsPresident == true)
                    {
                        AssassinationForm form = new AssassinationForm(PlayersArray);
                        form.ShowDialog();
                        PlayersArray[form.Selected].IsAssassinated = true;
                        PlayersArray[form.Selected].IsChancellor = false;
                        PlayersArray[form.Selected].IsNominated = false;
                        PlayersArray[form.Selected].WasInOffice = false;
                        LabelNames[form.Selected].ForeColor = Color.Gray;
                        LabelRoles[form.Selected].Text = "Dead";
                        LabelRoles[form.Selected].ForeColor = Color.Gray;
                        LabelRoles[form.Selected].Visible = true;
                    }
                    else
                    {
                        int rand;
                        LOOP:
                        rand = Rand.Next(0, PlayersArray.Count);
                        if (PlayersArray[rand].IsPresident == true || PlayersArray[rand].IsAssassinated == true)
                        {
                            goto LOOP;
                        }
                        PlayersArray[rand].IsAssassinated = true;
                        PlayersArray[rand].IsChancellor = false;
                        PlayersArray[rand].IsNominated = false;
                        PlayersArray[rand].WasInOffice = false;
                        LabelNames[rand].ForeColor = Color.Gray;
                        LabelRoles[rand].Text = "Dead";
                        LabelRoles[rand].ForeColor = Color.Gray;
                        LabelRoles[rand].Visible = true;
                    }
                }
            }
            else if (PlayersArray[0].IsPresident == true)
            {
                if (FascistPolicies >=4 && FirstAssassinationGiven == false)
                {
                    FirstAssassinationGiven = true;
                    AssassinationForm form = new AssassinationForm(PlayersArray);
                    form.ShowDialog();
                    PlayersArray[form.Selected].IsAssassinated = true;
                    PlayersArray[form.Selected].IsChancellor = false;
                    PlayersArray[form.Selected].IsNominated = false;
                    PlayersArray[form.Selected].WasInOffice = false;
                    LabelNames[form.Selected].ForeColor = Color.Gray;
                    LabelRoles[form.Selected].Text = "Dead";
                    LabelRoles[form.Selected].ForeColor = Color.Gray;
                    LabelRoles[form.Selected].Visible = true;
                }
                else if (FascistPolicies >= 5 && SecondAssassinationGiven == false)
                {
                    SecondAssassinationGiven = true;
                    AssassinationForm form = new AssassinationForm(PlayersArray);
                    form.ShowDialog();
                    PlayersArray[form.Selected].IsAssassinated = true;
                    PlayersArray[form.Selected].IsChancellor = false;
                    PlayersArray[form.Selected].IsNominated = false;
                    PlayersArray[form.Selected].WasInOffice = false;
                    LabelNames[form.Selected].ForeColor = Color.Gray;
                    LabelRoles[form.Selected].Text = "Dead";
                    LabelRoles[form.Selected].ForeColor = Color.Gray;
                    LabelRoles[form.Selected].Visible = true;
                }
            }


            //If policy win condition has been reached, call in Game over function
            if (LiberalPolicies == 5)
            {
                if (PlayersArray[0].IsLiberal==true)
                {
                    RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "Game over, we have won by enacting 5 policies!!",Color.Green);
                }
                else RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "Game over, Liberals have won by enacting 5 policies!! We lost.",Color.Red);
                GameOver();
            }
            else if (FascistPolicies == 6)
            {
                if (PlayersArray[0].IsLiberal == true)
                {
                    RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "Game over, Fascists have won by enacting 6 policies!! We lost.", Color.Red);
                }
                else RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "Game over, We have won by enacting 6 policies!!", Color.Green);
                GameOver();
            }
            else 
            {
                    //If there are less than three policies in policy card pile, add the discarded policies in, shuffle them and empty the discarded policy list
                    if (Policies.Count < 3)
                {
                    Policies.AddRange(DiscardedPolicies);
                    Policies.Shuffle();
                    DiscardedPolicies.RemoveRange(0, DiscardedPolicies.Count);
                }
                //Increasing the round counter and updating the label
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine+"END OF ROUND " + RoundCounter.ToString());
                //Restart the loop
                //StartGame();
                EventStage = 5;
                RoundCounter++;
                BTN_Continuation.Text = "Next Round";

                if (FirstAssassinationGiven == true)
                {
                    for (int i = 0; i < PlayersArray.Count; i++)
                    {
                        if (PlayersArray[i].IsHitler == true && PlayersArray[i].IsAssassinated == true)
                        {
                            if (PlayersArray[0].IsLiberal == true)
                            {
                                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "Hitler has been assassinated! We won.", Color.Green);
                            }
                            else if (PlayersArray[0].IsFascist == true)
                            {
                                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "Hitler has been assassinated! We lost.", Color.Red);
                            }
                            else
                            {
                                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "You, as Hitler, have been assassinated! Fascists lost.", Color.Red);
                            }
                            GameOver();
                        }
                    }
                }
            }


        }

        private void GameOver()
        {
           
            //Shows which player was playing as what role

            for (int i = 1; i < PlayersArray.Count; i++)
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

                BTN_Continuation.Text = "Reset";
                EventStage = 4;
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
                if (Properties.Settings.Default.AI_Difficulty == 0)
                {
                    int Discard = Rand.Next(0, 3);
                    string temp = Policies[Discard];
                    Policies.RemoveAt(Discard);
                    DiscardedPolicies.Add(temp);
                    //RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "President has discarded a card.");
                }
                else if (Properties.Settings.Default.AI_Difficulty == 1)
                {
                    for (int i = 1; i < PlayersArray.Count; i++)
                    {
                        if (PlayersArray[i].IsPresident == true)
                        {
                            if (PlayersArray[i].IsLiberal == true)
                            {
                                if (Policies[0] == "Fascist")
                                {
                                    string temp = Policies[0];
                                    Policies.RemoveAt(0);
                                    DiscardedPolicies.Add(temp);
                                }
                                else if(Policies[1] == "Fascist")
                                {
                                    string temp = Policies[1];
                                    Policies.RemoveAt(1);
                                    DiscardedPolicies.Add(temp);
                                }
                                else
                                {
                                    string temp = Policies[2];
                                    Policies.RemoveAt(2);
                                    DiscardedPolicies.Add(temp);
                                }
                            }
                            else
                            {
                                if (Policies[0] == "Liberal")
                                {
                                    string temp = Policies[0];
                                    Policies.RemoveAt(0);
                                    DiscardedPolicies.Add(temp);
                                }
                                else if(Policies[1] == "Liberal")
                                {
                                    string temp = Policies[1];
                                    Policies.RemoveAt(1);
                                    DiscardedPolicies.Add(temp);
                                }
                                else
                                {
                                    string temp = Policies[2];
                                    Policies.RemoveAt(2);
                                    DiscardedPolicies.Add(temp);
                                }
                            }
                        }
                        else continue;
                    }
                }
                else
                {
                    for (int i = 1; i < PlayersArray.Count; i++)
                    {
                        if (PlayersArray[i].IsPresident == true)
                        {
                            if (PlayersArray[i].IsLiberal == true || ((PlayersArray[i].IsFascist==true || PlayersArray[i].IsHitler == true) && LiberalPolicies < 3))
                            {
                                if (Policies[0] == "Fascist")
                                {
                                    string temp = Policies[0];
                                    Policies.RemoveAt(0);
                                    DiscardedPolicies.Add(temp);
                                }
                                else if (Policies[1] == "Fascist")
                                {
                                    string temp = Policies[1];
                                    Policies.RemoveAt(1);
                                    DiscardedPolicies.Add(temp);
                                }
                                else
                                {
                                    string temp = Policies[2];
                                    Policies.RemoveAt(2);
                                    DiscardedPolicies.Add(temp);
                                }
                            }
                            else
                            {
                                if (Policies[0] == "Liberal")
                                {
                                    string temp = Policies[0];
                                    Policies.RemoveAt(0);
                                    DiscardedPolicies.Add(temp);
                                }
                                else if (Policies[1] == "Liberal")
                                {
                                    string temp = Policies[1];
                                    Policies.RemoveAt(1);
                                    DiscardedPolicies.Add(temp);
                                }
                                else
                                {
                                    string temp = Policies[2];
                                    Policies.RemoveAt(2);
                                    DiscardedPolicies.Add(temp);
                                }
                            }
                        }
                    }
                }
                RTXTBOX_InfoLog.AppendText(Environment.NewLine + Environment.NewLine + "President has discarded a card.");
            }

            //Move event Stage to next stage
            EventStage = 3;
            BTN_Continuation.Text = "Chancellor Discard";
        }

        private void RTXTBOX_InfoLog_TextChanged(object sender, EventArgs e)
        {
            RTXTBOX_InfoLog.SelectionStart = RTXTBOX_InfoLog.Text.Length;
            RTXTBOX_InfoLog.ScrollToCaret();
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

        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.Text.Length;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
