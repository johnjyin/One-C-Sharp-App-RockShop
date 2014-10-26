using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockshop
{
    public partial class frmSelectRoyaltyOwners : Form
    {
        private int iroyaltyNo;
        private string sroyaltyName;
        private string sroyaltyAddress;

        dacRoyaltyOwner dacroyaltyowner;

        List<RoyaltyOwner> lstroyaltyowners;

        public DialogResult Result 
        { 
            get; 
            set; 
        }

        public int RoyaltyNo 
        {
            get
            {
                return iroyaltyNo; 
            }

            set
            {
                iroyaltyNo = value; 
            }
        }

        public string RoyaltyName
        {
            get
            {
                return sroyaltyName; 
            }

            set
            {
                sroyaltyName = value; 
            }
        }

        public string RoyaltyAddress 
        {
            get
            {
                return sroyaltyAddress; 
            }

            set
            {
                sroyaltyAddress = value; 
            }
        }

        public frmSelectRoyaltyOwners(int ioldRoyaltyNo)
        {
            InitializeComponent();

            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            dacroyaltyowner = new dacRoyaltyOwner();
            lstroyaltyowners = dacroyaltyowner.GetRoyaltyOwners();
            displayRoyaltyOwners(ioldRoyaltyNo);
        }

        private void displayRoyaltyOwners(int ioldRoyaltyNo)
        {
            //grdMedia.Rows.Clear();

            var source = new BindingSource();
            source.DataSource = lstroyaltyowners;
            grdRoyaltyOwners.DataSource = source;

            int i = 0;
            if (lstroyaltyowners.Count() == 0)
            {

            }
            else
            {
                if (ioldRoyaltyNo > 0)
                {
                    //objmedia = lstmedia.FirstOrDefault(x => x.productNo == iActiveProductNo);

                    foreach (RoyaltyOwner obj in lstroyaltyowners)
                    {
                        if (grdRoyaltyOwners.Rows[i].Cells[0].Value.ToString() == ioldRoyaltyNo.ToString())
                        {
                            break;
                        }
                        i++;
                    }

                }
                else
                {
                    //objmedia = lstmedia[0];
                }

                //set active row
                grdRoyaltyOwners.CurrentCell = grdRoyaltyOwners.Rows[i].Cells[0];
            }
        }


        private void grdRoyaltyOwners_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in grdRoyaltyOwners.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            try
            {
                if (cell != null)
                {
                    if (cell.RowIndex < this.grdRoyaltyOwners.RowCount
                        && cell.ColumnIndex < this.grdRoyaltyOwners.ColumnCount)
                    {
                        //.Enabled = true;

                        DataGridViewRow row = cell.OwningRow;
                        //objmedia = lstmedia.FirstOrDefault(x => x.productNo == Convert.ToInt32(row.Cells["ProductNo"].Value));

                        grdRoyaltyOwners.Rows[cell.RowIndex].Selected = true;

                        RoyaltyNo = Convert.ToInt32(row.Cells["RoyaltyNo"].Value);
                        RoyaltyName = row.Cells["RoyaltyName"].Value.ToString();
                        RoyaltyAddress = row.Cells["RoyaltyAddress"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Media Insert", MessageBoxButtons.OK);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

    }




}
