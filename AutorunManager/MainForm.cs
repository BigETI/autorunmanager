using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace AutorunManager
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : Form
    {
        #region Attributes

        /// <summary>
        /// Selected autorun item
        /// </summary>
        private RegistryType selected_autorun_item = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Getter and setter

        /// <summary>
        /// User type key
        /// </summary>
        private RegistryKey User
        {
            get
            {
                RegistryKey ret = Registry.CurrentUser;
                if (radioButtonLocalMachine.Checked)
                    ret = Registry.LocalMachine;
                return ret;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Load Autorun key
        /// </summary>
        /// <returns></returns>
        private RegistryKey loadAutorunKey()
        {
            return User.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        }

        /// <summary>
        /// Load Autorun items
        /// </summary>
        private void loadAutorunItems()
        {
            RegistryKey key = loadAutorunKey();
            listViewAutorun.Items.Clear();
            if (key != null)
            {
                string[] values = key.GetValueNames();
                foreach (string i in values)
                {
                    ListViewItem l = listViewAutorun.Items.Add(i);
                    RegistryType rt = new RegistryType(i, key);
                    l.Tag = rt;
                    l.SubItems.Add(rt.Value.ToString());
                }
                key.Close();
            }
        }

        /// <summary>
        /// Add new Autorun item
        /// </summary>
        private void addNewAutorunItem()
        {
            AddAutorunItemForm aaif = new AddAutorunItemForm();
            DialogResult result = aaif.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
            {
                string name = aaif.AutorunName;
                string value = aaif.Value;
                RegistryKey key = loadAutorunKey();
                if (key != null)
                {
                    try
                    {
                        key.SetValue(name, value);
                    }
                    catch (Exception _e)
                    {
                        MessageBox.Show(_e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    key.Close();
                    loadAutorunItems();
                }
            }
        }

        /// <summary>
        /// Remove selected Autorun items
        /// </summary>
        private void removeSelectedAutorunItems()
        {
            ListView.SelectedListViewItemCollection slvi = listViewAutorun.SelectedItems;
            if (slvi.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you really want to remove the selected entries?", "Remove entries", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                if (result == DialogResult.OK)
                {
                    try
                    {
                        RegistryKey key = loadAutorunKey();
                        foreach (ListViewItem lvi in slvi)
                            key.DeleteValue(((RegistryType)(lvi.Tag)).Name);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    loadAutorunItems();
                }
            }
        }

        /// <summary>
        /// Save changes
        /// </summary>
        private void saveChanges()
        {
            if ((selected_autorun_item != null) && (textBoxName.Text.Trim().Length > 0))
            {
                RegistryKey key = loadAutorunKey();
                if (key != null)
                {
                    try
                    {
                        key.DeleteValue(selected_autorun_item.Name);
                        key.SetValue(textBoxName.Text, textBoxValue.Text);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    key.Close();
                    loadAutorunItems();
                }
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Exit button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Main form shown event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            loadAutorunItems();
        }

        /// <summary>
        /// Add new button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewAutorunItem();
        }

        /// <summary>
        /// Refresh button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadAutorunItems();
        }

        /// <summary>
        /// Radio button checked change event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void radioButtonGeneric_CheckedChanged(object sender, EventArgs e)
        {
            loadAutorunItems();
        }

        /// <summary>
        /// Add new click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addNewAutorunItem();
        }

        /// <summary>
        /// Remove selected click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void removeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeSelectedAutorunItems();
        }

        /// <summary>
        /// Remove selected click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void removeSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            removeSelectedAutorunItems();
        }

        /// <summary>
        /// Save changes click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void saveEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        /// <summary>
        /// Save changes button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        /// <summary>
        /// List view Autorun items item selection changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void listViewAutorun_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewAutorun.SelectedItems.Count == 1)
                selected_autorun_item = (RegistryType)(listViewAutorun.SelectedItems[0].Tag);
            else
                selected_autorun_item = null;
            bool selected = (selected_autorun_item != null);
            panelAttributes.Visible = selected;
            removeSelectedToolStripMenuItem.Enabled = selected;
            removeSelectedToolStripMenuItem1.Enabled = selected;
            buttonSave.Enabled = selected;
            saveEntryToolStripMenuItem.Enabled = selected;
            if (selected)
            {
                textBoxName.Text = selected_autorun_item.Name;
                textBoxValue.Text = selected_autorun_item.Value.ToString();
            }
        }

        #endregion
    }
}
