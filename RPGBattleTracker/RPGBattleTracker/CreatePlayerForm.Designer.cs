namespace RPGBattleTracker
{
    partial class CreatePlayerForm
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
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxHP = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CharacterNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CharacterName = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.TextBox();
            this.Passive = new System.Windows.Forms.NumericUpDown();
            this.Level = new System.Windows.Forms.NumericUpDown();
            this.Race = new System.Windows.Forms.TextBox();
            this.Completedbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(117, 10);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(100, 20);
            this.PlayerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Name";
            // 
            // MaxHP
            // 
            this.MaxHP.Location = new System.Drawing.Point(117, 68);
            this.MaxHP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxHP.Name = "MaxHP";
            this.MaxHP.Size = new System.Drawing.Size(80, 20);
            this.MaxHP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Passive Perception";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Character Name";
            // 
            // CharacterNotes
            // 
            this.CharacterNotes.Location = new System.Drawing.Point(254, 37);
            this.CharacterNotes.Multiline = true;
            this.CharacterNotes.Name = "CharacterNotes";
            this.CharacterNotes.Size = new System.Drawing.Size(233, 166);
            this.CharacterNotes.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Character Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Level";
            // 
            // CharacterName
            // 
            this.CharacterName.Location = new System.Drawing.Point(117, 40);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(100, 20);
            this.CharacterName.TabIndex = 11;
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(117, 126);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(100, 20);
            this.Class.TabIndex = 12;
            // 
            // Passive
            // 
            this.Passive.Location = new System.Drawing.Point(117, 99);
            this.Passive.Name = "Passive";
            this.Passive.Size = new System.Drawing.Size(80, 20);
            this.Passive.TabIndex = 13;
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(117, 191);
            this.Level.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(80, 20);
            this.Level.TabIndex = 14;
            // 
            // Race
            // 
            this.Race.Location = new System.Drawing.Point(117, 161);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(100, 20);
            this.Race.TabIndex = 15;
            // 
            // Completedbtn
            // 
            this.Completedbtn.Location = new System.Drawing.Point(254, 213);
            this.Completedbtn.Name = "Completedbtn";
            this.Completedbtn.Size = new System.Drawing.Size(75, 23);
            this.Completedbtn.TabIndex = 16;
            this.Completedbtn.Text = "Completed";
            this.Completedbtn.UseVisualStyleBackColor = true;
            this.Completedbtn.Click += new System.EventHandler(this.Completedbtn_Click);
            // 
            // CreatePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 248);
            this.Controls.Add(this.Completedbtn);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Passive);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.CharacterName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CharacterNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerName);
            this.Name = "CreatePlayerForm";
            this.Text = "CreatePlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.MaxHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MaxHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CharacterNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CharacterName;
        private System.Windows.Forms.TextBox Class;
        private System.Windows.Forms.NumericUpDown Passive;
        private System.Windows.Forms.NumericUpDown Level;
        private System.Windows.Forms.TextBox Race;
        private System.Windows.Forms.Button Completedbtn;
    }
}