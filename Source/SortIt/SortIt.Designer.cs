namespace SortIt
{
    partial class SortIt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konfigurierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBox_showFile = new System.Windows.Forms.PictureBox();
            this.btn_LoadFiles = new System.Windows.Forms.Button();
            this.lbl_numberOfFoundFiles = new System.Windows.Forms.Label();
            this.btn_SelectSortFolders = new System.Windows.Forms.Button();
            this.panel_ShowSortFolders = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_showFile)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfigurierenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konfigurierenToolStripMenuItem
            // 
            this.konfigurierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem});
            this.konfigurierenToolStripMenuItem.Name = "konfigurierenToolStripMenuItem";
            this.konfigurierenToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.konfigurierenToolStripMenuItem.Text = "Konfigurieren";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // picBox_showFile
            // 
            this.picBox_showFile.Location = new System.Drawing.Point(446, 12);
            this.picBox_showFile.Name = "picBox_showFile";
            this.picBox_showFile.Size = new System.Drawing.Size(682, 758);
            this.picBox_showFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_showFile.TabIndex = 1;
            this.picBox_showFile.TabStop = false;
            // 
            // btn_LoadFiles
            // 
            this.btn_LoadFiles.Location = new System.Drawing.Point(11, 77);
            this.btn_LoadFiles.Name = "btn_LoadFiles";
            this.btn_LoadFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadFiles.TabIndex = 2;
            this.btn_LoadFiles.Text = "Load Files";
            this.btn_LoadFiles.UseVisualStyleBackColor = true;
            this.btn_LoadFiles.Click += new System.EventHandler(this.btn_LoadFiles_Click);
            // 
            // lbl_numberOfFoundFiles
            // 
            this.lbl_numberOfFoundFiles.AutoSize = true;
            this.lbl_numberOfFoundFiles.Location = new System.Drawing.Point(148, 82);
            this.lbl_numberOfFoundFiles.Name = "lbl_numberOfFoundFiles";
            this.lbl_numberOfFoundFiles.Size = new System.Drawing.Size(17, 13);
            this.lbl_numberOfFoundFiles.TabIndex = 4;
            this.lbl_numberOfFoundFiles.Text = "xx";
            // 
            // btn_SelectSortFolders
            // 
            this.btn_SelectSortFolders.Location = new System.Drawing.Point(11, 37);
            this.btn_SelectSortFolders.Name = "btn_SelectSortFolders";
            this.btn_SelectSortFolders.Size = new System.Drawing.Size(100, 23);
            this.btn_SelectSortFolders.TabIndex = 5;
            this.btn_SelectSortFolders.Text = "Sortier-Ordner auswählen";
            this.btn_SelectSortFolders.UseVisualStyleBackColor = true;
            this.btn_SelectSortFolders.Click += new System.EventHandler(this.btn_SelectSortFolders_Click);
            // 
            // panel_ShowSortFolders
            // 
            this.panel_ShowSortFolders.Location = new System.Drawing.Point(12, 129);
            this.panel_ShowSortFolders.Name = "panel_ShowSortFolders";
            this.panel_ShowSortFolders.Size = new System.Drawing.Size(410, 412);
            this.panel_ShowSortFolders.TabIndex = 6;
            // 
            // SortIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 782);
            this.Controls.Add(this.panel_ShowSortFolders);
            this.Controls.Add(this.btn_SelectSortFolders);
            this.Controls.Add(this.lbl_numberOfFoundFiles);
            this.Controls.Add(this.btn_LoadFiles);
            this.Controls.Add(this.picBox_showFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SortIt";
            this.Text = "ScanIt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_showFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konfigurierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBox_showFile;
        private System.Windows.Forms.Button btn_LoadFiles;
        private System.Windows.Forms.Label lbl_numberOfFoundFiles;
        private System.Windows.Forms.Button btn_SelectSortFolders;
        private System.Windows.Forms.FlowLayoutPanel panel_ShowSortFolders;
    }
}

