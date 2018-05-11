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
    public partial class CreatePlayerForm : Form
    {
        public  CreatePlayerForm(MainForm previousForm)
        {
            Prev = previousForm;
            add = true;
            InitializeComponent();
        }

        public CreatePlayerForm(MainForm previousForm, Player P)
        {
            Prev = previousForm;
            finishedPlayer = P;
            add = false;
            InitializeComponent();
            SetUp();
        }
        private MainForm Prev;
        public Player finishedPlayer;
        private bool add;

        public bool CheckforErrors()
        {
            return true;
        }

        public void SetUp()
        {
            Level.Value = finishedPlayer.GetLevel();
            MaxHP.Value = finishedPlayer.getMaxHP();
            Race.Text = finishedPlayer.GetRace();
            Class.Text = finishedPlayer.getClass();
            CharacterName.Text = finishedPlayer.GetName();
            PlayerName.Text = finishedPlayer.getPlayer();
            CharacterNotes.Text = finishedPlayer.getNotes();
            Passive.Value = finishedPlayer.getPassive();
        }

        private void Completedbtn_Click(object sender, EventArgs e)
        {
            finishedPlayer = new Player(Convert.ToInt32(Level.Value), Convert.ToInt32(MaxHP.Value), Race.Text, Class.Text, CharacterName.Text, PlayerName.Text, CharacterNotes.Text, Convert.ToInt32(Passive.Value));
            Prev.CreatePlayerDone(add);
        }
    }
}
