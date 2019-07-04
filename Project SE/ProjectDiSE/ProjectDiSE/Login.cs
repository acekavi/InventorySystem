using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ProjectDiSE.Includes;

namespace ProjectDiSE
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public event EventHandler LoadCompleted;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.OnLoadCompleted(EventArgs.Empty);
        }
        protected virtual void OnLoadCompleted(EventArgs e)
        {
            var handler = LoadCompleted;
            if (handler != null)
                handler(this, e);
        }

        public Login()
        {
            Thread.Sleep(2000);
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql;
        public static String user;
        public static String utype;

        private void btnlogin_Click(object sender, EventArgs e)
        {
            sql = " SELECT * FROM users WHERE username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "' ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                utype = config.dt.Rows[0].Field<string>("user_type");
                user = config.dt.Rows[0].Field<string>("username");
                MainMenu frm = new MainMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password doesn't match! Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtuser.Clear();
            txtuser.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(this, new EventArgs());
            }
        }
    }
}
