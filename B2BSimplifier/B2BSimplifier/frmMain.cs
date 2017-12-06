using B2BSimplifier.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2BSimplifier
{

    public partial class frmMain : Form
    {
        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;

        public DataTable parsedData = new DataTable();
        public frmMain()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
        }
        private void txtRedemption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string csvFileName = textBox1.Text;
                FileUtils fileUtils = new FileUtils();
                DataTable _result = fileUtils.FetchData(csvFileName, ",");

                dgvCSVData.DataSource = _result;

                TotalCheckBoxes = dgvCSVData.RowCount;
                TotalCheckedCheckBoxes = 0;
           

            }


        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            String csvFileName = string.Empty;
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Files|*.csv;";
            openFileDialog1.Title = "Please Select a CSV";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                csvFileName = openFileDialog1.FileName;
                textBox1.Text = csvFileName;

            }
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();

            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dgvCSVData.CellValueChanged += new DataGridViewCellEventHandler(dgvCSVData_CellValueChanged);
            dgvCSVData.CurrentCellDirtyStateChanged += new EventHandler(dgvCSVData_CurrentCellDirtyStateChanged);
            dgvCSVData.CellPainting += new DataGridViewCellPaintingEventHandler(dgvCSVData_CellPainting);

        }

        private void dgvCSVData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
                RowCheckBoxClick((DataGridViewCheckBoxCell)dgvCSVData[e.ColumnIndex, e.RowIndex]);
        }

        private void dgvCSVData_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCSVData.CurrentCell is DataGridViewCheckBoxCell)
                dgvCSVData.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                HeaderCheckBoxClick((CheckBox)sender);
        }

        private void dgvCSVData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();

            HeaderCheckBox.Size = new Size(15, 15);

            //Add the CheckBox into the DataGridView
            this.dgvCSVData.Controls.Add(HeaderCheckBox);
        }

        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.dgvCSVData.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();

            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;

            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dgvCSVData.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chkBxSelect"]).Value = HCheckBox.Checked;

            dgvCSVData.RefreshEdit();

            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

            IsHeaderCheckBoxClicked = false;
        }

        private void RowCheckBoxClick(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox != null)
            {
                //Modifiy Counter;            
                if ((bool)RCheckBox.Value && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                //Change state of the header CheckBox.
                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
        }

        private void btnOnBoard_Click(object sender, EventArgs e)
        {
            UserCollection SelectedUsers = new UserCollection();
            if (txtRedemption.Text.Length > 0)
            {
                SelectedUsers.DelayedRedemption = Convert.ToInt16(txtRedemption.Text);
                SelectedUsers.SupressInvite = chkbSupressInvite.Checked;
            }
            List<UserInfo> _usersInfo = new List<UserInfo>();
            List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvCSVData.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    rows_with_checked_column.Add(row);
                    _usersInfo.Add(new UserInfo { UserEmail = row.Cells["UserEmail"].Value.ToString(), UserName = row.Cells["UserName"].Value.ToString(), IsExternal = Convert.ToBoolean(row.Cells["IsExternal"].Value) });
                }
            }

            SelectedUsers.Users = _usersInfo;
        }
    }
}
 
 
