namespace AutorunManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAutorunItems = new System.Windows.Forms.Panel();
            this.listViewAutorun = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxUserType = new System.Windows.Forms.GroupBox();
            this.radioButtonLocalMachine = new System.Windows.Forms.RadioButton();
            this.radioButtonCurrentUser = new System.Windows.Forms.RadioButton();
            this.contextMenuStripAutorunItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAttributes = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.saveEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelAutorunItems.SuspendLayout();
            this.groupBoxUserType.SuspendLayout();
            this.contextMenuStripAutorunItems.SuspendLayout();
            this.panelAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.removeSelectedToolStripMenuItem1,
            this.saveEntryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // panelAutorunItems
            // 
            this.panelAutorunItems.Controls.Add(this.listViewAutorun);
            this.panelAutorunItems.Controls.Add(this.groupBoxUserType);
            this.panelAutorunItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAutorunItems.Location = new System.Drawing.Point(0, 24);
            this.panelAutorunItems.Name = "panelAutorunItems";
            this.panelAutorunItems.Size = new System.Drawing.Size(400, 471);
            this.panelAutorunItems.TabIndex = 4;
            // 
            // listViewAutorun
            // 
            this.listViewAutorun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderStart});
            this.listViewAutorun.ContextMenuStrip = this.contextMenuStripAutorunItems;
            this.listViewAutorun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAutorun.Location = new System.Drawing.Point(0, 42);
            this.listViewAutorun.Name = "listViewAutorun";
            this.listViewAutorun.Size = new System.Drawing.Size(400, 429);
            this.listViewAutorun.TabIndex = 3;
            this.listViewAutorun.UseCompatibleStateImageBehavior = false;
            this.listViewAutorun.View = System.Windows.Forms.View.Details;
            this.listViewAutorun.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewAutorun_ItemSelectionChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Application";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderStart
            // 
            this.columnHeaderStart.Text = "Start parameters";
            this.columnHeaderStart.Width = 200;
            // 
            // groupBoxUserType
            // 
            this.groupBoxUserType.Controls.Add(this.radioButtonLocalMachine);
            this.groupBoxUserType.Controls.Add(this.radioButtonCurrentUser);
            this.groupBoxUserType.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUserType.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUserType.Name = "groupBoxUserType";
            this.groupBoxUserType.Size = new System.Drawing.Size(400, 42);
            this.groupBoxUserType.TabIndex = 2;
            this.groupBoxUserType.TabStop = false;
            this.groupBoxUserType.Text = "User type";
            // 
            // radioButtonLocalMachine
            // 
            this.radioButtonLocalMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLocalMachine.AutoSize = true;
            this.radioButtonLocalMachine.Location = new System.Drawing.Point(300, 19);
            this.radioButtonLocalMachine.Name = "radioButtonLocalMachine";
            this.radioButtonLocalMachine.Size = new System.Drawing.Size(94, 17);
            this.radioButtonLocalMachine.TabIndex = 1;
            this.radioButtonLocalMachine.Text = "Local machine";
            this.radioButtonLocalMachine.UseVisualStyleBackColor = true;
            this.radioButtonLocalMachine.CheckedChanged += new System.EventHandler(this.radioButtonGeneric_CheckedChanged);
            // 
            // radioButtonCurrentUser
            // 
            this.radioButtonCurrentUser.AutoSize = true;
            this.radioButtonCurrentUser.Checked = true;
            this.radioButtonCurrentUser.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCurrentUser.Name = "radioButtonCurrentUser";
            this.radioButtonCurrentUser.Size = new System.Drawing.Size(82, 17);
            this.radioButtonCurrentUser.TabIndex = 0;
            this.radioButtonCurrentUser.TabStop = true;
            this.radioButtonCurrentUser.Text = "Current user";
            this.radioButtonCurrentUser.UseVisualStyleBackColor = true;
            this.radioButtonCurrentUser.CheckedChanged += new System.EventHandler(this.radioButtonGeneric_CheckedChanged);
            // 
            // contextMenuStripAutorunItems
            // 
            this.contextMenuStripAutorunItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.removeSelectedToolStripMenuItem});
            this.contextMenuStripAutorunItems.Name = "contextMenuStripAutorunItems";
            this.contextMenuStripAutorunItems.Size = new System.Drawing.Size(164, 70);
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.addNewToolStripMenuItem1.Text = "Add new...";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Enabled = false;
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // removeSelectedToolStripMenuItem1
            // 
            this.removeSelectedToolStripMenuItem1.Enabled = false;
            this.removeSelectedToolStripMenuItem1.Name = "removeSelectedToolStripMenuItem1";
            this.removeSelectedToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeSelectedToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.removeSelectedToolStripMenuItem1.Text = "Remove selected";
            this.removeSelectedToolStripMenuItem1.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem1_Click);
            // 
            // panelAttributes
            // 
            this.panelAttributes.Controls.Add(this.labelValue);
            this.panelAttributes.Controls.Add(this.labelName);
            this.panelAttributes.Controls.Add(this.buttonSave);
            this.panelAttributes.Controls.Add(this.textBoxValue);
            this.panelAttributes.Controls.Add(this.textBoxName);
            this.panelAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttributes.Location = new System.Drawing.Point(400, 24);
            this.panelAttributes.Name = "panelAttributes";
            this.panelAttributes.Size = new System.Drawing.Size(460, 471);
            this.panelAttributes.TabIndex = 9;
            this.panelAttributes.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(76, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(372, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValue.Location = new System.Drawing.Point(76, 29);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(372, 20);
            this.textBoxValue.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(76, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(372, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(400, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 471);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // saveEntryToolStripMenuItem
            // 
            this.saveEntryToolStripMenuItem.Enabled = false;
            this.saveEntryToolStripMenuItem.Name = "saveEntryToolStripMenuItem";
            this.saveEntryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveEntryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveEntryToolStripMenuItem.Text = "Save changes";
            this.saveEntryToolStripMenuItem.Click += new System.EventHandler(this.saveEntryToolStripMenuItem_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(6, 32);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(64, 13);
            this.labelValue.TabIndex = 13;
            this.labelValue.Text = "Run options";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 495);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelAttributes);
            this.Controls.Add(this.panelAutorunItems);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AutorunManager";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAutorunItems.ResumeLayout(false);
            this.groupBoxUserType.ResumeLayout(false);
            this.groupBoxUserType.PerformLayout();
            this.contextMenuStripAutorunItems.ResumeLayout(false);
            this.panelAttributes.ResumeLayout(false);
            this.panelAttributes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel panelAutorunItems;
        private System.Windows.Forms.ListView listViewAutorun;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderStart;
        private System.Windows.Forms.GroupBox groupBoxUserType;
        private System.Windows.Forms.RadioButton radioButtonLocalMachine;
        private System.Windows.Forms.RadioButton radioButtonCurrentUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAutorunItems;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveEntryToolStripMenuItem;
        private System.Windows.Forms.Panel panelAttributes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelName;
    }
}

