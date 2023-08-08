namespace Augenleuchten.Postetiketten
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            SuspendLayout();
            // 
            // btnPrintCurrentFile
            // 
            btnPrintCurrentFile.Location = new Point(98, 249);
            btnPrintCurrentFile.Margin = new Padding(2);
            btnPrintCurrentFile.Name = "btnPrintCurrentFile";
            btnPrintCurrentFile.Size = new Size(488, 41);
            btnPrintCurrentFile.TabIndex = 0;
            btnPrintCurrentFile.Text = "Drucken";
            btnPrintCurrentFile.UseVisualStyleBackColor = true;
            btnPrintCurrentFile.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"PDF-Dateien|*.pdf|Alle Dateien|*.*\"";
            openFileDialog1.Title = "Briefmarken auswählen";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // txtBoxCurrentFile
            // 
            txtBoxCurrentFile.Location = new Point(98, 54);
            txtBoxCurrentFile.Name = "txtBoxCurrentFile";
            txtBoxCurrentFile.ReadOnly = true;
            txtBoxCurrentFile.Size = new Size(488, 23);
            txtBoxCurrentFile.TabIndex = 1;
            // 
            // lblCurrentFile
            // 
            lblCurrentFile.AutoSize = true;
            lblCurrentFile.Location = new Point(12, 57);
            lblCurrentFile.Name = "lblCurrentFile";
            lblCurrentFile.Size = new Size(80, 15);
            lblCurrentFile.TabIndex = 2;
            lblCurrentFile.Text = "Aktuelle Datei";
            // 
            // btnChangePath
            // 
            btnChangePath.Location = new Point(592, 53);
            btnChangePath.Name = "btnChangePath";
            btnChangePath.Size = new Size(97, 24);
            btnChangePath.TabIndex = 3;
            btnChangePath.Text = "Ändern";
            btnChangePath.UseVisualStyleBackColor = true;
            btnChangePath.Click += btnChangePath_Click;
            // 
            // btnChangeOutputPath
            // 
            btnChangeOutputPath.Location = new Point(592, 100);
            btnChangeOutputPath.Name = "btnChangeOutputPath";
            btnChangeOutputPath.Size = new Size(97, 24);
            btnChangeOutputPath.TabIndex = 6;
            btnChangeOutputPath.Text = "Ändern";
            btnChangeOutputPath.UseVisualStyleBackColor = true;
            btnChangeOutputPath.Click += button1_Click_1;
            // 
            // lblOutputPath
            // 
            lblOutputPath.AutoSize = true;
            lblOutputPath.Location = new Point(31, 105);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new Size(61, 15);
            lblOutputPath.TabIndex = 5;
            lblOutputPath.Text = "Zielordner";
            // 
            // txtBoxOutputPath
            // 
            txtBoxOutputPath.Location = new Point(98, 101);
            txtBoxOutputPath.Name = "txtBoxOutputPath";
            txtBoxOutputPath.ReadOnly = true;
            txtBoxOutputPath.Size = new Size(488, 23);
            txtBoxOutputPath.TabIndex = 4;
            // 
            // lblErkannteBriefmarken
            // 
            lblErkannteBriefmarken.AutoSize = true;
            lblErkannteBriefmarken.Location = new Point(192, 133);
            lblErkannteBriefmarken.Name = "lblErkannteBriefmarken";
            lblErkannteBriefmarken.Size = new Size(120, 15);
            lblErkannteBriefmarken.TabIndex = 8;
            lblErkannteBriefmarken.Text = "Erkannte Briefmarken";
            // 
            // txtBoxErkannteBriefmarken
            // 
            txtBoxErkannteBriefmarken.Location = new Point(318, 130);
            txtBoxErkannteBriefmarken.Name = "txtBoxErkannteBriefmarken";
            txtBoxErkannteBriefmarken.ReadOnly = true;
            txtBoxErkannteBriefmarken.Size = new Size(82, 23);
            txtBoxErkannteBriefmarken.TabIndex = 7;
            txtBoxErkannteBriefmarken.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 316);
            Controls.Add(lblErkannteBriefmarken);
            Controls.Add(txtBoxErkannteBriefmarken);
            Controls.Add(btnChangeOutputPath);
            Controls.Add(lblOutputPath);
            Controls.Add(txtBoxOutputPath);
            Controls.Add(btnChangePath);
            Controls.Add(lblCurrentFile);
            Controls.Add(txtBoxCurrentFile);
            Controls.Add(btnPrintCurrentFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Gude-Solutions Briefmarkendrucker";
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
    }
}