namespace GDBase
{
    partial class FormMain
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
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.columnGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxCoverArt = new System.Windows.Forms.PictureBox();
            this.comboBoxSystem = new System.Windows.Forms.ComboBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonManageCollection = new System.Windows.Forms.Button();
            this.labelSystem = new System.Windows.Forms.Label();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverArt)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnGame,
            this.columnSystem,
            this.columnYear});
            this.dataGridViewItems.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(558, 358);
            this.dataGridViewItems.TabIndex = 0;
            // 
            // columnGame
            // 
            this.columnGame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGame.FillWeight = 70F;
            this.columnGame.HeaderText = "Game";
            this.columnGame.Name = "columnGame";
            this.columnGame.ReadOnly = true;
            // 
            // columnSystem
            // 
            this.columnSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSystem.FillWeight = 70F;
            this.columnSystem.HeaderText = "System";
            this.columnSystem.Name = "columnSystem";
            this.columnSystem.ReadOnly = true;
            // 
            // columnYear
            // 
            this.columnYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnYear.FillWeight = 30F;
            this.columnYear.HeaderText = "Year";
            this.columnYear.Name = "columnYear";
            this.columnYear.ReadOnly = true;
            this.columnYear.ToolTipText = "Year";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(178, 45);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 47);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(160, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Text = "Search";
            // 
            // pictureBoxCoverArt
            // 
            this.pictureBoxCoverArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCoverArt.Location = new System.Drawing.Point(576, 82);
            this.pictureBoxCoverArt.Name = "pictureBoxCoverArt";
            this.pictureBoxCoverArt.Size = new System.Drawing.Size(199, 150);
            this.pictureBoxCoverArt.TabIndex = 3;
            this.pictureBoxCoverArt.TabStop = false;
            // 
            // comboBoxSystem
            // 
            this.comboBoxSystem.DropDownHeight = 200;
            this.comboBoxSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSystem.FormattingEnabled = true;
            this.comboBoxSystem.IntegralHeight = false;
            this.comboBoxSystem.Items.AddRange(new object[] {
            "All",
            "",
            "--Nintendo--",
            "Nes",
            "Snes",
            "N64",
            "Gamecube",
            "Wii",
            "Wii U",
            "Game Boy",
            "Game Boy Color",
            "Game Boy Advance",
            "DS",
            "3DS",
            "Virtual Boy",
            "",
            "--Sega--",
            "Master System",
            "Genesis",
            "Saturn",
            "Dreamcast",
            "",
            "--Sony--",
            "Playstation",
            "Playstation 2",
            "Playstation 3",
            "PSP",
            "PS Vita",
            "",
            "--Microsoft--",
            "Xbox",
            "Xbox 360",
            "Xbox One"});
            this.comboBoxSystem.Location = new System.Drawing.Point(309, 47);
            this.comboBoxSystem.MaxDropDownItems = 5;
            this.comboBoxSystem.Name = "comboBoxSystem";
            this.comboBoxSystem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSystem.TabIndex = 4;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(785, 24);
            this.menuStripMain.TabIndex = 5;
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "File";
            // 
            // buttonManageCollection
            // 
            this.buttonManageCollection.Location = new System.Drawing.Point(441, 46);
            this.buttonManageCollection.Name = "buttonManageCollection";
            this.buttonManageCollection.Size = new System.Drawing.Size(129, 23);
            this.buttonManageCollection.TabIndex = 6;
            this.buttonManageCollection.Text = "Manage Collection";
            this.buttonManageCollection.UseVisualStyleBackColor = true;
            this.buttonManageCollection.Click += new System.EventHandler(this.buttonManageCollection_Click);
            // 
            // labelSystem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Location = new System.Drawing.Point(262, 50);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(44, 13);
            this.labelSystem.TabIndex = 7;
            this.labelSystem.Text = "System:";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(152, 22);
            this.menuItemExit.Text = "Exit";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 452);
            this.Controls.Add(this.labelSystem);
            this.Controls.Add(this.buttonManageCollection);
            this.Controls.Add(this.comboBoxSystem);
            this.Controls.Add(this.pictureBoxCoverArt);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "GDBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverArt)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnYear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxCoverArt;
        private System.Windows.Forms.ComboBox comboBoxSystem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.Button buttonManageCollection;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

