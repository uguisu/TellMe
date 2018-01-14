namespace TellMe
{
    partial class FormTellMe
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
            this.tabControlAll = new System.Windows.Forms.TabControl();
            this.tabPageMessage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnToEs = new System.Windows.Forms.Button();
            this.btnToMe = new System.Windows.Forms.Button();
            this.textBoxMe = new System.Windows.Forms.TextBox();
            this.textBoxEs = new System.Windows.Forms.TextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxKey = new System.Windows.Forms.MaskedTextBox();
            this.btnApplyKey = new System.Windows.Forms.Button();
            this.tabControlAll.SuspendLayout();
            this.tabPageMessage.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAll
            // 
            this.tabControlAll.Controls.Add(this.tabPageMessage);
            this.tabControlAll.Controls.Add(this.tabPageSettings);
            this.tabControlAll.Location = new System.Drawing.Point(12, 12);
            this.tabControlAll.Name = "tabControlAll";
            this.tabControlAll.SelectedIndex = 0;
            this.tabControlAll.Size = new System.Drawing.Size(660, 337);
            this.tabControlAll.TabIndex = 0;
            // 
            // tabPageMessage
            // 
            this.tabPageMessage.Controls.Add(this.label2);
            this.tabPageMessage.Controls.Add(this.label1);
            this.tabPageMessage.Controls.Add(this.btnClean);
            this.tabPageMessage.Controls.Add(this.btnToEs);
            this.tabPageMessage.Controls.Add(this.btnToMe);
            this.tabPageMessage.Controls.Add(this.textBoxMe);
            this.tabPageMessage.Controls.Add(this.textBoxEs);
            this.tabPageMessage.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessage.Name = "tabPageMessage";
            this.tabPageMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessage.Size = new System.Drawing.Size(652, 311);
            this.tabPageMessage.TabIndex = 0;
            this.tabPageMessage.Text = "Message";
            this.tabPageMessage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tell me";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Es";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(307, 245);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(33, 23);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "C";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnToEs
            // 
            this.btnToEs.Location = new System.Drawing.Point(307, 114);
            this.btnToEs.Name = "btnToEs";
            this.btnToEs.Size = new System.Drawing.Size(33, 23);
            this.btnToEs.TabIndex = 1;
            this.btnToEs.Text = "<<";
            this.btnToEs.UseVisualStyleBackColor = true;
            this.btnToEs.Click += new System.EventHandler(this.btnToEs_Click);
            // 
            // btnToMe
            // 
            this.btnToMe.Location = new System.Drawing.Point(307, 73);
            this.btnToMe.Name = "btnToMe";
            this.btnToMe.Size = new System.Drawing.Size(33, 23);
            this.btnToMe.TabIndex = 1;
            this.btnToMe.Text = ">>";
            this.btnToMe.UseVisualStyleBackColor = true;
            this.btnToMe.Click += new System.EventHandler(this.btnToMe_Click);
            // 
            // textBoxMe
            // 
            this.textBoxMe.Location = new System.Drawing.Point(364, 29);
            this.textBoxMe.Multiline = true;
            this.textBoxMe.Name = "textBoxMe";
            this.textBoxMe.Size = new System.Drawing.Size(271, 266);
            this.textBoxMe.TabIndex = 0;
            // 
            // textBoxEs
            // 
            this.textBoxEs.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEs.Location = new System.Drawing.Point(15, 29);
            this.textBoxEs.Multiline = true;
            this.textBoxEs.Name = "textBoxEs";
            this.textBoxEs.Size = new System.Drawing.Size(271, 266);
            this.textBoxEs.TabIndex = 0;
            this.textBoxEs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxEs_MouseMove);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.label3);
            this.tabPageSettings.Controls.Add(this.maskedTextBoxKey);
            this.tabPageSettings.Controls.Add(this.btnApplyKey);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(652, 311);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Covers";
            // 
            // maskedTextBoxKey
            // 
            this.maskedTextBoxKey.Location = new System.Drawing.Point(33, 42);
            this.maskedTextBoxKey.Name = "maskedTextBoxKey";
            this.maskedTextBoxKey.PasswordChar = '$';
            this.maskedTextBoxKey.Size = new System.Drawing.Size(185, 20);
            this.maskedTextBoxKey.TabIndex = 2;
            // 
            // btnApplyKey
            // 
            this.btnApplyKey.Location = new System.Drawing.Point(238, 42);
            this.btnApplyKey.Name = "btnApplyKey";
            this.btnApplyKey.Size = new System.Drawing.Size(75, 23);
            this.btnApplyKey.TabIndex = 1;
            this.btnApplyKey.Text = "Apply";
            this.btnApplyKey.UseVisualStyleBackColor = true;
            this.btnApplyKey.Click += new System.EventHandler(this.btnApplyKey_Click);
            // 
            // FormTellMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.tabControlAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTellMe";
            this.Text = "TellMe";
            this.Load += new System.EventHandler(this.FormTellMe_Load);
            this.tabControlAll.ResumeLayout(false);
            this.tabPageMessage.ResumeLayout(false);
            this.tabPageMessage.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAll;
        private System.Windows.Forms.TabPage tabPageMessage;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnToEs;
        private System.Windows.Forms.Button btnToMe;
        private System.Windows.Forms.TextBox textBoxMe;
        private System.Windows.Forms.TextBox textBoxEs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKey;
        private System.Windows.Forms.Button btnApplyKey;
        private System.Windows.Forms.Label label3;
    }
}

