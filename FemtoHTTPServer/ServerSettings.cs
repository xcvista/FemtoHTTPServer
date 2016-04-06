using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FemtoHTTPServer
{
    public partial class ServerSettings : Form
    {
        public ServerSettings()
        {
            InitializeComponent();
            validator = new HttpListener();
        }

        private Action<DialogResult> callback = null;
        private HttpListener validator;

        public void Show(Action<DialogResult> callback)
        {
            this.callback = callback;
            Show();
        }

        private void WebRootHighlight(object sender, EventArgs e)
        {
            WebRoot.Focus();
        }

        private void ChooseWebRoot(object sender, EventArgs e)
        {
            WebRootChooser.SelectedPath = Environment.ExpandEnvironmentVariables(WebRoot.Text);

            if (WebRootChooser.ShowDialog(this) == DialogResult.OK)
            {
                WebRoot.Text = WebRootChooser.SelectedPath;
            }
        }

        private void InitializeUserInterface(object sender, EventArgs e)
        {
            WebRoot.Text = Properties.Settings.Default.WebRoot;

            Ports.Items.Clear();
            foreach (var key in Properties.Settings.Default.Prefixes)
            {
                Ports.Items.Add(key);
            }
        }

        private new void Closed(object sender, FormClosedEventArgs e)
        {
            validator.Close();

            if (callback != null)
                callback(DialogResult);
        }

        private void ValidateData(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;

            string actualWebRoot = Environment.ExpandEnvironmentVariables(WebRoot.Text);
            if (!Directory.Exists(actualWebRoot))
            {
                MessageBox.Show(this, Properties.Resources.ERR_PATH_INVALID, Properties.Resources.UI_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            if (Ports.Items.Count <= 0)
            {
                MessageBox.Show(this, Properties.Resources.ERR_NO_PORT_DEFINED, Properties.Resources.UI_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            Properties.Settings.Default.WebRoot = WebRoot.Text;
            Properties.Settings.Default.Prefixes.Clear();
            foreach (ListViewItem item in Ports.Items)
            {
                Properties.Settings.Default.Prefixes.Add(item.Text);
            }
            Properties.Settings.Default.Save();
        }

        private void CloseOK(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CloseCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private ListViewItem newItem = null;

        private void AddPort(object sender, EventArgs e)
        {
            newItem = Ports.Items.Add(string.Empty);
            newItem.BeginEdit();
        }

        private void DeletePort(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Ports.SelectedItems)
                Ports.Items.Remove(item);
        }

        private void ValidateEdit(object sender, LabelEditEventArgs e)
        {
            ListViewItem item = Ports.Items[e.Item];

            try
            {
                validator.Prefixes.Add(e.Label);
            }
            catch
            {
                MessageBox.Show(this, Properties.Resources.ERR_PORT_SYNTAX, Properties.Resources.UI_ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
                if (item == newItem)
                    Ports.Items.Remove(newItem);
            }
            finally
            {
                newItem = null;
            }
        }

        private void ChangePort(object sender, EventArgs e)
        {
            if (Ports.SelectedItems.Count > 0)
            {
                Ports.SelectedItems[0].BeginEdit();
            }
        }

        private void ResetSettingsEx(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            InitializeUserInterface(sender, e);
        }
    }
}
