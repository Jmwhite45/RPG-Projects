namespace RPGBattleTracker
{
    partial class Player_Initative_Form
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
            this.InitOrderlb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.initValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.initValue)).BeginInit();
            this.SuspendLayout();
            // 
            // InitOrderlb
            // 
            this.InitOrderlb.FormattingEnabled = true;
            this.InitOrderlb.Location = new System.Drawing.Point(12, 32);
            this.InitOrderlb.Name = "InitOrderlb";
            this.InitOrderlb.Size = new System.Drawing.Size(140, 225);
            this.InitOrderlb.TabIndex = 2;
            this.InitOrderlb.SelectedValueChanged += new System.EventHandler(this.InitOrderlb_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players";
            // 
            // initValue
            // 
            this.initValue.Location = new System.Drawing.Point(189, 48);
            this.initValue.Name = "initValue";
            this.initValue.Size = new System.Drawing.Size(83, 20);
            this.initValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Initative";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Player_Initative_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InitOrderlb);
            this.Name = "Player_Initative_Form";
            this.Text = "Player_Initative_Form";
            ((System.ComponentModel.ISupportInitialize)(this.initValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InitOrderlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown initValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}