using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using static Cerberus.Cerberus.Forms.GameSaveResignerForm;

namespace Cerberus.Cerberus.Forms.Dialogs
{
    public partial class ListViewDialog : XtraForm
    {
        public ListViewDialog()
        {
            InitializeComponent();
        }

        public List<ListItem> Items { get; set; }

        public ListItem SelectedItem { get; set; }

        private void ListViewDialog_Load(object sender, EventArgs e)
        {
            // Set the text directly without using a resource language
            GroupListItems.Text = "Choose Item";

            using (DataTable dataTable = new DataTable())
            {
                // Define columns for the DataTable
                dataTable.Columns.Add("Value", typeof(string));
                dataTable.Columns.Add("Name", typeof(string));

                // Populate the DataTable with the Items list
                foreach (ListItem item in Items)
                {
                    dataTable.Rows.Add(item.Value, item.Name);
                }

                // Bind the DataTable to the GridControl
                GridControlListItems.DataSource = dataTable;
            }

            // Adjust GridView settings
            GridViewListItems.Columns[0].Visible = false;
            GridViewListItems.Columns[1].Width = GridViewListItems.Columns[1].GetBestWidth();

            // Dynamically resize the form to fit the list content
            if (Items.Count > 0)
            {
                Width = GridViewListItems.Columns[1].GetBestWidth() + 70;
                Refresh();
            }

            // Unselect the first row by default
            GridViewListItems.FocusedRowHandle = -1;
            GridViewListItems.UnselectRow(0);
        }

        private void GridViewListItems_RowClick(object sender, RowClickEventArgs e)
        {
            // Check if any rows are selected
            if (GridViewListItems.SelectedRowsCount > 0)
            {
                // Retrieve the selected item
                SelectedItem = new ListItem
                {
                    Name = GridViewListItems.GetRowCellDisplayText(e.RowHandle, "Name"),
                    Value = GridViewListItems.GetRowCellDisplayText(e.RowHandle, "Value")
                };

                // Close the dialog after selection
                Close();
            }
        }
    }
}
