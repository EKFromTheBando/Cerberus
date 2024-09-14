using Cerberus.Cerberus.Forms.Dialogs;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Windows.Forms;
using static Cerberus.Cerberus.Forms.GameSaveResignerForm;

namespace Cerberus.Cerberus.Helpers
{
    internal class DialogExtensions
    {
        public static ListItem ShowListViewDialog(Form owner, string title, List<ListItem> items)
        {
            using (ListViewDialog listViewDialog = new ListViewDialog())
            {
                listViewDialog.Owner = owner;
                listViewDialog.Text = title;
                listViewDialog.Items = items;

                MethodInvoker dialog = delegate
                {
                    listViewDialog.ShowDialog();
                };

                if (owner.InvokeRequired)
                {
                    owner.Invoke(dialog);
                }
                else
                {
                    dialog.Invoke();
                }

                return listViewDialog.SelectedItem;
            }
        }

        public static string ShowFolderBrowseDialog(Form owner, string description)
        {
            using (XtraFolderBrowserDialog folderBrowser = new XtraFolderBrowserDialog())
            {
                folderBrowser.Description = description;
                folderBrowser.ShowNewFolderButton = true;
                return folderBrowser.ShowDialog(owner) == DialogResult.OK ? folderBrowser.SelectedPath : null;
            }
        }

        public static string ShowOpenFileDialog(Form owner, string title, string fileTypes)
        {
            using (XtraOpenFileDialog openFileDialog = new XtraOpenFileDialog())
            {
                openFileDialog.Title = title;
                openFileDialog.Filter = fileTypes;
                return openFileDialog.ShowDialog(owner) == DialogResult.OK ? openFileDialog.FileName : null;
            }
        }

        public static string ShowSaveFileDialog(Form owner, string title, string fileTypes)
        {
            using (XtraSaveFileDialog saveFileDialog = new XtraSaveFileDialog())
            {
                saveFileDialog.Title = title;
                saveFileDialog.Filter = fileTypes;
                return saveFileDialog.ShowDialog(owner) == DialogResult.OK ? saveFileDialog.FileName : null;
            }
        }
    }
}
