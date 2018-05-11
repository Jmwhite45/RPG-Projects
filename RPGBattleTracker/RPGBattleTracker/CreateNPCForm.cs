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
    public partial class CreateNPCForm : Form
    {
        private MainForm Prev;
        public NPC[] finishedPlayer;

        public CreateNPCForm(MainForm p)
        {
            Prev = p;
            InitializeComponent();
        }

        public bool CheckforErrors()
        {
            return true;
        }

        private void Completedbtn_Click(object sender, EventArgs e)
        {
            finishedPlayer = new NPC[Convert.ToInt32(NumberOf.Value)];

            for (int i = 0; i < Convert.ToInt32(NumberOf.Value); i++)
            {
                finishedPlayer[i] = new NPC(Convert.ToInt32(MaxHP.Value), Convert.ToInt32(CR.Value), Convert.ToInt32(InitMod.Value), Type.Text, Size.Text, NPCName.Text+" "+(i+1), NPCNotes.Text);
            }
            Prev.CreateNPCDone();
        }
    }
}
