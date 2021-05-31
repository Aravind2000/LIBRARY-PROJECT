
namespace DBMS_project
{
    partial class AppBody
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.login_time = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.logoff = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.sliding = new System.Windows.Forms.Panel();
            this.abouttab = new System.Windows.Forms.Button();
            this.settingstab = new System.Windows.Forms.Button();
            this.transactiontab = new System.Windows.Forms.Button();
            this.borrowertab = new System.Windows.Forms.Button();
            this.bookstab = new System.Windows.Forms.Button();
            this.sliding_toggle = new System.Windows.Forms.Button();
            this.sliding_timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.sliding.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_time
            // 
            this.login_time.Interval = 25;
            this.login_time.Tick += new System.EventHandler(this.login_time_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.logoff);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::DBMS_project.Properties.Resources.mini;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.minimize.Location = new System.Drawing.Point(1199, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(38, 32);
            this.minimize.TabIndex = 3;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // logoff
            // 
            this.logoff.BackgroundImage = global::DBMS_project.Properties.Resources.logoff;
            this.logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoff.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logoff.Location = new System.Drawing.Point(1155, 0);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(38, 32);
            this.logoff.TabIndex = 2;
            this.logoff.UseVisualStyleBackColor = true;
            this.logoff.Click += new System.EventHandler(this.logoff_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = global::DBMS_project.Properties.Resources.Actions_window_close_icon;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.SystemColors.Highlight;
            this.close.Location = new System.Drawing.Point(1243, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 32);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // sliding
            // 
            this.sliding.BackColor = System.Drawing.Color.Transparent;
            this.sliding.BackgroundImage = global::DBMS_project.Properties.Resources.pic2;
            this.sliding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sliding.Controls.Add(this.abouttab);
            this.sliding.Controls.Add(this.settingstab);
            this.sliding.Controls.Add(this.transactiontab);
            this.sliding.Controls.Add(this.borrowertab);
            this.sliding.Controls.Add(this.bookstab);
            this.sliding.Controls.Add(this.sliding_toggle);
            this.sliding.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliding.Location = new System.Drawing.Point(0, 36);
            this.sliding.Name = "sliding";
            this.sliding.Size = new System.Drawing.Size(200, 559);
            this.sliding.TabIndex = 1;
            // 
            // abouttab
            // 
            this.abouttab.BackColor = System.Drawing.Color.Transparent;
            this.abouttab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abouttab.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.abouttab.ForeColor = System.Drawing.Color.OrangeRed;
            this.abouttab.Image = global::DBMS_project.Properties.Resources.ab2;
            this.abouttab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abouttab.Location = new System.Drawing.Point(0, 370);
            this.abouttab.Name = "abouttab";
            this.abouttab.Size = new System.Drawing.Size(200, 68);
            this.abouttab.TabIndex = 7;
            this.abouttab.Text = "About";
            this.abouttab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abouttab.UseVisualStyleBackColor = false;
            this.abouttab.Click += new System.EventHandler(this.abouttab_Click);
            // 
            // settingstab
            // 
            this.settingstab.BackColor = System.Drawing.Color.Transparent;
            this.settingstab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingstab.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.settingstab.ForeColor = System.Drawing.Color.OrangeRed;
            this.settingstab.Image = global::DBMS_project.Properties.Resources.set1;
            this.settingstab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingstab.Location = new System.Drawing.Point(0, 296);
            this.settingstab.Name = "settingstab";
            this.settingstab.Size = new System.Drawing.Size(200, 68);
            this.settingstab.TabIndex = 6;
            this.settingstab.Text = "Settings";
            this.settingstab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingstab.UseVisualStyleBackColor = false;
            this.settingstab.Click += new System.EventHandler(this.settingstab_Click);
            // 
            // transactiontab
            // 
            this.transactiontab.BackColor = System.Drawing.Color.Transparent;
            this.transactiontab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactiontab.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.transactiontab.ForeColor = System.Drawing.Color.OrangeRed;
            this.transactiontab.Image = global::DBMS_project.Properties.Resources.tran22;
            this.transactiontab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactiontab.Location = new System.Drawing.Point(0, 222);
            this.transactiontab.Name = "transactiontab";
            this.transactiontab.Size = new System.Drawing.Size(200, 78);
            this.transactiontab.TabIndex = 5;
            this.transactiontab.Text = "Transaction";
            this.transactiontab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transactiontab.UseVisualStyleBackColor = false;
            this.transactiontab.Click += new System.EventHandler(this.transactiontab_Click);
            // 
            // borrowertab
            // 
            this.borrowertab.BackColor = System.Drawing.Color.Transparent;
            this.borrowertab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowertab.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.borrowertab.ForeColor = System.Drawing.Color.OrangeRed;
            this.borrowertab.Image = global::DBMS_project.Properties.Resources.cust1;
            this.borrowertab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowertab.Location = new System.Drawing.Point(0, 148);
            this.borrowertab.Name = "borrowertab";
            this.borrowertab.Size = new System.Drawing.Size(200, 68);
            this.borrowertab.TabIndex = 4;
            this.borrowertab.Text = "Borrowers";
            this.borrowertab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.borrowertab.UseVisualStyleBackColor = false;
            this.borrowertab.Click += new System.EventHandler(this.borrowertab_Click);
            // 
            // bookstab
            // 
            this.bookstab.BackColor = System.Drawing.Color.Transparent;
            this.bookstab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookstab.Font = new System.Drawing.Font("Impact", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bookstab.ForeColor = System.Drawing.Color.OrangeRed;
            this.bookstab.Image = global::DBMS_project.Properties.Resources.books1;
            this.bookstab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookstab.Location = new System.Drawing.Point(0, 74);
            this.bookstab.Name = "bookstab";
            this.bookstab.Size = new System.Drawing.Size(200, 68);
            this.bookstab.TabIndex = 3;
            this.bookstab.Text = "Books";
            this.bookstab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookstab.UseVisualStyleBackColor = false;
            this.bookstab.Click += new System.EventHandler(this.bookstab_Click_1);
            // 
            // sliding_toggle
            // 
            this.sliding_toggle.BackColor = System.Drawing.Color.Transparent;
            this.sliding_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sliding_toggle.Image = global::DBMS_project.Properties.Resources.l2;
            this.sliding_toggle.Location = new System.Drawing.Point(0, 0);
            this.sliding_toggle.Name = "sliding_toggle";
            this.sliding_toggle.Size = new System.Drawing.Size(200, 68);
            this.sliding_toggle.TabIndex = 2;
            this.sliding_toggle.UseVisualStyleBackColor = false;
            this.sliding_toggle.Click += new System.EventHandler(this.sliding_toggle_Click);
            // 
            // sliding_timer
            // 
            this.sliding_timer.Interval = 25;
            this.sliding_timer.Tick += new System.EventHandler(this.sliding_timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpanel.Location = new System.Drawing.Point(200, 36);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1093, 559);
            this.contentpanel.TabIndex = 2;
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 595);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.sliding);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.panel1.ResumeLayout(false);
            this.sliding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer login_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel sliding;
        private System.Windows.Forms.Button sliding_toggle;
        private System.Windows.Forms.Timer sliding_timer;
        private System.Windows.Forms.Button abouttab;
        private System.Windows.Forms.Button settingstab;
        private System.Windows.Forms.Button transactiontab;
        private System.Windows.Forms.Button borrowertab;
        private System.Windows.Forms.Button bookstab;
        private System.Windows.Forms.Panel contentpanel;
    }
}