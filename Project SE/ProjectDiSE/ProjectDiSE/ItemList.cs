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
    public partial class ItemList : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public ItemList()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        public void clear()
        {
            txtitemid.Text = "";
            txtitemname.Text = "";
            txtqty.Text = "";
            txtwhole.Text = "";
            txtretail.Text = "";
            txtsell.Text = "";
            txtprofit.Text = "";
            btnadd.Visible = true;
            btndelete.Visible = false;
            btnupdate.Visible = false;
            txtitemid.Enabled = true;
            txtitemid.Focus();
            loadItems();
        }

        public void loadItems()
        {
            try
            {
                sql = "SELECT * FROM itemlist";
                config.Load_DTG(sql, dtglist);
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtitemid.Text == "" || txtitemname.Text == "" || txtqty.Text == "" || txtwhole.Text == "" || txtretail.Text == "" || txtsell.Text == "" || txtprofit.Text == "")
                {
                    MessageBox.Show("Fill up all the Fields please!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    sql = "SELECT itemID FROM itemlist WHERE itemID='" + txtitemid.Text + "'";
                    config.singleResult(sql);
                    if (config.dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Item exists with this ItemID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        sql = "INSERT INTO itemlist  (`itemID`,`itemName`, `Qty`, `wholePrice`, `retailPrice`, `sellPrice`,`profit`)" +
                                           "VALUES ('" + txtitemid.Text + "','" + txtitemname.Text + "','" + txtqty.Text + "','" + txtwhole.Text
                                           + "','" + txtretail.Text + "','" + txtsell.Text + "','" + txtprofit.Text + "' )";
                        config.Execute_CUD(sql, "Error while saving!", "Data has been saved in the database.");

                        clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving to database..." + Environment.NewLine + ex);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dtglist_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM itemlist WHERE itemID='" + dtglist.CurrentRow.Cells[0].Value.ToString() + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtitemid.Text = config.dt.Rows[0].Field<string>("itemID");
                txtitemname.Text = config.dt.Rows[0].Field<string>("itemName");
                txtqty.Text = config.dt.Rows[0].Field<string>("Qty");
                txtwhole.Text = config.dt.Rows[0].Field<int>("wholePrice").ToString();
                txtretail.Text = config.dt.Rows[0].Field<int>("retailPrice").ToString();
                txtsell.Text = config.dt.Rows[0].Field<int>("sellPrice").ToString();
                txtprofit.Text = config.dt.Rows[0].Field<int>("profit").ToString();

                txtitemid.Enabled = false;
                btnupdate.Visible = true;
                btndelete.Visible = true;
                btnadd.Visible = false;
            }
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Update the database?", "Confirm to Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (txtitemid.Text == "" || txtitemname.Text == "" || txtqty.Text == "" || txtwhole.Text == "" || txtretail.Text == "" || txtsell.Text == "" || txtprofit.Text == "")
                    {
                        MessageBox.Show("Fill up all the Fields please!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        sql = "UPDATE itemlist SET `itemName`='" + txtitemname.Text + "', `Qty`='" + txtqty.Text + "', `wholePrice`='" + txtwhole.Text + "', `retailPrice`='" + txtretail.Text + "'" +
                        ",`sellPrice`='" + txtsell.Text + "',`profit`='" + txtprofit.Text + "' WHERE itemID='" + txtitemid.Text + "'";
                        config.Execute_CUD(sql, "Error while updating!", "Data has been updated in the database");
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating the database..." + Environment.NewLine + ex);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete this from the database?", "Confirm to Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (txtitemid.Text == "" || txtitemname.Text == "" || txtqty.Text == "" || txtwhole.Text == "" || txtretail.Text == "" || txtsell.Text == "" || txtprofit.Text == "")
                    {
                        MessageBox.Show("Fill up all the Fields please!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        sql = "DELETE FROM itemlist WHERE itemID='" + dtglist.CurrentRow.Cells[0].Value + "'";
                        config.Execute_CUD(sql, "Error while deleting!", "Data has been deleted.");
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating the database..." + Environment.NewLine + ex);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM itemlist WHERE itemID LIKE '%" + txtsearch.Text + "%' OR itemName LIKE '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dtglist);
        }
    }
}
