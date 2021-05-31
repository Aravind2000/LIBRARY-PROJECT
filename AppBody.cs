using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace DBMS_project
{
    public partial class AppBody : Form
    {




        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();





        public AppBody()
        {
            InitializeComponent();
            //intializations
            isslidingExpanded = true;
            expandslideingpanelGUI();
        }

        private void AppBody_Load(Object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            login_time.Start();
        }

        private void login_time_Tick(Object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                login_time.Stop();
            }
        }

        private void close_Click(Object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(Object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoff_Click(Object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void panel1_Paint(Object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public void expandslideingpanelGUI()
        {
            //giu for expanding
            bookstab.Text = "BOOKS";
            borrowertab.Text = "BORROWERS";
            transactiontab.Text = "TRANSACTIONS";
            settingstab.Text = "SETTINGS";
            abouttab.Text = "ABOUT";
            sliding_toggle.Image = Properties.Resources.l2;

            bookstab.Image = null;
            borrowertab.Image = null;
            transactiontab.Image = null;
            settingstab.Image = null;
            abouttab.Image = null;


        }
        public void retractslideingpanelGUI()
        {
            //giu for expanding
            bookstab.Text = "";
            borrowertab.Text = "";
            transactiontab.Text = "";
            settingstab.Text = "";
            abouttab.Text = "";
            sliding_toggle.Image = Properties.Resources.r2;
            bookstab.Image = Properties.Resources.books1;
            borrowertab.Image = Properties.Resources.cust1;
            transactiontab.Image = Properties.Resources.tran22;
            settingstab.Image = Properties.Resources.set1;
            abouttab.Image = Properties.Resources.ab2;


        }


        //sliding plane code
        bool isslidingExpanded;
        const int MaxSliderwidth=200;
        const int MinSliderwidth=100;

        private void sliding_toggle_Click(Object sender, EventArgs e)
        {
            if(isslidingExpanded)
            {
                //retract
                //retractslideingpanelGUI();
            }
            sliding_timer.Start();
        }

        private void sliding_timer_Tick(Object sender, EventArgs e)
        {
            if (isslidingExpanded)
            {
                //retract
                sliding.Width -= 30;
                if(sliding.Width<=MinSliderwidth)
                {
                    //stop retract
                    isslidingExpanded = false;
                    sliding_timer.Stop();
                    retractslideingpanelGUI();


                    this.Refresh();
                }
            }
            else
            {
                //expand
                sliding.Width += 30;
                if (sliding.Width >= MaxSliderwidth)
                {
                    //stop expanded
                    isslidingExpanded = true;
                    sliding_timer.Stop();
                    expandslideingpanelGUI();


                    this.Refresh();
                }

            }
        }

        private void transactiontab_Click(Object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(trnas_UserControl1.Instance))
            {
                contentpanel.Controls.Add(trnas_UserControl1.Instance);
                trnas_UserControl1.Instance.Dock = DockStyle.Fill;
                trnas_UserControl1.Instance.BringToFront();
            }
            else
            {
                trnas_UserControl1.Instance.BringToFront();
            }
        }
        private void borrowertab_Click(Object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(borrowers_UserControl1.Instance))
            {
                contentpanel.Controls.Add(borrowers_UserControl1.Instance);
                borrowers_UserControl1.Instance.Dock = DockStyle.Fill;
                borrowers_UserControl1.Instance.BringToFront();
            }
            else
            {
                borrowers_UserControl1.Instance.BringToFront();
            }
        }

        private void settingstab_Click(Object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(settings_UserControl1.Instance))
            {
                contentpanel.Controls.Add(settings_UserControl1.Instance);
                settings_UserControl1.Instance.Dock = DockStyle.Fill;
                settings_UserControl1.Instance.BringToFront();
            }
            else
            {
                settings_UserControl1.Instance.BringToFront();
            }
        }

        private void abouttab_Click(Object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(about_UserControl1.Instance))
            {
                contentpanel.Controls.Add(about_UserControl1.Instance);
                about_UserControl1.Instance.Dock = DockStyle.Fill;
                about_UserControl1.Instance.BringToFront();
            }
            else
            {
                about_UserControl1.Instance.BringToFront();
            }
        }

        private void bookstab_Click_1(Object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(books_UserControl1.Instance))
            {
                contentpanel.Controls.Add(books_UserControl1.Instance);
                books_UserControl1.Instance.Dock = DockStyle.Fill;
                books_UserControl1.Instance.BringToFront();
            }
            else
            {
                books_UserControl1.Instance.BringToFront();
            }
        }
    }
}
