namespace csNumberChecker
{
    partial class FormCheckers
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
            this.cbSepa = new System.Windows.Forms.CheckBox();
            this.cbWithSpaces = new System.Windows.Forms.CheckBox();
            this.lResult = new System.Windows.Forms.Label();
            this.tbBEBankAccount = new System.Windows.Forms.TextBox();
            this.bCheckBankBE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSepa
            // 
            this.cbSepa.AutoSize = true;
            this.cbSepa.Checked = true;
            this.cbSepa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSepa.Location = new System.Drawing.Point(144, 43);
            this.cbSepa.Name = "cbSepa";
            this.cbSepa.Size = new System.Drawing.Size(51, 17);
            this.cbSepa.TabIndex = 9;
            this.cbSepa.Text = "Sepa";
            this.cbSepa.UseVisualStyleBackColor = true;
            // 
            // cbWithSpaces
            // 
            this.cbWithSpaces.AutoSize = true;
            this.cbWithSpaces.Location = new System.Drawing.Point(12, 43);
            this.cbWithSpaces.Name = "cbWithSpaces";
            this.cbWithSpaces.Size = new System.Drawing.Size(117, 17);
            this.cbWithSpaces.TabIndex = 8;
            this.cbWithSpaces.Text = "Format with spaces";
            this.cbWithSpaces.UseVisualStyleBackColor = true;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(9, 84);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(19, 13);
            this.lResult.TabIndex = 7;
            this.lResult.Text = "dd";
            // 
            // tbBEBankAccount
            // 
            this.tbBEBankAccount.Location = new System.Drawing.Point(12, 12);
            this.tbBEBankAccount.Name = "tbBEBankAccount";
            this.tbBEBankAccount.Size = new System.Drawing.Size(249, 20);
            this.tbBEBankAccount.TabIndex = 6;
            // 
            // bCheckBankBE
            // 
            this.bCheckBankBE.Location = new System.Drawing.Point(267, 9);
            this.bCheckBankBE.Name = "bCheckBankBE";
            this.bCheckBankBE.Size = new System.Drawing.Size(162, 23);
            this.bCheckBankBE.TabIndex = 5;
            this.bCheckBankBE.Text = "BE Bank account validation";
            this.bCheckBankBE.UseVisualStyleBackColor = true;
            this.bCheckBankBE.Click += new System.EventHandler(this.bCheckBankBE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 111);
            this.Controls.Add(this.cbSepa);
            this.Controls.Add(this.cbWithSpaces);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbBEBankAccount);
            this.Controls.Add(this.bCheckBankBE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox cbSepa;
        internal System.Windows.Forms.CheckBox cbWithSpaces;
        internal System.Windows.Forms.Label lResult;
        internal System.Windows.Forms.TextBox tbBEBankAccount;
        internal System.Windows.Forms.Button bCheckBankBE;
    }
}

