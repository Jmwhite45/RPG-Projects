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
    public partial class Player_Initative_Form : Form
    {
        private MainForm Prev;
        private List<Player> playerList;
        private Player currentSelected;

        public Player_Initative_Form(MainForm p)
        {
            Prev = p;
            InitializeComponent();
            playerList = p.getPlayerList();
            updateList();

        }

        public List<Player> getPlayerList()
        {
            return playerList;
        }

        public List<Character> getCharacterList()
        {
            List<Character> CharacterList = new List<Character>();
            foreach(Player p in playerList)
            {
                CharacterList.Add(p);
            }
            return CharacterList;
        }

        public void updateList()
        {
            Player[] Players = playerList.ToArray();
            InitOrderlb.Items.Clear();

            foreach (Player P in Players)
            {
                InitOrderlb.Items.Add(P.GetName());
            }
        }

        private void InitOrderlb_SelectedValueChanged(object sender, EventArgs e)
        {
            //save Prev init
            if (currentSelected != null)
            {
                currentSelected.setInit(Convert.ToInt32(initValue.Value));
            }
          
            // get new selected Value
            string Select = InitOrderlb.SelectedItem.ToString();

            // get new selected player
            foreach (Player P in playerList)
            {
                if(P.GetName() == Select)
                {
                    currentSelected = P;
                    break;
                }
            }

            // reset init value.
            initValue.Value = currentSelected.GetInit();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check values
            if (currentSelected != null)
            {
                currentSelected.setInit(Convert.ToInt32(initValue.Value));
            }
            Prev.AddInitDone();
        }
    }
}
