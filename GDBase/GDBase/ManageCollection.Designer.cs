namespace GDBase
{
    partial class ManageCollection
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
            this.tabManage = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.comboBoxSystemAdd = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelOwned = new System.Windows.Forms.Label();
            this.textBoxYearAdd = new System.Windows.Forms.TextBox();
            this.labelYearAdd = new System.Windows.Forms.Label();
            this.textBoxNameAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSystemAdd = new System.Windows.Forms.Label();
            this.labelNameAdd = new System.Windows.Forms.Label();
            this.tabRemove = new System.Windows.Forms.TabPage();
            this.dataGridViewRemoveList = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabManage.SuspendLayout();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.tabAdd);
            this.tabManage.Controls.Add(this.tabRemove);
            this.tabManage.Controls.Add(this.tabEdit);
            this.tabManage.Controls.Add(this.tabOptions);
            this.tabManage.Location = new System.Drawing.Point(13, 12);
            this.tabManage.Name = "tabManage";
            this.tabManage.SelectedIndex = 0;
            this.tabManage.Size = new System.Drawing.Size(530, 336);
            this.tabManage.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.comboBoxSystemAdd);
            this.tabAdd.Controls.Add(this.numericUpDown1);
            this.tabAdd.Controls.Add(this.labelOwned);
            this.tabAdd.Controls.Add(this.textBoxYearAdd);
            this.tabAdd.Controls.Add(this.labelYearAdd);
            this.tabAdd.Controls.Add(this.textBoxNameAdd);
            this.tabAdd.Controls.Add(this.buttonAdd);
            this.tabAdd.Controls.Add(this.labelSystemAdd);
            this.tabAdd.Controls.Add(this.labelNameAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(522, 310);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxSystemAdd
            // 
            this.comboBoxSystemAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSystemAdd.FormattingEnabled = true;
            this.comboBoxSystemAdd.Items.AddRange(new object[] {
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
            "Xbox One",
            "",
            "PC"});
            this.comboBoxSystemAdd.Location = new System.Drawing.Point(267, 31);
            this.comboBoxSystemAdd.Name = "comboBoxSystemAdd";
            this.comboBoxSystemAdd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSystemAdd.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // labelOwned
            // 
            this.labelOwned.AutoSize = true;
            this.labelOwned.Location = new System.Drawing.Point(85, 60);
            this.labelOwned.Name = "labelOwned";
            this.labelOwned.Size = new System.Drawing.Size(41, 13);
            this.labelOwned.TabIndex = 7;
            this.labelOwned.Text = "Owned";
            // 
            // textBoxYearAdd
            // 
            this.textBoxYearAdd.Location = new System.Drawing.Point(16, 77);
            this.textBoxYearAdd.Name = "textBoxYearAdd";
            this.textBoxYearAdd.Size = new System.Drawing.Size(52, 20);
            this.textBoxYearAdd.TabIndex = 6;
            this.textBoxYearAdd.Text = "Year";
            // 
            // labelYearAdd
            // 
            this.labelYearAdd.AutoSize = true;
            this.labelYearAdd.Location = new System.Drawing.Point(13, 60);
            this.labelYearAdd.Name = "labelYearAdd";
            this.labelYearAdd.Size = new System.Drawing.Size(29, 13);
            this.labelYearAdd.TabIndex = 5;
            this.labelYearAdd.Text = "Year";
            // 
            // textBoxNameAdd
            // 
            this.textBoxNameAdd.Location = new System.Drawing.Point(16, 32);
            this.textBoxNameAdd.Name = "textBoxNameAdd";
            this.textBoxNameAdd.Size = new System.Drawing.Size(235, 20);
            this.textBoxNameAdd.TabIndex = 1;
            this.textBoxNameAdd.Text = "Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(176, 75);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSystemAdd
            // 
            this.labelSystemAdd.AutoSize = true;
            this.labelSystemAdd.Location = new System.Drawing.Point(264, 15);
            this.labelSystemAdd.Name = "labelSystemAdd";
            this.labelSystemAdd.Size = new System.Drawing.Size(41, 13);
            this.labelSystemAdd.TabIndex = 3;
            this.labelSystemAdd.Text = "System";
            // 
            // labelNameAdd
            // 
            this.labelNameAdd.AutoSize = true;
            this.labelNameAdd.Location = new System.Drawing.Point(13, 16);
            this.labelNameAdd.Name = "labelNameAdd";
            this.labelNameAdd.Size = new System.Drawing.Size(35, 13);
            this.labelNameAdd.TabIndex = 2;
            this.labelNameAdd.Text = "Name";
            // 
            // tabRemove
            // 
            this.tabRemove.Controls.Add(this.dataGridViewRemoveList);
            this.tabRemove.Controls.Add(this.buttonRemove);
            this.tabRemove.Location = new System.Drawing.Point(4, 22);
            this.tabRemove.Name = "tabRemove";
            this.tabRemove.Size = new System.Drawing.Size(522, 310);
            this.tabRemove.TabIndex = 1;
            this.tabRemove.Text = "Remove";
            this.tabRemove.UseVisualStyleBackColor = true;
            this.tabRemove.Enter += new System.EventHandler(this.tabRemove_Enter);
            // 
            // dataGridViewRemoveList
            // 
            this.dataGridViewRemoveList.AllowUserToAddRows = false;
            this.dataGridViewRemoveList.AllowUserToDeleteRows = false;
            this.dataGridViewRemoveList.AllowUserToResizeRows = false;
            this.dataGridViewRemoveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemoveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName});
            this.dataGridViewRemoveList.Location = new System.Drawing.Point(185, 16);
            this.dataGridViewRemoveList.Name = "dataGridViewRemoveList";
            this.dataGridViewRemoveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRemoveList.Size = new System.Drawing.Size(323, 278);
            this.dataGridViewRemoveList.TabIndex = 3;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(104, 271);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // tabEdit
            // 
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(522, 310);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // tabOptions
            // 
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(522, 310);
            this.tabOptions.TabIndex = 3;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(468, 354);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ManageCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 382);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageCollection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageCollection";
            this.tabManage.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabRemove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManage;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxYearAdd;
        private System.Windows.Forms.Label labelYearAdd;
        private System.Windows.Forms.Label labelSystemAdd;
        private System.Windows.Forms.Label labelNameAdd;
        private System.Windows.Forms.TextBox textBoxNameAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabPage tabRemove;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView dataGridViewRemoveList;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelOwned;
        private System.Windows.Forms.ComboBox comboBoxSystemAdd;
    }
}