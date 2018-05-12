namespace RPGBattleTracker
{
    partial class DamageForm
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
            this.Addbtn = new System.Windows.Forms.Button();
            this.Damageslb = new System.Windows.Forms.ListBox();
            this.AmountBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.Completebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(143, 101);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Damageslb
            // 
            this.Damageslb.FormattingEnabled = true;
            this.Damageslb.Location = new System.Drawing.Point(16, 71);
            this.Damageslb.Name = "Damageslb";
            this.Damageslb.Size = new System.Drawing.Size(100, 134);
            this.Damageslb.TabIndex = 1;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(16, 45);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 20);
            this.AmountBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Damage";
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Acid",
            "BLudgeoning",
            "Cold",
            "Fire",
            "Force",
            "Lighting",
            "Necrotic",
            "Piercing",
            "Pioson",
            "Psychic",
            "Radiant",
            "Slashing",
            "Thunder"});
            this.TypeBox.Location = new System.Drawing.Point(122, 45);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 12;
            this.TypeBox.Text = "Damage Type";
            // 
            // Completebtn
            // 
            this.Completebtn.Location = new System.Drawing.Point(143, 130);
            this.Completebtn.Name = "Completebtn";
            this.Completebtn.Size = new System.Drawing.Size(75, 23);
            this.Completebtn.TabIndex = 13;
            this.Completebtn.Text = "Complete";
            this.Completebtn.UseVisualStyleBackColor = true;
            this.Completebtn.Click += new System.EventHandler(this.Completebtn_Click);
            // 
            // DamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.Completebtn);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.Damageslb);
            this.Controls.Add(this.Addbtn);
            this.Name = "DamageForm";
            this.Text = "DamageFrom";
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ListBox Damageslb;
        private System.Windows.Forms.NumericUpDown AmountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Button Completebtn;
    }
}