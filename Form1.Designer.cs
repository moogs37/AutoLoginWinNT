namespace AutoLoginWinNT
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
            this.button1 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.autoAdminLogonCVTB = new System.Windows.Forms.TextBox();
            this.stringNameLabel = new System.Windows.Forms.Label();
            this.currentValueLabel = new System.Windows.Forms.Label();
            this.newValueLabel = new System.Windows.Forms.Label();
            this.lautoAdminLogonLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultPasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultUserNameCVTB = new System.Windows.Forms.TextBox();
            this.defaultPasswordCVTB = new System.Windows.Forms.TextBox();
            this.defaultDomainNameCVTB = new System.Windows.Forms.TextBox();
            this.autoAdminLogonNVTB = new System.Windows.Forms.TextBox();
            this.defaultUserNameNVTB = new System.Windows.Forms.TextBox();
            this.defaultPasswordNVTB = new System.Windows.Forms.TextBox();
            this.defaultDomainNameNVTB = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(107, 178);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // autoAdminLogonCVTB
            // 
            this.autoAdminLogonCVTB.Location = new System.Drawing.Point(153, 47);
            this.autoAdminLogonCVTB.Name = "autoAdminLogonCVTB";
            this.autoAdminLogonCVTB.Size = new System.Drawing.Size(100, 20);
            this.autoAdminLogonCVTB.TabIndex = 9;
            // 
            // stringNameLabel
            // 
            this.stringNameLabel.AutoSize = true;
            this.stringNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stringNameLabel.Location = new System.Drawing.Point(8, 15);
            this.stringNameLabel.Name = "stringNameLabel";
            this.stringNameLabel.Size = new System.Drawing.Size(97, 20);
            this.stringNameLabel.TabIndex = 10;
            this.stringNameLabel.Text = "String Name";
            this.stringNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // currentValueLabel
            // 
            this.currentValueLabel.AutoSize = true;
            this.currentValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentValueLabel.Location = new System.Drawing.Point(149, 15);
            this.currentValueLabel.Name = "currentValueLabel";
            this.currentValueLabel.Size = new System.Drawing.Size(107, 20);
            this.currentValueLabel.TabIndex = 11;
            this.currentValueLabel.Text = "Current Value";
            this.currentValueLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // newValueLabel
            // 
            this.newValueLabel.AutoSize = true;
            this.newValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newValueLabel.Location = new System.Drawing.Point(278, 15);
            this.newValueLabel.Name = "newValueLabel";
            this.newValueLabel.Size = new System.Drawing.Size(85, 20);
            this.newValueLabel.TabIndex = 12;
            this.newValueLabel.Text = "New Value";
            // 
            // lautoAdminLogonLabel
            // 
            this.lautoAdminLogonLabel.AutoSize = true;
            this.lautoAdminLogonLabel.Location = new System.Drawing.Point(26, 54);
            this.lautoAdminLogonLabel.Name = "lautoAdminLogonLabel";
            this.lautoAdminLogonLabel.Size = new System.Drawing.Size(88, 13);
            this.lautoAdminLogonLabel.TabIndex = 13;
            this.lautoAdminLogonLabel.Text = "AutoAdminLogon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "DefaultUserName";
            // 
            // defaultPasswordLabel
            // 
            this.defaultPasswordLabel.AutoSize = true;
            this.defaultPasswordLabel.Location = new System.Drawing.Point(27, 106);
            this.defaultPasswordLabel.Name = "defaultPasswordLabel";
            this.defaultPasswordLabel.Size = new System.Drawing.Size(87, 13);
            this.defaultPasswordLabel.TabIndex = 15;
            this.defaultPasswordLabel.Text = "DefaultPassword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "DefaultDomainName";
            // 
            // defaultUserNameCVTB
            // 
            this.defaultUserNameCVTB.Location = new System.Drawing.Point(153, 72);
            this.defaultUserNameCVTB.Name = "defaultUserNameCVTB";
            this.defaultUserNameCVTB.Size = new System.Drawing.Size(100, 20);
            this.defaultUserNameCVTB.TabIndex = 17;
            // 
            // defaultPasswordCVTB
            // 
            this.defaultPasswordCVTB.Location = new System.Drawing.Point(153, 98);
            this.defaultPasswordCVTB.Name = "defaultPasswordCVTB";
            this.defaultPasswordCVTB.Size = new System.Drawing.Size(100, 20);
            this.defaultPasswordCVTB.TabIndex = 18;
            // 
            // defaultDomainNameCVTB
            // 
            this.defaultDomainNameCVTB.Location = new System.Drawing.Point(153, 124);
            this.defaultDomainNameCVTB.Name = "defaultDomainNameCVTB";
            this.defaultDomainNameCVTB.Size = new System.Drawing.Size(100, 20);
            this.defaultDomainNameCVTB.TabIndex = 19;
            // 
            // autoAdminLogonNVTB
            // 
            this.autoAdminLogonNVTB.Location = new System.Drawing.Point(282, 47);
            this.autoAdminLogonNVTB.Name = "autoAdminLogonNVTB";
            this.autoAdminLogonNVTB.Size = new System.Drawing.Size(100, 20);
            this.autoAdminLogonNVTB.TabIndex = 20;
            // 
            // defaultUserNameNVTB
            // 
            this.defaultUserNameNVTB.Location = new System.Drawing.Point(282, 72);
            this.defaultUserNameNVTB.Name = "defaultUserNameNVTB";
            this.defaultUserNameNVTB.Size = new System.Drawing.Size(100, 20);
            this.defaultUserNameNVTB.TabIndex = 21;
            // 
            // defaultPasswordNVTB
            // 
            this.defaultPasswordNVTB.Location = new System.Drawing.Point(282, 99);
            this.defaultPasswordNVTB.Name = "defaultPasswordNVTB";
            this.defaultPasswordNVTB.Size = new System.Drawing.Size(100, 20);
            this.defaultPasswordNVTB.TabIndex = 22;
            // 
            // defaultDomainNameNVTB
            // 
            this.defaultDomainNameNVTB.Location = new System.Drawing.Point(282, 124);
            this.defaultDomainNameNVTB.Name = "defaultDomainNameNVTB";
            this.defaultDomainNameNVTB.Size = new System.Drawing.Size(100, 20);
            this.defaultDomainNameNVTB.TabIndex = 23;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(208, 181);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 16);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 205);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.defaultDomainNameNVTB);
            this.Controls.Add(this.defaultPasswordNVTB);
            this.Controls.Add(this.defaultUserNameNVTB);
            this.Controls.Add(this.autoAdminLogonNVTB);
            this.Controls.Add(this.defaultDomainNameCVTB);
            this.Controls.Add(this.defaultPasswordCVTB);
            this.Controls.Add(this.defaultUserNameCVTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defaultPasswordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lautoAdminLogonLabel);
            this.Controls.Add(this.newValueLabel);
            this.Controls.Add(this.currentValueLabel);
            this.Controls.Add(this.stringNameLabel);
            this.Controls.Add(this.autoAdminLogonCVTB);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "AutoLoginWinNT";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox autoAdminLogonCVTB;
        private System.Windows.Forms.Label stringNameLabel;
        private System.Windows.Forms.Label currentValueLabel;
        private System.Windows.Forms.Label newValueLabel;
        private System.Windows.Forms.Label lautoAdminLogonLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label defaultPasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox defaultUserNameCVTB;
        private System.Windows.Forms.TextBox defaultPasswordCVTB;
        private System.Windows.Forms.TextBox defaultDomainNameCVTB;
        private System.Windows.Forms.TextBox autoAdminLogonNVTB;
        private System.Windows.Forms.TextBox defaultUserNameNVTB;
        private System.Windows.Forms.TextBox defaultPasswordNVTB;
        private System.Windows.Forms.TextBox defaultDomainNameNVTB;
        private System.Windows.Forms.Label statusLabel;
    }
}

