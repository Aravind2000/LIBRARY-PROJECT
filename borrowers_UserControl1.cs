using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class borrowers_UserControl1 : UserControl
    {
        private static borrowers_UserControl1 _instance;

        public static borrowers_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new borrowers_UserControl1();
                }
                return _instance;
            }
        }
        public borrowers_UserControl1()
        {
            InitializeComponent();
        }

        private void borrowers_UserControl1_Load(Object sender, EventArgs e)
        {

        }
    }
}
