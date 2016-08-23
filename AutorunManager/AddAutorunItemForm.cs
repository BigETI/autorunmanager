using System;
using System.Windows.Forms;

namespace AutorunManager
{
    /// <summary>
    /// Add Autorun item form
    /// </summary>
    public partial class AddAutorunItemForm : Form
    {
        #region Attributes

        /// <summary>
        /// Name of the item
        /// </summary>
        private string name = "";

        /// <summary>
        /// File name
        /// </summary>
        private string file_name = "";

        /// <summary>
        /// Run parameters
        /// </summary>
        private string run_params = "";

        #endregion

        #region Getter and setter

        /// <summary>
        /// Autorun item name
        /// </summary>
        public string AutorunName
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Autorun item Value
        /// </summary>
        public string Value
        {
            get
            {
                return "\"" + file_name + "\" " + run_params;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public AddAutorunItemForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Show file dialog
        /// </summary>
        private void showFileDialog()
        {
            openFileDialog.FileName = textBoxFileName.Text;
            DialogResult result = openFileDialog.ShowDialog();
            DialogResult = DialogResult.None;
            if (result == DialogResult.OK)
                textBoxFileName.Text = openFileDialog.FileName;
        }

        /// <summary>
        /// Accept entry
        /// </summary>
        private void acceptEntry()
        {
            name = textBoxName.Text;
            file_name = textBoxFileName.Text;
            if (name.Trim().Length <= 0)
            {
                resetEntry();
                MessageBox.Show("Name must be valid", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (file_name.Trim().Length <= 0)
                {
                    resetEntry();
                    MessageBox.Show("File name must be valid", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    run_params = textBoxRunParameters.Text;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// Reset entry
        /// </summary>
        private void resetEntry()
        {
            name = "";
            file_name = "";
            run_params = "";
        }

        /// <summary>
        /// Cancel entry
        /// </summary>
        private void cancelEntry()
        {
            resetEntry();
            DialogResult = DialogResult.Cancel;
        }

        #endregion

        #region Events

        /// <summary>
        /// OK button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            acceptEntry();
        }

        /// <summary>
        /// Cancel button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancelEntry();
        }

        /// <summary>
        /// Text box key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void textBoxGeneric_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    acceptEntry();
                    break;
                case Keys.Escape:
                    cancelEntry();
                    break;
                case Keys.O:
                    if (e.Modifiers == Keys.Control)
                        showFileDialog();
                    break;
            }
        }

        /// <summary>
        /// File name button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Parameters</param>
        private void buttonFileName_Click(object sender, EventArgs e)
        {
            showFileDialog();
        }

        #endregion
    }
}
