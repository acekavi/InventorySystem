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
    public partial class Password : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Password()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtpass1.Text == "" || txtpass2.Text == "")
            {
                MessageBox.Show("Fill up all the Fields please!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = " SELECT * FROM users WHERE username = '" + Login.user + "' ";
                config.singleResult(sql);
                string pass = config.dt.Rows[0].Field<string>("password");

                if (txtpass.Text == pass)
                {
                    if (txtpass1.Text == txtpass2.Text)
                    {
                        sql = "update users set password = '" + txtpass2.Text + "' ";
                        config.Execute_CUD(sql, "Unable to update", "Data has been updated in the database.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Two passwords doesn't match!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Current password is wrong!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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
    }
}
