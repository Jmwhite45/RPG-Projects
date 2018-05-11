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
            this.addNpcbtn.Location = new System.Drawing.Point(93, 12);
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
            // 
            // NPClistlb
            // 
            this.NPClistlb.FormattingEnabled = true;
            this.NPClistlb.Location = new System.Drawing.Point(361, 81);
            this.NPClistlb.Name = "NPClistlb";
            this.NPClistlb.Size = new System.Drawing.Size(140, 225);
            this.NPClistlb.TabIndex = 9;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 318);
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
    }
}

