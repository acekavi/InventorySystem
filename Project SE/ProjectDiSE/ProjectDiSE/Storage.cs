using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProjectDiSE.Includes;

namespace ProjectDiSE
{
    public partial class Storage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public Storage()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        public void ComboSelect()
        {
            sql = "SELECT itemName FROM `itemlist` WHERE itemID LIKE '%" + cboID.Text + "%' OR itemName LIKE '%" + cboID.Text + "%'";
            config.fill_CBO(sql, cboID);
            cboID.Text = "";
        }

        public void ClearInv()
        {
            cboID.Text = "";
            txtQty.Text = "";
            rmvInv.Visible = false;
            cboID.Focus();
        }

        public void ClearAll()
        {
            ClearInv();
            txtTrnsID.Text = "";
            txtStPrice.Text = "";
            dtInventory.Rows.Clear();
            dtInventory.Refresh();
            loadTrans();
        }

        public void stPrice()
        {
            double sum = 0;
            for (int i = 0; i < dtInventory.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dtInventory.Rows[i].Cells[4].Value);
            }
            txtStPrice.Text = sum.ToString();        
        }

        public void genTrnsID()
        {
            string trnsID;

            config.singleResult("SELECT concat(STRT,END) FROM genid WHERE ID = 2");
            trnsID = config.dt.Rows[0].Field<string>(0);

            txtTrnsID.Text = trnsID;
        }

        public void loadTrans()
        {
            try
            {
                sql = "SELECT * FROM transactions";
                config.Load_DTG(sql, dtStockReport);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Items..." + Environment.NewLine + ex);
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            ComboSelect();
            timer1.Start();
            ClearAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        
        private void addCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboID.Text) || string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Fill up all the Fields please!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string itmID;
                int itmPrice;

                config.singleResult("SELECT itemID,wholePrice FROM `itemlist` WHERE itemName='" + cboID.Text + "' OR itemID='" + cboID.Text + "'");
                itmID = config.dt.Rows[0].Field<string>("itemID");
                itmPrice = config.dt.Rows[0].Field<int>("wholePrice");

                string stockPrice = (itmPrice * int.Parse(txtQty.Text)).ToString();

                sql = "SELECT itemID FROM inventory WHERE itemID='" + itmID + "'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    int rQty;
                    string invID;

                    config.singleResult("SELECT inventoryID,Qty FROM `inventory` WHERE itemID='" + itmID + "'");
                    invID = config.dt.Rows[0].Field<string>("inventoryID");
                    rQty = config.dt.Rows[0].Field<int>("Qty") + int.Parse(txtQty.Text);
                                     
                    string[] row = new string[] {
                         invID,
                         itmID,
                         rQty.ToString(),
                         txtQty.Text,
                         stockPrice };

                    for (int i = 0; i < dtInventory.Rows.Count; i++)
                    {
                       if (dtInventory.Rows[i].Cells[1].Value.ToString() == itmID)
                        {
                            DataGridViewRow dgvDelRow = dtInventory.Rows[i];
                            dtInventory.Rows.Remove(dgvDelRow);
                        }
                    }
                    dtInventory.Rows.Add(row);
                    ClearInv();
                    
                }
                else
                {
                    string[] row = new string[] {
                                        "New Arrival",
                                        itmID,
                                        txtQty.Text,
                                        txtQty.Text,
                                        stockPrice};

                    for (int i = 0; i < dtInventory.Rows.Count; i++)
                    {
                        if (dtInventory.Rows[i].Cells[1].Value.ToString() == itmID)
                        {
                            DataGridViewRow dgvDelRow = dtInventory.Rows[i];
                            dtInventory.Rows.Remove(dgvDelRow);
                        }
                    }

                    dtInventory.Rows.Add(row);
                    ClearInv();
                }
            }
        }

        private void dtInventory_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            stPrice();
            genTrnsID();
        }

        private void saveStock_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtStPrice.Text) || string.IsNullOrWhiteSpace(txtTrnsID.Text))
            {
                MessageBox.Show("The cart is Empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure, You want to save this cart?", "Confirm to Save!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string itemList = "";
                    foreach (DataGridViewRow r in dtInventory.Rows)
                    {
                        ////////////////////Generating the ID////////////////////

                        string genInvID;
                        string InvID = r.Cells[0].Value.ToString();

                        if (r.Cells[0].Value.ToString()== "New Arrival")
                        {
                            config.singleResult("SELECT concat(STRT,END) FROM genid WHERE ID = 1");
                            genInvID = config.dt.Rows[0].Field<string>(0);
                            config.update_Autonumber("Inventory");
                        }
                        else
                        {
                            genInvID = InvID;
                        }
                        //////////////////////Sql for saving//////////////////////

                        sql = "SELECT * FROM inventory WHERE inventoryID='" + r.Cells[0].Value + "'";
                        config.singleResult(sql);
                        if (config.dt.Rows.Count > 0)
                        {
                            sql = "UPDATE inventory SET Qty = '" + r.Cells[2].Value + "' WHERE inventoryID ='" + r.Cells[0].Value + "'";
                            config.Execute_Query(sql);
                        }
                        else
                        {
                            sql = "INSERT INTO `inventory` ( `inventoryID`, `itemID`, `Qty`)" +
                             " VALUES ('" + genInvID + "','" + r.Cells[1].Value + "','" + r.Cells[2].Value + "')";
                            config.Execute_Query(sql);
                        }
                        ///////////////////Item List///////////////////////////////
                        itemList = itemList + r.Cells[1].Value+ "(" + r.Cells[3].Value + "), " ;
                    }
                    itemList = itemList.Substring(0, (itemList.Length - 2));

                    sql = "INSERT INTO `transactions` (`transID`, `user`, `transType`, `transDate`, `items`, `stockPrice`)" +
                          " VALUES ('" + txtTrnsID.Text + "','" + Login.user + "','Stock-IN','" + txtDate.Text + "','" + itemList + "','" + txtStPrice.Text + "')";
                    config.Execute_Query(sql);

                    config.update_Autonumber("Transaction");
                    ClearAll();
                }
            }
        }

        private void dtInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rmvInv.Visible = true;
            cboID.Text = dtInventory.CurrentRow.Cells[1].Value.ToString();
            txtQty.Text = dtInventory.CurrentRow.Cells[3].Value.ToString();
        }

        private void rmvInv_Click(object sender, EventArgs e)
        {
            dtInventory.Rows.RemoveAt(dtInventory.CurrentRow.Index);
            ClearInv();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addCart_Click(this, new EventArgs());
            }
        }

        /*old Code
        {
            if (string.IsNullOrWhiteSpace(cboID.Text) || string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Fill up all the Fields please!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            string genInvID;
            string itmID;
            int itmPrice;

            config.singleResult("SELECT itemID,wholePrice FROM `itemlist` WHERE itemName='" + cboID.Text + "'");
                    itmID = config.dt.Rows[0].Field<string>("itemID");
                    itmPrice = config.dt.Rows[0].Field<int>("wholePrice");


            config.singleResult("SELECT concat(STRT,END) FROM genid WHERE ID = 1");
            genInvID = config.dt.Rows[0].Field<string>(0);

            string stockPrice = (itmPrice * int.Parse(txtQty.Text)).ToString();


                    sql = "SELECT itemID FROM inventory WHERE itemID='" + itmID + "'";
                                config.singleResult(sql);
                                if (config.dt.Rows.Count > 0)
                                {
                                    int rQty;
                    string invID;

                    config.singleResult("SELECT inventoryID,Qty FROM `inventory` WHERE itemID='" + itmID + "'");
                                    invID = config.dt.Rows[0].Field<string>("inventoryID");
                                    rQty = config.dt.Rows[0].Field<int>("Qty") + int.Parse(txtQty.Text);

                    DialogResult res = MessageBox.Show("Item exists with this Item ID! Do you want to add Quantity?", "Confirm to Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        sql = "UPDATE inventory SET Qty = Qty + '" + txtQty.Text + "' WHERE inventoryID ='" + invID + "'";
                        config.Execute_Query(sql);

                        string[] row = new string[] {
                                        invID,
                                        itmID,
                                        rQty.ToString(),
                                        txtQty.Text,
                                        stockPrice};

                    dtInventory.Rows.Add(row);
                    ClearInv();
                }

                }
                else
                {
                    sql = "INSERT INTO `inventory` ( `inventoryID`, `itemID`, `Qty`)" +
                          " VALUES ('" + genInvID + "','" + itmID + "','" + txtQty.Text + "')";
                    config.Execute_Query(sql);

                    config.update_Autonumber("Inventory");

                    string[] row = new string[] {
                                        genInvID,
                                        itmID,
                                        txtQty.Text,
                                        txtQty.Text,
                                        stockPrice};

                       dtInventory.Rows.Add(row);
                    ClearInv();
                }
            }
        }*/
    }
}
