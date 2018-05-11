namespace RPG_character_sheet_randomizer
{
    partial class ErrorReportingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorReportingForm));
            this.Reportbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorType = new System.Windows.Forms.ComboBox();
            this.ExitError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reportbtn
            // 
            this.Reportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Reportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportbtn.Location = new System.Drawing.Point(16, 452);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Size = new System.Drawing.Size(152, 33);
            this.Reportbtn.TabIndex = 46;
            this.Reportbtn.Text = "Report Error";
            this.Reportbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportbtn.UseVisualStyleBackColor = false;
            this.Reportbtn.Visible = false;
            this.Reportbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Please explain your issue(more details the better)";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Location = new System.Drawing.Point(16, 71);
            this.ErrorMessage.Multiline = true;
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(433, 287);
            this.ErrorMessage.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Name of the Save file";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(127, 364);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 20);
            this.FileName.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 117);
            this.label3.TabIndex = 51;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // ErrorType
            // 
            this.ErrorType.FormattingEnabled = true;
            this.ErrorType.Items.AddRange(new object[] {
            "System Crash/Failer",
            "Incorrect Rules ",
            "Spelling Error",
            "Other"});
            this.ErrorType.Location = new System.Drawing.Point(273, 43);
            this.ErrorType.Name = "ErrorType";
            this.ErrorType.Size = new System.Drawing.Size(121, 21);
            this.ErrorType.TabIndex = 53;
            this.ErrorType.Text = "Please Select One";
            this.ErrorType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ExitError
            // 
            this.ExitError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitError.Location = new System.Drawing.Point(198, 452);
            this.ExitError.Name = "ExitError";
            this.ExitError.Size = new System.Drawing.Size(251, 33);
            this.ExitError.TabIndex = 54;
            this.ExitError.Text = "EXIT ERROR REPORTING";
            this.ExitError.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitError.UseVisualStyleBackColor = false;
            this.ExitError.Visible = false;
            // 
            // ErrorReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 497);
            this.Controls.Add(this.ExitError);
            this.Controls.Add(this.ErrorType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reportbtn);
            this.Name = "ErrorReportingForm";
            this.Text = "ErrorReportingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reportbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ErrorMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ErrorType;
        private System.Windows.Forms.Button ExitError;
    }
}