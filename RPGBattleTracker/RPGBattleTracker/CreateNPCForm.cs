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
        public NPC[] finishedNPC;
        public bool add;
        private int prevCurrent;
        private int prevMax;

        public CreateNPCForm(MainForm p)
        {
            Prev = p;
            add = true;
            prevCurrent = 0;
            prevMax = 0;
            InitializeComponent();
        }

        public CreateNPCForm(MainForm p, NPC N)
        {
            Prev = p;
            finishedNPC = new NPC[1];
            finishedNPC[0] = N;
            add = false;
            prevCurrent = N.getCurrentHP();
            prevMax = N.getMaxHP();
            InitializeComponent();
            SetUp();
        }

        public bool CheckforErrors()
        {
            return true;
        }

        public void SetUp()
        {
            CR.Value = finishedNPC[0].GetCR();
            MaxHP.Value = finishedNPC[0].getMaxHP();
            InitMod.Value = finishedNPC[0].getInit();
            Type.Text = finishedNPC[0].getType();
            Size.Text = finishedNPC[0].getSize();
            NPCName.Text = finishedNPC[0].GetName();
            NPCNotes.Text = finishedNPC[0].getNotes();

            NumberOf.Value = 1;
            NumberOf.Enabled = false;
        }

        private void Completedbtn_Click(object sender, EventArgs e)
        {
            finishedNPC = new NPC[Convert.ToInt32(NumberOf.Value)];


            for (int i = 0; i < Convert.ToInt32(NumberOf.Value); i++)
            {
                finishedNPC[i] = new NPC(Convert.ToInt32(MaxHP.Value), Convert.ToInt32(CR.Value), Convert.ToInt32(InitMod.Value), Type.Text, Size.Text, NPCName.Text+" "+(i+1), NPCNotes.Text);
            }
            if(add == false)
            {
                int total = prevCurrent + (Convert.ToInt32(MaxHP.Value) - prevMax);
                finishedNPC[0].setHP(total);
                finishedNPC[0].SetName(NPCName.Text);
            }
            Prev.CreateNPCDone(add);
        }
    }
}
