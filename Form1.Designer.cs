namespace Field.P6._CSharp
{
    partial class Form1
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
            this.tabWelcome = new System.Windows.Forms.TabControl();
            this.ta = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lbToThe = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.txtbWelcome = new System.Windows.Forms.TextBox();
            this.tabDep = new System.Windows.Forms.TabPage();
            this.btnAccountUpdate = new System.Windows.Forms.Button();
            this.txtbInterest = new System.Windows.Forms.TextBox();
            this.txtbAtmPin = new System.Windows.Forms.TextBox();
            this.txtbAtmNum = new System.Windows.Forms.TextBox();
            this.txtbAcctNum = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.cmbxAcctType = new System.Windows.Forms.ComboBox();
            this.lbInterest = new System.Windows.Forms.Label();
            this.lbAtmNum = new System.Windows.Forms.Label();
            this.lbATMAcctNum = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAcctNum = new System.Windows.Forms.Label();
            this.lbAcctType = new System.Windows.Forms.Label();
            this.tabDepositWithdrawl = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstbxTransactions = new System.Windows.Forms.ListBox();
            this.txtbResults = new System.Windows.Forms.TextBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.rdbtnWithdraw = new System.Windows.Forms.RadioButton();
            this.rdbtnDeposit = new System.Windows.Forms.RadioButton();
            this.txtbAmount = new System.Windows.Forms.TextBox();
            this.lbResults = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tabWelcome.SuspendLayout();
            this.ta.SuspendLayout();
            this.tabDep.SuspendLayout();
            this.tabDepositWithdrawl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.ta);
            this.tabWelcome.Controls.Add(this.tabDep);
            this.tabWelcome.Controls.Add(this.tabDepositWithdrawl);
            this.tabWelcome.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabWelcome.Location = new System.Drawing.Point(23, 17);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.SelectedIndex = 0;
            this.tabWelcome.Size = new System.Drawing.Size(625, 473);
            this.tabWelcome.TabIndex = 0;
            // 
            // ta
            // 
            this.ta.BackColor = System.Drawing.Color.Thistle;
            this.ta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ta.Controls.Add(this.label3);
            this.ta.Controls.Add(this.lbToThe);
            this.ta.Controls.Add(this.lbWelcome);
            this.ta.Controls.Add(this.txtbWelcome);
            this.ta.Location = new System.Drawing.Point(4, 28);
            this.ta.Name = "ta";
            this.ta.Padding = new System.Windows.Forms.Padding(3);
            this.ta.Size = new System.Drawing.Size(617, 441);
            this.ta.TabIndex = 0;
            this.ta.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(79, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 59);
            this.label3.TabIndex = 3;
            this.label3.Text = "C++ Banking Center";
            // 
            // lbToThe
            // 
            this.lbToThe.AutoSize = true;
            this.lbToThe.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbToThe.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToThe.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbToThe.Location = new System.Drawing.Point(278, 117);
            this.lbToThe.Name = "lbToThe";
            this.lbToThe.Size = new System.Drawing.Size(57, 23);
            this.lbToThe.TabIndex = 2;
            this.lbToThe.Text = "to the";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbWelcome.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbWelcome.Location = new System.Drawing.Point(244, 68);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(124, 32);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "Welcome";
            // 
            // txtbWelcome
            // 
            this.txtbWelcome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbWelcome.Location = new System.Drawing.Point(27, 23);
            this.txtbWelcome.Multiline = true;
            this.txtbWelcome.Name = "txtbWelcome";
            this.txtbWelcome.Size = new System.Drawing.Size(558, 391);
            this.txtbWelcome.TabIndex = 0;
            // 
            // tabDep
            // 
            this.tabDep.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabDep.Controls.Add(this.btnAccountUpdate);
            this.tabDep.Controls.Add(this.txtbInterest);
            this.tabDep.Controls.Add(this.txtbAtmPin);
            this.tabDep.Controls.Add(this.txtbAtmNum);
            this.tabDep.Controls.Add(this.txtbAcctNum);
            this.tabDep.Controls.Add(this.name);
            this.tabDep.Controls.Add(this.cmbxAcctType);
            this.tabDep.Controls.Add(this.lbInterest);
            this.tabDep.Controls.Add(this.lbAtmNum);
            this.tabDep.Controls.Add(this.lbATMAcctNum);
            this.tabDep.Controls.Add(this.lbName);
            this.tabDep.Controls.Add(this.lbAcctNum);
            this.tabDep.Controls.Add(this.lbAcctType);
            this.tabDep.Location = new System.Drawing.Point(4, 28);
            this.tabDep.Name = "tabDep";
            this.tabDep.Padding = new System.Windows.Forms.Padding(3);
            this.tabDep.Size = new System.Drawing.Size(617, 441);
            this.tabDep.TabIndex = 1;
            this.tabDep.Text = "Account";
            // 
            // btnAccountUpdate
            // 
            this.btnAccountUpdate.BackColor = System.Drawing.Color.Thistle;
            this.btnAccountUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAccountUpdate.FlatAppearance.BorderSize = 10;
            this.btnAccountUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccountUpdate.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountUpdate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAccountUpdate.Location = new System.Drawing.Point(452, 314);
            this.btnAccountUpdate.Name = "btnAccountUpdate";
            this.btnAccountUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnAccountUpdate.TabIndex = 12;
            this.btnAccountUpdate.Text = "Update";
            this.btnAccountUpdate.UseVisualStyleBackColor = false;
            this.btnAccountUpdate.Click += new System.EventHandler(this.btnAccountUpdate_Click);
            // 
            // txtbInterest
            // 
            this.txtbInterest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbInterest.Location = new System.Drawing.Point(266, 232);
            this.txtbInterest.Name = "txtbInterest";
            this.txtbInterest.Size = new System.Drawing.Size(141, 26);
            this.txtbInterest.TabIndex = 11;
            // 
            // txtbAtmPin
            // 
            this.txtbAtmPin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbAtmPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbAtmPin.Location = new System.Drawing.Point(266, 191);
            this.txtbAtmPin.Name = "txtbAtmPin";
            this.txtbAtmPin.Size = new System.Drawing.Size(141, 26);
            this.txtbAtmPin.TabIndex = 10;
            // 
            // txtbAtmNum
            // 
            this.txtbAtmNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbAtmNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbAtmNum.Location = new System.Drawing.Point(266, 150);
            this.txtbAtmNum.Name = "txtbAtmNum";
            this.txtbAtmNum.Size = new System.Drawing.Size(141, 26);
            this.txtbAtmNum.TabIndex = 9;
            // 
            // txtbAcctNum
            // 
            this.txtbAcctNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbAcctNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbAcctNum.Location = new System.Drawing.Point(266, 109);
            this.txtbAcctNum.Name = "txtbAcctNum";
            this.txtbAcctNum.Size = new System.Drawing.Size(141, 26);
            this.txtbAcctNum.TabIndex = 8;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(266, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(141, 26);
            this.name.TabIndex = 7;
            // 
            // cmbxAcctType
            // 
            this.cmbxAcctType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbxAcctType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbxAcctType.FormattingEnabled = true;
            this.cmbxAcctType.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Bank"});
            this.cmbxAcctType.Location = new System.Drawing.Point(266, 26);
            this.cmbxAcctType.Name = "cmbxAcctType";
            this.cmbxAcctType.Size = new System.Drawing.Size(141, 27);
            this.cmbxAcctType.TabIndex = 6;
            this.cmbxAcctType.Text = "Gold";
            // 
            // lbInterest
            // 
            this.lbInterest.AutoSize = true;
            this.lbInterest.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbInterest.Location = new System.Drawing.Point(44, 234);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(113, 19);
            this.lbInterest.TabIndex = 5;
            this.lbInterest.Text = "Interest Earned";
            // 
            // lbAtmNum
            // 
            this.lbAtmNum.AutoSize = true;
            this.lbAtmNum.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtmNum.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbAtmNum.Location = new System.Drawing.Point(44, 194);
            this.lbAtmNum.Name = "lbAtmNum";
            this.lbAtmNum.Size = new System.Drawing.Size(76, 18);
            this.lbAtmNum.TabIndex = 4;
            this.lbAtmNum.Text = "ATM PIN";
            // 
            // lbATMAcctNum
            // 
            this.lbATMAcctNum.AutoSize = true;
            this.lbATMAcctNum.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbATMAcctNum.Location = new System.Drawing.Point(44, 154);
            this.lbATMAcctNum.Name = "lbATMAcctNum";
            this.lbATMAcctNum.Size = new System.Drawing.Size(110, 19);
            this.lbATMAcctNum.TabIndex = 3;
            this.lbATMAcctNum.Text = "ATM Number";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbName.Location = new System.Drawing.Point(44, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(50, 19);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbAcctNum
            // 
            this.lbAcctNum.AutoSize = true;
            this.lbAcctNum.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbAcctNum.Location = new System.Drawing.Point(44, 114);
            this.lbAcctNum.Name = "lbAcctNum";
            this.lbAcctNum.Size = new System.Drawing.Size(128, 19);
            this.lbAcctNum.TabIndex = 1;
            this.lbAcctNum.Text = "Account Number";
            // 
            // lbAcctType
            // 
            this.lbAcctType.AutoSize = true;
            this.lbAcctType.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbAcctType.Location = new System.Drawing.Point(44, 34);
            this.lbAcctType.Name = "lbAcctType";
            this.lbAcctType.Size = new System.Drawing.Size(106, 19);
            this.lbAcctType.TabIndex = 0;
            this.lbAcctType.Text = "Account Type";
            // 
            // tabDepositWithdrawl
            // 
            this.tabDepositWithdrawl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabDepositWithdrawl.Controls.Add(this.btnClear);
            this.tabDepositWithdrawl.Controls.Add(this.lstbxTransactions);
            this.tabDepositWithdrawl.Controls.Add(this.txtbResults);
            this.tabDepositWithdrawl.Controls.Add(this.btnTransaction);
            this.tabDepositWithdrawl.Controls.Add(this.rdbtnWithdraw);
            this.tabDepositWithdrawl.Controls.Add(this.rdbtnDeposit);
            this.tabDepositWithdrawl.Controls.Add(this.txtbAmount);
            this.tabDepositWithdrawl.Controls.Add(this.lbResults);
            this.tabDepositWithdrawl.Controls.Add(this.lbAmount);
            this.tabDepositWithdrawl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabDepositWithdrawl.Location = new System.Drawing.Point(4, 28);
            this.tabDepositWithdrawl.Name = "tabDepositWithdrawl";
            this.tabDepositWithdrawl.Size = new System.Drawing.Size(617, 441);
            this.tabDepositWithdrawl.TabIndex = 2;
            this.tabDepositWithdrawl.Text = "Deposit /Withdrawl";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(189, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstbxTransactions
            // 
            this.lstbxTransactions.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstbxTransactions.FormattingEnabled = true;
            this.lstbxTransactions.ItemHeight = 19;
            this.lstbxTransactions.Location = new System.Drawing.Point(381, 46);
            this.lstbxTransactions.Name = "lstbxTransactions";
            this.lstbxTransactions.Size = new System.Drawing.Size(220, 365);
            this.lstbxTransactions.TabIndex = 7;
            // 
            // txtbResults
            // 
            this.txtbResults.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbResults.Location = new System.Drawing.Point(119, 234);
            this.txtbResults.Multiline = true;
            this.txtbResults.Name = "txtbResults";
            this.txtbResults.Size = new System.Drawing.Size(224, 177);
            this.txtbResults.TabIndex = 6;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Thistle;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransaction.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTransaction.Location = new System.Drawing.Point(119, 184);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(224, 34);
            this.btnTransaction.TabIndex = 5;
            this.btnTransaction.Text = "Process Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // rdbtnWithdraw
            // 
            this.rdbtnWithdraw.AutoSize = true;
            this.rdbtnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbtnWithdraw.Location = new System.Drawing.Point(248, 89);
            this.rdbtnWithdraw.Name = "rdbtnWithdraw";
            this.rdbtnWithdraw.Size = new System.Drawing.Size(95, 23);
            this.rdbtnWithdraw.TabIndex = 4;
            this.rdbtnWithdraw.TabStop = true;
            this.rdbtnWithdraw.Text = "Withdraw";
            this.rdbtnWithdraw.UseVisualStyleBackColor = true;
            // 
            // rdbtnDeposit
            // 
            this.rdbtnDeposit.AutoSize = true;
            this.rdbtnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbtnDeposit.Location = new System.Drawing.Point(119, 89);
            this.rdbtnDeposit.Name = "rdbtnDeposit";
            this.rdbtnDeposit.Size = new System.Drawing.Size(79, 23);
            this.rdbtnDeposit.TabIndex = 3;
            this.rdbtnDeposit.TabStop = true;
            this.rdbtnDeposit.Text = "Deposit";
            this.rdbtnDeposit.UseVisualStyleBackColor = true;
            // 
            // txtbAmount
            // 
            this.txtbAmount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbAmount.Location = new System.Drawing.Point(119, 46);
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(224, 26);
            this.txtbAmount.TabIndex = 2;
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.Location = new System.Drawing.Point(22, 234);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(70, 23);
            this.lbResults.TabIndex = 1;
            this.lbResults.Text = "Results";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(22, 46);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(79, 23);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(674, 514);
            this.Controls.Add(this.tabWelcome);
            this.Name = "Form1";
            this.Text = "Alix Field     afield@cnm.edu     Field.P6._CSharp";
            this.tabWelcome.ResumeLayout(false);
            this.ta.ResumeLayout(false);
            this.ta.PerformLayout();
            this.tabDep.ResumeLayout(false);
            this.tabDep.PerformLayout();
            this.tabDepositWithdrawl.ResumeLayout(false);
            this.tabDepositWithdrawl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabWelcome;
        private System.Windows.Forms.TabPage ta;
        private System.Windows.Forms.TabPage tabDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbToThe;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.TextBox txtbWelcome;
        private System.Windows.Forms.TabPage tabDepositWithdrawl;
        private System.Windows.Forms.TextBox txtbInterest;
        private System.Windows.Forms.TextBox txtbAtmPin;
        private System.Windows.Forms.TextBox txtbAtmNum;
        private System.Windows.Forms.TextBox txtbAcctNum;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox cmbxAcctType;
        private System.Windows.Forms.Label lbInterest;
        private System.Windows.Forms.Label lbAtmNum;
        private System.Windows.Forms.Label lbATMAcctNum;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAcctNum;
        private System.Windows.Forms.Label lbAcctType;
        private System.Windows.Forms.Button btnAccountUpdate;
        private System.Windows.Forms.ListBox lstbxTransactions;
        private System.Windows.Forms.TextBox txtbResults;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.RadioButton rdbtnWithdraw;
        private System.Windows.Forms.RadioButton rdbtnDeposit;
        private System.Windows.Forms.TextBox txtbAmount;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Button btnClear;
    }
}

