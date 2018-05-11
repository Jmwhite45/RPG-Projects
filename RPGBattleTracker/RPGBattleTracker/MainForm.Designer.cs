namespace RPGBattleTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPlayerbtn = new System.Windows.Forms.Button();
            this.InitOrderlb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNpcbtn = new System.Windows.Forms.Button();
            this.NPCInit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerListlb = new System.Windows.Forms.ListBox();
            this.NPClistlb = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTests = new System.Windows.Forms.Button();
            this.RemoveNPCbtn = new System.Windows.Forms.Button();
            this.removePlayerbtn = new System.Windows.Forms.Button();
            this.HPDisplay = new System.Windows.Forms.Label();
            this.CharacterDisplay = new System.Windows.Forms.Label();
            this.PlayerDisplay = new System.Windows.Forms.Label();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.NPCNameDisplay = new System.Windows.Forms.Label();
            this.NPCHPDisplay = new System.Windows.Forms.Label();
            this.CRDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPlayerbtn
            // 
            this.addPlayerbtn.Location = new System.Drawing.Point(12, 12);
            this.addPlayerbtn.Name = "addPlayerbtn";
            this.addPlayerbtn.Size = new System.Drawing.Size(75, 23);
            this.addPlayerbtn.TabIndex = 0;
            this.addPlayerbtn.Text = "Add Player";
            this.addPlayerbtn.UseVisualStyleBackColor = true;
            this.addPlayerbtn.Click += new System.EventHandler(this.addPlayerbtn_Click);
            // 
            // InitOrderlb
            // 
            this.InitOrderlb.FormattingEnabled = true;
            this.InitOrderlb.Location = new System.Drawing.Point(12, 81);
            this.InitOrderlb.Name = "InitOrderlb";
            this.InitOrderlb.Size = new System.Drawing.Size(140, 225);
            this.InitOrderlb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initative";
            // 
            // addNpcbtn
            // 
            this.addNpcbtn.Location = new System.Drawing.Point(12, 36);
            this.addNpcbtn.Name = "addNpcbtn";
            this.addNpcbtn.Size = new System.Drawing.Size(75, 23);
            this.addNpcbtn.TabIndex = 3;
            this.addNpcbtn.Text = "Add NPC";
            this.addNpcbtn.UseVisualStyleBackColor = true;
            this.addNpcbtn.Click += new System.EventHandler(this.addNpcbtn_Click);
            // 
            // NPCInit
            // 
            this.NPCInit.Location = new System.Drawing.Point(240, 12);
            this.NPCInit.Name = "NPCInit";
            this.NPCInit.Size = new System.Drawing.Size(103, 35);
            this.NPCInit.TabIndex = 4;
            this.NPCInit.Text = "Roll NPC Initative";
            this.NPCInit.UseVisualStyleBackColor = true;
            this.NPCInit.Click += new System.EventHandler(this.NPCInit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Player Initative";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerListlb
            // 
            this.PlayerListlb.FormattingEnabled = true;
            this.PlayerListlb.Location = new System.Drawing.Point(215, 81);
            this.PlayerListlb.Name = "PlayerListlb";
            this.PlayerListlb.Size = new System.Drawing.Size(140, 225);
            this.PlayerListlb.TabIndex = 8;
            this.PlayerListlb.SelectedIndexChanged += new System.EventHandler(this.PlayerListlb_SelectedIndexChanged);
            // 
            // NPClistlb
            // 
            this.NPClistlb.FormattingEnabled = true;
            this.NPClistlb.Location = new System.Drawing.Point(361, 81);
            this.NPClistlb.Name = "NPClistlb";
            this.NPClistlb.Size = new System.Drawing.Size(140, 225);
            this.NPClistlb.TabIndex = 9;
            this.NPClistlb.SelectedIndexChanged += new System.EventHandler(this.NPClistlb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "NPCs/Monsters";
            // 
            // AddTests
            // 
            this.AddTests.Location = new System.Drawing.Point(158, 81);
            this.AddTests.Name = "AddTests";
            this.AddTests.Size = new System.Drawing.Size(51, 58);
            this.AddTests.TabIndex = 12;
            this.AddTests.Text = "Add Test Players";
            this.AddTests.UseVisualStyleBackColor = true;
            this.AddTests.Click += new System.EventHandler(this.AddTests_Click);
            // 
            // RemoveNPCbtn
            // 
            this.RemoveNPCbtn.Location = new System.Drawing.Point(93, 36);
            this.RemoveNPCbtn.Name = "RemoveNPCbtn";
            this.RemoveNPCbtn.Size = new System.Drawing.Size(87, 23);
            this.RemoveNPCbtn.TabIndex = 14;
            this.RemoveNPCbtn.Text = "Remove NPC";
            this.RemoveNPCbtn.UseVisualStyleBackColor = true;
            this.RemoveNPCbtn.Click += new System.EventHandler(this.RemoveNPCbtn_Click);
            // 
            // removePlayerbtn
            // 
            this.removePlayerbtn.Location = new System.Drawing.Point(93, 12);
            this.removePlayerbtn.Name = "removePlayerbtn";
            this.removePlayerbtn.Size = new System.Drawing.Size(87, 23);
            this.removePlayerbtn.TabIndex = 13;
            this.removePlayerbtn.Text = "Remove Player";
            this.removePlayerbtn.UseVisualStyleBackColor = true;
            this.removePlayerbtn.Click += new System.EventHandler(this.removePlayerbtn_Click);
            // 
            // HPDisplay
            // 
            this.HPDisplay.AutoSize = true;
            this.HPDisplay.Location = new System.Drawing.Point(538, 161);
            this.HPDisplay.Name = "HPDisplay";
            this.HPDisplay.Size = new System.Drawing.Size(22, 13);
            this.HPDisplay.TabIndex = 17;
            this.HPDisplay.Text = "HP";
            // 
            // CharacterDisplay
            // 
            this.CharacterDisplay.AutoSize = true;
            this.CharacterDisplay.Location = new System.Drawing.Point(538, 139);
            this.CharacterDisplay.Name = "CharacterDisplay";
            this.CharacterDisplay.Size = new System.Drawing.Size(84, 13);
            this.CharacterDisplay.TabIndex = 18;
            this.CharacterDisplay.Text = "Character Name";
            // 
            // PlayerDisplay
            // 
            this.PlayerDisplay.AutoSize = true;
            this.PlayerDisplay.Location = new System.Drawing.Point(538, 117);
            this.PlayerDisplay.Name = "PlayerDisplay";
            this.PlayerDisplay.Size = new System.Drawing.Size(67, 13);
            this.PlayerDisplay.TabIndex = 19;
            this.PlayerDisplay.Text = "Player Name";
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(541, 178);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(92, 25);
            this.btnEditPlayer.TabIndex = 20;
            this.btnEditPlayer.Text = "Edit Player";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 25);
            this.button3.TabIndex = 21;
            this.button3.Text = "Add Damage";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(685, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 25);
            this.button4.TabIndex = 25;
            this.button4.Text = "Add Damage";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(685, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 25);
            this.button5.TabIndex = 24;
            this.button5.Text = "Edit Character";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // NPCNameDisplay
            // 
            this.NPCNameDisplay.AutoSize = true;
            this.NPCNameDisplay.Location = new System.Drawing.Point(682, 117);
            this.NPCNameDisplay.Name = "NPCNameDisplay";
            this.NPCNameDisplay.Size = new System.Drawing.Size(60, 13);
            this.NPCNameDisplay.TabIndex = 23;
            this.NPCNameDisplay.Text = "NPC Name";
            // 
            // NPCHPDisplay
            // 
            this.NPCHPDisplay.AutoSize = true;
            this.NPCHPDisplay.Location = new System.Drawing.Point(682, 161);
            this.NPCHPDisplay.Name = "NPCHPDisplay";
            this.NPCHPDisplay.Size = new System.Drawing.Size(22, 13);
            this.NPCHPDisplay.TabIndex = 22;
            this.NPCHPDisplay.Text = "HP";
            // 
            // CRDisplay
            // 
            this.CRDisplay.AutoSize = true;
            this.CRDisplay.Location = new System.Drawing.Point(682, 139);
            this.CRDisplay.Name = "CRDisplay";
            this.CRDisplay.Size = new System.Drawing.Size(22, 13);
            this.CRDisplay.TabIndex = 26;
            this.CRDisplay.Text = "CR";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 348);
            this.Controls.Add(this.CRDisplay);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.NPCNameDisplay);
            this.Controls.Add(this.NPCHPDisplay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.PlayerDisplay);
            this.Controls.Add(this.CharacterDisplay);
            this.Controls.Add(this.HPDisplay);
            this.Controls.Add(this.RemoveNPCbtn);
            this.Controls.Add(this.removePlayerbtn);
            this.Controls.Add(this.AddTests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NPClistlb);
            this.Controls.Add(this.PlayerListlb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NPCInit);
            this.Controls.Add(this.addNpcbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InitOrderlb);
            this.Controls.Add(this.addPlayerbtn);
            this.Name = "MainForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayerbtn;
        private System.Windows.Forms.ListBox InitOrderlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNpcbtn;
        private System.Windows.Forms.Button NPCInit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox PlayerListlb;
        private System.Windows.Forms.ListBox NPClistlb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddTests;
        private System.Windows.Forms.Button RemoveNPCbtn;
        private System.Windows.Forms.Button removePlayerbtn;
        private System.Windows.Forms.Label HPDisplay;
        private System.Windows.Forms.Label CharacterDisplay;
        private System.Windows.Forms.Label PlayerDisplay;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label NPCNameDisplay;
        private System.Windows.Forms.Label NPCHPDisplay;
        private System.Windows.Forms.Label CRDisplay;
    }
}

