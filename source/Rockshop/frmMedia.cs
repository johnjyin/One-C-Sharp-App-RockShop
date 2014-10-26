#define DEBUG

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

/// <summary>
/// Required designer variable.
/// author: john yin
/// version: v0.3
/// create date: 5/5/2014
/// last update data: 23/5/2014
/// </summary>
/// 

namespace Rockshop
{


    public partial class frmMedia : Form
    {
        Media objmedia;
        dacMedia dacmedia;
        //dacMySQLConn dacmySql;
        List <Media> lstmedia;

        const bool bReq = true;
        const bool bOpt = false;
        static int quickMediaCount = 0;
        DateTime quickMediaBaseDate = DateTime.Parse("15/11/2013");


        public frmMedia()
        {
            InitializeComponent();


            this.ActiveControl = txtProductName;

            dacmedia = new dacMedia();
            lstmedia = dacmedia.GetMedias();
            displayMediaList(-1);

        }


        private void displayMediaList(int iActiveProductNo)
        {
            //grdMedia.Rows.Clear();

            var source = new BindingSource();
            
            // define DataGridView Column Title
            grdMedia.AutoGenerateColumns = false;
            grdMedia.Columns.Clear();

            DataGridViewTextBoxColumn colProductNo = new DataGridViewTextBoxColumn();
            colProductNo.DataPropertyName = "productNo";
            colProductNo.HeaderText = "Product No";
            colProductNo.Name = "ProductNo";
            grdMedia.Columns.Add(colProductNo);

            DataGridViewTextBoxColumn colProductName = new DataGridViewTextBoxColumn();
            colProductName.DataPropertyName = "productName";
            colProductName.HeaderText = "Product Name";
            colProductName.Name = "ProductName";
            grdMedia.Columns.Add(colProductName);

            DataGridViewTextBoxColumn colProductType = new DataGridViewTextBoxColumn();
            colProductType.DataPropertyName = "productType";
            colProductType.HeaderText = "Product Type";
            colProductType.Name = "ProductType";
            grdMedia.Columns.Add(colProductType);

            DataGridViewTextBoxColumn colFileType = new DataGridViewTextBoxColumn();
            colFileType.DataPropertyName = "fileType";
            colFileType.HeaderText = "File Type";
            colFileType.Name = "FileType";
            grdMedia.Columns.Add(colFileType);

            DataGridViewTextBoxColumn colUrlSampler = new DataGridViewTextBoxColumn();
            colUrlSampler.DataPropertyName = "urlSampler";
            colUrlSampler.HeaderText = "URL Sampler";
            colUrlSampler.Name = "UrlSampler";
            grdMedia.Columns.Add(colUrlSampler);

            DataGridViewTextBoxColumn colUrlMedia = new DataGridViewTextBoxColumn();
            colUrlMedia.DataPropertyName = "urlMedia";
            colUrlMedia.HeaderText = "URL Media";
            colUrlMedia.Name = "UrlMedia";
            grdMedia.Columns.Add(colUrlMedia);

            DataGridViewTextBoxColumn colUnitPrice = new DataGridViewTextBoxColumn();
            colUnitPrice.DataPropertyName = "unitPrice";
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "UnitPrice";
            grdMedia.Columns.Add(colUnitPrice);

            DataGridViewTextBoxColumn colRoyaltyNo = new DataGridViewTextBoxColumn();
            colRoyaltyNo.DataPropertyName = "royaltyNo";
            colRoyaltyNo.HeaderText = "Royalty No";
            colRoyaltyNo.Name = "RoyaltyNo";
            grdMedia.Columns.Add(colRoyaltyNo);

            DataGridViewTextBoxColumn colRoyaltyOwner = new DataGridViewTextBoxColumn();
            colRoyaltyOwner.DataPropertyName = "royaltyOwner";
            colRoyaltyOwner.HeaderText = "Royalty Owner";
            colRoyaltyOwner.Name = "RoyaltyOwner";
            grdMedia.Columns.Add(colRoyaltyOwner);

            DataGridViewTextBoxColumn colRoyaltyAddress = new DataGridViewTextBoxColumn();
            colRoyaltyAddress.DataPropertyName = "royaltyAddress";
            colRoyaltyAddress.HeaderText = "Royalty Address";
            colRoyaltyAddress.Name = "RoyaltyAddress";
            grdMedia.Columns.Add(colRoyaltyAddress);

            DataGridViewTextBoxColumn colUnitRoyalty = new DataGridViewTextBoxColumn();
            colUnitRoyalty.DataPropertyName = "unitRoyalty";
            colUnitRoyalty.HeaderText = "Unit Royalty";
            colUnitRoyalty.Name = "UnitRoyalty";
            grdMedia.Columns.Add(colUnitRoyalty);

            DataGridViewTextBoxColumn colDateAdded = new DataGridViewTextBoxColumn();
            colDateAdded.DataPropertyName = "dateAdded";
            colDateAdded.HeaderText = "Date Added";
            colDateAdded.Name = "DateAdded";
            grdMedia.Columns.Add(colDateAdded);

            source.DataSource = lstmedia;
            grdMedia.DataSource = source;
           
            int i = 0;
            if (lstmedia.Count() == 0)
            {
                grdMedia.ReadOnly = true;
                objmedia = new Media();
                // clear datagrid view
                txtProductNo.Text = "";
                txtProductName.Text = "";
                txtProductType.Text = "";
                txtFileType.Text = "";
                txtUrlSampler.Text = "";
                txtUrlMedia.Text = "";
                txtUnitPrice.Text = "";
                txtRoyaltyNo.Text = "";
                txtUnitRoyalty.Text = "";
                txtDateAdded.Text = "";
            }
            else
            {
                if (iActiveProductNo > 0)
                {
                    // lambda expression
                    objmedia = lstmedia.FirstOrDefault(x => x.productNo == iActiveProductNo);

                    foreach (Media obj in lstmedia)
                    {
                        if (grdMedia.Rows[i].Cells[0].Value.ToString() == iActiveProductNo.ToString())
                        {
                            break;
                        }
                        i++;
                    }

                }
                else
                {
                    objmedia = lstmedia[0];
                }

                //set active row
                grdMedia.CurrentCell = grdMedia.Rows[i].Cells[0];
            }
        }

