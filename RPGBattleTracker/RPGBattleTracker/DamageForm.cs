using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RPGBattleTracker.Vars;

namespace RPGBattleTracker
{
    public partial class DamageForm : Form
    {
        private List<Damage> DamageList;
        private MainForm Prev;
        private Character Char;

        public DamageForm(MainForm P, Character C)
        {
            DamageList = new List<Damage>();
            Prev = P;
            Char = C;
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Damage dam = new Damage((DAMAGETYPE)TypeBox.SelectedIndex, (int)AmountBox.Value);

            DamageList.Add(dam);

            Damageslb.Items.Add(dam.ToString());
        }

        private void Completebtn_Click(object sender, EventArgs e)
        {
            foreach (Damage D in DamageList)
            {
                Char.addDamage(D.amount);
            }
            Prev.DamageDone();
        }
    }
}
