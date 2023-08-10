namespace Augenleuchten.Postetiketten
{
    partial class FormMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            btnPrintCurrentFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtBoxCurrentFile = new TextBox();
            lblCurrentFile = new Label();
            btnChangePath = new Button();
            btnChangeOutputPath = new Button();
            lblOutputPath = new Label();
            txtBoxOutputPath = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lblErkannteBriefmarken = new Label();
            txtBoxErkannteBriefmarken = new TextBox();
            menuStrip1 = new MenuStrip();
            druckerAuswählenToolStripMenuItem = new ToolStripMenuItem();
            druckerAuswaehlenToolStripMenuItem1 = new ToolStripComboBox();
            printDialog1 = new PrintDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrintCurrentFile
            // 
            btnPrintCurrentFile.Location = new Point(140, 415);
            btnPrintCurrentFile.Name = "btnPrintCurrentFile";
            btnPrintCurrentFile.Size = new Size(697, 68);
            btnPrintCurrentFile.TabIndex = 0;
            btnPrintCurrentFile.Text = "Drucken";
            btnPrintCurrentFile.UseVisualStyleBackColor = true;
            btnPrintCurrentFile.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "\"PDF-Dateien|*.pdf|Alle Dateien|*.*\"";
            openFileDialog1.Title = "Briefmarken auswählen";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // txtBoxCurrentFile
            // 
            txtBoxCurrentFile.Location = new Point(140, 90);
            txtBoxCurrentFile.Margin = new Padding(4, 5, 4, 5);
            txtBoxCurrentFile.Name = "txtBoxCurrentFile";
            txtBoxCurrentFile.ReadOnly = true;
            txtBoxCurrentFile.Size = new Size(695, 31);
            txtBoxCurrentFile.TabIndex = 1;
            // 
            // lblCurrentFile
            // 
            lblCurrentFile.AutoSize = true;
            lblCurrentFile.Location = new Point(17, 95);
            lblCurrentFile.Margin = new Padding(4, 0, 4, 0);
            lblCurrentFile.Name = "lblCurrentFile";
            lblCurrentFile.Size = new Size(121, 25);
            lblCurrentFile.TabIndex = 2;
            lblCurrentFile.Text = "Aktuelle Datei";
            // 
            // btnChangePath
            // 
            btnChangePath.Location = new Point(846, 88);
            btnChangePath.Margin = new Padding(4, 5, 4, 5);
            btnChangePath.Name = "btnChangePath";
            btnChangePath.Size = new Size(139, 40);
            btnChangePath.TabIndex = 3;
            btnChangePath.Text = "Ändern";
            btnChangePath.UseVisualStyleBackColor = true;
            btnChangePath.Click += btnChangePath_Click;
            // 
            // btnChangeOutputPath
            // 
            btnChangeOutputPath.Location = new Point(846, 167);
            btnChangeOutputPath.Margin = new Padding(4, 5, 4, 5);
            btnChangeOutputPath.Name = "btnChangeOutputPath";
            btnChangeOutputPath.Size = new Size(139, 40);
            btnChangeOutputPath.TabIndex = 6;
            btnChangeOutputPath.Text = "Ändern";
            btnChangeOutputPath.UseVisualStyleBackColor = true;
            btnChangeOutputPath.Click += button1_Click_1;
            // 
            // lblOutputPath
            // 
            lblOutputPath.AutoSize = true;
            lblOutputPath.Location = new Point(44, 175);
            lblOutputPath.Margin = new Padding(4, 0, 4, 0);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new Size(92, 25);
            lblOutputPath.TabIndex = 5;
            lblOutputPath.Text = "Zielordner";
            // 
            // txtBoxOutputPath
            // 
            txtBoxOutputPath.Location = new Point(140, 168);
            txtBoxOutputPath.Margin = new Padding(4, 5, 4, 5);
            txtBoxOutputPath.Name = "txtBoxOutputPath";
            txtBoxOutputPath.ReadOnly = true;
            txtBoxOutputPath.Size = new Size(695, 31);
            txtBoxOutputPath.TabIndex = 4;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // lblErkannteBriefmarken
            // 
            lblErkannteBriefmarken.AutoSize = true;
            lblErkannteBriefmarken.Location = new Point(274, 222);
            lblErkannteBriefmarken.Margin = new Padding(4, 0, 4, 0);
            lblErkannteBriefmarken.Name = "lblErkannteBriefmarken";
            lblErkannteBriefmarken.Size = new Size(179, 25);
            lblErkannteBriefmarken.TabIndex = 8;
            lblErkannteBriefmarken.Text = "Erkannte Briefmarken";
            // 
            // txtBoxErkannteBriefmarken
            // 
            txtBoxErkannteBriefmarken.Location = new Point(454, 217);
            txtBoxErkannteBriefmarken.Margin = new Padding(4, 5, 4, 5);
            txtBoxErkannteBriefmarken.Name = "txtBoxErkannteBriefmarken";
            txtBoxErkannteBriefmarken.ReadOnly = true;
            txtBoxErkannteBriefmarken.Size = new Size(115, 31);
            txtBoxErkannteBriefmarken.TabIndex = 7;
            txtBoxErkannteBriefmarken.TextAlign = HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { druckerAuswählenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1001, 35);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // druckerAuswählenToolStripMenuItem
            // 
            druckerAuswählenToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            druckerAuswählenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { druckerAuswaehlenToolStripMenuItem1 });
            druckerAuswählenToolStripMenuItem.Name = "druckerAuswählenToolStripMenuItem";
            druckerAuswählenToolStripMenuItem.Size = new Size(132, 29);
            druckerAuswählenToolStripMenuItem.Text = "Einstellungen";
            druckerAuswählenToolStripMenuItem.Click += druckerAuswählenToolStripMenuItem_Click;
            // 
            // druckerAuswaehlenToolStripMenuItem1
            // 
            druckerAuswaehlenToolStripMenuItem1.AccessibleName = "Drucker Auswählen";
            druckerAuswaehlenToolStripMenuItem1.AutoToolTip = true;
            druckerAuswaehlenToolStripMenuItem1.DropDownStyle = ComboBoxStyle.DropDownList;
            druckerAuswaehlenToolStripMenuItem1.DropDownWidth = 300;
            druckerAuswaehlenToolStripMenuItem1.MaxDropDownItems = 16;
            druckerAuswaehlenToolStripMenuItem1.Name = "druckerAuswaehlenToolStripMenuItem1";
            druckerAuswaehlenToolStripMenuItem1.Size = new Size(180, 33);
            druckerAuswaehlenToolStripMenuItem1.Sorted = true;
            druckerAuswaehlenToolStripMenuItem1.Tag = "Drucker Auswählen";
            druckerAuswaehlenToolStripMenuItem1.ToolTipText = "Drucker Auswählen";
            druckerAuswaehlenToolStripMenuItem1.SelectedIndexChanged += druckerAuswaehlenToolStripMenuItem1_SelectedIndexChanged;
            druckerAuswaehlenToolStripMenuItem1.Click += druckerAuswählenToolStripMenuItem1_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // FormMainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 527);
            Controls.Add(lblErkannteBriefmarken);
            Controls.Add(txtBoxErkannteBriefmarken);
            Controls.Add(btnChangeOutputPath);
            Controls.Add(lblOutputPath);
            Controls.Add(txtBoxOutputPath);
            Controls.Add(btnChangePath);
            Controls.Add(lblCurrentFile);
            Controls.Add(txtBoxCurrentFile);
            Controls.Add(btnPrintCurrentFile);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormMainWindow";
            Text = "Gude-Solutions Briefmarkendrucker";
            FormClosed += FormMainWindow_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrintCurrentFile;
        private OpenFileDialog openFileDialog1;
        private TextBox txtBoxCurrentFile;
        private Label lblCurrentFile;
        private Button btnChangePath;
        private Button btnChangeOutputPath;
        private Label lblOutputPath;
        private TextBox txtBoxOutputPath;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label lblErkannteBriefmarken;
        private TextBox txtBoxErkannteBriefmarken;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem druckerAuswählenToolStripMenuItem;
        private PrintDialog printDialog1;
        private ToolStripComboBox druckerAuswaehlenToolStripMenuItem1;
    }
}