        /* -----------------------------------------------------------------

            Read Media From Database 
            - And Refresh Data Grid View 
            - And Refresh All Text Field On Form

        --------------------------------------------------------------------*/

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstmedia = dacmedia.GetMedias();
            displayMediaList(-1);
        }

        /* -----------------------------------------------------------------

            Whenever Data Grid View Changed
            - To Reset the Active Media Object: objmedia
            - And Show Its Fields On Form

        --------------------------------------------------------------------*/

        private void grdMedia_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in grdMedia.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            try
            {
                if (cell != null && grdMedia.ColumnCount >= 12) 
                {
                    if (cell.RowIndex < this.grdMedia.RowCount
                        && cell.ColumnIndex < this.grdMedia.ColumnCount)
                    {
                        menuStrip1.Enabled = true;

                        DataGridViewRow row = cell.OwningRow;
                        objmedia = lstmedia.FirstOrDefault(x => x.productNo == Convert.ToInt32(row.Cells["ProductNo"].Value));

                        grdMedia.Rows[cell.RowIndex].Selected = true;

                        txtProductNo.Text = row.Cells["ProductNo"].Value.ToString();
                        txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                        txtProductType.Text = row.Cells["ProductType"].Value.ToString();
                        txtFileType.Text = row.Cells["FileType"].Value.ToString();
                        txtUrlSampler.Text = row.Cells["UrlSampler"].Value.ToString();
                        txtUrlMedia.Text = row.Cells["UrlMedia"].Value.ToString();
                        txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                        txtRoyaltyNo.Text = row.Cells["RoyaltyNo"].Value.ToString();
                        txtRoyaltyOwner.Text = row.Cells["RoyaltyOwner"].Value.ToString();
                        txtRoyaltyAddress.Text = row.Cells["RoyaltyAddress"].Value.ToString();
                        txtUnitRoyalty.Text = row.Cells["UnitRoyalty"].Value.ToString();
                        txtDateAdded.Text = DateTime.Parse(row.Cells["DateAdded"].Value.ToString()).ToString("dd-MM-yyyy");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception in Selection Changed Event with Message!", MessageBoxButtons.OK);
            }
        }

        /* -----------------------------------------------------------------

            Insert One Media

        --------------------------------------------------------------------*/

        private void mnuInsert_Click(object sender, EventArgs e)
        {
            insertMedia();
        }

        private void insertMedia()
        {
            try
            {
                objmedia.validateProductName(txtProductName.Text, true);
                objmedia.validateProductType(txtProductType.Text, true);
                objmedia.validateFileType(txtFileType.Text, true);
                objmedia.validateUrlSampler(txtUrlSampler.Text, true);
                objmedia.validateUrlMedia(txtUrlMedia.Text, true);
                objmedia.validateUnitPrice(txtUnitPrice.Text, true);
                objmedia.validateRoyaltyNo(txtRoyaltyNo.Text, true);
                objmedia.validateUnitRoyalty(txtUnitRoyalty.Text, true);
                objmedia.validateDateAdded(txtDateAdded.Text, true);
                int count = dacmedia.Insert(objmedia);
                switch (count)
                {
                    case -1:
                        throw new Exception("Search aborted, no search criteria supplied");
                    case 0:
                        throw new Exception("Product failed to add, Product may already be on file");
                    case 1:
                        int iNewProductNo = dacmedia.LastUsedProductNo();
                        txtProductNo.Text = iNewProductNo.ToString();
                        lstmedia = dacmedia.GetMedias();
                        displayMediaList(iNewProductNo);
                        //objmedia = lstmedia.FirstOrDefault(x => x.productNo == iNewProductNo);
                        break;
                    default:
                        throw new Exception("Database corrupted, Inform DBA, presss any key to abort");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Media Insert", MessageBoxButtons.OK);
            }
        }

        /* -----------------------------------------------------------------

            Quickly Insert One Media

        --------------------------------------------------------------------*/

        private void quickMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quickMedia();
        }

        private void quickMedia()
        {
            String si, sFileType = "";
            DateTime dteDateAdded;
            if (quickMediaCount == 0)
            {
                quickMediaCount = dacmedia.LastUsedProductNo() + 1;
            }
            else
            {
                quickMediaCount += 1;
            }

            si = String.Format("{0:0000}", quickMediaCount);

            txtProductNo.Text = "";
            txtProductName.Text = "ProductName" + si;
            txtProductType.Text = quickMediaCount.ToString();

            switch (quickMediaCount % 3)
            {
                case 0:
                    sFileType = "avi";
                    break;
                case 1:
                    sFileType = "mov";
                    break;
                case 2:
                    sFileType = "jpg";
                    break;
            }

            txtFileType.Text = sFileType.ToString();
            txtUrlSampler.Text = "URLSampler" + si;
            txtUrlMedia.Text = "URLMedia" + si;
            txtUnitPrice.Text = String.Format("{0:0.00}", 10 * quickMediaCount);
            Random rnd = new Random();
            txtRoyaltyNo.Text = string.Format("{0}", rnd.Next(1, 5)); // creates a number between 1 and 5
            txtUnitRoyalty.Text = String.Format("{0:0.00}", quickMediaCount);
            dteDateAdded = quickMediaBaseDate.AddDays(quickMediaCount);
            txtDateAdded.Text = dteDateAdded.ToString("dd-MM-yyyy");
        }

        /* -----------------------------------------------------------------

            Delete Media

        --------------------------------------------------------------------*/

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iDelProductNo;
            if (int.TryParse(txtProductNo.Text, out iDelProductNo))
            {
                deleteMedia(iDelProductNo);
            }
            else
            {
                MessageBox.Show("Please check Product No: " + txtProductNo.ToString(), "Media Delete", MessageBoxButtons.OK);
            }
        }

