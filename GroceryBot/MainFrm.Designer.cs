namespace GroceryBot
{
    partial class MainFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.cbBlackHole = new MetroFramework.Controls.MetroCheckBox();
            this.cbBlackHoleChair = new MetroFramework.Controls.MetroCheckBox();
            this.cbInitialChair = new MetroFramework.Controls.MetroCheckBox();
            this.cbAutoSit = new MetroFramework.Controls.MetroCheckBox();
            this.cbItem1 = new MetroFramework.Controls.MetroCheckBox();
            this.cbItem2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbItem3 = new MetroFramework.Controls.MetroCheckBox();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "by Ric";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(23, 73);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(185, 29);
            this.metroComboBox1.Sorted = true;
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(23, 108);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(185, 29);
            this.metroComboBox2.Sorted = true;
            this.metroComboBox2.TabIndex = 2;
            this.metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(23, 143);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(185, 29);
            this.metroComboBox3.Sorted = true;
            this.metroComboBox3.TabIndex = 3;
            this.metroComboBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // cbBlackHole
            // 
            this.cbBlackHole.AutoSize = true;
            this.cbBlackHole.Location = new System.Drawing.Point(226, 73);
            this.cbBlackHole.Name = "cbBlackHole";
            this.cbBlackHole.Size = new System.Drawing.Size(79, 15);
            this.cbBlackHole.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbBlackHole.TabIndex = 4;
            this.cbBlackHole.Text = "Black Hole";
            this.cbBlackHole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbBlackHole.UseSelectable = true;
            this.cbBlackHole.CheckedChanged += new System.EventHandler(this.cbBlackHole_CheckedChanged);
            // 
            // cbBlackHoleChair
            // 
            this.cbBlackHoleChair.AutoSize = true;
            this.cbBlackHoleChair.Location = new System.Drawing.Point(226, 94);
            this.cbBlackHoleChair.Name = "cbBlackHoleChair";
            this.cbBlackHoleChair.Size = new System.Drawing.Size(154, 15);
            this.cbBlackHoleChair.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbBlackHoleChair.TabIndex = 5;
            this.cbBlackHoleChair.Text = "Chair near the black hole";
            this.cbBlackHoleChair.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbBlackHoleChair.UseSelectable = true;
            this.cbBlackHoleChair.CheckedChanged += new System.EventHandler(this.cbBlackHoleChair_CheckedChanged);
            // 
            // cbInitialChair
            // 
            this.cbInitialChair.AutoSize = true;
            this.cbInitialChair.Location = new System.Drawing.Point(226, 115);
            this.cbInitialChair.Name = "cbInitialChair";
            this.cbInitialChair.Size = new System.Drawing.Size(83, 15);
            this.cbInitialChair.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbInitialChair.TabIndex = 6;
            this.cbInitialChair.Text = "Initial Chair";
            this.cbInitialChair.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbInitialChair.UseSelectable = true;
            // 
            // cbAutoSit
            // 
            this.cbAutoSit.AutoSize = true;
            this.cbAutoSit.Location = new System.Drawing.Point(226, 156);
            this.cbAutoSit.Name = "cbAutoSit";
            this.cbAutoSit.Size = new System.Drawing.Size(65, 15);
            this.cbAutoSit.Style = MetroFramework.MetroColorStyle.Red;
            this.cbAutoSit.TabIndex = 7;
            this.cbAutoSit.Text = "Auto Sit";
            this.cbAutoSit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbAutoSit.UseSelectable = true;
            // 
            // cbItem1
            // 
            this.cbItem1.AutoSize = true;
            this.cbItem1.Checked = true;
            this.cbItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbItem1.Location = new System.Drawing.Point(6, 80);
            this.cbItem1.Name = "cbItem1";
            this.cbItem1.Size = new System.Drawing.Size(39, 15);
            this.cbItem1.Style = MetroFramework.MetroColorStyle.White;
            this.cbItem1.TabIndex = 8;
            this.cbItem1.Text = "xx1";
            this.cbItem1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbItem1.UseSelectable = true;
            // 
            // cbItem2
            // 
            this.cbItem2.AutoSize = true;
            this.cbItem2.Checked = true;
            this.cbItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbItem2.Location = new System.Drawing.Point(6, 115);
            this.cbItem2.Name = "cbItem2";
            this.cbItem2.Size = new System.Drawing.Size(39, 15);
            this.cbItem2.Style = MetroFramework.MetroColorStyle.White;
            this.cbItem2.TabIndex = 9;
            this.cbItem2.Text = "xx2";
            this.cbItem2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbItem2.UseSelectable = true;
            // 
            // cbItem3
            // 
            this.cbItem3.AutoSize = true;
            this.cbItem3.Checked = true;
            this.cbItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbItem3.Location = new System.Drawing.Point(6, 149);
            this.cbItem3.Name = "cbItem3";
            this.cbItem3.Size = new System.Drawing.Size(39, 15);
            this.cbItem3.Style = MetroFramework.MetroColorStyle.White;
            this.cbItem3.TabIndex = 10;
            this.cbItem3.Text = "xx3";
            this.cbItem3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbItem3.UseSelectable = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(23, 179);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(104, 179);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Checked = true;
            this.metroCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox2.Location = new System.Drawing.Point(226, 29);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(73, 15);
            this.metroCheckBox2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroCheckBox2.TabIndex = 13;
            this.metroCheckBox2.Text = "Top Most";
            this.metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 210);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbAutoSit);
            this.Controls.Add(this.cbInitialChair);
            this.Controls.Add(this.cbBlackHoleChair);
            this.Controls.Add(this.cbBlackHole);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbItem1);
            this.Controls.Add(this.cbItem2);
            this.Controls.Add(this.cbItem3);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Opacity = 0.8D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Grocery Bot";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroCheckBox cbBlackHole;
        private MetroFramework.Controls.MetroCheckBox cbBlackHoleChair;
        private MetroFramework.Controls.MetroCheckBox cbInitialChair;
        private MetroFramework.Controls.MetroCheckBox cbAutoSit;
        private MetroFramework.Controls.MetroCheckBox cbItem1;
        private MetroFramework.Controls.MetroCheckBox cbItem2;
        private MetroFramework.Controls.MetroCheckBox cbItem3;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
    }
}