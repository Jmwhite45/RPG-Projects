namespace RPG_character_sheet_randomizer
{
    public partial class RpgRndCharGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpgRndCharGen));
            this.btnRandomize = new System.Windows.Forms.Button();
            this.rbtnPathfinder = new System.Windows.Forms.RadioButton();
            this.rbtnDnD5e = new System.Windows.Forms.RadioButton();
            this.lbRace = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RaceOutput = new System.Windows.Forms.Label();
            this.ChaOutput = new System.Windows.Forms.Label();
            this.WisOutput = new System.Windows.Forms.Label();
            this.IntOutput = new System.Windows.Forms.Label();
            this.ConOutput = new System.Windows.Forms.Label();
            this.DexOutput = new System.Windows.Forms.Label();
            this.StrOutput = new System.Windows.Forms.Label();
            this.BackgroundOutput = new System.Windows.Forms.Label();
            this.ClassOutput = new System.Windows.Forms.Label();
            this.rbtn3D6 = new System.Windows.Forms.RadioButton();
            this.rbtn4D6 = new System.Windows.Forms.RadioButton();
            this.ErrorRepo = new System.Windows.Forms.Label();
            this.ErrorRepoText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ExpansionText = new System.Windows.Forms.Label();
            this.PathExpansions = new System.Windows.Forms.FlowLayoutPanel();
            this.PathACG = new System.Windows.Forms.CheckBox();
            this.PathAPG = new System.Windows.Forms.CheckBox();
            this.PathARG = new System.Windows.Forms.CheckBox();
            this.DnDExpansions = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckDnDVGtM = new System.Windows.Forms.CheckBox();
            this.CheckDnDtSCAG = new System.Windows.Forms.CheckBox();
            this.CheckDnDEE = new System.Windows.Forms.CheckBox();
            this.CheckDnDUA = new System.Windows.Forms.CheckBox();
            this.ClassImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TraitText = new System.Windows.Forms.Label();
            this.TraitOutput = new System.Windows.Forms.Label();
            this.BondOutput = new System.Windows.Forms.Label();
            this.IdealOutput = new System.Windows.Forms.Label();
            this.BondText = new System.Windows.Forms.Label();
            this.IdealText = new System.Windows.Forms.Label();
            this.FlawOutput = new System.Windows.Forms.Label();
            this.FlawText = new System.Windows.Forms.Label();
            this.DevVersion = new System.Windows.Forms.Label();
            this.ExitDev = new System.Windows.Forms.Button();
            this.BGRollOutput = new System.Windows.Forms.Label();
            this.DevClass = new System.Windows.Forms.Label();
            this.DevBackground = new System.Windows.Forms.Label();
            this.DevBackgroundNum = new System.Windows.Forms.NumericUpDown();
            this.btnLegal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.NumericUpDown();
            this.ClassPowers = new System.Windows.Forms.TextBox();
            this.HPoutput = new System.Windows.Forms.Label();
            this.GoldOutput = new System.Windows.Forms.Label();
            this.GoldText = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DevClassNum = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.PathExpansions.SuspendLayout();
            this.DnDExpansions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevBackgroundNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevClassNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandomize
            // 
            this.btnRandomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRandomize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRandomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnRandomize.Location = new System.Drawing.Point(12, 12);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(163, 94);
            this.btnRandomize.TabIndex = 0;
            this.btnRandomize.Text = "Randomize Character sheet";
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // rbtnPathfinder
            // 
            this.rbtnPathfinder.AutoSize = true;
            this.rbtnPathfinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnPathfinder.Location = new System.Drawing.Point(3, 33);
            this.rbtnPathfinder.Name = "rbtnPathfinder";
            this.rbtnPathfinder.Size = new System.Drawing.Size(110, 24);
            this.rbtnPathfinder.TabIndex = 1;
            this.rbtnPathfinder.Text = "Pathfinder";
            this.rbtnPathfinder.UseVisualStyleBackColor = true;
            this.rbtnPathfinder.CheckedChanged += new System.EventHandler(this.rbtnPathfinder_CheckedChanged);
            // 
            // rbtnDnD5e
            // 
            this.rbtnDnD5e.AutoSize = true;
            this.rbtnDnD5e.Checked = true;
            this.rbtnDnD5e.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnDnD5e.Location = new System.Drawing.Point(3, 3);
            this.rbtnDnD5e.Name = "rbtnDnD5e";
            this.rbtnDnD5e.Size = new System.Drawing.Size(88, 24);
            this.rbtnDnD5e.TabIndex = 2;
            this.rbtnDnD5e.TabStop = true;
            this.rbtnDnD5e.Text = "DnD 5e";
            this.rbtnDnD5e.UseVisualStyleBackColor = true;
            this.rbtnDnD5e.CheckedChanged += new System.EventHandler(this.rbtnDnD5e_CheckedChanged);
            // 
            // lbRace
            // 
            this.lbRace.AutoSize = true;
            this.lbRace.BackColor = System.Drawing.Color.Transparent;
            this.lbRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRace.Location = new System.Drawing.Point(17, 164);
            this.lbRace.Name = "lbRace";
            this.lbRace.Size = new System.Drawing.Size(56, 20);
            this.lbRace.TabIndex = 3;
            this.lbRace.Text = "Race:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Background:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Con:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dex:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Str:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Int:";
            // 
            // RaceOutput
            // 
            this.RaceOutput.AutoSize = true;
            this.RaceOutput.BackColor = System.Drawing.Color.Transparent;
            this.RaceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceOutput.Location = new System.Drawing.Point(79, 164);
            this.RaceOutput.Name = "RaceOutput";
            this.RaceOutput.Size = new System.Drawing.Size(19, 20);
            this.RaceOutput.TabIndex = 12;
            this.RaceOutput.Text = "  ";
            // 
            // ChaOutput
            // 
            this.ChaOutput.AutoSize = true;
            this.ChaOutput.BackColor = System.Drawing.Color.Transparent;
            this.ChaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaOutput.Location = new System.Drawing.Point(64, 369);
            this.ChaOutput.Name = "ChaOutput";
            this.ChaOutput.Size = new System.Drawing.Size(24, 20);
            this.ChaOutput.TabIndex = 13;
            this.ChaOutput.Text = "   ";
            // 
            // WisOutput
            // 
            this.WisOutput.AutoSize = true;
            this.WisOutput.BackColor = System.Drawing.Color.Transparent;
            this.WisOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisOutput.Location = new System.Drawing.Point(75, 340);
            this.WisOutput.Name = "WisOutput";
            this.WisOutput.Size = new System.Drawing.Size(19, 20);
            this.WisOutput.TabIndex = 14;
            this.WisOutput.Text = "  ";
            // 
            // IntOutput
            // 
            this.IntOutput.AutoSize = true;
            this.IntOutput.BackColor = System.Drawing.Color.Transparent;
            this.IntOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntOutput.Location = new System.Drawing.Point(69, 312);
            this.IntOutput.Name = "IntOutput";
            this.IntOutput.Size = new System.Drawing.Size(19, 20);
            this.IntOutput.TabIndex = 15;
            this.IntOutput.Text = "  ";
            // 
            // ConOutput
            // 
            this.ConOutput.AutoSize = true;
            this.ConOutput.BackColor = System.Drawing.Color.Transparent;
            this.ConOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConOutput.Location = new System.Drawing.Point(69, 281);
            this.ConOutput.Name = "ConOutput";
            this.ConOutput.Size = new System.Drawing.Size(19, 20);
            this.ConOutput.TabIndex = 16;
            this.ConOutput.Text = "  ";
            // 
            // DexOutput
            // 
            this.DexOutput.AutoSize = true;
            this.DexOutput.BackColor = System.Drawing.Color.Transparent;
            this.DexOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexOutput.Location = new System.Drawing.Point(69, 252);
            this.DexOutput.Name = "DexOutput";
            this.DexOutput.Size = new System.Drawing.Size(19, 20);
            this.DexOutput.TabIndex = 17;
            this.DexOutput.Text = "  ";
            // 
            // StrOutput
            // 
            this.StrOutput.AutoSize = true;
            this.StrOutput.BackColor = System.Drawing.Color.Transparent;
            this.StrOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrOutput.Location = new System.Drawing.Point(65, 224);
            this.StrOutput.Name = "StrOutput";
            this.StrOutput.Size = new System.Drawing.Size(14, 20);
            this.StrOutput.TabIndex = 18;
            this.StrOutput.Text = " ";
            // 
            // BackgroundOutput
            // 
            this.BackgroundOutput.AutoSize = true;
            this.BackgroundOutput.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundOutput.Location = new System.Drawing.Point(132, 109);
            this.BackgroundOutput.Name = "BackgroundOutput";
            this.BackgroundOutput.Size = new System.Drawing.Size(24, 20);
            this.BackgroundOutput.TabIndex = 19;
            this.BackgroundOutput.Text = "   ";
            // 
            // ClassOutput
            // 
            this.ClassOutput.AutoSize = true;
            this.ClassOutput.BackColor = System.Drawing.Color.Transparent;
            this.ClassOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassOutput.Location = new System.Drawing.Point(79, 193);
            this.ClassOutput.Name = "ClassOutput";
            this.ClassOutput.Size = new System.Drawing.Size(34, 20);
            this.ClassOutput.TabIndex = 20;
            this.ClassOutput.Text = "     ";
            // 
            // rbtn3D6
            // 
            this.rbtn3D6.AutoSize = true;
            this.rbtn3D6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbtn3D6.Location = new System.Drawing.Point(3, 33);
            this.rbtn3D6.Name = "rbtn3D6";
            this.rbtn3D6.Size = new System.Drawing.Size(60, 24);
            this.rbtn3D6.TabIndex = 1;
            this.rbtn3D6.Text = "3D6";
            this.rbtn3D6.UseVisualStyleBackColor = true;
            // 
            // rbtn4D6
            // 
            this.rbtn4D6.AutoSize = true;
            this.rbtn4D6.Checked = true;
            this.rbtn4D6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbtn4D6.Location = new System.Drawing.Point(3, 3);
            this.rbtn4D6.Name = "rbtn4D6";
            this.rbtn4D6.Size = new System.Drawing.Size(187, 24);
            this.rbtn4D6.TabIndex = 0;
            this.rbtn4D6.TabStop = true;
            this.rbtn4D6.Text = "4D6 subtract lowest";
            this.rbtn4D6.UseVisualStyleBackColor = true;
            // 
            // ErrorRepo
            // 
            this.ErrorRepo.AutoSize = true;
            this.ErrorRepo.BackColor = System.Drawing.Color.Transparent;
            this.ErrorRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ErrorRepo.ForeColor = System.Drawing.Color.Black;
            this.ErrorRepo.Location = new System.Drawing.Point(1223, 647);
            this.ErrorRepo.Name = "ErrorRepo";
            this.ErrorRepo.Size = new System.Drawing.Size(121, 17);
            this.ErrorRepo.TabIndex = 23;
            this.ErrorRepo.Text = "Error Reporting";
            this.ErrorRepo.Click += new System.EventHandler(this.ErrorRepo_Click);
            // 
            // ErrorRepoText
            // 
            this.ErrorRepoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ErrorRepoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorRepoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorRepoText.Location = new System.Drawing.Point(527, 167);
            this.ErrorRepoText.Multiline = true;
            this.ErrorRepoText.Name = "ErrorRepoText";
            this.ErrorRepoText.Size = new System.Drawing.Size(834, 440);
            this.ErrorRepoText.TabIndex = 24;
            this.ErrorRepoText.Text = resources.GetString("ErrorRepoText.Text");
            this.ErrorRepoText.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.rbtnDnD5e);
            this.flowLayoutPanel1.Controls.Add(this.rbtnPathfinder);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(181, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 69);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.rbtn4D6);
            this.flowLayoutPanel2.Controls.Add(this.rbtn3D6);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(300, 34);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(208, 62);
            this.flowLayoutPanel2.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Game";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(334, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Stats Roller Type";
            // 
            // ExpansionText
            // 
            this.ExpansionText.AutoSize = true;
            this.ExpansionText.BackColor = System.Drawing.Color.Transparent;
            this.ExpansionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpansionText.Location = new System.Drawing.Point(766, 9);
            this.ExpansionText.Name = "ExpansionText";
            this.ExpansionText.Size = new System.Drawing.Size(142, 20);
            this.ExpansionText.TabIndex = 31;
            this.ExpansionText.Text = "DnD Expansions";
            // 
            // PathExpansions
            // 
            this.PathExpansions.BackColor = System.Drawing.Color.Transparent;
            this.PathExpansions.Controls.Add(this.PathACG);
            this.PathExpansions.Controls.Add(this.PathAPG);
            this.PathExpansions.Controls.Add(this.PathARG);
            this.PathExpansions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PathExpansions.Location = new System.Drawing.Point(735, 44);
            this.PathExpansions.Name = "PathExpansions";
            this.PathExpansions.Size = new System.Drawing.Size(229, 97);
            this.PathExpansions.TabIndex = 28;
            this.PathExpansions.Visible = false;
            // 
            // PathACG
            // 
            this.PathACG.AutoSize = true;
            this.PathACG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathACG.Location = new System.Drawing.Point(3, 3);
            this.PathACG.Name = "PathACG";
            this.PathACG.Size = new System.Drawing.Size(209, 24);
            this.PathACG.TabIndex = 2;
            this.PathACG.Text = "Advanced Class Guide";
            this.PathACG.UseVisualStyleBackColor = true;
            // 
            // PathAPG
            // 
            this.PathAPG.AutoSize = true;
            this.PathAPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathAPG.Location = new System.Drawing.Point(3, 33);
            this.PathAPG.Name = "PathAPG";
            this.PathAPG.Size = new System.Drawing.Size(214, 24);
            this.PathAPG.TabIndex = 0;
            this.PathAPG.Text = "Advanced Player Guide";
            this.PathAPG.UseVisualStyleBackColor = true;
            // 
            // PathARG
            // 
            this.PathARG.AutoSize = true;
            this.PathARG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathARG.Location = new System.Drawing.Point(3, 63);
            this.PathARG.Name = "PathARG";
            this.PathARG.Size = new System.Drawing.Size(207, 24);
            this.PathARG.TabIndex = 3;
            this.PathARG.Text = "Advanced Race Guide";
            this.PathARG.UseVisualStyleBackColor = true;
            // 
            // DnDExpansions
            // 
            this.DnDExpansions.BackColor = System.Drawing.Color.Transparent;
            this.DnDExpansions.Controls.Add(this.CheckDnDVGtM);
            this.DnDExpansions.Controls.Add(this.CheckDnDtSCAG);
            this.DnDExpansions.Controls.Add(this.CheckDnDEE);
            this.DnDExpansions.Controls.Add(this.CheckDnDUA);
            this.DnDExpansions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DnDExpansions.Location = new System.Drawing.Point(734, 43);
            this.DnDExpansions.Name = "DnDExpansions";
            this.DnDExpansions.Size = new System.Drawing.Size(324, 127);
            this.DnDExpansions.TabIndex = 29;
            // 
            // CheckDnDVGtM
            // 
            this.CheckDnDVGtM.AutoSize = true;
            this.CheckDnDVGtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDnDVGtM.Location = new System.Drawing.Point(3, 3);
            this.CheckDnDVGtM.Name = "CheckDnDVGtM";
            this.CheckDnDVGtM.Size = new System.Drawing.Size(230, 24);
            this.CheckDnDVGtM.TabIndex = 0;
            this.CheckDnDVGtM.Text = "Volo\'s Guide to Monsters";
            this.CheckDnDVGtM.UseVisualStyleBackColor = true;
            // 
            // CheckDnDtSCAG
            // 
            this.CheckDnDtSCAG.AutoSize = true;
            this.CheckDnDtSCAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDnDtSCAG.Location = new System.Drawing.Point(3, 33);
            this.CheckDnDtSCAG.Name = "CheckDnDtSCAG";
            this.CheckDnDtSCAG.Size = new System.Drawing.Size(314, 24);
            this.CheckDnDtSCAG.TabIndex = 2;
            this.CheckDnDtSCAG.Text = "The Sword Coast Adventures Guide";
            this.CheckDnDtSCAG.UseVisualStyleBackColor = true;
            // 
            // CheckDnDEE
            // 
            this.CheckDnDEE.AutoSize = true;
            this.CheckDnDEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDnDEE.Location = new System.Drawing.Point(3, 63);
            this.CheckDnDEE.Name = "CheckDnDEE";
            this.CheckDnDEE.Size = new System.Drawing.Size(303, 24);
            this.CheckDnDEE.TabIndex = 3;
            this.CheckDnDEE.Text = "Elemental Evil Player\'s Companion";
            this.CheckDnDEE.UseVisualStyleBackColor = true;
            // 
            // CheckDnDUA
            // 
            this.CheckDnDUA.AutoSize = true;
            this.CheckDnDUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDnDUA.Location = new System.Drawing.Point(3, 93);
            this.CheckDnDUA.Name = "CheckDnDUA";
            this.CheckDnDUA.Size = new System.Drawing.Size(175, 24);
            this.CheckDnDUA.TabIndex = 4;
            this.CheckDnDUA.Text = "Unearthed Arcana";
            this.CheckDnDUA.UseVisualStyleBackColor = true;
            // 
            // ClassImage
            // 
            this.ClassImage.BackColor = System.Drawing.Color.Transparent;
            this.ClassImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClassImage.Location = new System.Drawing.Point(703, 164);
            this.ClassImage.Name = "ClassImage";
            this.ClassImage.Size = new System.Drawing.Size(293, 503);
            this.ClassImage.TabIndex = 32;
            this.ClassImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 647);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Version: 1.1.1";
            // 
            // TraitText
            // 
            this.TraitText.AutoSize = true;
            this.TraitText.BackColor = System.Drawing.Color.Transparent;
            this.TraitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraitText.Location = new System.Drawing.Point(132, 224);
            this.TraitText.Name = "TraitText";
            this.TraitText.Size = new System.Drawing.Size(50, 20);
            this.TraitText.TabIndex = 37;
            this.TraitText.Text = "Trait:";
            // 
            // TraitOutput
            // 
            this.TraitOutput.AutoSize = true;
            this.TraitOutput.BackColor = System.Drawing.Color.Transparent;
            this.TraitOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraitOutput.Location = new System.Drawing.Point(188, 224);
            this.TraitOutput.Name = "TraitOutput";
            this.TraitOutput.Size = new System.Drawing.Size(24, 20);
            this.TraitOutput.TabIndex = 39;
            this.TraitOutput.Text = "   ";
            // 
            // BondOutput
            // 
            this.BondOutput.AutoSize = true;
            this.BondOutput.BackColor = System.Drawing.Color.Transparent;
            this.BondOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BondOutput.Location = new System.Drawing.Point(193, 284);
            this.BondOutput.Name = "BondOutput";
            this.BondOutput.Size = new System.Drawing.Size(34, 20);
            this.BondOutput.TabIndex = 40;
            this.BondOutput.Text = "     ";
            // 
            // IdealOutput
            // 
            this.IdealOutput.AutoSize = true;
            this.IdealOutput.BackColor = System.Drawing.Color.Transparent;
            this.IdealOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdealOutput.Location = new System.Drawing.Point(193, 255);
            this.IdealOutput.Name = "IdealOutput";
            this.IdealOutput.Size = new System.Drawing.Size(19, 20);
            this.IdealOutput.TabIndex = 38;
            this.IdealOutput.Text = "  ";
            // 
            // BondText
            // 
            this.BondText.AutoSize = true;
            this.BondText.BackColor = System.Drawing.Color.Transparent;
            this.BondText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BondText.Location = new System.Drawing.Point(130, 284);
            this.BondText.Name = "BondText";
            this.BondText.Size = new System.Drawing.Size(61, 20);
            this.BondText.TabIndex = 36;
            this.BondText.Text = "Bond: ";
            // 
            // IdealText
            // 
            this.IdealText.AutoSize = true;
            this.IdealText.BackColor = System.Drawing.Color.Transparent;
            this.IdealText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdealText.Location = new System.Drawing.Point(131, 255);
            this.IdealText.Name = "IdealText";
            this.IdealText.Size = new System.Drawing.Size(54, 20);
            this.IdealText.TabIndex = 35;
            this.IdealText.Text = "Ideal:";
            // 
            // FlawOutput
            // 
            this.FlawOutput.AutoSize = true;
            this.FlawOutput.BackColor = System.Drawing.Color.Transparent;
            this.FlawOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlawOutput.Location = new System.Drawing.Point(194, 313);
            this.FlawOutput.Name = "FlawOutput";
            this.FlawOutput.Size = new System.Drawing.Size(34, 20);
            this.FlawOutput.TabIndex = 42;
            this.FlawOutput.Text = "     ";
            // 
            // FlawText
            // 
            this.FlawText.AutoSize = true;
            this.FlawText.BackColor = System.Drawing.Color.Transparent;
            this.FlawText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlawText.Location = new System.Drawing.Point(131, 313);
            this.FlawText.Name = "FlawText";
            this.FlawText.Size = new System.Drawing.Size(51, 20);
            this.FlawText.TabIndex = 41;
            this.FlawText.Text = "Flaw:";
            // 
            // DevVersion
            // 
            this.DevVersion.AutoSize = true;
            this.DevVersion.BackColor = System.Drawing.Color.Transparent;
            this.DevVersion.Location = new System.Drawing.Point(131, 649);
            this.DevVersion.Name = "DevVersion";
            this.DevVersion.Size = new System.Drawing.Size(10, 13);
            this.DevVersion.TabIndex = 43;
            this.DevVersion.Text = " ";
            this.DevVersion.Click += new System.EventHandler(this.DevVersion_Click);
            // 
            // ExitDev
            // 
            this.ExitDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitDev.Location = new System.Drawing.Point(265, 597);
            this.ExitDev.Name = "ExitDev";
            this.ExitDev.Size = new System.Drawing.Size(152, 33);
            this.ExitDev.TabIndex = 44;
            this.ExitDev.Text = "Exit Dev Mode";
            this.ExitDev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitDev.UseVisualStyleBackColor = false;
            this.ExitDev.Visible = false;
            this.ExitDev.Click += new System.EventHandler(this.ExitDev_Click);
            // 
            // BGRollOutput
            // 
            this.BGRollOutput.AutoSize = true;
            this.BGRollOutput.BackColor = System.Drawing.Color.Transparent;
            this.BGRollOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGRollOutput.Location = new System.Drawing.Point(18, 137);
            this.BGRollOutput.Name = "BGRollOutput";
            this.BGRollOutput.Size = new System.Drawing.Size(24, 20);
            this.BGRollOutput.TabIndex = 46;
            this.BGRollOutput.Text = "   ";
            // 
            // DevClass
            // 
            this.DevClass.AutoSize = true;
            this.DevClass.BackColor = System.Drawing.Color.Transparent;
            this.DevClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevClass.ForeColor = System.Drawing.Color.Black;
            this.DevClass.Location = new System.Drawing.Point(18, 606);
            this.DevClass.Name = "DevClass";
            this.DevClass.Size = new System.Drawing.Size(58, 20);
            this.DevClass.TabIndex = 47;
            this.DevClass.Text = "Class:";
            this.DevClass.Visible = false;
            // 
            // DevBackground
            // 
            this.DevBackground.AutoSize = true;
            this.DevBackground.BackColor = System.Drawing.Color.Transparent;
            this.DevBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevBackground.ForeColor = System.Drawing.Color.Black;
            this.DevBackground.Location = new System.Drawing.Point(14, 577);
            this.DevBackground.Name = "DevBackground";
            this.DevBackground.Size = new System.Drawing.Size(105, 20);
            this.DevBackground.TabIndex = 48;
            this.DevBackground.Text = "Background";
            this.DevBackground.Visible = false;
            // 
            // DevBackgroundNum
            // 
            this.DevBackgroundNum.Location = new System.Drawing.Point(136, 577);
            this.DevBackgroundNum.Name = "DevBackgroundNum";
            this.DevBackgroundNum.Size = new System.Drawing.Size(120, 20);
            this.DevBackgroundNum.TabIndex = 49;
            this.DevBackgroundNum.Visible = false;
            // 
            // btnLegal
            // 
            this.btnLegal.AutoSize = true;
            this.btnLegal.BackColor = System.Drawing.Color.Transparent;
            this.btnLegal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnLegal.ForeColor = System.Drawing.Color.Black;
            this.btnLegal.Location = new System.Drawing.Point(1132, 647);
            this.btnLegal.Name = "btnLegal";
            this.btnLegal.Size = new System.Drawing.Size(85, 17);
            this.btnLegal.TabIndex = 50;
            this.btnLegal.Text = "Legal stuff";
            this.btnLegal.Click += new System.EventHandler(this.btnLegal_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(523, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Level";
            // 
            // Level
            // 
            this.Level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(527, 34);
            this.Level.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(47, 26);
            this.Level.TabIndex = 52;
            this.Level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClassPowers
            // 
            this.ClassPowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClassPowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassPowers.Location = new System.Drawing.Point(252, 221);
            this.ClassPowers.Multiline = true;
            this.ClassPowers.Name = "ClassPowers";
            this.ClassPowers.ReadOnly = true;
            this.ClassPowers.Size = new System.Drawing.Size(392, 350);
            this.ClassPowers.TabIndex = 53;
            this.ClassPowers.Text = "Class Powers:";
            // 
            // HPoutput
            // 
            this.HPoutput.AutoSize = true;
            this.HPoutput.BackColor = System.Drawing.Color.Transparent;
            this.HPoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPoutput.Location = new System.Drawing.Point(75, 415);
            this.HPoutput.Name = "HPoutput";
            this.HPoutput.Size = new System.Drawing.Size(19, 20);
            this.HPoutput.TabIndex = 57;
            this.HPoutput.Text = "  ";
            // 
            // GoldOutput
            // 
            this.GoldOutput.AutoSize = true;
            this.GoldOutput.BackColor = System.Drawing.Color.Transparent;
            this.GoldOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldOutput.Location = new System.Drawing.Point(64, 444);
            this.GoldOutput.Name = "GoldOutput";
            this.GoldOutput.Size = new System.Drawing.Size(24, 20);
            this.GoldOutput.TabIndex = 56;
            this.GoldOutput.Text = "   ";
            // 
            // GoldText
            // 
            this.GoldText.AutoSize = true;
            this.GoldText.BackColor = System.Drawing.Color.Transparent;
            this.GoldText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldText.Location = new System.Drawing.Point(18, 444);
            this.GoldText.Name = "GoldText";
            this.GoldText.Size = new System.Drawing.Size(52, 20);
            this.GoldText.TabIndex = 55;
            this.GoldText.Text = "Gold:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 415);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 20);
            this.label16.TabIndex = 54;
            this.label16.Text = "HP:";
            // 
            // DevClassNum
            // 
            this.DevClassNum.Location = new System.Drawing.Point(136, 609);
            this.DevClassNum.Name = "DevClassNum";
            this.DevClassNum.Size = new System.Drawing.Size(120, 20);
            this.DevClassNum.TabIndex = 34;
            this.DevClassNum.Visible = false;
            // 
            // RpgRndCharGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 676);
            this.Controls.Add(this.DnDExpansions);
            this.Controls.Add(this.HPoutput);
            this.Controls.Add(this.GoldOutput);
            this.Controls.Add(this.GoldText);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ErrorRepoText);
            this.Controls.Add(this.ClassPowers);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLegal);
            this.Controls.Add(this.DevBackgroundNum);
            this.Controls.Add(this.DevBackground);
            this.Controls.Add(this.DevClass);
            this.Controls.Add(this.BGRollOutput);
            this.Controls.Add(this.ExitDev);
            this.Controls.Add(this.FlawOutput);
            this.Controls.Add(this.FlawText);
            this.Controls.Add(this.TraitText);
            this.Controls.Add(this.TraitOutput);
            this.Controls.Add(this.BondOutput);
            this.Controls.Add(this.IdealOutput);
            this.Controls.Add(this.BondText);
            this.Controls.Add(this.IdealText);
            this.Controls.Add(this.DevClassNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExpansionText);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ErrorRepo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackgroundOutput);
            this.Controls.Add(this.ClassOutput);
            this.Controls.Add(this.StrOutput);
            this.Controls.Add(this.DexOutput);
            this.Controls.Add(this.ConOutput);
            this.Controls.Add(this.IntOutput);
            this.Controls.Add(this.WisOutput);
            this.Controls.Add(this.ChaOutput);
            this.Controls.Add(this.RaceOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRace);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.PathExpansions);
            this.Controls.Add(this.ClassImage);
            this.Controls.Add(this.DevVersion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RpgRndCharGen";
            this.Text = "Random Izer";
            this.Load += new System.EventHandler(this.RpgRndCharGen_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.PathExpansions.ResumeLayout(false);
            this.PathExpansions.PerformLayout();
            this.DnDExpansions.ResumeLayout(false);
            this.DnDExpansions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevBackgroundNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevClassNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Label lbRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ErrorRepo;
        private System.Windows.Forms.TextBox ErrorRepoText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ExpansionText;
        private System.Windows.Forms.FlowLayoutPanel PathExpansions;
        public System.Windows.Forms.CheckBox PathACG;
        private System.Windows.Forms.FlowLayoutPanel DnDExpansions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TraitText;
        private System.Windows.Forms.Label BondText;
        private System.Windows.Forms.Label IdealText;
        private System.Windows.Forms.Label FlawText;
        private System.Windows.Forms.Label DevVersion;
        private System.Windows.Forms.Button ExitDev;
        private System.Windows.Forms.Label DevClass;
        private System.Windows.Forms.Label DevBackground;
        private System.Windows.Forms.Label btnLegal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown Level;
        private System.Windows.Forms.Label GoldText;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.CheckBox PathAPG;
        public System.Windows.Forms.CheckBox CheckDnDVGtM;
        public System.Windows.Forms.CheckBox PathARG;
        public System.Windows.Forms.RadioButton rbtnPathfinder;
        public System.Windows.Forms.RadioButton rbtnDnD5e;
        public System.Windows.Forms.RadioButton rbtn4D6;
        public System.Windows.Forms.RadioButton rbtn3D6;
        public System.Windows.Forms.CheckBox CheckDnDtSCAG;
        public System.Windows.Forms.CheckBox CheckDnDEE;
        public System.Windows.Forms.CheckBox CheckDnDUA;
        public System.Windows.Forms.NumericUpDown DevBackgroundNum;
        public System.Windows.Forms.PictureBox ClassImage;
        public System.Windows.Forms.Label BackgroundOutput;
        public System.Windows.Forms.Label ClassOutput;
        public System.Windows.Forms.TextBox ClassPowers;
        public System.Windows.Forms.Label RaceOutput;
        public System.Windows.Forms.Label ChaOutput;
        public System.Windows.Forms.Label WisOutput;
        public System.Windows.Forms.Label IntOutput;
        public System.Windows.Forms.Label ConOutput;
        public System.Windows.Forms.Label DexOutput;
        public System.Windows.Forms.Label StrOutput;
        public System.Windows.Forms.Label TraitOutput;
        public System.Windows.Forms.Label BondOutput;
        public System.Windows.Forms.Label IdealOutput;
        public System.Windows.Forms.Label FlawOutput;
        public System.Windows.Forms.Label HPoutput;
        public System.Windows.Forms.Label GoldOutput;
        public System.Windows.Forms.Label BGRollOutput;
        public System.Windows.Forms.NumericUpDown DevClassNum;
    }
}