        private bool deleteMedia(int iProductNo)
        {
            bool bResult = true;
            try
            {
                Media mediaToDelete = lstmedia.SingleOrDefault(x => x.productNo == iProductNo);
                if (mediaToDelete != null)
                {
                    DialogResult dr = MessageBox.Show("Confirm Delete Media: ProductNo = " + mediaToDelete.productNo.ToString()
                                                    + "; Name = " + mediaToDelete.productName + " !",
                                                        "Delete Media", MessageBoxButtons.YesNo, 
                                                        MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        int count = dacmedia.Delete(mediaToDelete);
                        switch (count)
                        {
                            case -1:
                                throw new Exception("Delete Exception by returning -1, and inform DBA!");
                            case 0:
                                throw new Exception("Delete failed by returning 0, and inform DBA!");
                            case 1:
                                lstmedia = dacmedia.GetMedias();
                                displayMediaList(-1);
                                MessageBox.Show("Delete successful", "Media Delete", MessageBoxButtons.OK);
                                break;
                            default:
                                throw new Exception("Database corrupted, Inform DBA, press any key to abort!");
                        }
                    }
                    else
                    {
                        bResult = false;
                    }
                }
                return bResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Media Delete failed", MessageBoxButtons.OK);
                return false;
            }
        }

        /* -----------------------------------------------------------------

            Update Media

        --------------------------------------------------------------------*/

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMedia();
        }

        public void updateMedia()
        {
            try
            {
                objmedia.validateProductName(txtProductName.Text, true);
                objmedia.validateProductType(txtProductType.Text, true);
                objmedia.validateFileType(txtFileType.Text, true);
                objmedia.validateUrlSampler(txtUrlSampler.Text, true);
                objmedia.validateUrlMedia(txtUrlMedia.Text, true);
                objmedia.validateUnitPrice(txtUnitPrice.Text, true);
                objmedia.validateRoyaltyNo(txtRoyaltyNo.Text, true);
                objmedia.validateUnitRoyalty(txtUnitRoyalty.Text, true);
                objmedia.validateDateAdded(txtDateAdded.Text, true);
                int count = dacmedia.Update(objmedia);

                switch (count)
                {
                    case -1:
                        throw new Exception("Update Exception by returning -1, and inform DBA!");
                    case 0:
                        throw new Exception("Update failed by returning 0, and inform DBA!");
                    case 1:
                        lstmedia = dacmedia.GetMedias();
                        displayMediaList(objmedia.productNo);
                        MessageBox.Show("Update successful", "Media Save", MessageBoxButtons.OK);
                        break;
                    default:
                        throw new Exception("Database corrupted, Inform DBA, press any key to abort!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Media", MessageBoxButtons.OK);
            }
        }

        /* -----------------------------------------------------------------

            Search Media

        --------------------------------------------------------------------*/

        private void allSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchMedia();
        }

        public void searchMedia()
        {
            try
            {
                objmedia.validateProductName(txtProductName.Text, true);
                objmedia.validateProductType(txtProductType.Text, true);
                objmedia.validateFileType(txtFileType.Text, true);
                objmedia.validateUrlSampler(txtUrlSampler.Text, true);
                objmedia.validateUrlMedia(txtUrlMedia.Text, true);
                objmedia.validateUnitPrice(txtUnitPrice.Text, true);
                objmedia.validateRoyaltyNo(txtRoyaltyNo.Text, true);
                objmedia.validateUnitRoyalty(txtUnitRoyalty.Text, true);
                objmedia.validateDateAdded(txtDateAdded.Text, true);
                bool ok = dacmedia.Search(objmedia, ref lstmedia);
                if (ok)
                {
                    switch (lstmedia.Count)
                    {
                        case 0:
                            MessageBox.Show("No records found, \r check the search criteria before repeating the query",
                                "Media Search", MessageBoxButtons.OK);
                            break;
                        case 1:
                            displayMediaList(-1);
                            break;
                        default:
                            displayMediaList(-1);
                            break;
                    }
                }
                else
                {
                    grdMedia.Rows.Clear();
                    objmedia = new Media();
                    // clear datagrid view
                    txtProductNo.Text = "";
                    txtProductName.Text = "";
                    txtProductType.Text = "";
                    txtFileType.Text = "";
                    txtUrlSampler.Text = "";
                    txtUrlMedia.Text = "";
                    txtUnitPrice.Text = "";
                    txtRoyaltyNo.Text = "";
                    txtUnitRoyalty.Text = "";
                    txtDateAdded.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Media Search", MessageBoxButtons.OK);
            }
        }

        private void advSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advSearchMedia();
        }

        public void advSearchMedia()
        {
            try
            {
                objmedia.validateProductName(txtProductName.Text, false);
                objmedia.validateProductType(txtProductType.Text, false);
                objmedia.validateFileType(txtFileType.Text, false);
                objmedia.validateUrlSampler(txtUrlSampler.Text, false);
                objmedia.validateUrlMedia(txtUrlMedia.Text, false);
                objmedia.validateUnitPrice(txtUnitPrice.Text, false);
                objmedia.validateRoyaltyNo(txtRoyaltyNo.Text, false);
                objmedia.validateUnitRoyalty(txtUnitRoyalty.Text, false);
                objmedia.validateDateAdded(txtDateAdded.Text, false);

                bool ok = dacmedia.Search(objmedia, ref lstmedia);
                
                if (ok)
                {
                    switch (lstmedia.Count)
                    {
                        case 0:
                            MessageBox.Show("No records found, \r check the search criteria before repeating the query",
                                "Media Search", MessageBoxButtons.OK);
                            break;
                        case 1:
                            displayMediaList(-1);
                            break;
                        default:
                            displayMediaList(-1);
                            break;
                    }
                }
                else
                {
                    grdMedia.Rows.Clear();
                    objmedia = new Media();
                    // clear datagrid view
                    txtProductNo.Text = "";
                    txtProductName.Text = "";
                    txtProductType.Text = "";
                    txtFileType.Text = "";
                    txtUrlSampler.Text = "";
                    txtUrlMedia.Text = "";
                    txtUnitPrice.Text = "";
                    txtRoyaltyNo.Text = "";
                    txtUnitRoyalty.Text = "";
                    txtDateAdded.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advanced Media Search", MessageBoxButtons.OK);
            }
        }

        /* -----------------------------------------------------------------

            Select Royalty Owners
            So To Change The Active Media's Royalty Owner

        --------------------------------------------------------------------*/

        private void btnRoyaltyOwners_Click(object sender, EventArgs e)
        {
            int ioldRoyaltyNo = objmedia.royaltyNo;


            frmSelectRoyaltyOwners selectOwners = new frmSelectRoyaltyOwners(ioldRoyaltyNo);

            // center position child form
            selectOwners.StartPosition = FormStartPosition.CenterParent;

            if (selectOwners.ShowDialog(this) == DialogResult.OK)
            {
                this.txtRoyaltyNo.Text = selectOwners.RoyaltyNo.ToString();
                this.txtRoyaltyOwner.Text = selectOwners.RoyaltyName.ToString();
                this.txtRoyaltyAddress.Text = selectOwners.RoyaltyAddress.ToString();
            }

        }

        /* -----------------------------------------------------------------

            OpenExcelMedias() has been replaced by OpenExcelTestData() 

        --------------------------------------------------------------------*/

        public void OpenExcelMedias()
        {
            OpenFileDialog dlgTestFile;
            Excel.Application xlApp;        //Microsoft Excel 14 object in references-> COM tab
            
            String msFilename;

            DateTime dteNow;
            int iPos;
            string yyyy, MM, dd, hh, mm;

            int iTestProductNo = 0;

            Excel.Workbook xlWorkbook;
            Excel._Worksheet xlWorksheet;
            Excel.Range xlRange;

            dlgTestFile = new OpenFileDialog();
            dlgTestFile.DefaultExt = "xls";
            dlgTestFile.InitialDirectory = Application.StartupPath;
            dlgTestFile.Filter = "Excel Worksheets 2007(*.xlsx)|*.xlsx|Excel Worksheets 2003(*.xls)|*.xls|All Files (*.*)|*.*";
            dlgTestFile.FilterIndex = 1;
            dlgTestFile.FileName = "TestData.xls";

            if (dlgTestFile.ShowDialog() == DialogResult.OK)
            {
                msFilename = dlgTestFile.FileName;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlApp.Workbooks.Open(msFilename);

                try 
                {
                    dteNow = DateTime.Now;
                    yyyy = dteNow.ToString("yyyy");
                    MM = dteNow.ToString("MM");
                    dd = dteNow.ToString("dd");
                    hh = dteNow.ToString("hh");
                    mm = dteNow.ToString("mm");
                    iPos = msFilename.LastIndexOf('\\') + 1;
                    msFilename = msFilename.Substring(0, iPos) + "TestData" + "_"
                        + yyyy + "_" + MM + "_" + dd + "_"
                        + hh + "_" + mm + ".xls";
                    xlApp.Application.ActiveWorkbook.SaveCopyAs(msFilename);

                    MessageBox.Show("Excel file created , you can find the file: " + msFilename);

                    DialogResult dr = MessageBox.Show("Test Data Excel file: " + msFilename + " has been created! Do you confirm to run test?",
                                                        "Test", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        // Create COM Objects. Create a COM object for everything that is referenced
                        xlWorkbook = xlApp.Workbooks.Open(msFilename);
                        xlWorksheet = xlWorkbook.Sheets[1];
                        xlRange = xlWorksheet.UsedRange;

                        try
                        {
                            int rowCount = xlRange.Rows.Count;
                            int colCount = xlRange.Columns.Count;

                            // iterate over the rows and columns and print to the console as it appears in the file
                            // excel is not zero based!!
                            for (int i = 2; i <= rowCount; i++)
                            {
                                int j = 3;

                                txtProductName.Text = xlWorksheet.Cells[i, j + 1].Value.ToString();
                                txtProductType.Text = xlWorksheet.Cells[i, j + 2].Value.ToString();
                                txtFileType.Text = xlWorksheet.Cells[i, j + 3].Value.ToString();
                                txtUrlSampler.Text = xlWorksheet.Cells[i, j + 4].Value.ToString();
                                txtUrlMedia.Text = xlWorksheet.Cells[i, j + 5].Value.ToString();
                                txtUnitPrice.Text = xlWorksheet.Cells[i, j + 6].Value.ToString();
                                txtRoyaltyNo.Text = xlWorksheet.Cells[i, j + 7].Value.ToString();
                                txtUnitRoyalty.Text = xlWorksheet.Cells[i, j + 8].Value.ToString();
                                //var dblDate = Double.xlWorksheet(xlRange.Cells[i, j + 9].Value.ToString();
                                txtDateAdded.Text = xlWorksheet.Cells[i, j + 9].Value.ToString("yyyy-MM-dd");

                                xlRange = (Excel.Range)xlWorksheet.Cells[i, 1];
                                // insert()
                                try
                                {
                                    objmedia.validateProductName(txtProductName.Text, true);
                                    objmedia.validateProductType(txtProductType.Text, true);
                                    objmedia.validateFileType(txtFileType.Text, true);
                                    objmedia.validateUrlSampler(txtUrlSampler.Text, true);
                                    objmedia.validateUrlMedia(txtUrlMedia.Text, true);
                                    objmedia.validateUnitPrice(txtUnitPrice.Text, true);
                                    objmedia.validateRoyaltyNo(txtRoyaltyNo.Text, true);
                                    objmedia.validateUnitRoyalty(txtUnitRoyalty.Text, true);
                                    objmedia.validateDateAdded(txtDateAdded.Text, true);

                                    int count = dacmedia.Insert(objmedia);

                                    switch (count)
                                    {
                                        case -1:
                                            xlRange.Value = "Search aborted, no search criteria supplied";
                                            break;
                                        case 0:
                                            xlRange.Value = "Product failed to add, Product may already be on file";
                                            break;
                                        case 1:
                                            iTestProductNo = dacmedia.LastUsedProductNo();
                                            txtProductNo.Text = iTestProductNo.ToString();
                                            xlWorksheet.Cells[i, 3].Value = iTestProductNo.ToString();
                                            xlRange.Value = "OK";
                                            lstmedia = dacmedia.GetMedias();
                                            displayMediaList(iTestProductNo);
                                            break;
                                        default:
                                            xlRange.Value = "Database corrupted, Inform DBA, presss any key to abort";
                                            break;
                                    }

                                }
                                catch (Exception ex)
                                {
                                    xlRange.Value = "Insert Media Error: " + ex.Message;
                                }

                            }
                        }
                        // coming from: https://coderwall.com/p/app3ya
                        finally
                        {
                            //cleanup
                            GC.Collect();
                            GC.WaitForPendingFinalizers();

                            //rule of thumb for releasing com objects:
                            //  never use two dots, all COM objects must be referenced and released individually
                            //  ex: [somthing].[something].[something] is bad

                            //release com objects to fully kill excel process from running in the background
                            Marshal.ReleaseComObject(xlRange);
                            Marshal.ReleaseComObject(xlWorksheet);

                            //close and release
                            xlWorkbook.Close(true);
                            Marshal.ReleaseComObject(xlWorkbook);
                        }
                    }
                }
                finally
                {
                    //quit and release xlApp
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
            }
        }


        /* -----------------------------------------------------------------

            Read Test Data From Excel
            And Run Test Data
            Switch (dataType)
                case 1: Call Insert Medias Function
                case 2: Call Insert Royalty Owners Function
                case n: ...
            End Switch

        --------------------------------------------------------------------*/

        private void openTestDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DEBUG
            openExcelTestData(1);
#endif
        }

        public void openExcelTestData(int dataType)
        {
            OpenFileDialog dlgTestFile;
            Excel.Application xlApp;        //Microsoft Excel 14 object in references-> COM tab

            String msFilename;

            DateTime dteNow;
            int iPos;
            string yyyy, MM, dd, hh, mm;

            dlgTestFile = new OpenFileDialog();
            dlgTestFile.DefaultExt = "xls";
            dlgTestFile.InitialDirectory = Application.StartupPath;
            switch (dataType)
            {
                case 1:
                    dlgTestFile.Filter = "TestData_Medias.xlsx|*.xlsx|TestData_Medias.xls|*.xls";
                    break;
                case 2:
                    dlgTestFile.Filter = "TestData_MediasOwners.xlsx|*.xlsx|TestData_MediasOwners.xls|*.xls";
                    break;
            }
            dlgTestFile.FilterIndex = 1;
            

            if (dlgTestFile.ShowDialog() == DialogResult.OK)
            {
                msFilename = dlgTestFile.FileName;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlApp.Workbooks.Open(msFilename);

                try
                {
                    dteNow = DateTime.Now;
                    yyyy = dteNow.ToString("yyyy");
                    MM = dteNow.ToString("MM");
                    dd = dteNow.ToString("dd");
                    hh = dteNow.ToString("hh");
                    mm = dteNow.ToString("mm");
                    iPos = msFilename.LastIndexOf('.');
                    msFilename = msFilename.Substring(0, iPos) + "_"
                        + yyyy + "_" + MM + "_" + dd + "_"
                        + hh + mm 
                        + msFilename.Substring(iPos);
                    xlApp.Application.ActiveWorkbook.SaveCopyAs(msFilename);

                    MessageBox.Show("Excel file created , you can find the file: " + msFilename);

                    DialogResult dr = MessageBox.Show("Test Data Excel file: " + msFilename + " has been created! Do you confirm to run test?",
                                                        "Test", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        switch (dataType)
                        {
                            case 1:
                                excelTestMedias(ref xlApp, msFilename);
                                break;
                            case 2:
                                excelAddMediasAndOwners(ref xlApp, msFilename);
                                break;
                        }

                    }
                }
                finally
                {
                    //quit and release xlApp
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
            }
        }

        /* -----------------------------------------------------------------

            Automatic Test Medias From Test Excel File

         *  This has been substituted by excelTestMedias() since v0.3
        --------------------------------------------------------------------*/

        private void excelAddMedias(ref Excel.Application xlApp, string sexcelFileName)
        {
            Excel.Workbook xlWorkbook;
            Excel._Worksheet xlWorksheet;
            Excel.Range xlRange;

            int iTestProductNo = 0;

            // Create COM Objects. Create a COM object for everything that is referenced
            xlWorkbook = xlApp.Workbooks.Open(sexcelFileName);
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;

            try
            {
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                // iterate over the rows and columns and print to the console as it appears in the file
                // excel is not zero based!!
                for (int i = 2; i <= rowCount; i++)
                {
                    xlRange = (Excel.Range)xlWorksheet.Cells[i, 1];
                     
                    try
                    {
                        int j = 3;

                        // it's safe to be in try...except 
                        // when in case sheet cell value is null
                        txtProductName.Text = xlWorksheet.Cells[i, j + 1].Value.ToString();
                        txtProductType.Text = xlWorksheet.Cells[i, j + 2].Value.ToString();
                        txtFileType.Text = xlWorksheet.Cells[i, j + 3].Value.ToString();
                        txtUrlSampler.Text = xlWorksheet.Cells[i, j + 4].Value.ToString();
                        txtUrlMedia.Text = xlWorksheet.Cells[i, j + 5].Value.ToString();
                        txtUnitPrice.Text = xlWorksheet.Cells[i, j + 6].Value.ToString();
                        txtRoyaltyNo.Text = xlWorksheet.Cells[i, j + 7].Value.ToString();
                        txtUnitRoyalty.Text = xlWorksheet.Cells[i, j + 8].Value.ToString();
                        //var dblDate = Double.xlWorksheet(xlRange.Cells[i, j + 9].Value.ToString();
                        txtDateAdded.Text = xlWorksheet.Cells[i, j + 9].Value.ToString("yyyy-MM-dd");

                        
                        // insert()

                        objmedia.validateProductName(txtProductName.Text, true);
                        objmedia.validateProductType(txtProductType.Text, true);
                        objmedia.validateFileType(txtFileType.Text, true);
                        objmedia.validateUrlSampler(txtUrlSampler.Text, true);
                        objmedia.validateUrlMedia(txtUrlMedia.Text, true);
                        objmedia.validateUnitPrice(txtUnitPrice.Text, true);
                        objmedia.validateRoyaltyNo(txtRoyaltyNo.Text, true);
                        objmedia.validateUnitRoyalty(txtUnitRoyalty.Text, true);
                        objmedia.validateDateAdded(txtDateAdded.Text, true);

                        int count = dacmedia.Insert(objmedia);

                        switch (count)
                        {
                            case -1:
                                xlRange.Value = "Search aborted, no search criteria supplied";
                                break;
                            case 0:
                                xlRange.Value = "Product failed to add, Product may already be on file";
                                break;
                            case 1:
                                iTestProductNo = dacmedia.LastUsedProductNo();
                                txtProductNo.Text = iTestProductNo.ToString();
                                xlWorksheet.Cells[i, 3].Value = iTestProductNo.ToString();
                                xlRange.Value = "OK";
                                lstmedia = dacmedia.GetMedias();
                                displayMediaList(iTestProductNo);
                                break;
                            default:
                                xlRange.Value = "Database corrupted, Inform DBA, presss any key to abort";
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        xlRange.Value = "Insert Media Error: " + ex.Message;
                    }

                    // deletMedia()

                    /* xlRange = xlWorksheet.Cells[i, 2];
                    try
                    {
                        Media mediaToDelete = lstmedia.SingleOrDefault(x => x.productNo == iTestProductNo);
                        if (mediaToDelete != null)
                        {
                            int count = dacmedia.Delete(mediaToDelete);

                            switch (count)
                            {
                                case -1:
                                    xlRange.Value = "Delete Exception, and inform DBA!";
                                    break;
                                case 0:
                                    xlRange.Value = "Delete failed, and inform DBA!";
                                    break;
                                case 1:
                                    xlRange.Value = "OK";
                                    lstmedia = dacmedia.GetMedias();
                                    displayMediaList(lstmedia);
                                    break;
                                default:
                                    xlRange.Value = "Database corrupted, Inform DBA, press any key to abort!";
                                    break;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        xlRange.Value = "Delete Media Error: " + ex.Message;
                    }
                     */
                }
            }
            // coming from: https://coderwall.com/p/app3ya
            finally
            {
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close(true);
                Marshal.ReleaseComObject(xlWorkbook);
            }

        }


        /* -----------------------------------------------------------------

            Test Medias From Test Excel Data

        *   This substitudes excelTestMedias() since v0.3
        --------------------------------------------------------------------*/

        private void excelTestMedias(ref Excel.Application xlApp, string sexcelFileName)
        {
            Excel.Workbook xlWorkbook;
            Excel._Worksheet xlWorksheet;
            Excel.Range xlResult;
            string sAction;

            int iTestProductNo = 0;

            // Create COM Objects. Create a COM object for everything that is referenced
            xlWorkbook = xlApp.Workbooks.Open(sexcelFileName);
            xlWorksheet = xlWorkbook.Sheets[1];
            xlResult = xlWorksheet.UsedRange;

            try
            {
                int rowCount = xlResult.Rows.Count;
                int colCount = xlResult.Columns.Count;

                // iterate over the rows and columns and print to the console as it appears in the file
                
                /* -----------------------------
                 * 
                 * !! excel is not zero based!!
                 * 
                 * ----------------------------- */
                 
                for (int i = 2; i <= rowCount; i++)
                {
                    sAction = xlWorksheet.Cells[i, 1].Value != null ?
                        xlWorksheet.Cells[i, 1].Value.ToString() : "";
                    
                    xlResult = (Excel.Range)xlWorksheet.Cells[i, 2];

                    int j = 4;

                    if (sAction == "Insert") 
                    {
                        /*
                         *  To test insertMedia()
                         */

                        try
                        {
                            /*  it's necessary to check the cell value is null or not 
                                before convert to text 
                                And whether the value is valid or not
                                would be decided by Valide function
                             */
                            txtProductName.Text = xlWorksheet.Cells[i, j + 1].Value != null ?
                                xlWorksheet.Cells[i, j + 1].Value.ToString() : "";
                            txtProductType.Text = xlWorksheet.Cells[i, j + 2].Value != null ?
                                xlWorksheet.Cells[i, j + 2].Value.ToString() : "";
                            txtFileType.Text = xlWorksheet.Cells[i, j + 3].Value != null ?
                                xlWorksheet.Cells[i, j + 3].Value.ToString() : "";
                            txtUrlSampler.Text = xlWorksheet.Cells[i, j + 4].Value != null ?
                                xlWorksheet.Cells[i, j + 4].Value.ToString() : "";
                            txtUrlMedia.Text = xlWorksheet.Cells[i, j + 5].Value != null ?
                                xlWorksheet.Cells[i, j + 5].Value.ToString() : "";
                            txtUnitPrice.Text = xlWorksheet.Cells[i, j + 6].Value != null ?
                                xlWorksheet.Cells[i, j + 6].Value.ToString() : "";
                            txtRoyaltyNo.Text = xlWorksheet.Cells[i, j + 7].Value != null ?
                                xlWorksheet.Cells[i, j + 7].Value.ToString() : "";
                            txtUnitRoyalty.Text = xlWorksheet.Cells[i, j + 8].Value != null ?
                                xlWorksheet.Cells[i, j + 8].Value.ToString() : "";
                            txtDateAdded.Text = xlWorksheet.Cells[i, j + 9].Value != null ?
                                xlWorksheet.Cells[i, j + 9].Value.ToString("yyyy-MM-dd") : "";

                            objmedia.validateProductName(txtProductName.Text, true);
                            objmedia.validateProductType(txtProductType.Text, true);
                            objmedia.validateFileType(txtFileType.Text, true);
                            objmedia.validateUrlSampler(txtUrlSampler.Text, true);
                            objmedia.validateUrlMedia(txtUrlMedia.Text, true);
                            objmedia.validateUnitPrice(txtUnitPrice.Text, true);
                            objmedia.validateRoyaltyNo(txtRoyaltyNo.Text, true);
                            objmedia.validateUnitRoyalty(txtUnitRoyalty.Text, true);
                            objmedia.validateDateAdded(txtDateAdded.Text, true);

                            int count = dacmedia.Insert(objmedia);

                            switch (count)
                            {
                                case -1:
                                    xlResult.Value = "Search aborted, no search criteria supplied";
                                    break;
                                case 0:
                                    xlResult.Value = "Product failed to add, Product may already be on file";
                                    break;
                                case 1:
                                    iTestProductNo = dacmedia.LastUsedProductNo();
                                    txtProductNo.Text = iTestProductNo.ToString();

                                    xlWorksheet.Cells[i, 4].Value = iTestProductNo.ToString();
                                    xlResult.Value = "Insert Media OK";

                                    lstmedia = dacmedia.GetMedias();
                                    displayMediaList(iTestProductNo);
                                    break;
                                default:
                                    xlResult.Value = "Insert Media Error: Database corrupted, Inform DBA, presss any key to abort";
                                    break;
                            }

                        }
                        catch (Exception ex)
                        {
                            xlResult.Value = "Insert Media Error: " + ex.Message;
                        }
                    }
                    else if (sAction == "Search")
                    {
                        /*  
                         *  To test searchMedia()
                         */

                        /* 
                         *  reset and fetch all Medias before search
                         * 
                         */
                        //lstmedia = dacmedia.GetMedias();
                        ///displayMediaList(-1);

                        //  start search
                        try
                        {
                            /*  
                             * it's necessary to check the cell value is null or not 
                             * when the field value is null, means the filter is not required
                             */
                            
                            txtProductName.Text = xlWorksheet.Cells[i, j + 1].Value != null ?
                                xlWorksheet.Cells[i, j + 1].Value.ToString() : "";
                            txtProductType.Text = xlWorksheet.Cells[i, j + 2].Value != null ?
                                xlWorksheet.Cells[i, j + 2].Value.ToString() : "";
                            txtFileType.Text = xlWorksheet.Cells[i, j + 3].Value != null ?
                                xlWorksheet.Cells[i, j + 3].Value.ToString() : "";
                            txtUrlSampler.Text = xlWorksheet.Cells[i, j + 4].Value != null ?
                                xlWorksheet.Cells[i, j + 4].Value.ToString() : "";
                            txtUrlMedia.Text = xlWorksheet.Cells[i, j + 5].Value != null ?
                                xlWorksheet.Cells[i, j + 5].Value.ToString() : "";
                            txtUnitPrice.Text = xlWorksheet.Cells[i, j + 6].Value != null ?
                                xlWorksheet.Cells[i, j + 6].Value.ToString() : "";
                            txtRoyaltyNo.Text = xlWorksheet.Cells[i, j + 7].Value != null ?
                                xlWorksheet.Cells[i, j + 7].Value.ToString() : "";
                            txtUnitRoyalty.Text = xlWorksheet.Cells[i, j + 8].Value != null ?
                                xlWorksheet.Cells[i, j + 8].Value.ToString() : "";
                            txtDateAdded.Text = xlWorksheet.Cells[i, j + 9].Value != null ?
                                xlWorksheet.Cells[i, j + 9].Value.ToString("yyyy-MM-dd") : "";

                            objmedia = new Media();
                            objmedia.validateProductName(txtProductName.Text, false);
                            objmedia.validateProductType(txtProductType.Text, false);
                            objmedia.validateFileType(txtFileType.Text, false);
                            objmedia.validateUrlSampler(txtUrlSampler.Text, false);
                            objmedia.validateUrlMedia(txtUrlMedia.Text, false);
                            objmedia.validateUnitPrice(txtUnitPrice.Text, false);
                            objmedia.validateRoyaltyNo(txtRoyaltyNo.Text, false);
                            objmedia.validateUnitRoyalty(txtUnitRoyalty.Text, false);
                            objmedia.validateDateAdded(txtDateAdded.Text, false);

                            bool ok = dacmedia.Search(objmedia, ref lstmedia);
                            
                            if (ok)
                            {
                                switch (lstmedia.Count)
                                {
                                    case 0:
                                        MessageBox.Show("No records found, \r check the search criteria before repeating the query",
                                            "Media Search", MessageBoxButtons.OK);
                                        break;
                                    case 1:
                                        displayMediaList(-1);
                                        break;
                                    default:
                                        displayMediaList(-1);
                                        break;
                                }
                            }
                            else
                            {
                                grdMedia.Rows.Clear();
                                objmedia = new Media();
                                // clear datagrid view
                                txtProductNo.Text = "";
                                txtProductName.Text = "";
                                txtProductType.Text = "";
                                txtFileType.Text = "";
                                txtUrlSampler.Text = "";
                                txtUrlMedia.Text = "";
                                txtUnitPrice.Text = "";
                                txtRoyaltyNo.Text = "";
                                txtUnitRoyalty.Text = "";
                                txtDateAdded.Text = "";
                            }
                            xlResult.Value = "Search " + lstmedia.Count.ToString() + " Medias";
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message, "Media Search", MessageBoxButtons.OK);
                            xlResult.Value = "Search Media Error: " + ex.Message;
                        }
                    }
                    else if (sAction == "Delete")
                    {

                        /*
                         *  To test deleteMedia()
                         *  
                         *  in here, we just remove the 1st Medias from the search result
                         */

                        try
                        {
                            foreach (Media obj in lstmedia)
                            {
                                if (deleteMedia(obj.productNo) )
                                xlResult.Value += "Delete Media: " + obj.productNo.ToString() + "\n";
                            }

                        }
                        catch (Exception ex)
                        {
                            xlResult.Value = "Delete Media Error: " + ex.Message;
                        }
                        
                    }
                    else if (sAction == "Update")
                    {
                        /*
                         *  To test updateMedia()
                         *  
                         *  in here, we just remove the 1st Medias from the search result
                         */


                    }

                }
            }
            // coming from: https://coderwall.com/p/app3ya
            finally
            {
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlResult);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close(true);
                Marshal.ReleaseComObject(xlWorkbook);
            }

        }


        /* -----------------------------------------------------------------

            Insert Medias From Test Excel File
         * 
         *  Not Yet Finished ???

        --------------------------------------------------------------------*/

        private void excelAddMediasAndOwners(ref Excel.Application xlApp, string sexcelFileName)
        {
            Excel.Workbook xlWorkbook;
            Excel._Worksheet xlWorksheet;
            Excel.Range xlRange;

            int iTestProductNo = 0;

            // Create COM Objects. Create a COM object for everything that is referenced
            xlWorkbook = xlApp.Workbooks.Open(sexcelFileName);
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;

            try
            {
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                /* ..... */

            }
            // coming from: https://coderwall.com/p/app3ya
            finally
            {
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close(true);
                Marshal.ReleaseComObject(xlWorkbook);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
    }
}
