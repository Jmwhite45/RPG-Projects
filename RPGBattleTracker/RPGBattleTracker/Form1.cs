using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGBattleTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            playerList = new List<Player>();
            NPCList = new List<NPC>();
            InitializeComponent();
        }

        public enum form
        {
            MAIN, CREATEPLAYER, CREATENPC
        }

        private Player newPlayer;
        private CreatePlayerForm CPform;
        private CreateNPCForm CNform;

        private form activeForm;
        private List<Player> playerList;
        private List<NPC> NPCList;

        public void CreatePlayerDone()
        {
            activeForm = form.MAIN;
            playerList.Add(CPform.finishedPlayer);
            updatePlayers();
            CPform.Close();
            this.Show();
        }

        public void CreateNPCDone()
        {
            activeForm = form.MAIN;
            NPCList.AddRange(CNform.finishedPlayer.ToList());
            updateNPCs();
            CNform.Close();
            this.Show();
        }

        public void updateNPCs()
        {
            NPC[] NPCs = NPCList.ToArray();
            NPClistlb.Items.Clear();

            foreach (NPC N in NPCs)
            {
                NPClistlb.Items.Add(N.getName());
            }
        }

        private void updatePlayers()
        {
            Player[] players = playerList.ToArray();
            PlayerListlb.Items.Clear();

            foreach (Player P in players)
            {
                PlayerListlb.Items.Add(P.getName());
            }

        }

        private void addPlayerbtn_Click(object sender, EventArgs e)
        {
           CPform  = new CreatePlayerForm(this);
            CPform.Show();
            this.Hide();
        }

        private void addNpcbtn_Click(object sender, EventArgs e)
        {
            CNform = new CreateNPCForm(this);
            CNform.Show();
            this.Hide();
        }
    }
}
