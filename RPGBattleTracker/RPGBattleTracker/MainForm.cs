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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            playerList = new List<Player>();
            NPCList = new List<NPC>();
            InitList = new List<Character>();
            InitializeComponent();
        }

        public enum form
        {
            MAIN, CREATEPLAYER, CREATENPC
        }

        private Player newPlayer;
        private CreatePlayerForm CPform;
        private CreateNPCForm CNform;
        private Player_Initative_Form AIform;

        private form activeForm;
        private List<Player> playerList;
        private List<Character> InitList;
        private List<NPC> NPCList;

        public void CreatePlayerDone()
        {
            activeForm = form.MAIN;
            playerList.Add(CPform.finishedPlayer);
            updatePlayers();
            CPform.Close();
            this.Show();
        }

        public List<Player> getPlayerList()
        {
            return playerList;
        }

        public void CreateNPCDone()
        {
            activeForm = form.MAIN;
            NPCList.AddRange(CNform.finishedPlayer.ToList());
            updateNPCs();
            CNform.Close();
            this.Show();
        }

        public void AddToInit(List<Character> c)
        {
            foreach(Character C in c)
            {
                foreach(Character C2 in InitList)
                {
                    if(C == C2)
                    {
                        InitList.Remove(C2);
                        break;
                    }
                }
            }

            InitList.AddRange(c);
            sortInitList();
        }

        public void sortInitList()
        {
            List<int> initList = new List<int>();
            List<string> NameList= new List<string>();
            List<Character> oldCharacters = new List<Character>();

            foreach (Character c in InitList)
            {
                initList.Add(c.GetInit());
                NameList.Add(c.GetName());
                oldCharacters.Add(c);
            }

            int[] initatives = initList.ToArray();
            string[] names = NameList.ToArray();

            Array.Sort(initatives, names);
            Array.Reverse(names);

            InitList.Clear();
            InitOrderlb.Items.Clear();

            foreach (string name in NameList)
            {
                foreach (Character c in oldCharacters)
                {
                    if(c.GetName() == name)
                    {
                        InitList.Add(c);
                        break;
                    }
                }
            }
            
            foreach (string C in names)
            {
                InitOrderlb.Items.Add(C);
            }
        }

        public void AddInitDone()
        {
            activeForm = form.MAIN;
            AddToInit(AIform.getCharacterList());
            AIform.Close();
            this.Show();
        }

        public void updateNPCs()
        {
            NPC[] NPCs = NPCList.ToArray();
            NPClistlb.Items.Clear();

            foreach (NPC N in NPCs)
            {
                NPClistlb.Items.Add(N.GetName());
            }
        }

        private void updatePlayers()
        {
            Player[] players = playerList.ToArray();
            PlayerListlb.Items.Clear();

            foreach (Player P in players)
            {
                PlayerListlb.Items.Add(P.GetName());
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

        private void button1_Click(object sender, EventArgs e)
        {
            AIform = new Player_Initative_Form(this);
            AIform.Show();
            this.Hide();
        }

        private void AddTests_Click(object sender, EventArgs e)
        {
            Player Ptest1 = new Player(1, 45, "asdf", "Character 1", "name 1", "asdfasdf", "asdfasdf", 12);
            Player Ptest2 = new Player(1, 45, "asdf", "Character 2", "name 2", "asdfasdf", "asdfasdf", 12);
            Player Ptest3 = new Player(1, 45, "asdf", "Character 3", "name 3", "asdfasdf", "asdfasdf", 12);

            NPC Ntest1 = new NPC(45, 1, 2, "type", "Size", "NPC 1", "qwerqwer");
            NPC Ntest2 = new NPC(45, 1, 2, "type", "Size", "NPC 2", "qwerqwer");
            NPC Ntest3 = new NPC(45, 1, 2, "type", "Size", "NPC 3", "qwerqwer");

            playerList.Add(Ptest1);
            playerList.Add(Ptest2);
            playerList.Add(Ptest3);
            NPCList.Add(Ntest1);
            NPCList.Add(Ntest2);
            NPCList.Add(Ntest3);

            updateNPCs();
            updatePlayers();
        }

        private void NPCInit_Click(object sender, EventArgs e)
        {
            AddToInit(convertToCharacterList(NPCList));
        }

        public static List<Character> convertToCharacterList(List<NPC> ListNPC)
        {
            List<Character> returnList = new List<Character>();

            foreach(NPC n in ListNPC)
            {
                returnList.Add(n);
            }

            return returnList;
        }
    }
}
