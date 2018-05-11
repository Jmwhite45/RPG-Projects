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
            InitializeComponent();
        }
        private MainForm Prev;
        public Player finishedPlayer;

        public bool CheckforErrors()
        {
            return true;
        }

        private void Completedbtn_Click(object sender, EventArgs e)
        {
            finishedPlayer = new Player(Convert.ToInt32(Level.Value), Convert.ToInt32(MaxHP.Value), Race.Text, Class.Text, CharacterName.Text, PlayerName.Text, CharacterNotes.Text, Convert.ToInt32(Passive.Value));
            Prev.CreatePlayerDone();
        }
    }
}
