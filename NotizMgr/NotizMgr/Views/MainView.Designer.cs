namespace NotizMgr
{
    partial class MainView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dATEIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bEARBEITENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesProjektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.neueNotizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueAufgabeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProjekte = new System.Windows.Forms.ListBox();
            this.tcElemente = new System.Windows.Forms.TabControl();
            this.tpNotiz = new System.Windows.Forms.TabPage();
            this.lbNotizen = new System.Windows.Forms.ListBox();
            this.tpTermin = new System.Windows.Forms.TabPage();
            this.lbTermine = new System.Windows.Forms.ListBox();
            this.tpAufgabe = new System.Windows.Forms.TabPage();
            this.lbAufgaben = new System.Windows.Forms.ListBox();
            this.menuStrip2.SuspendLayout();
            this.tcElemente.SuspendLayout();
            this.tpNotiz.SuspendLayout();
            this.tpTermin.SuspendLayout();
            this.tpAufgabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATEIToolStripMenuItem,
            this.bEARBEITENToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(661, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dATEIToolStripMenuItem
            // 
            this.dATEIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektLadenToolStripMenuItem,
            this.projektSpeichernToolStripMenuItem,
            this.toolStripMenuItem2,
            this.beendenToolStripMenuItem});
            this.dATEIToolStripMenuItem.Name = "dATEIToolStripMenuItem";
            this.dATEIToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dATEIToolStripMenuItem.Text = "DATEI";
            // 
            // projektLadenToolStripMenuItem
            // 
            this.projektLadenToolStripMenuItem.Name = "projektLadenToolStripMenuItem";
            this.projektLadenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.projektLadenToolStripMenuItem.Text = "Projekt laden";
            this.projektLadenToolStripMenuItem.Click += new System.EventHandler(this.projektLadenToolStripMenuItem_Click);
            // 
            // projektSpeichernToolStripMenuItem
            // 
            this.projektSpeichernToolStripMenuItem.Name = "projektSpeichernToolStripMenuItem";
            this.projektSpeichernToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.projektSpeichernToolStripMenuItem.Text = "Projekt speichern";
            this.projektSpeichernToolStripMenuItem.Click += new System.EventHandler(this.projektSpeichernToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bEARBEITENToolStripMenuItem
            // 
            this.bEARBEITENToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesProjektToolStripMenuItem,
            this.toolStripMenuItem3,
            this.neueNotizToolStripMenuItem,
            this.neuerTerminToolStripMenuItem,
            this.neueAufgabeToolStripMenuItem});
            this.bEARBEITENToolStripMenuItem.Name = "bEARBEITENToolStripMenuItem";
            this.bEARBEITENToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bEARBEITENToolStripMenuItem.Text = "BEARBEITEN";
            // 
            // neuesProjektToolStripMenuItem
            // 
            this.neuesProjektToolStripMenuItem.Name = "neuesProjektToolStripMenuItem";
            this.neuesProjektToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.neuesProjektToolStripMenuItem.Text = "Neues Projekt ...";
            this.neuesProjektToolStripMenuItem.Click += new System.EventHandler(this.neuesProjektToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // neueNotizToolStripMenuItem
            // 
            this.neueNotizToolStripMenuItem.Name = "neueNotizToolStripMenuItem";
            this.neueNotizToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.neueNotizToolStripMenuItem.Text = "Neue Notiz ...";
            this.neueNotizToolStripMenuItem.Click += new System.EventHandler(this.neueNotizToolStripMenuItem_Click);
            // 
            // neuerTerminToolStripMenuItem
            // 
            this.neuerTerminToolStripMenuItem.Name = "neuerTerminToolStripMenuItem";
            this.neuerTerminToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.neuerTerminToolStripMenuItem.Text = "Neuer Termin ...";
            this.neuerTerminToolStripMenuItem.Click += new System.EventHandler(this.neuerTerminToolStripMenuItem_Click);
            // 
            // neueAufgabeToolStripMenuItem
            // 
            this.neueAufgabeToolStripMenuItem.Name = "neueAufgabeToolStripMenuItem";
            this.neueAufgabeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.neueAufgabeToolStripMenuItem.Text = "Neue Aufgabe ...";
            this.neueAufgabeToolStripMenuItem.Click += new System.EventHandler(this.neueAufgabeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROJEKTE";
            // 
            // lbProjekte
            // 
            this.lbProjekte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProjekte.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjekte.FormattingEnabled = true;
            this.lbProjekte.Location = new System.Drawing.Point(12, 53);
            this.lbProjekte.Name = "lbProjekte";
            this.lbProjekte.Size = new System.Drawing.Size(120, 277);
            this.lbProjekte.TabIndex = 3;
            this.lbProjekte.SelectedIndexChanged += new System.EventHandler(this.lbProjekte_SelectedIndexChanged);
            // 
            // tcElemente
            // 
            this.tcElemente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcElemente.Controls.Add(this.tpNotiz);
            this.tcElemente.Controls.Add(this.tpTermin);
            this.tcElemente.Controls.Add(this.tpAufgabe);
            this.tcElemente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcElemente.Location = new System.Drawing.Point(138, 40);
            this.tcElemente.Name = "tcElemente";
            this.tcElemente.SelectedIndex = 0;
            this.tcElemente.Size = new System.Drawing.Size(511, 290);
            this.tcElemente.TabIndex = 4;
            // 
            // tpNotiz
            // 
            this.tpNotiz.Controls.Add(this.lbNotizen);
            this.tpNotiz.Location = new System.Drawing.Point(4, 22);
            this.tpNotiz.Name = "tpNotiz";
            this.tpNotiz.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotiz.Size = new System.Drawing.Size(503, 264);
            this.tpNotiz.TabIndex = 0;
            this.tpNotiz.Text = "Notizen";
            this.tpNotiz.UseVisualStyleBackColor = true;
            // 
            // lbNotizen
            // 
            this.lbNotizen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNotizen.FormattingEnabled = true;
            this.lbNotizen.Location = new System.Drawing.Point(0, 0);
            this.lbNotizen.Name = "lbNotizen";
            this.lbNotizen.Size = new System.Drawing.Size(503, 264);
            this.lbNotizen.TabIndex = 0;
            // 
            // tpTermin
            // 
            this.tpTermin.Controls.Add(this.lbTermine);
            this.tpTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTermin.Location = new System.Drawing.Point(4, 22);
            this.tpTermin.Name = "tpTermin";
            this.tpTermin.Padding = new System.Windows.Forms.Padding(3);
            this.tpTermin.Size = new System.Drawing.Size(503, 264);
            this.tpTermin.TabIndex = 1;
            this.tpTermin.Text = "Termine";
            this.tpTermin.UseVisualStyleBackColor = true;
            // 
            // lbTermine
            // 
            this.lbTermine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTermine.FormattingEnabled = true;
            this.lbTermine.Location = new System.Drawing.Point(0, 0);
            this.lbTermine.Name = "lbTermine";
            this.lbTermine.Size = new System.Drawing.Size(503, 264);
            this.lbTermine.TabIndex = 1;
            // 
            // tpAufgabe
            // 
            this.tpAufgabe.Controls.Add(this.lbAufgaben);
            this.tpAufgabe.Location = new System.Drawing.Point(4, 22);
            this.tpAufgabe.Name = "tpAufgabe";
            this.tpAufgabe.Padding = new System.Windows.Forms.Padding(3);
            this.tpAufgabe.Size = new System.Drawing.Size(503, 264);
            this.tpAufgabe.TabIndex = 2;
            this.tpAufgabe.Text = "Aufgaben";
            this.tpAufgabe.UseVisualStyleBackColor = true;
            // 
            // lbAufgaben
            // 
            this.lbAufgaben.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAufgaben.FormattingEnabled = true;
            this.lbAufgaben.Location = new System.Drawing.Point(0, 0);
            this.lbAufgaben.Name = "lbAufgaben";
            this.lbAufgaben.Size = new System.Drawing.Size(503, 264);
            this.lbAufgaben.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 344);
            this.Controls.Add(this.tcElemente);
            this.Controls.Add(this.lbProjekte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Notizmanager";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tcElemente.ResumeLayout(false);
            this.tpNotiz.ResumeLayout(false);
            this.tpTermin.ResumeLayout(false);
            this.tpAufgabe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dATEIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bEARBEITENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesProjektToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem neueNotizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuerTerminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueAufgabeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbProjekte;
        private System.Windows.Forms.TabControl tcElemente;
        private System.Windows.Forms.TabPage tpNotiz;
        private System.Windows.Forms.TabPage tpTermin;
        private System.Windows.Forms.TabPage tpAufgabe;
        private System.Windows.Forms.ListBox lbNotizen;
        private System.Windows.Forms.ListBox lbTermine;
        private System.Windows.Forms.ListBox lbAufgaben;
    }
}

