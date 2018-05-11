namespace RPGBattleTracker
{
    partial class CreateNPCForm
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
            this.Type = new System.Windows.Forms.TextBox();
            this.CR = new System.Windows.Forms.NumericUpDown();
            this.InitMod = new System.Windows.Forms.NumericUpDown();
            this.Size = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NPCNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxHP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NPCName = new System.Windows.Forms.TextBox();
            this.Completedbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOf = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOf)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(116, 127);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 20);
            this.Type.TabIndex = 32;
            // 
            // CR
            // 
            this.CR.Location = new System.Drawing.Point(116, 157);
            this.CR.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(80, 20);
            this.CR.TabIndex = 31;
            // 
            // InitMod
            // 
            this.InitMod.Location = new System.Drawing.Point(116, 65);
            this.InitMod.Name = "InitMod";
            this.InitMod.Size = new System.Drawing.Size(80, 20);
            this.InitMod.TabIndex = 30;
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(116, 92);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(100, 20);
            this.Size.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "CR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "NPC Notes";
            // 
            // NPCNotes
            // 
            this.NPCNotes.Location = new System.Drawing.Point(253, 33);
            this.NPCNotes.Multiline = true;
            this.NPCNotes.Name = "NPCNotes";
            this.NPCNotes.Size = new System.Drawing.Size(233, 166);
            this.NPCNotes.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Max HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type";
            // 
            // MaxHP
            // 
            this.MaxHP.Location = new System.Drawing.Point(116, 34);
            this.MaxHP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxHP.Name = "MaxHP";
            this.MaxHP.Size = new System.Drawing.Size(80, 20);
            this.MaxHP.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "NPC Name";
            // 
            // NPCName
            // 
            this.NPCName.Location = new System.Drawing.Point(116, 6);
            this.NPCName.Name = "NPCName";
            this.NPCName.Size = new System.Drawing.Size(100, 20);
            this.NPCName.TabIndex = 17;
            // 
            // Completedbtn
            // 
            this.Completedbtn.Location = new System.Drawing.Point(253, 209);
            this.Completedbtn.Name = "Completedbtn";
            this.Completedbtn.Size = new System.Drawing.Size(75, 23);
            this.Completedbtn.TabIndex = 33;
            this.Completedbtn.Text = "Completed";
            this.Completedbtn.UseVisualStyleBackColor = true;
            this.Completedbtn.Click += new System.EventHandler(this.Completedbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Initative Modifer";
            // 
            // NumberOf
            // 
            this.NumberOf.Location = new System.Drawing.Point(116, 192);
            this.NumberOf.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberOf.Name = "NumberOf";
            this.NumberOf.Size = new System.Drawing.Size(80, 20);
            this.NumberOf.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Number of";
            // 
            // CreateNPCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 237);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberOf);
            this.Controls.Add(this.Completedbtn);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.CR);
            this.Controls.Add(this.InitMod);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NPCNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NPCName);
            this.Name = "CreateNPCForm";
            this.Text = "CreateNPCForm";
            ((System.ComponentModel.ISupportInitialize)(this.CR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.NumericUpDown CR;
        private System.Windows.Forms.NumericUpDown InitMod;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NPCNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NPCName;
        private System.Windows.Forms.Button Completedbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumberOf;
        private System.Windows.Forms.Label label6;
    }
}